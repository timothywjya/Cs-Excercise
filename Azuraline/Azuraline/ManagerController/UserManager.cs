using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azuraline.ManagerController;

namespace Azuraline
{
    class UserManager
    {
        private DatabaseManager dbManager;

        public UserManager(string connectionName)
        {
            dbManager = new DatabaseManager(connectionName);
        }

        public bool Login(string username, string password)
        {
            Login login = new Login(dbManager);
            return login.ValidateUser(username, password);
        }

        public bool CreateUser(string username, string password, string otherDetails)
        {
            CreateUser createUser = new CreateUser(dbManager);
            return createUser.AddUser(username, password, otherDetails);
        }

        public bool UpdateUser(int userId, string newUsername, string newPassword)
        {
            UpdateUser updateUser = new UpdateUser(dbManager);
            return updateUser.ModifyUser(userId, newUsername, newPassword);
        }

        public bool DeleteUser(int userId)
        {
            DeleteUser deleteUser = new DeleteUser(dbManager);
            return deleteUser.RemoveUser(userId);
        }

        public string ShowUser(int userId)
        {
            ShowUser showUser = new ShowUser(dbManager);
            return showUser.GetUserDetails(userId);
        }
    }
}
