namespace AGV
{
    partial class Login
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.LblPassword = new System.Windows.Forms.Label();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.LblId = new System.Windows.Forms.Label();
            this.txbId = new System.Windows.Forms.TextBox();
            this.LblCode = new System.Windows.Forms.Label();
            this.txbOperator = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.btnRegist = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(368, 174);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 32;
            this.btnLogin.Text = "로그인";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.LblPassword.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LblPassword.ForeColor = System.Drawing.Color.White;
            this.LblPassword.Location = new System.Drawing.Point(280, 138);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(57, 12);
            this.LblPassword.TabIndex = 31;
            this.LblPassword.Text = "비밀번호";
            this.LblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbPassword
            // 
            this.txbPassword.Location = new System.Drawing.Point(343, 135);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.PasswordChar = '*';
            this.txbPassword.Size = new System.Drawing.Size(100, 21);
            this.txbPassword.TabIndex = 30;
            this.txbPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxbPassword_KeyDown);
            // 
            // LblId
            // 
            this.LblId.AutoSize = true;
            this.LblId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.LblId.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LblId.ForeColor = System.Drawing.Color.White;
            this.LblId.Location = new System.Drawing.Point(280, 111);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(31, 12);
            this.LblId.TabIndex = 29;
            this.LblId.Text = "사번";
            this.LblId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbId
            // 
            this.txbId.Location = new System.Drawing.Point(343, 108);
            this.txbId.Name = "txbId";
            this.txbId.Size = new System.Drawing.Size(100, 21);
            this.txbId.TabIndex = 28;
            // 
            // LblCode
            // 
            this.LblCode.AutoSize = true;
            this.LblCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.LblCode.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LblCode.ForeColor = System.Drawing.Color.White;
            this.LblCode.Location = new System.Drawing.Point(280, 84);
            this.LblCode.Name = "LblCode";
            this.LblCode.Size = new System.Drawing.Size(31, 12);
            this.LblCode.TabIndex = 27;
            this.LblCode.Text = "이름";
            this.LblCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbOperator
            // 
            this.txbOperator.Location = new System.Drawing.Point(343, 81);
            this.txbOperator.Name = "txbOperator";
            this.txbOperator.Size = new System.Drawing.Size(100, 21);
            this.txbOperator.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.label4.Location = new System.Drawing.Point(252, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 12);
            this.label4.TabIndex = 25;
            this.label4.Text = "Produced By 2019 PKNU IoT Proj";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AGV.Properties.Resources.AGV_Navigation_icon_drop_shadow;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 214);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // pbClose
            // 
            this.pbClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.pbClose.Image = global::AGV.Properties.Resources.exit_black_small_01;
            this.pbClose.Location = new System.Drawing.Point(424, 12);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(30, 30);
            this.pbClose.TabIndex = 36;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.PbClose_Click);
            this.pbClose.MouseEnter += new System.EventHandler(this.PbClose_MouseEnter);
            this.pbClose.MouseLeave += new System.EventHandler(this.PbClose_MouseLeave);
            // 
            // btnRegist
            // 
            this.btnRegist.Location = new System.Drawing.Point(287, 174);
            this.btnRegist.Name = "btnRegist";
            this.btnRegist.Size = new System.Drawing.Size(75, 23);
            this.btnRegist.TabIndex = 37;
            this.btnRegist.Text = "등록";
            this.btnRegist.UseVisualStyleBackColor = true;
            this.btnRegist.Click += new System.EventHandler(this.BtnRegist_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.ClientSize = new System.Drawing.Size(466, 238);
            this.Controls.Add(this.btnRegist);
            this.Controls.Add(this.pbClose);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.LblId);
            this.Controls.Add(this.txbId);
            this.Controls.Add(this.LblCode);
            this.Controls.Add(this.txbOperator);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.Label LblId;
        private System.Windows.Forms.TextBox txbId;
        private System.Windows.Forms.Label LblCode;
        private System.Windows.Forms.TextBox txbOperator;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.Button btnRegist;
    }
}