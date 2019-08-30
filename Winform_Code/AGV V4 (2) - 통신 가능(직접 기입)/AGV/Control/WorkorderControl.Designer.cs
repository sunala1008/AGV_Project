namespace AGV.Control
{
    partial class WorkorderControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnpass = new System.Windows.Forms.RadioButton();
            this.btnStop = new System.Windows.Forms.Button();
            this.rbtnunpass = new System.Windows.Forms.RadioButton();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.lbWorklist = new System.Windows.Forms.ListBox();
            this.pbMap = new System.Windows.Forms.PictureBox();
            this.pbCam = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCam)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnpass);
            this.groupBox1.Controls.Add(this.btnStop);
            this.groupBox1.Controls.Add(this.rbtnunpass);
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnDel);
            this.groupBox1.Controls.Add(this.lbWorklist);
            this.groupBox1.Location = new System.Drawing.Point(768, 421);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 332);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // rbtnpass
            // 
            this.rbtnpass.AutoSize = true;
            this.rbtnpass.Location = new System.Drawing.Point(22, 30);
            this.rbtnpass.Name = "rbtnpass";
            this.rbtnpass.Size = new System.Drawing.Size(187, 16);
            this.rbtnpass.TabIndex = 8;
            this.rbtnpass.TabStop = true;
            this.rbtnpass.Text = "양품 적재 후 양품 창고에 하차";
            this.rbtnpass.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(184, 74);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(48, 23);
            this.btnStop.TabIndex = 14;
            this.btnStop.Text = "정지";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // rbtnunpass
            // 
            this.rbtnunpass.AutoSize = true;
            this.rbtnunpass.Location = new System.Drawing.Point(22, 52);
            this.rbtnunpass.Name = "rbtnunpass";
            this.rbtnunpass.Size = new System.Drawing.Size(211, 16);
            this.rbtnunpass.TabIndex = 9;
            this.rbtnunpass.TabStop = true;
            this.rbtnunpass.Text = "불량품 적재 후 불량품 창고에 하차";
            this.rbtnunpass.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(130, 74);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(48, 23);
            this.btnStart.TabIndex = 13;
            this.btnStart.Text = "실행";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(22, 74);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(48, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "추가";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(76, 74);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(48, 23);
            this.btnDel.TabIndex = 12;
            this.btnDel.Text = "삭제";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // lbWorklist
            // 
            this.lbWorklist.FormattingEnabled = true;
            this.lbWorklist.ItemHeight = 12;
            this.lbWorklist.Location = new System.Drawing.Point(22, 103);
            this.lbWorklist.Name = "lbWorklist";
            this.lbWorklist.Size = new System.Drawing.Size(211, 208);
            this.lbWorklist.TabIndex = 11;
            // 
            // pbMap
            // 
            this.pbMap.Image = global::AGV.Properties.Resources.warning;
            this.pbMap.Location = new System.Drawing.Point(657, 3);
            this.pbMap.Name = "pbMap";
            this.pbMap.Size = new System.Drawing.Size(363, 417);
            this.pbMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbMap.TabIndex = 15;
            this.pbMap.TabStop = false;
            // 
            // pbCam
            // 
            this.pbCam.Image = global::AGV.Properties.Resources.warning;
            this.pbCam.Location = new System.Drawing.Point(3, 3);
            this.pbCam.Name = "pbCam";
            this.pbCam.Size = new System.Drawing.Size(648, 755);
            this.pbCam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbCam.TabIndex = 16;
            this.pbCam.TabStop = false;
            // 
            // WorkorderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pbCam);
            this.Controls.Add(this.pbMap);
            this.Controls.Add(this.groupBox1);
            this.Name = "WorkorderControl";
            this.Size = new System.Drawing.Size(1023, 761);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnpass;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.RadioButton rbtnunpass;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.ListBox lbWorklist;
        private System.Windows.Forms.PictureBox pbMap;
        private System.Windows.Forms.PictureBox pbCam;
    }
}
