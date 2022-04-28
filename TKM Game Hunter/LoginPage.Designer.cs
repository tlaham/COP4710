
namespace TKM_Game_Hunter
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.txtbx_username = new System.Windows.Forms.TextBox();
            this.txtbx_password = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_create = new System.Windows.Forms.Button();
            this.pswdvis_check = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_title.AutoSize = true;
            this.lbl_title.BackColor = System.Drawing.Color.Black;
            this.lbl_title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_title.Font = new System.Drawing.Font("Dead Kansas", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.White;
            this.lbl_title.Location = new System.Drawing.Point(333, 9);
            this.lbl_title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(352, 41);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "TKM Game Hunter";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_title.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_password
            // 
            this.lbl_password.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_password.AutoSize = true;
            this.lbl_password.BackColor = System.Drawing.Color.Black;
            this.lbl_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.ForeColor = System.Drawing.Color.White;
            this.lbl_password.Location = new System.Drawing.Point(270, 279);
            this.lbl_password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(121, 25);
            this.lbl_password.TabIndex = 1;
            this.lbl_password.Text = "Password:";
            this.lbl_password.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lbl_username
            // 
            this.lbl_username.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_username.AutoSize = true;
            this.lbl_username.BackColor = System.Drawing.Color.Black;
            this.lbl_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.ForeColor = System.Drawing.Color.White;
            this.lbl_username.Location = new System.Drawing.Point(270, 201);
            this.lbl_username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(125, 25);
            this.lbl_username.TabIndex = 2;
            this.lbl_username.Text = "Username:";
            // 
            // txtbx_username
            // 
            this.txtbx_username.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtbx_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtbx_username.Location = new System.Drawing.Point(399, 202);
            this.txtbx_username.Margin = new System.Windows.Forms.Padding(2);
            this.txtbx_username.Name = "txtbx_username";
            this.txtbx_username.Size = new System.Drawing.Size(241, 26);
            this.txtbx_username.TabIndex = 3;
            this.txtbx_username.TextChanged += new System.EventHandler(this.txtbx_username_TextChanged);
            // 
            // txtbx_password
            // 
            this.txtbx_password.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtbx_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtbx_password.Location = new System.Drawing.Point(399, 280);
            this.txtbx_password.Margin = new System.Windows.Forms.Padding(2);
            this.txtbx_password.Name = "txtbx_password";
            this.txtbx_password.Size = new System.Drawing.Size(241, 26);
            this.txtbx_password.TabIndex = 4;
            this.txtbx_password.UseSystemPasswordChar = true;
            this.txtbx_password.TextChanged += new System.EventHandler(this.txtbx_password_TextChanged);
            // 
            // btn_login
            // 
            this.btn_login.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_login.BackgroundImage = global::TKM_Game_Hunter.Properties.Resources.VecteezyWhite_Background_02RD0421_rev_01_generated;
            this.btn_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_login.Location = new System.Drawing.Point(529, 390);
            this.btn_login.Margin = new System.Windows.Forms.Padding(2);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(132, 32);
            this.btn_login.TabIndex = 5;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_create
            // 
            this.btn_create.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_create.BackgroundImage = global::TKM_Game_Hunter.Properties.Resources.VecteezyWhite_Background_02RD0421_rev_01_generated;
            this.btn_create.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_create.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_create.Location = new System.Drawing.Point(371, 390);
            this.btn_create.Margin = new System.Windows.Forms.Padding(2);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(132, 32);
            this.btn_create.TabIndex = 6;
            this.btn_create.Text = "Create Account";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // pswdvis_check
            // 
            this.pswdvis_check.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pswdvis_check.AutoSize = true;
            this.pswdvis_check.BackColor = System.Drawing.Color.Black;
            this.pswdvis_check.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pswdvis_check.ForeColor = System.Drawing.Color.White;
            this.pswdvis_check.Location = new System.Drawing.Point(645, 289);
            this.pswdvis_check.Name = "pswdvis_check";
            this.pswdvis_check.Size = new System.Drawing.Size(122, 20);
            this.pswdvis_check.TabIndex = 7;
            this.pswdvis_check.Text = "Show Password";
            this.pswdvis_check.UseVisualStyleBackColor = false;
            this.pswdvis_check.CheckedChanged += new System.EventHandler(this.pswdvis_check_CheckedChanged);
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1013, 538);
            this.Controls.Add(this.pswdvis_check);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txtbx_password);
            this.Controls.Add(this.txtbx_username);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Page";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LoginPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.TextBox txtbx_username;
        private System.Windows.Forms.TextBox txtbx_password;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.CheckBox pswdvis_check;
    }
}

