namespace AGVProj
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ptbClose = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.ptbMini = new System.Windows.Forms.PictureBox();
            this.lblState1 = new System.Windows.Forms.Label();
            this.informationControl1 = new AGVProj.InformationControl();
            this.menuControl1 = new AGVProj.MenuControl();
            ((System.ComponentModel.ISupportInitialize)(this.ptbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMini)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbClose
            // 
            this.ptbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.ptbClose.Image = ((System.Drawing.Image)(resources.GetObject("ptbClose.Image")));
            this.ptbClose.Location = new System.Drawing.Point(926, 6);
            this.ptbClose.Name = "ptbClose";
            this.ptbClose.Size = new System.Drawing.Size(30, 30);
            this.ptbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ptbClose.TabIndex = 9;
            this.ptbClose.TabStop = false;
            this.ptbClose.Click += new System.EventHandler(this.PictureBox10_Click);
            this.ptbClose.MouseEnter += new System.EventHandler(this.PtbClose_MouseEnter);
            this.ptbClose.MouseLeave += new System.EventHandler(this.PtbClose_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::AGVProj.Properties.Resources.ActionBack_01_01;
            this.pictureBox1.Location = new System.Drawing.Point(872, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::AGVProj.Properties.Resources.project_name_bar_01_01;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(890, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.DoubleClick += new System.EventHandler(this.PictureBox2_DoubleClick);
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox2_MouseDown);
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox2_MouseMove);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.pictureBox3.Image = global::AGVProj.Properties.Resources.AGV_Navigation_icon_drop_shadow;
            this.pictureBox3.Location = new System.Drawing.Point(1, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.lblName.Font = new System.Drawing.Font("문체부 훈민정음체", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(47, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(216, 20);
            this.lblName.TabIndex = 13;
            this.lblName.Text = "AGV Management System";
            this.lblName.DoubleClick += new System.EventHandler(this.LblName_DoubleClick);
            this.lblName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LblName_MouseDown);
            this.lblName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LblName_MouseMove);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox4.Location = new System.Drawing.Point(0, 651);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(962, 10);
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.pictureBox7.Location = new System.Drawing.Point(168, 35);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(796, 10);
            this.pictureBox7.TabIndex = 18;
            this.pictureBox7.TabStop = false;
            // 
            // ptbMini
            // 
            this.ptbMini.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbMini.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.ptbMini.Image = ((System.Drawing.Image)(resources.GetObject("ptbMini.Image")));
            this.ptbMini.Location = new System.Drawing.Point(881, 6);
            this.ptbMini.Name = "ptbMini";
            this.ptbMini.Size = new System.Drawing.Size(30, 30);
            this.ptbMini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ptbMini.TabIndex = 10;
            this.ptbMini.TabStop = false;
            this.ptbMini.Click += new System.EventHandler(this.PictureBox11_Click);
            this.ptbMini.MouseEnter += new System.EventHandler(this.PictureBox11_MouseEnter);
            this.ptbMini.MouseLeave += new System.EventHandler(this.PtbMini_MouseLeave);
            // 
            // lblState1
            // 
            this.lblState1.AutoSize = true;
            this.lblState1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.lblState1.Font = new System.Drawing.Font("문체부 돋음체", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblState1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblState1.Location = new System.Drawing.Point(78, 400);
            this.lblState1.Name = "lblState1";
            this.lblState1.Size = new System.Drawing.Size(76, 16);
            this.lblState1.TabIndex = 29;
            this.lblState1.Text = "비운행중";
            // 
            // informationControl1
            // 
            this.informationControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.informationControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.informationControl1.Location = new System.Drawing.Point(169, 45);
            this.informationControl1.Name = "informationControl1";
            this.informationControl1.Size = new System.Drawing.Size(795, 606);
            this.informationControl1.TabIndex = 24;
            // 
            // menuControl1
            // 
            this.menuControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.menuControl1.Location = new System.Drawing.Point(0, 40);
            this.menuControl1.Name = "menuControl1";
            this.menuControl1.Size = new System.Drawing.Size(171, 626);
            this.menuControl1.TabIndex = 11;
            this.menuControl1.Notice_Click += new System.EventHandler<AGVProj.MenuControl.Notice_ClickEventArgs>(this.MenuControl1_Notice_Click);
            this.menuControl1.Enroll_Click += new System.EventHandler<AGVProj.MenuControl.Enroll_ClickEventArgs>(this.MenuControl1_Enroll_Click);
            this.menuControl1.Search_Click += new System.EventHandler<AGVProj.MenuControl.Search_ClickEventArgs>(this.MenuControl1_Search_Click);
            this.menuControl1.Indication_Click += new System.EventHandler<AGVProj.MenuControl.Indication_ClickEventArgs>(this.MenuControl1_Indication_Click);
            this.menuControl1.Manual_Click += new System.EventHandler<AGVProj.MenuControl.Manual_ClickEventArgs>(this.MenuControl1_Manual_Click);
            this.menuControl1.Logout_Click += new System.EventHandler<AGVProj.MenuControl.Logout_ClickEventArgs>(this.MenuControl1_Logout_Click);
            this.menuControl1.Banner_Click += new System.EventHandler<AGVProj.MenuControl.Banner_ClickEventArgs>(this.MenuControl1_Banner_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(962, 661);
            this.Controls.Add(this.lblState1);
            this.Controls.Add(this.informationControl1);
            this.Controls.Add(this.ptbMini);
            this.Controls.Add(this.ptbClose);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.menuControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(962, 661);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMini)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox ptbClose;
        private MenuControl menuControl1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox ptbMini;
        private InformationControl informationControl1;
        private System.Windows.Forms.Label lblState1;

    }
}