﻿namespace AGVProj
{
    partial class CameraConrtol
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
            this.warningControl1 = new AGVProj.WarningControl();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // warningControl1
            // 
            this.warningControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.warningControl1.Location = new System.Drawing.Point(85, 130);
            this.warningControl1.Name = "warningControl1";
            this.warningControl1.Size = new System.Drawing.Size(219, 213);
            this.warningControl1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // CameraConrtol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.warningControl1);
            this.Name = "CameraConrtol";
            this.Size = new System.Drawing.Size(386, 491);
            this.Load += new System.EventHandler(this.CameraConrtol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WarningControl warningControl1;
        private System.Windows.Forms.Label label1;
    }
}
