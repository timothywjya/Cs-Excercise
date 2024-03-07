using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace Azuraline
{
    public partial class Dashboard : Form
    {
        string kode;

        private string connectionString = ConfigurationManager.ConnectionStrings["MyDbConn"].ConnectionString;
        public Dashboard()
        {
            InitializeComponent();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginpage = new LoginForm();
            loginpage.Show();
            this.Hide();
            Application.Exit();
        }

        private void NamaLabel_Click(object sender, EventArgs e)
        {
            InputNama.Focus();
        }

        private void UsernameLabel_Click(object sender, EventArgs e)
        {
            InputUsername.Focus();
        }

        private void EmailLabel_Click(object sender, EventArgs e)
        {
            InputEmail.Focus();
        }

        private void PasswordLabel_Click(object sender, EventArgs e)
        {
            InputPassword.Focus();
        }

        private bool CheckingDataInput(string username, string password, string name, string email)
        {
            string emailPattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";

            Regex regex = new Regex(emailPattern);

            Match match = regex.Match(email);

            // Kembalikan true jika semua input valid, yaitu username, password, name, dan email memiliki nilai dan email sesuai format
            return !string.IsNullOrEmpty(username) &&
                   !string.IsNullOrEmpty(password) &&
                   !string.IsNullOrEmpty(name) &&
                   match.Success;
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            string username = InputUsername.Text;
            string password = InputPassword.Text;
            string name = InputNama.Text;
            string email = InputEmail.Text;

            if (CheckingDataInput(username, password, name, email)) {
                try {
                    string connectionString = ConfigurationManager.ConnectionStrings["MyDbConn"].ConnectionString;
                    using (MySqlConnection connection = new MySqlConnection(connectionString)) {
                        string query = "SELECT COUNT(*) FROM users WHERE username = @username OR email = @email";

                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@username", username);
                            command.Parameters.AddWithValue("@email", email);

                            connection.Open();
                            int count = Convert.ToInt32(command.ExecuteScalar());

                            if (count > 0)
                            {
                                MessageBox.Show("Username atau Email sudah pernah daftar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string queryCreate = "INSERT INTO `db_testing`.`users` (`name`, `username`, `email`, `password`) VALUES (@nameCreate, @usernameCreate, @emailCreate, @passwordCreate);";

                                using (MySqlCommand commandCreate = new MySqlCommand(queryCreate, connection))
                                {
                                    commandCreate.Parameters.AddWithValue("@usernameCreate", username);
                                    commandCreate.Parameters.AddWithValue("@emailCreate", email);
                                    commandCreate.Parameters.AddWithValue("@passwordCreate", password);
                                    commandCreate.Parameters.AddWithValue("@nameCreate", name);

                                    int rowsAffected = commandCreate.ExecuteNonQuery();

                                    if (rowsAffected > 0)
                                    {
                                        MessageBox.Show("Data berhasil ditambahkan.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        LoadData();
                                        InputNama.Clear();
                                        InputPassword.Clear();
                                        InputUsername.Clear();
                                        InputEmail.Clear();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Gagal menambahkan data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                        }
                    }
                } catch(Exception exc) {
                    MessageBox.Show("Terjadi kesalahan: " + exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else 
            {
                MessageBox.Show("Format Pengisian Data Salah", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            BtnUpdate.Enabled = false;
            BtnDelete.Enabled = false;
            LoadData();
        }

        private void LoadData() {
            try {
                try {
                    string connectionString = ConfigurationManager.ConnectionStrings["MyDbConn"].ConnectionString;

                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        string query = "SELECT id, name as Nama, username as Username, email as Email FROM users";

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            DataTableUser.DataSource = dataTable;
                            DataTableUser.Columns[0].Visible = false;
                        }
                    }
                }
                catch (MySqlException ex) {
                    MessageBox.Show("MySQL Error: " + ex.Message);
                }
            } catch (Exception ex) {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void DataTableUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) {
                DataGridViewRow pilihData = DataTableUser.Rows[e.RowIndex];
                kode = pilihData.Cells[0].Value.ToString();
                InputUsername.Text = pilihData.Cells[2].Value.ToString();
                InputNama.Text = pilihData.Cells[1].Value.ToString();
                InputEmail.Text = pilihData.Cells[3].Value.ToString();

                BtnUpdate.Enabled = true;
                BtnDelete.Enabled = true;
                BtnCreate.Enabled = false;
            }
        }

        private void InputPassword_TextChanged(object sender, EventArgs e)
        {
            InputPassword.PasswordChar = '*';
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            InputNama.Clear();
            InputPassword.Clear();
            InputUsername.Clear();
            InputEmail.Clear();
            kode = null;

            BtnCreate.Enabled = true;
            BtnUpdate.Enabled = false;
            BtnDelete.Enabled = false;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            string username = InputUsername.Text;
            string password = InputPassword.Text;
            string name = InputNama.Text;
            string email = InputEmail.Text;
            if (CheckingDataInput(username, password, name, email)){
                try {
                    string connectionString = ConfigurationManager.ConnectionStrings["MyDbConn"].ConnectionString;
                    using (MySqlConnection connection = new MySqlConnection(connectionString)){
                        string query = "UPDATE users SET name = @nama, username = @username, email = @email ";
                        if (password != null || password != "") {
                            query += " ,password = @password";
                        }
                        query += " WHERE id = @kode";

                        using (MySqlCommand command = new MySqlCommand(query, connection)){
                            command.Parameters.AddWithValue("@kode", kode);
                            command.Parameters.AddWithValue("@username", username);
                            command.Parameters.AddWithValue("@email", email);
                            command.Parameters.AddWithValue("@password", password);
                            command.Parameters.AddWithValue("@nama", name);

                            connection.Open();
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Data berhasil diubah.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadData();
                                InputNama.Clear();
                                InputPassword.Clear();
                                InputUsername.Clear();
                                InputEmail.Clear();
                            }
                            else
                            {
                                MessageBox.Show("Gagal menambahkan data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                } catch (Exception ex) {
                    MessageBox.Show("Error: " + ex.Message);
                }
            } else {
                MessageBox.Show("Format Pengisian Data Salah", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try {
                string connectionString = ConfigurationManager.ConnectionStrings["MyDbConn"].ConnectionString;
                using (MySqlConnection connection = new MySqlConnection(connectionString)){
                    string query = "DELETE FROM users WHERE id = @kode";

                    using (MySqlCommand command = new MySqlCommand(query, connection)){
                        command.Parameters.AddWithValue("@kode", kode);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0){
                            MessageBox.Show("Data berhasil dihapus.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData();
                            InputNama.Clear();
                            InputPassword.Clear();
                            InputUsername.Clear();
                            InputEmail.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Gagal menambahkan data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            } catch (Exception ex) {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
