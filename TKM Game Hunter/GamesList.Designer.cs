namespace TKM_Game_Hunter
{
    partial class GamesList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GamesList));
            this.dgv_games = new System.Windows.Forms.DataGridView();
            this.lbl_title = new System.Windows.Forms.Label();
            this.txtbx_title = new System.Windows.Forms.TextBox();
            this.txtbx_genre = new System.Windows.Forms.TextBox();
            this.lbl_genre = new System.Windows.Forms.Label();
            this.txtbx_price = new System.Windows.Forms.TextBox();
            this.lbl_price = new System.Windows.Forms.Label();
            this.txtbx_company = new System.Windows.Forms.TextBox();
            this.lbl_company = new System.Windows.Forms.Label();
            this.txtbx_platform = new System.Windows.Forms.TextBox();
            this.lbl_platform = new System.Windows.Forms.Label();
            this.lbl_splashart = new System.Windows.Forms.Label();
            this.but_insert = new System.Windows.Forms.Button();
            this.but_update = new System.Windows.Forms.Button();
            this.but_delete = new System.Windows.Forms.Button();
            this.pbx_splash = new System.Windows.Forms.PictureBox();
            this.but_save = new System.Windows.Forms.Button();
            this.but_browse = new System.Windows.Forms.Button();
            this.but_home = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_games)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_splash)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_games
            // 
            this.dgv_games.AllowUserToAddRows = false;
            this.dgv_games.AllowUserToDeleteRows = false;
            this.dgv_games.AllowUserToOrderColumns = true;
            this.dgv_games.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_games.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_games.Location = new System.Drawing.Point(12, 207);
            this.dgv_games.MultiSelect = false;
            this.dgv_games.Name = "dgv_games";
            this.dgv_games.ReadOnly = true;
            this.dgv_games.RowHeadersWidth = 51;
            this.dgv_games.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_games.Size = new System.Drawing.Size(842, 231);
            this.dgv_games.TabIndex = 0;
            this.dgv_games.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_games_CellClick);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(8, 50);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(67, 29);
            this.lbl_title.TabIndex = 1;
            this.lbl_title.Text = "Title:";
            // 
            // txtbx_title
            // 
            this.txtbx_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_title.Location = new System.Drawing.Point(118, 48);
            this.txtbx_title.Name = "txtbx_title";
            this.txtbx_title.Size = new System.Drawing.Size(226, 30);
            this.txtbx_title.TabIndex = 2;
            this.txtbx_title.TextChanged += new System.EventHandler(this.txtbx_title_TextChanged);
            // 
            // txtbx_genre
            // 
            this.txtbx_genre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_genre.Location = new System.Drawing.Point(118, 80);
            this.txtbx_genre.Name = "txtbx_genre";
            this.txtbx_genre.Size = new System.Drawing.Size(226, 30);
            this.txtbx_genre.TabIndex = 4;
            // 
            // lbl_genre
            // 
            this.lbl_genre.AutoSize = true;
            this.lbl_genre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_genre.Location = new System.Drawing.Point(8, 82);
            this.lbl_genre.Name = "lbl_genre";
            this.lbl_genre.Size = new System.Drawing.Size(86, 29);
            this.lbl_genre.TabIndex = 3;
            this.lbl_genre.Text = "Genre:";
            // 
            // txtbx_price
            // 
            this.txtbx_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_price.Location = new System.Drawing.Point(118, 112);
            this.txtbx_price.Name = "txtbx_price";
            this.txtbx_price.Size = new System.Drawing.Size(226, 30);
            this.txtbx_price.TabIndex = 6;
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.Location = new System.Drawing.Point(8, 114);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(69, 29);
            this.lbl_price.TabIndex = 5;
            this.lbl_price.Text = "Price";
            // 
            // txtbx_company
            // 
            this.txtbx_company.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_company.Location = new System.Drawing.Point(118, 144);
            this.txtbx_company.Name = "txtbx_company";
            this.txtbx_company.Size = new System.Drawing.Size(226, 30);
            this.txtbx_company.TabIndex = 8;
            // 
            // lbl_company
            // 
            this.lbl_company.AutoSize = true;
            this.lbl_company.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_company.Location = new System.Drawing.Point(8, 146);
            this.lbl_company.Name = "lbl_company";
            this.lbl_company.Size = new System.Drawing.Size(121, 29);
            this.lbl_company.TabIndex = 7;
            this.lbl_company.Text = "Company:";
            // 
            // txtbx_platform
            // 
            this.txtbx_platform.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_platform.Location = new System.Drawing.Point(118, 180);
            this.txtbx_platform.Name = "txtbx_platform";
            this.txtbx_platform.Size = new System.Drawing.Size(226, 30);
            this.txtbx_platform.TabIndex = 10;
            // 
            // lbl_platform
            // 
            this.lbl_platform.AutoSize = true;
            this.lbl_platform.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_platform.Location = new System.Drawing.Point(8, 180);
            this.lbl_platform.Name = "lbl_platform";
            this.lbl_platform.Size = new System.Drawing.Size(108, 29);
            this.lbl_platform.TabIndex = 9;
            this.lbl_platform.Text = "Platform:";
            // 
            // lbl_splashart
            // 
            this.lbl_splashart.AutoSize = true;
            this.lbl_splashart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_splashart.Location = new System.Drawing.Point(350, 146);
            this.lbl_splashart.Name = "lbl_splashart";
            this.lbl_splashart.Size = new System.Drawing.Size(120, 29);
            this.lbl_splashart.TabIndex = 11;
            this.lbl_splashart.Text = "Splashart:";
            // 
            // but_insert
            // 
            this.but_insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_insert.Location = new System.Drawing.Point(698, 9);
            this.but_insert.Name = "but_insert";
            this.but_insert.Size = new System.Drawing.Size(75, 75);
            this.but_insert.TabIndex = 13;
            this.but_insert.Text = "Insert";
            this.but_insert.UseVisualStyleBackColor = true;
            this.but_insert.Click += new System.EventHandler(this.but_insert_Click);
            // 
            // but_update
            // 
            this.but_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_update.Location = new System.Drawing.Point(779, 9);
            this.but_update.Name = "but_update";
            this.but_update.Size = new System.Drawing.Size(75, 75);
            this.but_update.TabIndex = 14;
            this.but_update.Text = "Update";
            this.but_update.UseVisualStyleBackColor = true;
            this.but_update.Click += new System.EventHandler(this.but_update_Click);
            // 
            // but_delete
            // 
            this.but_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_delete.Location = new System.Drawing.Point(779, 90);
            this.but_delete.Name = "but_delete";
            this.but_delete.Size = new System.Drawing.Size(75, 75);
            this.but_delete.TabIndex = 15;
            this.but_delete.Text = "Delete";
            this.but_delete.UseVisualStyleBackColor = true;
            this.but_delete.Click += new System.EventHandler(this.but_delete_Click);
            // 
            // pbx_splash
            // 
            this.pbx_splash.Location = new System.Drawing.Point(452, 7);
            this.pbx_splash.Name = "pbx_splash";
            this.pbx_splash.Size = new System.Drawing.Size(240, 194);
            this.pbx_splash.TabIndex = 16;
            this.pbx_splash.TabStop = false;
            // 
            // but_save
            // 
            this.but_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_save.Location = new System.Drawing.Point(698, 90);
            this.but_save.Name = "but_save";
            this.but_save.Size = new System.Drawing.Size(75, 75);
            this.but_save.TabIndex = 17;
            this.but_save.Text = "Save";
            this.but_save.UseVisualStyleBackColor = true;
            this.but_save.Click += new System.EventHandler(this.but_save_Click);
            // 
            // but_browse
            // 
            this.but_browse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_browse.Location = new System.Drawing.Point(354, 173);
            this.but_browse.Name = "but_browse";
            this.but_browse.Size = new System.Drawing.Size(75, 29);
            this.but_browse.TabIndex = 18;
            this.but_browse.Text = "Browse";
            this.but_browse.UseVisualStyleBackColor = true;
            this.but_browse.Click += new System.EventHandler(this.but_browse_Click);
            // 
            // but_home
            // 
            this.but_home.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("but_home.BackgroundImage")));
            this.but_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.but_home.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_home.Location = new System.Drawing.Point(12, 9);
            this.but_home.Name = "but_home";
            this.but_home.Size = new System.Drawing.Size(40, 40);
            this.but_home.TabIndex = 19;
            this.but_home.UseVisualStyleBackColor = true;
            this.but_home.Click += new System.EventHandler(this.but_home_Click);
            // 
            // GamesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 450);
            this.Controls.Add(this.but_home);
            this.Controls.Add(this.but_browse);
            this.Controls.Add(this.but_save);
            this.Controls.Add(this.pbx_splash);
            this.Controls.Add(this.but_delete);
            this.Controls.Add(this.but_update);
            this.Controls.Add(this.but_insert);
            this.Controls.Add(this.lbl_splashart);
            this.Controls.Add(this.txtbx_platform);
            this.Controls.Add(this.lbl_platform);
            this.Controls.Add(this.txtbx_company);
            this.Controls.Add(this.lbl_company);
            this.Controls.Add(this.txtbx_price);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.txtbx_genre);
            this.Controls.Add(this.lbl_genre);
            this.Controls.Add(this.txtbx_title);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.dgv_games);
            this.Name = "GamesList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GamesList";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GamesList_FormClosed);
            this.Load += new System.EventHandler(this.GamesList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_games)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_splash)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_games;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.TextBox txtbx_title;
        private System.Windows.Forms.TextBox txtbx_genre;
        private System.Windows.Forms.Label lbl_genre;
        private System.Windows.Forms.TextBox txtbx_price;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.TextBox txtbx_company;
        private System.Windows.Forms.Label lbl_company;
        private System.Windows.Forms.TextBox txtbx_platform;
        private System.Windows.Forms.Label lbl_platform;
        private System.Windows.Forms.Label lbl_splashart;
        private System.Windows.Forms.Button but_insert;
        private System.Windows.Forms.Button but_update;
        private System.Windows.Forms.Button but_delete;
        private System.Windows.Forms.PictureBox pbx_splash;
        private System.Windows.Forms.Button but_save;
        private System.Windows.Forms.Button but_browse;
        private System.Windows.Forms.Button but_home;
    }
}