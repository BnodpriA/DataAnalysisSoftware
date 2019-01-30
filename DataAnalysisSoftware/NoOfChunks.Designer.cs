namespace DataAnalysisSoftware
{
    partial class NoOfChunks
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbNoOfChunks = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "SELECT NUMBER OF CHUNKS\r\nYOU WANTED TO SPLIT THE\r\nSELECTED DATA";
            // 
            // cmbNoOfChunks
            // 
            this.cmbNoOfChunks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNoOfChunks.FormattingEnabled = true;
            this.cmbNoOfChunks.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmbNoOfChunks.Location = new System.Drawing.Point(211, 97);
            this.cmbNoOfChunks.Name = "cmbNoOfChunks";
            this.cmbNoOfChunks.Size = new System.Drawing.Size(98, 27);
            this.cmbNoOfChunks.TabIndex = 1;
            this.cmbNoOfChunks.SelectedIndexChanged += new System.EventHandler(this.cmbNoOfChunks_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "No. of Chunks:";
            // 
            // btnOK
            // 
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Location = new System.Drawing.Point(172, 159);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 34);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "Ok";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // NoOfChunks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(421, 231);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbNoOfChunks);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NoOfChunks";
            this.Text = "NoOfChunks";
            this.Load += new System.EventHandler(this.NoOfChunks_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cmbNoOfChunks;
        private System.Windows.Forms.Button btnOK;
    }
}