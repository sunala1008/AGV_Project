namespace AGVProj
{
    partial class InformationControl
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
            this.pnlsplit = new System.Windows.Forms.SplitContainer();
            this.lblSymbol = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.mapSmallControl1 = new AGVProj.MapSmallControl();
            this.manualControl2 = new AGVProj.ManualControl();
            this.detailConrtol1 = new AGVProj.DetailConrtol();
            this.indicationControl1 = new AGVProj.IndicationControl();
            this.cameraConrtol2 = new AGVProj.CameraConrtol();
            this.enrollControl1 = new AGVProj.EnrollControl();
            this.mapControl1 = new AGVProj.MapControl();
            this.noticeControl1 = new AGVProj.NoticeControl();
            this.searchControl1 = new AGVProj.SearchControl();
            ((System.ComponentModel.ISupportInitialize)(this.pnlsplit)).BeginInit();
            this.pnlsplit.Panel1.SuspendLayout();
            this.pnlsplit.Panel2.SuspendLayout();
            this.pnlsplit.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlsplit
            // 
            this.pnlsplit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlsplit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.pnlsplit.IsSplitterFixed = true;
            this.pnlsplit.Location = new System.Drawing.Point(1196, 0);
            this.pnlsplit.Name = "pnlsplit";
            this.pnlsplit.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // pnlsplit.Panel1
            // 
            this.pnlsplit.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.pnlsplit.Panel1.Controls.Add(this.mapSmallControl1);
            this.pnlsplit.Panel1.Controls.Add(this.manualControl2);
            this.pnlsplit.Panel1.Controls.Add(this.detailConrtol1);
            this.pnlsplit.Panel1.Controls.Add(this.indicationControl1);
            // 
            // pnlsplit.Panel2
            // 
            this.pnlsplit.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.pnlsplit.Panel2.Controls.Add(this.cameraConrtol2);
            this.pnlsplit.Size = new System.Drawing.Size(386, 982);
            this.pnlsplit.SplitterDistance = 487;
            this.pnlsplit.TabIndex = 20;
            // 
            // lblSymbol
            // 
            this.lblSymbol.AutoSize = true;
            this.lblSymbol.Font = new System.Drawing.Font("문체부 제목 돋음체", 200.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblSymbol.Location = new System.Drawing.Point(390, 302);
            this.lblSymbol.Name = "lblSymbol";
            this.lblSymbol.Size = new System.Drawing.Size(548, 267);
            this.lblSymbol.TabIndex = 24;
            this.lblSymbol.Text = "AMS";
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.pnlMain.Controls.Add(this.enrollControl1);
            this.pnlMain.Controls.Add(this.mapControl1);
            this.pnlMain.Controls.Add(this.noticeControl1);
            this.pnlMain.Controls.Add(this.searchControl1);
            this.pnlMain.Controls.Add(this.lblSymbol);
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1191, 982);
            this.pnlMain.TabIndex = 21;
            // 
            // mapSmallControl1
            // 
            this.mapSmallControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.mapSmallControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapSmallControl1.Location = new System.Drawing.Point(0, 0);
            this.mapSmallControl1.Name = "mapSmallControl1";
            this.mapSmallControl1.Size = new System.Drawing.Size(386, 487);
            this.mapSmallControl1.TabIndex = 3;
            // 
            // manualControl2
            // 
            this.manualControl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.manualControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.manualControl2.Location = new System.Drawing.Point(0, 0);
            this.manualControl2.Name = "manualControl2";
            this.manualControl2.Size = new System.Drawing.Size(386, 487);
            this.manualControl2.TabIndex = 1;
            // 
            // detailConrtol1
            // 
            this.detailConrtol1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.detailConrtol1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailConrtol1.Location = new System.Drawing.Point(0, 0);
            this.detailConrtol1.Name = "detailConrtol1";
            this.detailConrtol1.Size = new System.Drawing.Size(386, 487);
            this.detailConrtol1.TabIndex = 1;
            // 
            // indicationControl1
            // 
            this.indicationControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.indicationControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.indicationControl1.Location = new System.Drawing.Point(0, 0);
            this.indicationControl1.Name = "indicationControl1";
            this.indicationControl1.Size = new System.Drawing.Size(386, 487);
            this.indicationControl1.TabIndex = 0;
            // 
            // cameraConrtol2
            // 
            this.cameraConrtol2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.cameraConrtol2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cameraConrtol2.Location = new System.Drawing.Point(0, 0);
            this.cameraConrtol2.Name = "cameraConrtol2";
            this.cameraConrtol2.Size = new System.Drawing.Size(386, 491);
            this.cameraConrtol2.TabIndex = 0;
            // 
            // enrollControl1
            // 
            this.enrollControl1.BackColor = System.Drawing.Color.White;
            this.enrollControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enrollControl1.Location = new System.Drawing.Point(0, 0);
            this.enrollControl1.Name = "enrollControl1";
            this.enrollControl1.Size = new System.Drawing.Size(1191, 982);
            this.enrollControl1.TabIndex = 25;
            this.enrollControl1.Connect_Click += new System.EventHandler<AGVProj.EnrollControl.Connect_ClickEventArgs>(this.enrollControl1_Connect_Click);
            // 
            // mapControl1
            // 
            this.mapControl1.BackColor = System.Drawing.Color.White;
            this.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapControl1.Location = new System.Drawing.Point(0, 0);
            this.mapControl1.Name = "mapControl1";
            this.mapControl1.Size = new System.Drawing.Size(1191, 982);
            this.mapControl1.TabIndex = 5;
            // 
            // noticeControl1
            // 
            this.noticeControl1.BackColor = System.Drawing.Color.White;
            this.noticeControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.noticeControl1.Location = new System.Drawing.Point(0, 0);
            this.noticeControl1.Name = "noticeControl1";
            this.noticeControl1.Size = new System.Drawing.Size(1191, 982);
            this.noticeControl1.TabIndex = 1;
            // 
            // searchControl1
            // 
            this.searchControl1.BackColor = System.Drawing.Color.White;
            this.searchControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchControl1.Location = new System.Drawing.Point(0, 0);
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Size = new System.Drawing.Size(1191, 982);
            this.searchControl1.TabIndex = 0;
            this.searchControl1.Visible = false;
            // 
            // InformationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Controls.Add(this.pnlsplit);
            this.Controls.Add(this.pnlMain);
            this.Name = "InformationControl";
            this.Size = new System.Drawing.Size(1588, 982);
            this.pnlsplit.Panel1.ResumeLayout(false);
            this.pnlsplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlsplit)).EndInit();
            this.pnlsplit.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer pnlsplit;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblSymbol;
        private SearchControl searchControl1;
        private NoticeControl noticeControl1;
        private MapControl mapControl1;
        private DetailConrtol detailConrtol1;
        private IndicationControl indicationControl1;
        private CameraConrtol cameraConrtol2;
        private ManualControl manualControl2;
        private MapSmallControl mapSmallControl1;
        private EnrollControl enrollControl1;
    }
}
