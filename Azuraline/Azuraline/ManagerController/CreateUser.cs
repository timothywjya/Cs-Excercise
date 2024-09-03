using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Azuraline.ManagerController
{
    class CreateUser
    {
        private DatabaseManager dbManager;

        public CreateUser(DatabaseManager dbManager)
        {
            this.dbManager = dbManager;
        }

        public bool AddUser(string username, string password, string otherDetails)
        {
            bool isAdded = false;
            using (MySqlConnection connection = dbManager.GetConnection())
            {
                string query = "INSERT INTO users (username, password, other_details) VALUES (@username, @password, @otherDetails)";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    try
                    {
                        connection.Open();
                        int result = command.ExecuteNonQuery();
                        isAdded = result > 0;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }
            return isAdded;
        }
    }
}
