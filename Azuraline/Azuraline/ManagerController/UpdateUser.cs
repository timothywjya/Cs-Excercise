using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Azuraline.ManagerController
{
    class UpdateUser
    {
        private DatabaseManager dbManager;

        public UpdateUser(DatabaseManager dbManager)
        {
            this.dbManager = dbManager;
        }

        public bool ModifyUser(int userId, string newUsername, string newPassword)
        {
            bool isUpdated = false;
            using (MySqlConnection connection = dbManager.GetConnection())
            {
                string query = "UPDATE users SET username = @username, password = @password WHERE user_id = @userId";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", newUsername);
                    command.Parameters.AddWithValue("@password", newPassword);
                    command.Parameters.AddWithValue("@userId", userId);

                    try
                    {
                        connection.Open();
                        int result = command.ExecuteNonQuery();
                        isUpdated = result > 0;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }
            return isUpdated;
        }
    }
}
