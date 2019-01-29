namespace DataAnalysisSoftware
{
    partial class IntervalDetection
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvIntervalInformation = new System.Windows.Forms.DataGridView();
            this.SNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Interval = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Power = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbIntervals = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblThresholdPower = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAveragePower = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIntervalInformation)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1162, 45);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(419, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "INTERVAL DETECTION";
            // 
            // dgvIntervalInformation
            // 
            this.dgvIntervalInformation.AllowUserToAddRows = false;
            this.dgvIntervalInformation.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvIntervalInformation.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvIntervalInformation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIntervalInformation.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIntervalInformation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvIntervalInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIntervalInformation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SNo,
            this.Interval,
            this.Power});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvIntervalInformation.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvIntervalInformation.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvIntervalInformation.Location = new System.Drawing.Point(842, 45);
            this.dgvIntervalInformation.Name = "dgvIntervalInformation";
            this.dgvIntervalInformation.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIntervalInformation.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvIntervalInformation.RowHeadersVisible = false;
            this.dgvIntervalInformation.Size = new System.Drawing.Size(320, 446);
            this.dgvIntervalInformation.TabIndex = 1;
            // 
            // SNo
            // 
            this.SNo.FillWeight = 50F;
            this.SNo.HeaderText = "SN";
            this.SNo.Name = "SNo";
            this.SNo.ReadOnly = true;
            // 
            // Interval
            // 
            this.Interval.HeaderText = "Interval";
            this.Interval.Name = "Interval";
            this.Interval.ReadOnly = true;
            // 
            // Power
            // 
            this.Power.HeaderText = "Power";
            this.Power.Name = "Power";
            this.Power.ReadOnly = true;
            // 
            // lbIntervals
            // 
            this.lbIntervals.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbIntervals.FormattingEnabled = true;
            this.lbIntervals.ItemHeight = 19;
            this.lbIntervals.Location = new System.Drawing.Point(552, 45);
            this.lbIntervals.Name = "lbIntervals";
            this.lbIntervals.Size = new System.Drawing.Size(290, 446);
            this.lbIntervals.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Threshold Power:";
            // 
            // lblThresholdPower
            // 
            this.lblThresholdPower.AutoSize = true;
            this.lblThresholdPower.Location = new System.Drawing.Point(325, 141);
            this.lblThresholdPower.Name = "lblThresholdPower";
            this.lblThresholdPower.Size = new System.Drawing.Size(18, 19);
            this.lblThresholdPower.TabIndex = 4;
            this.lblThresholdPower.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Average Power:";
            // 
            // lblAveragePower
            // 
            this.lblAveragePower.AutoSize = true;
            this.lblAveragePower.Location = new System.Drawing.Point(325, 176);
            this.lblAveragePower.Name = "lblAveragePower";
            this.lblAveragePower.Size = new System.Drawing.Size(18, 19);
            this.lblAveragePower.TabIndex = 4;
            this.lblAveragePower.Text = "0";
            // 
            // IntervalDetection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1162, 491);
            this.Controls.Add(this.lblAveragePower);
            this.Controls.Add(this.lblThresholdPower);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbIntervals);
            this.Controls.Add(this.dgvIntervalInformation);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "IntervalDetection";
            this.Text = "IntervalDetection";
            this.Load += new System.EventHandler(this.IntervalDetection_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIntervalInformation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvIntervalInformation;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Interval;
        private System.Windows.Forms.DataGridViewTextBoxColumn Power;
        private System.Windows.Forms.ListBox lbIntervals;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblThresholdPower;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAveragePower;
    }
}