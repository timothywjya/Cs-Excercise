
namespace Azuraline
{
    partial class LoginForm
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
            this.BtnConn = new System.Windows.Forms.Button();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.UsernameInput = new System.Windows.Forms.TextBox();
            this.PasswordInput = new System.Windows.Forms.TextBox();
            this.LabelTItle = new System.Windows.Forms.Label();
            this.WatermarkLabel = new System.Windows.Forms.Label();
            this.Clear = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnConn
            // 
            this.BtnConn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConn.Location = new System.Drawing.Point(253, 228);
            this.BtnConn.Name = "BtnConn";
            this.BtnConn.Size = new System.Drawing.Size(75, 29);
            this.BtnConn.TabIndex = 4;
            this.BtnConn.Text = "Login";
            this.BtnConn.UseVisualStyleBackColor = true;
            this.BtnConn.Click += new System.EventHandler(this.BtnConn_Click);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(134, 182);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(72, 19);
            this.PasswordLabel.TabIndex = 6;
            this.PasswordLabel.Text = "Password:";
            this.PasswordLabel.Click += new System.EventHandler(this.PasswordLabel_Click);
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.Location = new System.Drawing.Point(134, 142);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(73, 19);
            this.UsernameLabel.TabIndex = 5;
            this.UsernameLabel.Text = "Username:";
            this.UsernameLabel.Click += new System.EventHandler(this.UsernameLabel_Click);
            // 
            // UsernameInput
            // 
            this.UsernameInput.Location = new System.Drawing.Point(253, 140);
            this.UsernameInput.Name = "UsernameInput";
            this.UsernameInput.Size = new System.Drawing.Size(250, 20);
            this.UsernameInput.TabIndex = 7;
            // 
            // PasswordInput
            // 
            this.PasswordInput.Location = new System.Drawing.Point(253, 181);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.Size = new System.Drawing.Size(250, 20);
            this.PasswordInput.TabIndex = 8;
            this.PasswordInput.TextChanged += new System.EventHandler(this.PasswordInput_TextChanged);
            // 
            // LabelTItle
            // 
            this.LabelTItle.AutoSize = true;
            this.LabelTItle.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTItle.Location = new System.Drawing.Point(106, 63);
            this.LabelTItle.Name = "LabelTItle";
            this.LabelTItle.Size = new System.Drawing.Size(445, 42);
            this.LabelTItle.TabIndex = 9;
            this.LabelTItle.Text = "Welcome to The SD 1 Jungle";
            // 
            // WatermarkLabel
            // 
            this.WatermarkLabel.AutoSize = true;
            this.WatermarkLabel.Location = new System.Drawing.Point(476, 419);
            this.WatermarkLabel.Name = "WatermarkLabel";
            this.WatermarkLabel.Size = new System.Drawing.Size(136, 13);
            this.WatermarkLabel.TabIndex = 10;
            this.WatermarkLabel.Text = "Created by: Timothy Wijaya";
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Location = new System.Drawing.Point(344, 228);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 29);
            this.Clear.TabIndex = 11;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.Location = new System.Drawing.Point(537, 12);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 29);
            this.BtnClose.TabIndex = 12;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.WatermarkLabel);
            this.Controls.Add(this.LabelTItle);
            this.Controls.Add(this.PasswordInput);
            this.Controls.Add(this.UsernameInput);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.BtnConn);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnConn;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.TextBox UsernameInput;
        private System.Windows.Forms.TextBox PasswordInput;
        private System.Windows.Forms.Label LabelTItle;
        private System.Windows.Forms.Label WatermarkLabel;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button BtnClose;
    }
}

