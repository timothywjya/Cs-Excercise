using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Azuraline.ManagerController
{
    class ShowUser
    {
        private DatabaseManager dbManager;

        public ShowUser(DatabaseManager dbManager)
        {
            this.dbManager = dbManager;
        }

        public string GetUserDetails(int userId)
        {
            string userDetails = "";
            using (MySqlConnection connection = dbManager.GetConnection())
            {
                string query = "SELECT * FROM users WHERE user_id = @userId";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userId", userId);

                    try
                    {
                        connection.Open();
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                userDetails = $"ID: {reader["user_id"]}, Username: {reader["username"]}, Other Details: {reader["other_details"]}";
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }
            return userDetails;
        }
    }
}
