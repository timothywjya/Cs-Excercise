
namespace Azuraline
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnLogout = new System.Windows.Forms.Button();
            this.PanelEdit = new System.Windows.Forms.Panel();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.InputPassword = new System.Windows.Forms.TextBox();
            this.InputEmail = new System.Windows.Forms.TextBox();
            this.InputNama = new System.Windows.Forms.TextBox();
            this.InputUsername = new System.Windows.Forms.TextBox();
            this.NamaLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DataTableUser = new System.Windows.Forms.DataGridView();
            this.BtnClear = new System.Windows.Forms.Button();
            this.PanelEdit.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataTableUser)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnLogout
            // 
            this.BtnLogout.Location = new System.Drawing.Point(713, 12);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(75, 23);
            this.BtnLogout.TabIndex = 1;
            this.BtnLogout.Text = "LogOut";
            this.BtnLogout.UseVisualStyleBackColor = true;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // PanelEdit
            // 
            this.PanelEdit.Controls.Add(this.BtnClear);
            this.PanelEdit.Controls.Add(this.BtnDelete);
            this.PanelEdit.Controls.Add(this.BtnUpdate);
            this.PanelEdit.Controls.Add(this.BtnCreate);
            this.PanelEdit.Controls.Add(this.PasswordLabel);
            this.PanelEdit.Controls.Add(this.EmailLabel);
            this.PanelEdit.Controls.Add(this.InputPassword);
            this.PanelEdit.Controls.Add(this.InputEmail);
            this.PanelEdit.Controls.Add(this.InputNama);
            this.PanelEdit.Controls.Add(this.InputUsername);
            this.PanelEdit.Controls.Add(this.NamaLabel);
            this.PanelEdit.Controls.Add(this.UsernameLabel);
            this.PanelEdit.Location = new System.Drawing.Point(12, 55);
            this.PanelEdit.Name = "PanelEdit";
            this.PanelEdit.Size = new System.Drawing.Size(367, 383);
            this.PanelEdit.TabIndex = 2;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(188, 253);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 10;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(107, 253);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(75, 23);
            this.BtnUpdate.TabIndex = 9;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnCreate
            // 
            this.BtnCreate.Location = new System.Drawing.Point(26, 253);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(75, 23);
            this.BtnCreate.TabIndex = 8;
            this.BtnCreate.Text = "Create";
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(22, 205);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(69, 19);
            this.PasswordLabel.TabIndex = 7;
            this.PasswordLabel.Text = "Password";
            this.PasswordLabel.Click += new System.EventHandler(this.PasswordLabel_Click);
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.Location = new System.Drawing.Point(22, 149);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(42, 19);
            this.EmailLabel.TabIndex = 6;
            this.EmailLabel.Text = "Email";
            this.EmailLabel.Click += new System.EventHandler(this.EmailLabel_Click);
            // 
            // InputPassword
            // 
            this.InputPassword.Location = new System.Drawing.Point(111, 204);
            this.InputPassword.Name = "InputPassword";
            this.InputPassword.Size = new System.Drawing.Size(233, 20);
            this.InputPassword.TabIndex = 5;
            this.InputPassword.TextChanged += new System.EventHandler(this.InputPassword_TextChanged);
            // 
            // InputEmail
            // 
            this.InputEmail.Location = new System.Drawing.Point(111, 150);
            this.InputEmail.Name = "InputEmail";
            this.InputEmail.Size = new System.Drawing.Size(233, 20);
            this.InputEmail.TabIndex = 4;
            // 
            // InputNama
            // 
            this.InputNama.Location = new System.Drawing.Point(111, 94);
            this.InputNama.Name = "InputNama";
            this.InputNama.Size = new System.Drawing.Size(233, 20);
            this.InputNama.TabIndex = 3;
            // 
            // InputUsername
            // 
            this.InputUsername.Location = new System.Drawing.Point(111, 40);
            this.InputUsername.Name = "InputUsername";
            this.InputUsername.Size = new System.Drawing.Size(233, 20);
            this.InputUsername.TabIndex = 2;
            // 
            // NamaLabel
            // 
            this.NamaLabel.AutoSize = true;
            this.NamaLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NamaLabel.Location = new System.Drawing.Point(22, 93);
            this.NamaLabel.Name = "NamaLabel";
            this.NamaLabel.Size = new System.Drawing.Size(46, 19);
            this.NamaLabel.TabIndex = 1;
            this.NamaLabel.Text = "Nama";
            this.NamaLabel.Click += new System.EventHandler(this.NamaLabel_Click);
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.Location = new System.Drawing.Point(22, 39);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(70, 19);
            this.UsernameLabel.TabIndex = 0;
            this.UsernameLabel.Text = "Username";
            this.UsernameLabel.Click += new System.EventHandler(this.UsernameLabel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DataTableUser);
            this.panel1.Location = new System.Drawing.Point(421, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 383);
            this.panel1.TabIndex = 3;
            // 
            // DataTableUser
            // 
            this.DataTableUser.AllowUserToAddRows = false;
            this.DataTableUser.AllowUserToDeleteRows = false;
            this.DataTableUser.AllowUserToOrderColumns = true;
            this.DataTableUser.AllowUserToResizeColumns = false;
            this.DataTableUser.AllowUserToResizeRows = false;
            this.DataTableUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataTableUser.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DataTableUser.Location = new System.Drawing.Point(2, 0);
            this.DataTableUser.Name = "DataTableUser";
            this.DataTableUser.Size = new System.Drawing.Size(361, 383);
            this.DataTableUser.TabIndex = 0;
            this.DataTableUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataTableUser_CellContentClick);
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(269, 253);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(75, 23);
            this.BtnClear.TabIndex = 11;
            this.BtnClear.Text = "Clean";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelEdit);
            this.Controls.Add(this.BtnLogout);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.PanelEdit.ResumeLayout(false);
            this.PanelEdit.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataTableUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnLogout;
        private System.Windows.Forms.Panel PanelEdit;
        private System.Windows.Forms.TextBox InputUsername;
        private System.Windows.Forms.Label NamaLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox InputNama;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox InputPassword;
        private System.Windows.Forms.TextBox InputEmail;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.DataGridView DataTableUser;
        private System.Windows.Forms.Button BtnClear;
    }
}