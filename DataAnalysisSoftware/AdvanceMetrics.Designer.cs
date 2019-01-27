namespace DataAnalysisSoftware
{
    partial class AdvanceMetrics
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPowerBalance = new System.Windows.Forms.Label();
            this.lblMovingPower = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNormalizedPower = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTrainingStress = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblntensityFactor = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1162, 52);
            this.pnlHeader.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(452, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADVANCE MATRIX CALCULATION";
            // 
            // lblPowerBalance
            // 
            this.lblPowerBalance.AutoSize = true;
            this.lblPowerBalance.Location = new System.Drawing.Point(421, 136);
            this.lblPowerBalance.Name = "lblPowerBalance";
            this.lblPowerBalance.Size = new System.Drawing.Size(116, 19);
            this.lblPowerBalance.TabIndex = 1;
            this.lblPowerBalance.Text = "Power Balance:";
            // 
            // lblMovingPower
            // 
            this.lblMovingPower.AutoSize = true;
            this.lblMovingPower.Location = new System.Drawing.Point(681, 136);
            this.lblMovingPower.Name = "lblMovingPower";
            this.lblMovingPower.Size = new System.Drawing.Size(18, 19);
            this.lblMovingPower.TabIndex = 2;
            this.lblMovingPower.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(421, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Normalized Power:";
            // 
            // lblNormalizedPower
            // 
            this.lblNormalizedPower.AutoSize = true;
            this.lblNormalizedPower.Location = new System.Drawing.Point(681, 171);
            this.lblNormalizedPower.Name = "lblNormalizedPower";
            this.lblNormalizedPower.Size = new System.Drawing.Size(18, 19);
            this.lblNormalizedPower.TabIndex = 2;
            this.lblNormalizedPower.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(421, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Training Stress Score (TSS):";
            // 
            // lblTrainingStress
            // 
            this.lblTrainingStress.AutoSize = true;
            this.lblTrainingStress.Location = new System.Drawing.Point(681, 206);
            this.lblTrainingStress.Name = "lblTrainingStress";
            this.lblTrainingStress.Size = new System.Drawing.Size(18, 19);
            this.lblTrainingStress.TabIndex = 2;
            this.lblTrainingStress.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(421, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "Intensity Factor (IF):";
            // 
            // lblntensityFactor
            // 
            this.lblntensityFactor.AutoSize = true;
            this.lblntensityFactor.Location = new System.Drawing.Point(681, 239);
            this.lblntensityFactor.Name = "lblntensityFactor";
            this.lblntensityFactor.Size = new System.Drawing.Size(18, 19);
            this.lblntensityFactor.TabIndex = 2;
            this.lblntensityFactor.Text = "0";
            // 
            // AdvanceMetrics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1162, 491);
            this.Controls.Add(this.lblntensityFactor);
            this.Controls.Add(this.lblTrainingStress);
            this.Controls.Add(this.lblNormalizedPower);
            this.Controls.Add(this.lblMovingPower);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPowerBalance);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdvanceMetrics";
            this.Text = "AdvanceMetrics";
            this.Load += new System.EventHandler(this.AdvanceMetrics_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPowerBalance;
        private System.Windows.Forms.Label lblMovingPower;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNormalizedPower;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTrainingStress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblntensityFactor;
    }
}