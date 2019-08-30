namespace AGV_Test
{
    partial class Form1
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnpass = new System.Windows.Forms.Button();
            this.btnunpass = new System.Windows.Forms.Button();
            this.btnCamera = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnpass
            // 
            this.btnpass.Location = new System.Drawing.Point(14, 15);
            this.btnpass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnpass.Name = "btnpass";
            this.btnpass.Size = new System.Drawing.Size(86, 29);
            this.btnpass.TabIndex = 0;
            this.btnpass.Text = "양품";
            this.btnpass.UseVisualStyleBackColor = true;
            this.btnpass.Click += new System.EventHandler(this.btnpass_Click);
            // 
            // btnunpass
            // 
            this.btnunpass.Location = new System.Drawing.Point(14, 51);
            this.btnunpass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnunpass.Name = "btnunpass";
            this.btnunpass.Size = new System.Drawing.Size(86, 29);
            this.btnunpass.TabIndex = 1;
            this.btnunpass.Text = "불량품";
            this.btnunpass.UseVisualStyleBackColor = true;
            this.btnunpass.Click += new System.EventHandler(this.btnunpass_Click);
            // 
            // btnCamera
            // 
            this.btnCamera.Location = new System.Drawing.Point(14, 88);
            this.btnCamera.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCamera.Name = "btnCamera";
            this.btnCamera.Size = new System.Drawing.Size(86, 29);
            this.btnCamera.TabIndex = 2;
            this.btnCamera.Text = "카메라";
            this.btnCamera.UseVisualStyleBackColor = true;
            this.btnCamera.Click += new System.EventHandler(this.btnCamera_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(106, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(814, 528);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1461, 1039);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCamera);
            this.Controls.Add(this.btnunpass);
            this.Controls.Add(this.btnpass);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnpass;
        private System.Windows.Forms.Button btnunpass;
        private System.Windows.Forms.Button btnCamera;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

