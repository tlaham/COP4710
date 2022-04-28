
namespace TKM_Game_Hunter
{
    partial class ProfilePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfilePage));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_user = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_age = new System.Windows.Forms.Label();
            this.lbl_utype = new System.Windows.Forms.Label();
            this.but_ppic = new System.Windows.Forms.Button();
            this.but_home = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(335, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_user
            // 
            this.lbl_user.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_user.AutoSize = true;
            this.lbl_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.Location = new System.Drawing.Point(330, 140);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(130, 25);
            this.lbl_user.TabIndex = 1;
            this.lbl_user.Text = "Username:()";
            this.lbl_user.Click += new System.EventHandler(this.lbl_user_Click);
            // 
            // lbl_email
            // 
            this.lbl_email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(330, 252);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(91, 25);
            this.lbl_email.TabIndex = 2;
            this.lbl_email.Text = "Email: ()";
            // 
            // lbl_age
            // 
            this.lbl_age.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_age.AutoSize = true;
            this.lbl_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_age.Location = new System.Drawing.Point(330, 196);
            this.lbl_age.Name = "lbl_age";
            this.lbl_age.Size = new System.Drawing.Size(76, 25);
            this.lbl_age.TabIndex = 3;
            this.lbl_age.Text = "Age: ()";
            // 
            // lbl_utype
            // 
            this.lbl_utype.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_utype.AutoSize = true;
            this.lbl_utype.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_utype.Location = new System.Drawing.Point(330, 307);
            this.lbl_utype.Name = "lbl_utype";
            this.lbl_utype.Size = new System.Drawing.Size(131, 25);
            this.lbl_utype.TabIndex = 4;
            this.lbl_utype.Text = "UserType: ()";
            // 
            // but_ppic
            // 
            this.but_ppic.Location = new System.Drawing.Point(441, 89);
            this.but_ppic.Name = "but_ppic";
            this.but_ppic.Size = new System.Drawing.Size(109, 23);
            this.but_ppic.TabIndex = 5;
            this.but_ppic.Text = "Upload Photo";
            this.but_ppic.UseVisualStyleBackColor = true;
            this.but_ppic.Click += new System.EventHandler(this.but_ppic_Click);
            // 
            // but_home
            // 
            this.but_home.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("but_home.BackgroundImage")));
            this.but_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.but_home.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_home.Location = new System.Drawing.Point(12, 12);
            this.but_home.Name = "but_home";
            this.but_home.Size = new System.Drawing.Size(40, 40);
            this.but_home.TabIndex = 20;
            this.but_home.UseVisualStyleBackColor = true;
            this.but_home.Click += new System.EventHandler(this.but_home_Click);
            // 
            // ProfilePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.but_home);
            this.Controls.Add(this.but_ppic);
            this.Controls.Add(this.lbl_utype);
            this.Controls.Add(this.lbl_age);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ProfilePage";
            this.Text = "ProfilePage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProfilePage_FormClosed);
            this.Load += new System.EventHandler(this.ProfilePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_age;
        private System.Windows.Forms.Label lbl_utype;
        private System.Windows.Forms.Button but_ppic;
        private System.Windows.Forms.Button but_home;
    }
}