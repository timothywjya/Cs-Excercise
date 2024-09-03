using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Azuraline.ManagerController
{
    class DeleteUser
    {
        private DatabaseManager dbManager;

        public DeleteUser(DatabaseManager dbManager)
        {
            this.dbManager = dbManager;
        }

        public bool RemoveUser(int userId)
        {
            bool isDeleted = false;
            using (MySqlConnection connection = dbManager.GetConnection())
            {
                string query = "DELETE FROM users WHERE user_id = @userId";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userId", userId);

                    try
                    {
                        connection.Open();
                        int result = command.ExecuteNonQuery();
                        isDeleted = result > 0;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }
            return isDeleted;
        }
    }
}
