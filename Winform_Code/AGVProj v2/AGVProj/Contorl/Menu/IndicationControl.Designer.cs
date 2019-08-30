namespace AGVProj
{
    partial class IndicationControl
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
            this.rbtnpass = new System.Windows.Forms.RadioButton();
            this.rbtnunpass = new System.Windows.Forms.RadioButton();
            this.btnAdd = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnstop = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbtnpass
            // 
            this.rbtnpass.AutoSize = true;
            this.rbtnpass.Location = new System.Drawing.Point(7, 20);
            this.rbtnpass.Name = "rbtnpass";
            this.rbtnpass.Size = new System.Drawing.Size(187, 16);
            this.rbtnpass.TabIndex = 0;
            this.rbtnpass.TabStop = true;
            this.rbtnpass.Text = "양품 적재 후 양품 창고에 하차";
            this.rbtnpass.UseVisualStyleBackColor = true;
            // 
            // rbtnunpass
            // 
            this.rbtnunpass.AutoSize = true;
            this.rbtnunpass.Location = new System.Drawing.Point(7, 42);
            this.rbtnunpass.Name = "rbtnunpass";
            this.rbtnunpass.Size = new System.Drawing.Size(211, 16);
            this.rbtnunpass.TabIndex = 1;
            this.rbtnunpass.TabStop = true;
            this.rbtnunpass.Text = "불량품 적재 후 불량품 창고에 하차";
            this.rbtnunpass.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(7, 64);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(48, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "추가";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(7, 93);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(211, 208);
            this.listBox1.TabIndex = 3;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(61, 64);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(48, 23);
            this.btnDel.TabIndex = 4;
            this.btnDel.Text = "삭제";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // btnstop
            // 
            this.btnstop.Location = new System.Drawing.Point(115, 64);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(48, 23);
            this.btnstop.TabIndex = 6;
            this.btnstop.Text = "실행";
            this.btnstop.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(169, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "정지";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnpass);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.rbtnunpass);
            this.groupBox1.Controls.Add(this.btnstop);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnDel);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(83, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 311);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // IndicationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox1);
            this.Name = "IndicationControl";
            this.Size = new System.Drawing.Size(386, 487);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnpass;
        private System.Windows.Forms.RadioButton rbtnunpass;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnstop;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
