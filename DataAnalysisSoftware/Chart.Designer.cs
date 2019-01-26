namespace DataAnalysisSoftware
{
    partial class Chart
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
            this.components = new System.ComponentModel.Container();
            this.zrcHRMGraph = new ZedGraph.ZedGraphControl();
            this.lblPower = new System.Windows.Forms.Label();
            this.lblHeartRate = new System.Windows.Forms.Label();
            this.lblAltitude = new System.Windows.Forms.Label();
            this.lblCadence = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chkPower = new System.Windows.Forms.CheckBox();
            this.chkHeartRate = new System.Windows.Forms.CheckBox();
            this.chkAltitude = new System.Windows.Forms.CheckBox();
            this.chkCadence = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Speed = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chkSpeed = new System.Windows.Forms.CheckBox();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlSummary = new System.Windows.Forms.Panel();
            this.pnlHeader.SuspendLayout();
            this.pnlSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // zrcHRMGraph
            // 
            this.zrcHRMGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zrcHRMGraph.Location = new System.Drawing.Point(0, 44);
            this.zrcHRMGraph.Margin = new System.Windows.Forms.Padding(4);
            this.zrcHRMGraph.Name = "zrcHRMGraph";
            this.zrcHRMGraph.ScrollGrace = 0D;
            this.zrcHRMGraph.ScrollMaxX = 0D;
            this.zrcHRMGraph.ScrollMaxY = 0D;
            this.zrcHRMGraph.ScrollMaxY2 = 0D;
            this.zrcHRMGraph.ScrollMinX = 0D;
            this.zrcHRMGraph.ScrollMinY = 0D;
            this.zrcHRMGraph.ScrollMinY2 = 0D;
            this.zrcHRMGraph.Size = new System.Drawing.Size(962, 447);
            this.zrcHRMGraph.TabIndex = 5;
            this.zrcHRMGraph.UseExtendedPrintDialog = true;
            // 
            // lblPower
            // 
            this.lblPower.AutoSize = true;
            this.lblPower.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPower.Location = new System.Drawing.Point(109, 194);
            this.lblPower.Name = "lblPower";
            this.lblPower.Size = new System.Drawing.Size(0, 19);
            this.lblPower.TabIndex = 0;
            // 
            // lblHeartRate
            // 
            this.lblHeartRate.AutoSize = true;
            this.lblHeartRate.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeartRate.Location = new System.Drawing.Point(109, 164);
            this.lblHeartRate.Name = "lblHeartRate";
            this.lblHeartRate.Size = new System.Drawing.Size(0, 19);
            this.lblHeartRate.TabIndex = 0;
            // 
            // lblAltitude
            // 
            this.lblAltitude.AutoSize = true;
            this.lblAltitude.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltitude.Location = new System.Drawing.Point(109, 134);
            this.lblAltitude.Name = "lblAltitude";
            this.lblAltitude.Size = new System.Drawing.Size(0, 19);
            this.lblAltitude.TabIndex = 8;
            // 
            // lblCadence
            // 
            this.lblCadence.AutoSize = true;
            this.lblCadence.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadence.Location = new System.Drawing.Point(109, 104);
            this.lblCadence.Name = "lblCadence";
            this.lblCadence.Size = new System.Drawing.Size(0, 19);
            this.lblCadence.TabIndex = 0;
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpeed.Location = new System.Drawing.Point(109, 74);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(18, 19);
            this.lblSpeed.TabIndex = 0;
            this.lblSpeed.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Power:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Heart Rate:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Altitude";
            // 
            // chkPower
            // 
            this.chkPower.AutoSize = true;
            this.chkPower.Checked = true;
            this.chkPower.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPower.Location = new System.Drawing.Point(626, 10);
            this.chkPower.Name = "chkPower";
            this.chkPower.Size = new System.Drawing.Size(73, 23);
            this.chkPower.TabIndex = 4;
            this.chkPower.Text = "Power";
            this.chkPower.UseVisualStyleBackColor = true;
            this.chkPower.CheckedChanged += new System.EventHandler(this.chkPower_CheckedChanged);
            // 
            // chkHeartRate
            // 
            this.chkHeartRate.AutoSize = true;
            this.chkHeartRate.Checked = true;
            this.chkHeartRate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHeartRate.Location = new System.Drawing.Point(518, 10);
            this.chkHeartRate.Name = "chkHeartRate";
            this.chkHeartRate.Size = new System.Drawing.Size(102, 23);
            this.chkHeartRate.TabIndex = 3;
            this.chkHeartRate.Text = "Heart Rate";
            this.chkHeartRate.UseVisualStyleBackColor = true;
            this.chkHeartRate.CheckedChanged += new System.EventHandler(this.chkHeartRate_CheckedChanged);
            // 
            // chkAltitude
            // 
            this.chkAltitude.AutoSize = true;
            this.chkAltitude.Checked = true;
            this.chkAltitude.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAltitude.Location = new System.Drawing.Point(436, 10);
            this.chkAltitude.Name = "chkAltitude";
            this.chkAltitude.Size = new System.Drawing.Size(82, 23);
            this.chkAltitude.TabIndex = 2;
            this.chkAltitude.Text = "Altitude";
            this.chkAltitude.UseVisualStyleBackColor = true;
            this.chkAltitude.CheckedChanged += new System.EventHandler(this.chkAltitude_CheckedChanged);
            // 
            // chkCadence
            // 
            this.chkCadence.AutoSize = true;
            this.chkCadence.Checked = true;
            this.chkCadence.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCadence.Location = new System.Drawing.Point(344, 10);
            this.chkCadence.Name = "chkCadence";
            this.chkCadence.Size = new System.Drawing.Size(86, 23);
            this.chkCadence.TabIndex = 1;
            this.chkCadence.Text = "Cadence";
            this.chkCadence.UseVisualStyleBackColor = true;
            this.chkCadence.CheckedChanged += new System.EventHandler(this.chkCadence_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Candence:";
            // 
            // Speed
            // 
            this.Speed.AutoSize = true;
            this.Speed.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Speed.Location = new System.Drawing.Point(10, 74);
            this.Speed.Name = "Speed";
            this.Speed.Size = new System.Drawing.Size(57, 19);
            this.Speed.TabIndex = 0;
            this.Speed.Text = "Speed:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "SUMMARY";
            // 
            // chkSpeed
            // 
            this.chkSpeed.AutoSize = true;
            this.chkSpeed.Checked = true;
            this.chkSpeed.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSpeed.Location = new System.Drawing.Point(268, 10);
            this.chkSpeed.Name = "chkSpeed";
            this.chkSpeed.Size = new System.Drawing.Size(70, 23);
            this.chkSpeed.TabIndex = 0;
            this.chkSpeed.Text = "Speed";
            this.chkSpeed.UseVisualStyleBackColor = true;
            this.chkSpeed.CheckedChanged += new System.EventHandler(this.chkSpeed_CheckedChanged);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHeader.Controls.Add(this.chkPower);
            this.pnlHeader.Controls.Add(this.chkHeartRate);
            this.pnlHeader.Controls.Add(this.chkAltitude);
            this.pnlHeader.Controls.Add(this.chkCadence);
            this.pnlHeader.Controls.Add(this.chkSpeed);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(962, 44);
            this.pnlHeader.TabIndex = 4;
            // 
            // pnlSummary
            // 
            this.pnlSummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSummary.Controls.Add(this.lblPower);
            this.pnlSummary.Controls.Add(this.lblHeartRate);
            this.pnlSummary.Controls.Add(this.lblAltitude);
            this.pnlSummary.Controls.Add(this.lblCadence);
            this.pnlSummary.Controls.Add(this.lblSpeed);
            this.pnlSummary.Controls.Add(this.label6);
            this.pnlSummary.Controls.Add(this.label3);
            this.pnlSummary.Controls.Add(this.label4);
            this.pnlSummary.Controls.Add(this.label2);
            this.pnlSummary.Controls.Add(this.Speed);
            this.pnlSummary.Controls.Add(this.label1);
            this.pnlSummary.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSummary.Location = new System.Drawing.Point(962, 0);
            this.pnlSummary.Name = "pnlSummary";
            this.pnlSummary.Size = new System.Drawing.Size(200, 491);
            this.pnlSummary.TabIndex = 3;
            // 
            // Chart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1162, 491);
            this.Controls.Add(this.zrcHRMGraph);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlSummary);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Chart";
            this.Text = "Chart";
            this.Load += new System.EventHandler(this.Chart_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlSummary.ResumeLayout(false);
            this.pnlSummary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ZedGraph.ZedGraphControl zrcHRMGraph;
        private System.Windows.Forms.Label lblPower;
        private System.Windows.Forms.Label lblHeartRate;
        private System.Windows.Forms.Label lblAltitude;
        private System.Windows.Forms.Label lblCadence;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkPower;
        private System.Windows.Forms.CheckBox chkHeartRate;
        private System.Windows.Forms.CheckBox chkAltitude;
        private System.Windows.Forms.CheckBox chkCadence;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Speed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkSpeed;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlSummary;
    }
}