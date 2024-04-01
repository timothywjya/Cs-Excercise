using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Azuraline
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void userManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form userManagementForm = Application.OpenForms["UserManagement"];
                
            if (userManagementForm != null)
            {
                userManagementForm.Close();
            }

            if (Application.OpenForms["UserManagement"] == null)
            {
                UserManagement FormUser = new UserManagement();
                FormUser.MdiParent = this;
                FormUser.WindowState = FormWindowState.Maximized;
                FormUser.Show();
            }
        }

        private void updateDataCabangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form branchMasterForm = Application.OpenForms["BranchMaster"];

            if (branchMasterForm != null)
            {
                branchMasterForm.Close();
            }

            if (Application.OpenForms["BranchMaster"] == null)
            {
                BranchMaster FormMasterBranch = new BranchMaster();
                FormMasterBranch.MdiParent = this;
                FormMasterBranch.WindowState = FormWindowState.Maximized;
                FormMasterBranch.Show();
            }
        }
    }
}
