using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Azuraline.ManagerController
{
    class Login
    {
        private DatabaseManager dbManager;

        public Login(DatabaseManager dbManager)
        {
            this.dbManager = dbManager;
        }

        public bool ValidateUser(string username, string password)
        {
            bool isValid = false;
            using (MySqlConnection connection = dbManager.GetConnection())
            {
                string query = "SELECT COUNT(*) FROM users WHERE username = @username AND password = @password";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    try
                    {
                        connection.Open();
                        int count = Convert.ToInt32(command.ExecuteScalar());
                        isValid = count > 0;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }
            return isValid;
        }
    }
}
