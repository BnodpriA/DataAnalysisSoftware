namespace DataAnalysisSoftware
{
    partial class SelectDataToCompare
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
            this.btnFileOne = new System.Windows.Forms.Button();
            this.btnUploadSecondFile = new System.Windows.Forms.Button();
            this.btnCompare = new System.Windows.Forms.Button();
            this.lblFileOne = new System.Windows.Forms.Label();
            this.lblFileTwo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFileOne
            // 
            this.btnFileOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFileOne.Location = new System.Drawing.Point(499, 112);
            this.btnFileOne.Name = "btnFileOne";
            this.btnFileOne.Size = new System.Drawing.Size(136, 40);
            this.btnFileOne.TabIndex = 0;
            this.btnFileOne.Text = "Upload File One";
            this.btnFileOne.UseVisualStyleBackColor = true;
            this.btnFileOne.Click += new System.EventHandler(this.btnFileOne_Click);
            // 
            // btnUploadSecondFile
            // 
            this.btnUploadSecondFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadSecondFile.Location = new System.Drawing.Point(499, 209);
            this.btnUploadSecondFile.Name = "btnUploadSecondFile";
            this.btnUploadSecondFile.Size = new System.Drawing.Size(136, 40);
            this.btnUploadSecondFile.TabIndex = 1;
            this.btnUploadSecondFile.Text = "Upload File Two";
            this.btnUploadSecondFile.UseVisualStyleBackColor = true;
            this.btnUploadSecondFile.Click += new System.EventHandler(this.btnUploadSecondFile_Click);
            // 
            // btnCompare
            // 
            this.btnCompare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompare.Location = new System.Drawing.Point(499, 306);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(136, 40);
            this.btnCompare.TabIndex = 2;
            this.btnCompare.Text = "Compare";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // lblFileOne
            // 
            this.lblFileOne.AutoSize = true;
            this.lblFileOne.Location = new System.Drawing.Point(499, 171);
            this.lblFileOne.Name = "lblFileOne";
            this.lblFileOne.Size = new System.Drawing.Size(65, 19);
            this.lblFileOne.TabIndex = 3;
            this.lblFileOne.Text = "File One";
            // 
            // lblFileTwo
            // 
            this.lblFileTwo.AutoSize = true;
            this.lblFileTwo.Location = new System.Drawing.Point(499, 268);
            this.lblFileTwo.Name = "lblFileTwo";
            this.lblFileTwo.Size = new System.Drawing.Size(68, 19);
            this.lblFileTwo.TabIndex = 4;
            this.lblFileTwo.Text = "File Two";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1162, 45);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(422, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "SELECT DATA TO COMPARE";
            // 
            // SelectDataToCompare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1162, 491);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblFileTwo);
            this.Controls.Add(this.lblFileOne);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.btnUploadSecondFile);
            this.Controls.Add(this.btnFileOne);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SelectDataToCompare";
            this.Text = "SelectDataToCompare";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFileOne;
        private System.Windows.Forms.Button btnUploadSecondFile;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.Label lblFileOne;
        private System.Windows.Forms.Label lblFileTwo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}