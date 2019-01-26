namespace DataAnalysisSoftware
{
    partial class FileComparison
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbFileComparison = new System.Windows.Forms.TabControl();
            this.tbpComparisionfTwoFiles = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gbDataOfFirstFile = new System.Windows.Forms.GroupBox();
            this.gbDataOfSecondFile = new System.Windows.Forms.GroupBox();
            this.gbSummaryOfFirstFile = new System.Windows.Forms.GroupBox();
            this.gbSummaryOfSecondFile = new System.Windows.Forms.GroupBox();
            this.dgvHRMDataOfSecondFile = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHRMDataOfFirstFile = new System.Windows.Forms.DataGridView();
            this.SNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeartRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Speed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cadence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Altitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Power = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbFileComparison.SuspendLayout();
            this.tbpComparisionfTwoFiles.SuspendLayout();
            this.gbDataOfFirstFile.SuspendLayout();
            this.gbDataOfSecondFile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHRMDataOfSecondFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHRMDataOfFirstFile)).BeginInit();
            this.SuspendLayout();
            // 
            // tbFileComparison
            // 
            this.tbFileComparison.Controls.Add(this.tbpComparisionfTwoFiles);
            this.tbFileComparison.Controls.Add(this.tabPage2);
            this.tbFileComparison.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbFileComparison.Location = new System.Drawing.Point(0, 0);
            this.tbFileComparison.Name = "tbFileComparison";
            this.tbFileComparison.SelectedIndex = 0;
            this.tbFileComparison.Size = new System.Drawing.Size(1162, 491);
            this.tbFileComparison.TabIndex = 0;
            // 
            // tbpComparisionfTwoFiles
            // 
            this.tbpComparisionfTwoFiles.Controls.Add(this.gbDataOfSecondFile);
            this.tbpComparisionfTwoFiles.Controls.Add(this.gbDataOfFirstFile);
            this.tbpComparisionfTwoFiles.Location = new System.Drawing.Point(4, 28);
            this.tbpComparisionfTwoFiles.Name = "tbpComparisionfTwoFiles";
            this.tbpComparisionfTwoFiles.Padding = new System.Windows.Forms.Padding(3);
            this.tbpComparisionfTwoFiles.Size = new System.Drawing.Size(1154, 459);
            this.tbpComparisionfTwoFiles.TabIndex = 0;
            this.tbpComparisionfTwoFiles.Text = "Data Comparison";
            this.tbpComparisionfTwoFiles.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1154, 459);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gbDataOfFirstFile
            // 
            this.gbDataOfFirstFile.Controls.Add(this.dgvHRMDataOfFirstFile);
            this.gbDataOfFirstFile.Controls.Add(this.gbSummaryOfFirstFile);
            this.gbDataOfFirstFile.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbDataOfFirstFile.Location = new System.Drawing.Point(3, 3);
            this.gbDataOfFirstFile.Name = "gbDataOfFirstFile";
            this.gbDataOfFirstFile.Size = new System.Drawing.Size(545, 453);
            this.gbDataOfFirstFile.TabIndex = 0;
            this.gbDataOfFirstFile.TabStop = false;
            this.gbDataOfFirstFile.Text = "Data of First File";
            // 
            // gbDataOfSecondFile
            // 
            this.gbDataOfSecondFile.Controls.Add(this.dgvHRMDataOfSecondFile);
            this.gbDataOfSecondFile.Controls.Add(this.gbSummaryOfSecondFile);
            this.gbDataOfSecondFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDataOfSecondFile.Location = new System.Drawing.Point(548, 3);
            this.gbDataOfSecondFile.Name = "gbDataOfSecondFile";
            this.gbDataOfSecondFile.Size = new System.Drawing.Size(603, 453);
            this.gbDataOfSecondFile.TabIndex = 1;
            this.gbDataOfSecondFile.TabStop = false;
            this.gbDataOfSecondFile.Text = "Data of Second File";
            // 
            // gbSummaryOfFirstFile
            // 
            this.gbSummaryOfFirstFile.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbSummaryOfFirstFile.Location = new System.Drawing.Point(3, 318);
            this.gbSummaryOfFirstFile.Name = "gbSummaryOfFirstFile";
            this.gbSummaryOfFirstFile.Size = new System.Drawing.Size(539, 132);
            this.gbSummaryOfFirstFile.TabIndex = 4;
            this.gbSummaryOfFirstFile.TabStop = false;
            this.gbSummaryOfFirstFile.Text = "Summary of First File";
            // 
            // gbSummaryOfSecondFile
            // 
            this.gbSummaryOfSecondFile.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbSummaryOfSecondFile.Location = new System.Drawing.Point(3, 318);
            this.gbSummaryOfSecondFile.Name = "gbSummaryOfSecondFile";
            this.gbSummaryOfSecondFile.Size = new System.Drawing.Size(597, 132);
            this.gbSummaryOfSecondFile.TabIndex = 5;
            this.gbSummaryOfSecondFile.TabStop = false;
            this.gbSummaryOfSecondFile.Text = "Summary of Second File";
            // 
            // dgvHRMDataOfSecondFile
            // 
            this.dgvHRMDataOfSecondFile.AllowUserToAddRows = false;
            this.dgvHRMDataOfSecondFile.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvHRMDataOfSecondFile.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHRMDataOfSecondFile.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHRMDataOfSecondFile.BackgroundColor = System.Drawing.Color.White;
            this.dgvHRMDataOfSecondFile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHRMDataOfSecondFile.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dgvHRMDataOfSecondFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHRMDataOfSecondFile.Location = new System.Drawing.Point(3, 22);
            this.dgvHRMDataOfSecondFile.Name = "dgvHRMDataOfSecondFile";
            this.dgvHRMDataOfSecondFile.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHRMDataOfSecondFile.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHRMDataOfSecondFile.RowHeadersVisible = false;
            this.dgvHRMDataOfSecondFile.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvHRMDataOfSecondFile.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHRMDataOfSecondFile.Size = new System.Drawing.Size(597, 296);
            this.dgvHRMDataOfSecondFile.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 40F;
            this.dataGridViewTextBoxColumn1.HeaderText = "S.N.";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Heart Rate (bpm)";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.FillWeight = 60F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Speed";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Cadence (rpm)";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Altitude (m/ft)";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.FillWeight = 90F;
            this.dataGridViewTextBoxColumn6.HeaderText = "Power (watt)";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dgvHRMDataOfFirstFile
            // 
            this.dgvHRMDataOfFirstFile.AllowUserToAddRows = false;
            this.dgvHRMDataOfFirstFile.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvHRMDataOfFirstFile.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHRMDataOfFirstFile.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHRMDataOfFirstFile.BackgroundColor = System.Drawing.Color.White;
            this.dgvHRMDataOfFirstFile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHRMDataOfFirstFile.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SNo,
            this.HeartRate,
            this.Speed,
            this.Cadence,
            this.Altitude,
            this.Power});
            this.dgvHRMDataOfFirstFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHRMDataOfFirstFile.Location = new System.Drawing.Point(3, 22);
            this.dgvHRMDataOfFirstFile.Name = "dgvHRMDataOfFirstFile";
            this.dgvHRMDataOfFirstFile.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHRMDataOfFirstFile.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvHRMDataOfFirstFile.RowHeadersVisible = false;
            this.dgvHRMDataOfFirstFile.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvHRMDataOfFirstFile.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHRMDataOfFirstFile.Size = new System.Drawing.Size(539, 296);
            this.dgvHRMDataOfFirstFile.TabIndex = 5;
            // 
            // SNo
            // 
            this.SNo.FillWeight = 40F;
            this.SNo.HeaderText = "S.N.";
            this.SNo.Name = "SNo";
            this.SNo.ReadOnly = true;
            // 
            // HeartRate
            // 
            this.HeartRate.HeaderText = "Heart Rate (bpm)";
            this.HeartRate.Name = "HeartRate";
            this.HeartRate.ReadOnly = true;
            // 
            // Speed
            // 
            this.Speed.FillWeight = 60F;
            this.Speed.HeaderText = "Speed";
            this.Speed.Name = "Speed";
            this.Speed.ReadOnly = true;
            // 
            // Cadence
            // 
            this.Cadence.HeaderText = "Cadence (rpm)";
            this.Cadence.Name = "Cadence";
            this.Cadence.ReadOnly = true;
            // 
            // Altitude
            // 
            this.Altitude.HeaderText = "Altitude (m/ft)";
            this.Altitude.Name = "Altitude";
            this.Altitude.ReadOnly = true;
            // 
            // Power
            // 
            this.Power.FillWeight = 90F;
            this.Power.HeaderText = "Power (watt)";
            this.Power.Name = "Power";
            this.Power.ReadOnly = true;
            // 
            // FileComparison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1162, 491);
            this.Controls.Add(this.tbFileComparison);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FileComparison";
            this.Text = "FileComparison";
            this.tbFileComparison.ResumeLayout(false);
            this.tbpComparisionfTwoFiles.ResumeLayout(false);
            this.gbDataOfFirstFile.ResumeLayout(false);
            this.gbDataOfSecondFile.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHRMDataOfSecondFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHRMDataOfFirstFile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbFileComparison;
        private System.Windows.Forms.TabPage tbpComparisionfTwoFiles;
        private System.Windows.Forms.GroupBox gbDataOfSecondFile;
        private System.Windows.Forms.GroupBox gbDataOfFirstFile;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox gbSummaryOfSecondFile;
        private System.Windows.Forms.GroupBox gbSummaryOfFirstFile;
        public System.Windows.Forms.DataGridView dgvHRMDataOfSecondFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        public System.Windows.Forms.DataGridView dgvHRMDataOfFirstFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeartRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Speed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cadence;
        private System.Windows.Forms.DataGridViewTextBoxColumn Altitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn Power;
    }
}