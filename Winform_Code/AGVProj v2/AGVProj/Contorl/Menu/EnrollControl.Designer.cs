namespace AGVProj
{
    partial class EnrollControl
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
            this.label12 = new System.Windows.Forms.Label();
            this.btndel = new System.Windows.Forms.Button();
            this.btnconnect = new System.Windows.Forms.Button();
            this.lbagvlist = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbregistername = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tbagvname = new System.Windows.Forms.TextBox();
            this.tbcameraport = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbcameraip4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbcameraip3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbcameraip2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbcameraip1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbmap = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbagvport = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbagvip4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbagvip3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbagvip2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbagvip1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbmap)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(282, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 12);
            this.label12.TabIndex = 28;
            this.label12.Text = "AGV 등록자";
            // 
            // btndel
            // 
            this.btndel.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btndel.Location = new System.Drawing.Point(1113, 397);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(75, 23);
            this.btndel.TabIndex = 2;
            this.btndel.Text = "삭제";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click_1);
            // 
            // btnconnect
            // 
            this.btnconnect.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnconnect.Location = new System.Drawing.Point(1113, 368);
            this.btnconnect.Name = "btnconnect";
            this.btnconnect.Size = new System.Drawing.Size(75, 23);
            this.btnconnect.TabIndex = 1;
            this.btnconnect.Text = "연결";
            this.btnconnect.UseVisualStyleBackColor = true;
            this.btnconnect.Click += new System.EventHandler(this.btnconnect_Click_1);
            // 
            // lbagvlist
            // 
            this.lbagvlist.FormattingEnabled = true;
            this.lbagvlist.ItemHeight = 27;
            this.lbagvlist.Location = new System.Drawing.Point(6, 38);
            this.lbagvlist.Name = "lbagvlist";
            this.lbagvlist.Size = new System.Drawing.Size(1101, 355);
            this.lbagvlist.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btndel);
            this.groupBox2.Controls.Add(this.btnconnect);
            this.groupBox2.Controls.Add(this.lbagvlist);
            this.groupBox2.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(101, 523);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1194, 425);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "AGV 연결";
            // 
            // tbregistername
            // 
            this.tbregistername.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbregistername.Location = new System.Drawing.Point(358, 45);
            this.tbregistername.Name = "tbregistername";
            this.tbregistername.Size = new System.Drawing.Size(106, 21);
            this.tbregistername.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.Location = new System.Drawing.Point(470, 391);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 25);
            this.button2.TabIndex = 12;
            this.button2.Text = "이미지 불러오기";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // tbagvname
            // 
            this.tbagvname.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbagvname.Location = new System.Drawing.Point(126, 48);
            this.tbagvname.Name = "tbagvname";
            this.tbagvname.Size = new System.Drawing.Size(106, 21);
            this.tbagvname.TabIndex = 0;
            // 
            // tbcameraport
            // 
            this.tbcameraport.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbcameraport.Location = new System.Drawing.Point(408, 135);
            this.tbcameraport.Name = "tbcameraport";
            this.tbcameraport.Size = new System.Drawing.Size(56, 21);
            this.tbcameraport.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(375, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 12);
            this.label6.TabIndex = 18;
            this.label6.Text = "Port";
            // 
            // tbcameraip4
            // 
            this.tbcameraip4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbcameraip4.Location = new System.Drawing.Point(303, 135);
            this.tbcameraip4.Name = "tbcameraip4";
            this.tbcameraip4.Size = new System.Drawing.Size(47, 21);
            this.tbcameraip4.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(294, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(9, 12);
            this.label7.TabIndex = 16;
            this.label7.Text = ".";
            // 
            // tbcameraip3
            // 
            this.tbcameraip3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbcameraip3.Location = new System.Drawing.Point(244, 135);
            this.tbcameraip3.Name = "tbcameraip3";
            this.tbcameraip3.Size = new System.Drawing.Size(47, 21);
            this.tbcameraip3.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(235, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(9, 12);
            this.label8.TabIndex = 14;
            this.label8.Text = ".";
            // 
            // tbcameraip2
            // 
            this.tbcameraip2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbcameraip2.Location = new System.Drawing.Point(185, 135);
            this.tbcameraip2.Name = "tbcameraip2";
            this.tbcameraip2.Size = new System.Drawing.Size(47, 21);
            this.tbcameraip2.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(176, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(9, 12);
            this.label9.TabIndex = 12;
            this.label9.Text = ".";
            // 
            // tbcameraip1
            // 
            this.tbcameraip1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbcameraip1.Location = new System.Drawing.Point(126, 135);
            this.tbcameraip1.Name = "tbcameraip1";
            this.tbcameraip1.Size = new System.Drawing.Size(47, 21);
            this.tbcameraip1.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbregistername);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.pbmap);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.tbagvname);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.tbcameraport);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbcameraip4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbcameraip3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbcameraip2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tbcameraip1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.tbagvport);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbagvip4);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbagvip3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbagvip2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbagvip1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(101, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1194, 466);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "AGV 등록";
            // 
            // pbmap
            // 
            this.pbmap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbmap.Location = new System.Drawing.Point(126, 180);
            this.pbmap.Name = "pbmap";
            this.pbmap.Size = new System.Drawing.Size(338, 267);
            this.pbmap.TabIndex = 26;
            this.pbmap.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.Location = new System.Drawing.Point(42, 180);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 12);
            this.label13.TabIndex = 25;
            this.label13.Text = "MAP";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(470, 422);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 25);
            this.button1.TabIndex = 13;
            this.button1.Text = "AGV 등록";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(42, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 12);
            this.label11.TabIndex = 20;
            this.label11.Text = "AGV Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(42, 141);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 12);
            this.label10.TabIndex = 10;
            this.label10.Text = "CAMERA IP";
            // 
            // tbagvport
            // 
            this.tbagvport.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbagvport.Location = new System.Drawing.Point(408, 90);
            this.tbagvport.Name = "tbagvport";
            this.tbagvport.Size = new System.Drawing.Size(56, 21);
            this.tbagvport.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(375, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "Port";
            // 
            // tbagvip4
            // 
            this.tbagvip4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbagvip4.Location = new System.Drawing.Point(303, 90);
            this.tbagvip4.Name = "tbagvip4";
            this.tbagvip4.Size = new System.Drawing.Size(47, 21);
            this.tbagvip4.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(294, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(9, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = ".";
            // 
            // tbagvip3
            // 
            this.tbagvip3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbagvip3.Location = new System.Drawing.Point(244, 90);
            this.tbagvip3.Name = "tbagvip3";
            this.tbagvip3.Size = new System.Drawing.Size(47, 21);
            this.tbagvip3.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(235, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(9, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = ".";
            // 
            // tbagvip2
            // 
            this.tbagvip2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbagvip2.Location = new System.Drawing.Point(185, 90);
            this.tbagvip2.Name = "tbagvip2";
            this.tbagvip2.Size = new System.Drawing.Size(47, 21);
            this.tbagvip2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(176, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(9, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = ".";
            // 
            // tbagvip1
            // 
            this.tbagvip1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbagvip1.Location = new System.Drawing.Point(126, 90);
            this.tbagvip1.Name = "tbagvip1";
            this.tbagvip1.Size = new System.Drawing.Size(47, 21);
            this.tbagvip1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(42, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "AGV IP";
            // 
            // EnrollControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "EnrollControl";
            this.Size = new System.Drawing.Size(1396, 982);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbmap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btnconnect;
        private System.Windows.Forms.ListBox lbagvlist;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbregistername;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbagvname;
        private System.Windows.Forms.TextBox tbcameraport;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbcameraip4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbcameraip3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbcameraip2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbcameraip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbmap;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbagvport;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbagvip4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbagvip3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbagvip2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbagvip1;
        private System.Windows.Forms.Label label1;
    }
}
