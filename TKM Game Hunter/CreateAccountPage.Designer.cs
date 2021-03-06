
namespace TKM_Game_Hunter
{
    partial class CreateAccountPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAccountPage));
            this.btn_createAccount = new System.Windows.Forms.Button();
            this.txtbx_password = new System.Windows.Forms.TextBox();
            this.txtbx_username = new System.Windows.Forms.TextBox();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.txtbx_pswdconfirm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbx_email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dob_picker = new System.Windows.Forms.DateTimePicker();
            this.cmbobx_usertype = new System.Windows.Forms.ComboBox();
            this.back_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_createAccount
            // 
            this.btn_createAccount.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_createAccount.BackgroundImage = global::TKM_Game_Hunter.Properties.Resources.VecteezyWhite_Background_02RD0421_rev_01_generated;
            this.btn_createAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_createAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_createAccount.Location = new System.Drawing.Point(378, 384);
            this.btn_createAccount.Margin = new System.Windows.Forms.Padding(2);
            this.btn_createAccount.Name = "btn_createAccount";
            this.btn_createAccount.Size = new System.Drawing.Size(216, 40);
            this.btn_createAccount.TabIndex = 13;
            this.btn_createAccount.Text = "Create Account!";
            this.btn_createAccount.UseVisualStyleBackColor = true;
            this.btn_createAccount.Click += new System.EventHandler(this.btn_createAccount_Click);
            // 
            // txtbx_password
            // 
            this.txtbx_password.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtbx_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtbx_password.Location = new System.Drawing.Point(232, 229);
            this.txtbx_password.Margin = new System.Windows.Forms.Padding(2);
            this.txtbx_password.Name = "txtbx_password";
            this.txtbx_password.PasswordChar = '*';
            this.txtbx_password.Size = new System.Drawing.Size(241, 26);
            this.txtbx_password.TabIndex = 11;
            this.txtbx_password.TextChanged += new System.EventHandler(this.txtbx_password_TextChanged);
            // 
            // txtbx_username
            // 
            this.txtbx_username.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtbx_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtbx_username.Location = new System.Drawing.Point(232, 151);
            this.txtbx_username.Margin = new System.Windows.Forms.Padding(2);
            this.txtbx_username.Name = "txtbx_username";
            this.txtbx_username.Size = new System.Drawing.Size(241, 26);
            this.txtbx_username.TabIndex = 10;
            this.txtbx_username.TextChanged += new System.EventHandler(this.txtbx_username_TextChanged);
            // 
            // lbl_username
            // 
            this.lbl_username.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_username.AutoSize = true;
            this.lbl_username.BackColor = System.Drawing.Color.Black;
            this.lbl_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_username.Location = new System.Drawing.Point(42, 150);
            this.lbl_username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(150, 29);
            this.lbl_username.TabIndex = 9;
            this.lbl_username.Text = "*Username:";
            this.lbl_username.Click += new System.EventHandler(this.lbl_username_Click);
            // 
            // lbl_password
            // 
            this.lbl_password.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_password.AutoSize = true;
            this.lbl_password.BackColor = System.Drawing.Color.Black;
            this.lbl_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_password.Location = new System.Drawing.Point(44, 225);
            this.lbl_password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(146, 29);
            this.lbl_password.TabIndex = 8;
            this.lbl_password.Text = "*Password:";
            this.lbl_password.Click += new System.EventHandler(this.lbl_password_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_title.AutoSize = true;
            this.lbl_title.BackColor = System.Drawing.Color.Black;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_title.Location = new System.Drawing.Point(378, 59);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(225, 31);
            this.lbl_title.TabIndex = 14;
            this.lbl_title.Text = "Create Account!";
            // 
            // txtbx_pswdconfirm
            // 
            this.txtbx_pswdconfirm.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtbx_pswdconfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtbx_pswdconfirm.Location = new System.Drawing.Point(232, 301);
            this.txtbx_pswdconfirm.Margin = new System.Windows.Forms.Padding(2);
            this.txtbx_pswdconfirm.Name = "txtbx_pswdconfirm";
            this.txtbx_pswdconfirm.PasswordChar = '*';
            this.txtbx_pswdconfirm.Size = new System.Drawing.Size(241, 26);
            this.txtbx_pswdconfirm.TabIndex = 16;
            this.txtbx_pswdconfirm.TextChanged += new System.EventHandler(this.txtbx_pswdconfirm_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(8, 306);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "*Re-type Password:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(512, 301);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "*User Type:";
            // 
            // txtbx_email
            // 
            this.txtbx_email.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtbx_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtbx_email.Location = new System.Drawing.Point(653, 151);
            this.txtbx_email.Margin = new System.Windows.Forms.Padding(2);
            this.txtbx_email.Name = "txtbx_email";
            this.txtbx_email.Size = new System.Drawing.Size(241, 26);
            this.txtbx_email.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(542, 154);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(547, 232);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "DOB:";
            // 
            // dob_picker
            // 
            this.dob_picker.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dob_picker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dob_picker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dob_picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dob_picker.Location = new System.Drawing.Point(653, 231);
            this.dob_picker.Name = "dob_picker";
            this.dob_picker.Size = new System.Drawing.Size(241, 26);
            this.dob_picker.TabIndex = 22;
            this.dob_picker.Value = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            // 
            // cmbobx_usertype
            // 
            this.cmbobx_usertype.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cmbobx_usertype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbobx_usertype.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbobx_usertype.FormattingEnabled = true;
            this.cmbobx_usertype.Items.AddRange(new object[] {
            "User",
            "Admin"});
            this.cmbobx_usertype.Location = new System.Drawing.Point(653, 303);
            this.cmbobx_usertype.Name = "cmbobx_usertype";
            this.cmbobx_usertype.Size = new System.Drawing.Size(241, 28);
            this.cmbobx_usertype.TabIndex = 23;
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.Color.Transparent;
            this.back_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("back_button.BackgroundImage")));
            this.back_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.back_button.ForeColor = System.Drawing.Color.Transparent;
            this.back_button.Location = new System.Drawing.Point(13, 13);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(40, 40);
            this.back_button.TabIndex = 24;
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // CreateAccountPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(905, 450);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.cmbobx_usertype);
            this.Controls.Add(this.dob_picker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbx_email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbx_pswdconfirm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.btn_createAccount);
            this.Controls.Add(this.txtbx_password);
            this.Controls.Add(this.txtbx_username);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.lbl_password);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateAccountPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Account";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CreateAccountPage_FormClosed);
            this.Load += new System.EventHandler(this.CreateAccountPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_createAccount;
        private System.Windows.Forms.TextBox txtbx_password;
        private System.Windows.Forms.TextBox txtbx_username;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.TextBox txtbx_pswdconfirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbx_email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dob_picker;
        private System.Windows.Forms.ComboBox cmbobx_usertype;
        private System.Windows.Forms.Button back_button;
    }
}