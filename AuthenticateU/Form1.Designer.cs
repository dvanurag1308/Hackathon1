namespace AuthenticateU
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.fbButton = new System.Windows.Forms.Button();
            this.lbl_userName = new System.Windows.Forms.Label();
            this.tb_userName = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.btn_addUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fbButton
            // 
            this.fbButton.Image = ((System.Drawing.Image)(resources.GetObject("fbButton.Image")));
            this.fbButton.Location = new System.Drawing.Point(124, 53);
            this.fbButton.Name = "fbButton";
            this.fbButton.Size = new System.Drawing.Size(121, 124);
            this.fbButton.TabIndex = 0;
            this.fbButton.UseVisualStyleBackColor = true;
            // 
            // lbl_userName
            // 
            this.lbl_userName.AutoSize = true;
            this.lbl_userName.Location = new System.Drawing.Point(269, 82);
            this.lbl_userName.Name = "lbl_userName";
            this.lbl_userName.Size = new System.Drawing.Size(60, 13);
            this.lbl_userName.TabIndex = 2;
            this.lbl_userName.Text = "UserName:";
            // 
            // tb_userName
            // 
            this.tb_userName.Location = new System.Drawing.Point(335, 79);
            this.tb_userName.Name = "tb_userName";
            this.tb_userName.Size = new System.Drawing.Size(130, 20);
            this.tb_userName.TabIndex = 3;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(272, 114);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(56, 13);
            this.lbl_password.TabIndex = 4;
            this.lbl_password.Text = "Password:";
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(335, 111);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(130, 20);
            this.tb_password.TabIndex = 5;
            // 
            // btn_addUser
            // 
            this.btn_addUser.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_addUser.Location = new System.Drawing.Point(275, 150);
            this.btn_addUser.Name = "btn_addUser";
            this.btn_addUser.Size = new System.Drawing.Size(75, 23);
            this.btn_addUser.TabIndex = 6;
            this.btn_addUser.Text = "Add User";
            this.btn_addUser.UseVisualStyleBackColor = false;
            this.btn_addUser.Click += new System.EventHandler(this.btn_addUser_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 472);
            this.Controls.Add(this.btn_addUser);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.tb_userName);
            this.Controls.Add(this.lbl_userName);
            this.Controls.Add(this.fbButton);
            this.Name = "MainPage";
            this.Text = "Apps";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fbButton;
        private System.Windows.Forms.Label lbl_userName;
        private System.Windows.Forms.TextBox tb_userName;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Button btn_addUser;
    }
}

