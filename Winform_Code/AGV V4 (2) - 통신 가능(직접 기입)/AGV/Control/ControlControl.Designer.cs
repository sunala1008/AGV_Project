namespace AGV.Control
{
    partial class ControlControl
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pbCam = new System.Windows.Forms.PictureBox();
            this.pbMap = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMap)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Location = new System.Drawing.Point(792, 585);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 168);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Image = global::AGV.Properties.Resources.go;
            this.button1.Location = new System.Drawing.Point(84, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 64);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Image = global::AGV.Properties.Resources.left;
            this.button2.Location = new System.Drawing.Point(14, 90);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 64);
            this.button2.TabIndex = 8;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Image = global::AGV.Properties.Resources.right;
            this.button3.Location = new System.Drawing.Point(154, 90);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(64, 64);
            this.button3.TabIndex = 9;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // pbCam
            // 
            this.pbCam.Image = global::AGV.Properties.Resources.warning;
            this.pbCam.Location = new System.Drawing.Point(3, 3);
            this.pbCam.Name = "pbCam";
            this.pbCam.Size = new System.Drawing.Size(648, 755);
            this.pbCam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbCam.TabIndex = 18;
            this.pbCam.TabStop = false;
            // 
            // pbMap
            // 
            this.pbMap.Image = global::AGV.Properties.Resources.warning;
            this.pbMap.Location = new System.Drawing.Point(657, 3);
            this.pbMap.Name = "pbMap";
            this.pbMap.Size = new System.Drawing.Size(363, 581);
            this.pbMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbMap.TabIndex = 17;
            this.pbMap.TabStop = false;
            // 
            // ControlControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pbCam);
            this.Controls.Add(this.pbMap);
            this.Controls.Add(this.groupBox1);
            this.Name = "ControlControl";
            this.Size = new System.Drawing.Size(1023, 761);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbCam;
        private System.Windows.Forms.PictureBox pbMap;
    }
}
