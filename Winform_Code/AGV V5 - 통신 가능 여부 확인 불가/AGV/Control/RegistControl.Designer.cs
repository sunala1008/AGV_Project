namespace AGV.Control
{
    partial class RegistControl
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
            this.tbRegisterName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnMapLoad = new System.Windows.Forms.Button();
            this.btnAGVRegist = new System.Windows.Forms.Button();
            this.tbAGVName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbCamPort = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvAGVList = new System.Windows.Forms.DataGridView();
            this.btnAGVDisconnect = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnAGVConnect = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbAGVPort = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbAGVIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCamIP = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pbmap = new System.Windows.Forms.PictureBox();
            this.aGVNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aGVIPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aGVPortDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.camIPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.camPortDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdsAGVList = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAGVList)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbmap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsAGVList)).BeginInit();
            this.SuspendLayout();
            // 
            // tbRegisterName
            // 
            this.tbRegisterName.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbRegisterName.Location = new System.Drawing.Point(112, 67);
            this.tbRegisterName.Name = "tbRegisterName";
            this.tbRegisterName.Size = new System.Drawing.Size(106, 21);
            this.tbRegisterName.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(27, 70);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 12);
            this.label12.TabIndex = 28;
            this.label12.Text = "AGV 등록자";
            // 
            // btnMapLoad
            // 
            this.btnMapLoad.Font = new System.Drawing.Font("Gulim", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMapLoad.Location = new System.Drawing.Point(749, 281);
            this.btnMapLoad.Name = "btnMapLoad";
            this.btnMapLoad.Size = new System.Drawing.Size(110, 25);
            this.btnMapLoad.TabIndex = 12;
            this.btnMapLoad.Text = "이미지 불러오기";
            this.btnMapLoad.UseVisualStyleBackColor = true;
            this.btnMapLoad.Click += new System.EventHandler(this.BtnMapLoad_Click);
            // 
            // btnAGVRegist
            // 
            this.btnAGVRegist.Font = new System.Drawing.Font("Gulim", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnAGVRegist.Location = new System.Drawing.Point(749, 317);
            this.btnAGVRegist.Name = "btnAGVRegist";
            this.btnAGVRegist.Size = new System.Drawing.Size(110, 25);
            this.btnAGVRegist.TabIndex = 13;
            this.btnAGVRegist.Text = "AGV 등록";
            this.btnAGVRegist.UseVisualStyleBackColor = true;
            this.btnAGVRegist.Click += new System.EventHandler(this.BtnAGVRegist_Click);
            // 
            // tbAGVName
            // 
            this.tbAGVName.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbAGVName.Location = new System.Drawing.Point(111, 31);
            this.tbAGVName.Name = "tbAGVName";
            this.tbAGVName.Size = new System.Drawing.Size(106, 21);
            this.tbAGVName.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(27, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 12);
            this.label11.TabIndex = 20;
            this.label11.Text = "AGV Name";
            // 
            // tbCamPort
            // 
            this.tbCamPort.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbCamPort.Location = new System.Drawing.Point(111, 211);
            this.tbCamPort.Name = "tbCamPort";
            this.tbCamPort.Size = new System.Drawing.Size(56, 21);
            this.tbCamPort.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvAGVList);
            this.groupBox2.Controls.Add(this.btnAGVDisconnect);
            this.groupBox2.Controls.Add(this.btnLoad);
            this.groupBox2.Controls.Add(this.btnAGVConnect);
            this.groupBox2.Font = new System.Drawing.Font("Gulim", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(8, 369);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1003, 380);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "AGV 연결";
            // 
            // dgvAGVList
            // 
            this.dgvAGVList.AllowUserToAddRows = false;
            this.dgvAGVList.AllowUserToDeleteRows = false;
            this.dgvAGVList.AllowUserToOrderColumns = true;
            this.dgvAGVList.AllowUserToResizeColumns = false;
            this.dgvAGVList.AllowUserToResizeRows = false;
            this.dgvAGVList.AutoGenerateColumns = false;
            this.dgvAGVList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAGVList.ColumnHeadersHeight = 24;
            this.dgvAGVList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAGVList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aGVNameDataGridViewTextBoxColumn,
            this.registerNameDataGridViewTextBoxColumn,
            this.aGVIPDataGridViewTextBoxColumn,
            this.aGVPortDataGridViewTextBoxColumn,
            this.camIPDataGridViewTextBoxColumn,
            this.camPortDataGridViewTextBoxColumn,
            this.mapDataGridViewTextBoxColumn});
            this.dgvAGVList.DataSource = this.bdsAGVList;
            this.dgvAGVList.Location = new System.Drawing.Point(6, 24);
            this.dgvAGVList.Name = "dgvAGVList";
            this.dgvAGVList.ReadOnly = true;
            this.dgvAGVList.RowHeadersVisible = false;
            this.dgvAGVList.RowTemplate.Height = 23;
            this.dgvAGVList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAGVList.Size = new System.Drawing.Size(865, 342);
            this.dgvAGVList.StandardTab = true;
            this.dgvAGVList.TabIndex = 17;
            this.dgvAGVList.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DgvAGVList_KeyUp);
            // 
            // btnAGVDisconnect
            // 
            this.btnAGVDisconnect.Font = new System.Drawing.Font("Gulim", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnAGVDisconnect.Location = new System.Drawing.Point(877, 341);
            this.btnAGVDisconnect.Name = "btnAGVDisconnect";
            this.btnAGVDisconnect.Size = new System.Drawing.Size(110, 25);
            this.btnAGVDisconnect.TabIndex = 16;
            this.btnAGVDisconnect.Text = "AGV 연결 해제";
            this.btnAGVDisconnect.UseVisualStyleBackColor = true;
            this.btnAGVDisconnect.Click += new System.EventHandler(this.BtnAGVDisconnect_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Gulim", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnLoad.Location = new System.Drawing.Point(877, 270);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(110, 25);
            this.btnLoad.TabIndex = 15;
            this.btnLoad.Text = "AGV 불러오기";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // btnAGVConnect
            // 
            this.btnAGVConnect.Font = new System.Drawing.Font("Gulim", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnAGVConnect.Location = new System.Drawing.Point(877, 305);
            this.btnAGVConnect.Name = "btnAGVConnect";
            this.btnAGVConnect.Size = new System.Drawing.Size(110, 25);
            this.btnAGVConnect.TabIndex = 14;
            this.btnAGVConnect.Text = "AGV 연결";
            this.btnAGVConnect.UseVisualStyleBackColor = true;
            this.btnAGVConnect.Click += new System.EventHandler(this.BtnAGVConnect_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(27, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 12);
            this.label6.TabIndex = 18;
            this.label6.Text = "Cam Port";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(27, 178);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 12);
            this.label10.TabIndex = 10;
            this.label10.Text = "Cam IP";
            // 
            // tbAGVPort
            // 
            this.tbAGVPort.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbAGVPort.Location = new System.Drawing.Point(112, 139);
            this.tbAGVPort.Name = "tbAGVPort";
            this.tbAGVPort.Size = new System.Drawing.Size(56, 21);
            this.tbAGVPort.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(27, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "AGV Port";
            // 
            // tbAGVIP
            // 
            this.tbAGVIP.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbAGVIP.Location = new System.Drawing.Point(111, 103);
            this.tbAGVIP.Name = "tbAGVIP";
            this.tbAGVIP.Size = new System.Drawing.Size(169, 21);
            this.tbAGVIP.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(27, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "AGV IP";
            // 
            // tbCamIP
            // 
            this.tbCamIP.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbCamIP.Location = new System.Drawing.Point(112, 175);
            this.tbCamIP.Name = "tbCamIP";
            this.tbCamIP.Size = new System.Drawing.Size(169, 21);
            this.tbCamIP.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbRegisterName);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.btnMapLoad);
            this.groupBox1.Controls.Add(this.pbmap);
            this.groupBox1.Controls.Add(this.btnAGVRegist);
            this.groupBox1.Controls.Add(this.tbAGVName);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.tbCamPort);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbCamIP);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.tbAGVPort);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbAGVIP);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Gulim", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(8, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1003, 351);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "AGV 등록";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(337, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 12);
            this.label2.TabIndex = 29;
            this.label2.Text = "Map";
            // 
            // pbmap
            // 
            this.pbmap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbmap.Location = new System.Drawing.Point(389, 34);
            this.pbmap.Name = "pbmap";
            this.pbmap.Size = new System.Drawing.Size(338, 308);
            this.pbmap.TabIndex = 26;
            this.pbmap.TabStop = false;
            // 
            // aGVNameDataGridViewTextBoxColumn
            // 
            this.aGVNameDataGridViewTextBoxColumn.DataPropertyName = "AGVName";
            this.aGVNameDataGridViewTextBoxColumn.FillWeight = 70F;
            this.aGVNameDataGridViewTextBoxColumn.HeaderText = "AGVName";
            this.aGVNameDataGridViewTextBoxColumn.Name = "aGVNameDataGridViewTextBoxColumn";
            this.aGVNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // registerNameDataGridViewTextBoxColumn
            // 
            this.registerNameDataGridViewTextBoxColumn.DataPropertyName = "RegisterName";
            this.registerNameDataGridViewTextBoxColumn.HeaderText = "RegisterName";
            this.registerNameDataGridViewTextBoxColumn.Name = "registerNameDataGridViewTextBoxColumn";
            this.registerNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aGVIPDataGridViewTextBoxColumn
            // 
            this.aGVIPDataGridViewTextBoxColumn.DataPropertyName = "AGVIP";
            this.aGVIPDataGridViewTextBoxColumn.HeaderText = "AGVIP";
            this.aGVIPDataGridViewTextBoxColumn.Name = "aGVIPDataGridViewTextBoxColumn";
            this.aGVIPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aGVPortDataGridViewTextBoxColumn
            // 
            this.aGVPortDataGridViewTextBoxColumn.DataPropertyName = "AGVPort";
            this.aGVPortDataGridViewTextBoxColumn.FillWeight = 70F;
            this.aGVPortDataGridViewTextBoxColumn.HeaderText = "AGVPort";
            this.aGVPortDataGridViewTextBoxColumn.Name = "aGVPortDataGridViewTextBoxColumn";
            this.aGVPortDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // camIPDataGridViewTextBoxColumn
            // 
            this.camIPDataGridViewTextBoxColumn.DataPropertyName = "CamIP";
            this.camIPDataGridViewTextBoxColumn.HeaderText = "CamIP";
            this.camIPDataGridViewTextBoxColumn.Name = "camIPDataGridViewTextBoxColumn";
            this.camIPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // camPortDataGridViewTextBoxColumn
            // 
            this.camPortDataGridViewTextBoxColumn.DataPropertyName = "CamPort";
            this.camPortDataGridViewTextBoxColumn.FillWeight = 70F;
            this.camPortDataGridViewTextBoxColumn.HeaderText = "CamPort";
            this.camPortDataGridViewTextBoxColumn.Name = "camPortDataGridViewTextBoxColumn";
            this.camPortDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mapDataGridViewTextBoxColumn
            // 
            this.mapDataGridViewTextBoxColumn.DataPropertyName = "Map";
            this.mapDataGridViewTextBoxColumn.FillWeight = 210F;
            this.mapDataGridViewTextBoxColumn.HeaderText = "Map";
            this.mapDataGridViewTextBoxColumn.Name = "mapDataGridViewTextBoxColumn";
            this.mapDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bdsAGVList
            // 
            this.bdsAGVList.DataSource = typeof(AGV.AGVRegist);
            // 
            // RegistControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "RegistControl";
            this.Size = new System.Drawing.Size(1023, 761);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAGVList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbmap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsAGVList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tbRegisterName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnMapLoad;
        private System.Windows.Forms.PictureBox pbmap;
        private System.Windows.Forms.Button btnAGVRegist;
        private System.Windows.Forms.TextBox tbAGVName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbCamPort;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAGVConnect;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbAGVPort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbAGVIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCamIP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAGVDisconnect;
        private System.Windows.Forms.DataGridView dgvAGVList;
        private System.Windows.Forms.DataGridViewTextBoxColumn aGVNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aGVIPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aGVPortDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn camIPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn camPortDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mapDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bdsAGVList;
    }
}
