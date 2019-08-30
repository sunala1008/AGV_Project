namespace AGV.Control
{
    partial class NoticeControl
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
            this.components = new System.ComponentModel.Container();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label2 = new System.Windows.Forms.Label();
            this.lbWhatTimeisitNow = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ptbNotice = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbNotice)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(9, 582);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(29, 561);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "현재 시간 : ";
            // 
            // lbWhatTimeisitNow
            // 
            this.lbWhatTimeisitNow.AutoSize = true;
            this.lbWhatTimeisitNow.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbWhatTimeisitNow.Location = new System.Drawing.Point(113, 561);
            this.lbWhatTimeisitNow.Name = "lbWhatTimeisitNow";
            this.lbWhatTimeisitNow.Size = new System.Drawing.Size(0, 16);
            this.lbWhatTimeisitNow.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // ptbNotice
            // 
            this.ptbNotice.Image = global::AGV.Properties.Resources.Notice;
            this.ptbNotice.Location = new System.Drawing.Point(161, 76);
            this.ptbNotice.Name = "ptbNotice";
            this.ptbNotice.Size = new System.Drawing.Size(692, 403);
            this.ptbNotice.TabIndex = 3;
            this.ptbNotice.TabStop = false;
            // 
            // NoticeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ptbNotice);
            this.Controls.Add(this.lbWhatTimeisitNow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "NoticeControl";
            this.Size = new System.Drawing.Size(1023, 761);
            ((System.ComponentModel.ISupportInitialize)(this.ptbNotice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbWhatTimeisitNow;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox ptbNotice;
    }
}
