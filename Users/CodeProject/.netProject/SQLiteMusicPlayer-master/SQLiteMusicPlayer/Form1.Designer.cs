namespace SQLiteMusicPlayer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.artist = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.title = new MetroFramework.Controls.MetroTextBox();
            this.browser = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.category = new System.Windows.Forms.TextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.listBoxCategories = new System.Windows.Forms.ListBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.SearchmetroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.audio1 = new SQLiteMusicPlayer.Audio();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            resources.ApplyResources(this.metroLabel1, "metroLabel1");
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Name = "metroLabel1";
            // 
            // artist
            // 
            // 
            // 
            // 
            this.artist.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.artist.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode")));
            this.artist.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location")));
            this.artist.CustomButton.Margin = ((System.Windows.Forms.Padding)(resources.GetObject("resource.Margin")));
            this.artist.CustomButton.Name = "";
            this.artist.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size")));
            this.artist.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.artist.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex")));
            this.artist.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.artist.CustomButton.UseSelectable = true;
            this.artist.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible")));
            this.artist.Lines = new string[0];
            resources.ApplyResources(this.artist, "artist");
            this.artist.MaxLength = 32767;
            this.artist.Name = "artist";
            this.artist.PasswordChar = '\0';
            this.artist.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.artist.SelectedText = "";
            this.artist.SelectionLength = 0;
            this.artist.SelectionStart = 0;
            this.artist.ShortcutsEnabled = true;
            this.artist.UseSelectable = true;
            this.artist.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.artist.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            resources.ApplyResources(this.metroLabel2, "metroLabel2");
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Name = "metroLabel2";
            // 
            // title
            // 
            // 
            // 
            // 
            this.title.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.title.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode1")));
            this.title.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location1")));
            this.title.CustomButton.Margin = ((System.Windows.Forms.Padding)(resources.GetObject("resource.Margin1")));
            this.title.CustomButton.Name = "";
            this.title.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size1")));
            this.title.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.title.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex1")));
            this.title.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.title.CustomButton.UseSelectable = true;
            this.title.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible1")));
            this.title.Lines = new string[0];
            resources.ApplyResources(this.title, "title");
            this.title.MaxLength = 32767;
            this.title.Name = "title";
            this.title.PasswordChar = '\0';
            this.title.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.title.SelectedText = "";
            this.title.SelectionLength = 0;
            this.title.SelectionStart = 0;
            this.title.ShortcutsEnabled = true;
            this.title.UseSelectable = true;
            this.title.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.title.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.title.Click += new System.EventHandler(this.title_Click);
            // 
            // browser
            // 
            resources.ApplyResources(this.browser, "browser");
            this.browser.Name = "browser";
            this.browser.UseSelectable = true;
            this.browser.Click += new System.EventHandler(this.browser_Click);
            // 
            // metroLabel3
            // 
            resources.ApplyResources(this.metroLabel3, "metroLabel3");
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Name = "metroLabel3";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            resources.ApplyResources(this.listView1, "listView1");
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            resources.ApplyResources(this.columnHeader1, "columnHeader1");
            // 
            // columnHeader2
            // 
            resources.ApplyResources(this.columnHeader2, "columnHeader2");
            // 
            // columnHeader3
            // 
            resources.ApplyResources(this.columnHeader3, "columnHeader3");
            // 
            // columnHeader4
            // 
            resources.ApplyResources(this.columnHeader4, "columnHeader4");
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // category
            // 
            resources.ApplyResources(this.category, "category");
            this.category.Name = "category";
            this.category.TextChanged += new System.EventHandler(this.category_TextChanged);
            // 
            // metroLabel4
            // 
            resources.ApplyResources(this.metroLabel4, "metroLabel4");
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Click += new System.EventHandler(this.metroLabel4_Click);
            // 
            // listBoxCategories
            // 
            this.listBoxCategories.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.listBoxCategories.FormattingEnabled = true;
            resources.ApplyResources(this.listBoxCategories, "listBoxCategories");
            this.listBoxCategories.Items.AddRange(new object[] {
            resources.GetString("listBoxCategories.Items"),
            resources.GetString("listBoxCategories.Items1"),
            resources.GetString("listBoxCategories.Items2"),
            resources.GetString("listBoxCategories.Items3")});
            this.listBoxCategories.Name = "listBoxCategories";
            this.listBoxCategories.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // pictureBox4
            // 
            resources.ApplyResources(this.pictureBox4, "pictureBox4");
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // SearchmetroTextBox
            // 
            // 
            // 
            // 
            this.SearchmetroTextBox.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.SearchmetroTextBox.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode2")));
            this.SearchmetroTextBox.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location2")));
            this.SearchmetroTextBox.CustomButton.Name = "";
            this.SearchmetroTextBox.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size2")));
            this.SearchmetroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.SearchmetroTextBox.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex2")));
            this.SearchmetroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SearchmetroTextBox.CustomButton.UseSelectable = true;
            this.SearchmetroTextBox.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible2")));
            this.SearchmetroTextBox.Lines = new string[0];
            resources.ApplyResources(this.SearchmetroTextBox, "SearchmetroTextBox");
            this.SearchmetroTextBox.MaxLength = 32767;
            this.SearchmetroTextBox.Name = "SearchmetroTextBox";
            this.SearchmetroTextBox.PasswordChar = '\0';
            this.SearchmetroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SearchmetroTextBox.SelectedText = "";
            this.SearchmetroTextBox.SelectionLength = 0;
            this.SearchmetroTextBox.SelectionStart = 0;
            this.SearchmetroTextBox.ShortcutsEnabled = true;
            this.SearchmetroTextBox.UseSelectable = true;
            this.SearchmetroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SearchmetroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.SearchmetroTextBox.Click += new System.EventHandler(this.SearchmetroTextBox_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // pictureBox5
            // 
            resources.ApplyResources(this.pictureBox5, "pictureBox5");
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.TabStop = false;
            // 
            // audio1
            // 
            this.audio1.BackColor = System.Drawing.Color.Transparent;
            this.audio1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.audio1, "audio1");
            this.audio1.Name = "audio1";
            this.audio1.Load += new System.EventHandler(this.audio1_Load);
            // 
            // pictureBox6
            // 
            resources.ApplyResources(this.pictureBox6, "pictureBox6");
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImage = ((System.Drawing.Image)(resources.GetObject("$this.BackImage")));
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchmetroTextBox);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.listBoxCategories);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.category);
            this.Controls.Add(this.audio1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.browser);
            this.Controls.Add(this.title);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.artist);
            this.Controls.Add(this.metroLabel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.TransparencyKey = System.Drawing.Color.DodgerBlue;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox artist;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox title;
        private MetroFramework.Controls.MetroButton browser;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Audio audio1;
        private System.Windows.Forms.TextBox category;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.ListBox listBoxCategories;
        private System.Windows.Forms.PictureBox pictureBox4;
        private MetroFramework.Controls.MetroTextBox SearchmetroTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}

