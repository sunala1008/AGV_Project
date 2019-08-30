namespace AGVProj
{
    partial class MenuControl
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuControl));
            this.lblAMS = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblState2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbOperatorName = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ptbLogout = new System.Windows.Forms.PictureBox();
            this.ptbmanual = new System.Windows.Forms.PictureBox();
            this.ptbIndication = new System.Windows.Forms.PictureBox();
            this.ptbSearch = new System.Windows.Forms.PictureBox();
            this.ptbEnroll = new System.Windows.Forms.PictureBox();
            this.ptbNotice = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbmanual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbIndication)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbEnroll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbNotice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAMS
            // 
            this.lblAMS.BackColor = System.Drawing.Color.Black;
            this.lblAMS.Font = new System.Drawing.Font("MHunmin", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblAMS.ForeColor = System.Drawing.Color.White;
            this.lblAMS.Location = new System.Drawing.Point(0, 0);
            this.lblAMS.Name = "lblAMS";
            this.lblAMS.Size = new System.Drawing.Size(169, 67);
            this.lblAMS.TabIndex = 17;
            this.lblAMS.Text = "AMS";
            this.lblAMS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAMS.Click += new System.EventHandler(this.LblAMS_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.label1.Font = new System.Drawing.Font("MDotum", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 359);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "상태";
            // 
            // lblState2
            // 
            this.lblState2.AutoSize = true;
            this.lblState2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.lblState2.Font = new System.Drawing.Font("MDotum", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblState2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblState2.Location = new System.Drawing.Point(95, 359);
            this.lblState2.Name = "lblState2";
            this.lblState2.Size = new System.Drawing.Size(59, 16);
            this.lblState2.TabIndex = 21;
            this.lblState2.Text = "운행중";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.label2.Font = new System.Drawing.Font("MDotum", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 410);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "운전자";
            // 
            // lbOperatorName
            // 
            this.lbOperatorName.AutoSize = true;
            this.lbOperatorName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.lbOperatorName.Font = new System.Drawing.Font("MDotum", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbOperatorName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbOperatorName.Location = new System.Drawing.Point(95, 410);
            this.lbOperatorName.Name = "lbOperatorName";
            this.lbOperatorName.Size = new System.Drawing.Size(59, 16);
            this.lbOperatorName.TabIndex = 23;
            this.lbOperatorName.Text = "야옹이";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AGVProj.Properties.Resources.menu_state_01;
            this.pictureBox2.Location = new System.Drawing.Point(9, 400);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AGVProj.Properties.Resources.menu_state_01;
            this.pictureBox1.Location = new System.Drawing.Point(9, 349);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // ptbLogout
            // 
            this.ptbLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ptbLogout.Image = global::AGVProj.Properties.Resources.menu_6_1_01;
            this.ptbLogout.Location = new System.Drawing.Point(4, 572);
            this.ptbLogout.Name = "ptbLogout";
            this.ptbLogout.Size = new System.Drawing.Size(163, 50);
            this.ptbLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ptbLogout.TabIndex = 16;
            this.ptbLogout.TabStop = false;
            this.ptbLogout.Click += new System.EventHandler(this.PtbLogout_Click);
            this.ptbLogout.MouseEnter += new System.EventHandler(this.PtbLogout_MouseEnter);
            this.ptbLogout.MouseLeave += new System.EventHandler(this.PtbLogout_MouseLeave);
            // 
            // ptbmanual
            // 
            this.ptbmanual.Image = global::AGVProj.Properties.Resources.menu_5_1_01_01;
            this.ptbmanual.Location = new System.Drawing.Point(4, 270);
            this.ptbmanual.Name = "ptbmanual";
            this.ptbmanual.Size = new System.Drawing.Size(163, 50);
            this.ptbmanual.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ptbmanual.TabIndex = 15;
            this.ptbmanual.TabStop = false;
            this.ptbmanual.Click += new System.EventHandler(this.Ptbmanual_Click);
            this.ptbmanual.MouseEnter += new System.EventHandler(this.Ptbmanual_MouseEnter);
            this.ptbmanual.MouseLeave += new System.EventHandler(this.Ptbmanual_MouseLeave);
            // 
            // ptbIndication
            // 
            this.ptbIndication.Image = global::AGVProj.Properties.Resources.menu_4_1_01;
            this.ptbIndication.Location = new System.Drawing.Point(4, 220);
            this.ptbIndication.Name = "ptbIndication";
            this.ptbIndication.Size = new System.Drawing.Size(163, 50);
            this.ptbIndication.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ptbIndication.TabIndex = 14;
            this.ptbIndication.TabStop = false;
            this.ptbIndication.Click += new System.EventHandler(this.PtbIndication_Click);
            this.ptbIndication.MouseEnter += new System.EventHandler(this.PtbIndication_MouseEnter);
            this.ptbIndication.MouseLeave += new System.EventHandler(this.PtbIndication_MouseLeave);
            // 
            // ptbSearch
            // 
            this.ptbSearch.Image = ((System.Drawing.Image)(resources.GetObject("ptbSearch.Image")));
            this.ptbSearch.Location = new System.Drawing.Point(4, 170);
            this.ptbSearch.Name = "ptbSearch";
            this.ptbSearch.Size = new System.Drawing.Size(163, 50);
            this.ptbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ptbSearch.TabIndex = 13;
            this.ptbSearch.TabStop = false;
            this.ptbSearch.Click += new System.EventHandler(this.PtbSearch_Click);
            this.ptbSearch.MouseEnter += new System.EventHandler(this.PtbSearch_MouseEnter);
            this.ptbSearch.MouseLeave += new System.EventHandler(this.PtbSearch_MouseLeave);
            // 
            // ptbEnroll
            // 
            this.ptbEnroll.Image = global::AGVProj.Properties.Resources.menu_2_1_01_01;
            this.ptbEnroll.Location = new System.Drawing.Point(4, 120);
            this.ptbEnroll.Name = "ptbEnroll";
            this.ptbEnroll.Size = new System.Drawing.Size(163, 50);
            this.ptbEnroll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ptbEnroll.TabIndex = 12;
            this.ptbEnroll.TabStop = false;
            this.ptbEnroll.Click += new System.EventHandler(this.PtbEnroll_Click);
            this.ptbEnroll.MouseEnter += new System.EventHandler(this.PtbEnroll_MouseEnter);
            this.ptbEnroll.MouseLeave += new System.EventHandler(this.PtbEnroll_MouseLeave);
            // 
            // ptbNotice
            // 
            this.ptbNotice.Image = global::AGVProj.Properties.Resources.menu_1_1_01_01_01;
            this.ptbNotice.Location = new System.Drawing.Point(4, 70);
            this.ptbNotice.Name = "ptbNotice";
            this.ptbNotice.Size = new System.Drawing.Size(163, 50);
            this.ptbNotice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ptbNotice.TabIndex = 11;
            this.ptbNotice.TabStop = false;
            this.ptbNotice.Click += new System.EventHandler(this.PtbNotice_Click);
            this.ptbNotice.MouseEnter += new System.EventHandler(this.PtbNotice_MouseEnter);
            this.ptbNotice.MouseLeave += new System.EventHandler(this.PtbNotice_MouseLeave);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(4, 70);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(163, 559);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(170, 661);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // MenuControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbOperatorName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblState2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblAMS);
            this.Controls.Add(this.ptbLogout);
            this.Controls.Add(this.ptbmanual);
            this.Controls.Add(this.ptbIndication);
            this.Controls.Add(this.ptbSearch);
            this.Controls.Add(this.ptbEnroll);
            this.Controls.Add(this.ptbNotice);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Name = "MenuControl";
            this.Size = new System.Drawing.Size(169, 644);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbmanual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbIndication)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbEnroll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbNotice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox ptbmanual;
        private System.Windows.Forms.PictureBox ptbIndication;
        private System.Windows.Forms.PictureBox ptbSearch;
        private System.Windows.Forms.PictureBox ptbEnroll;
        private System.Windows.Forms.PictureBox ptbNotice;
        private System.Windows.Forms.PictureBox ptbLogout;
        private System.Windows.Forms.Label lblAMS;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblState2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbOperatorName;

    }
}
