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
using System.Security.Cryptography;

namespace Azuraline
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UsernameInput.Focus();
        }

        private void BtnConn_Click(object sender, EventArgs e)
        {
            string username = UsernameInput.Text;
            string password = PasswordInput.Text;
            try
            {
                UserManager userManager = new UserManager("MyDbConn");

                if (userManager.Login(username, password))
                {
                    MessageBox.Show("Login berhasil! Welcome, " + username, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MainMenu dashpage = new MainMenu();
                    dashpage.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Login gagal, coba lagi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            
            } catch (Exception ex) {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PasswordInput_TextChanged(object sender, EventArgs e)
        {
            PasswordInput.PasswordChar = '*';
        }

        private void UsernameLabel_Click(object sender, EventArgs e)
        {
            UsernameInput.Focus();
        }

        private void PasswordLabel_Click(object sender, EventArgs e)
        {
            PasswordInput.Focus();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            UsernameInput.Clear();
            PasswordInput.Clear();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
