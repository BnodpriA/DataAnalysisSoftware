namespace DataAnalysisSoftware
{
    partial class DataSummary
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.label34 = new System.Windows.Forms.Label();
            this.pnlDataSummary = new System.Windows.Forms.Panel();
            this.gbDataSummary = new System.Windows.Forms.GroupBox();
            this.label23 = new System.Windows.Forms.Label();
            this.cmbSpeedUnit = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblMinSpeed = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblAvgSpeed = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblMaxSpeed = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbParameterInfo = new System.Windows.Forms.GroupBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.lblMonitorType = new System.Windows.Forms.Label();
            this.dgvHRMData = new System.Windows.Forms.DataGridView();
            this.SNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Speed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cadence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Altitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeartRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Power = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDeviceVersion = new System.Windows.Forms.Label();
            this.lblSMode = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.lblInterval = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblMaxHR = new System.Windows.Forms.Label();
            this.lblRestHR = new System.Windows.Forms.Label();
            this.lblVO2max = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlDataSummary.SuspendLayout();
            this.gbDataSummary.SuspendLayout();
            this.gbParameterInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHRMData)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHeader.Controls.Add(this.label34);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1162, 61);
            this.pnlHeader.TabIndex = 0;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(437, 21);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(259, 22);
            this.label34.TabIndex = 1;
            this.label34.Text = "POLAR HRM DATA SUMMARY";
            // 
            // pnlDataSummary
            // 
            this.pnlDataSummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDataSummary.Controls.Add(this.gbDataSummary);
            this.pnlDataSummary.Controls.Add(this.gbParameterInfo);
            this.pnlDataSummary.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlDataSummary.Location = new System.Drawing.Point(746, 61);
            this.pnlDataSummary.Name = "pnlDataSummary";
            this.pnlDataSummary.Size = new System.Drawing.Size(416, 430);
            this.pnlDataSummary.TabIndex = 1;
            // 
            // gbDataSummary
            // 
            this.gbDataSummary.Controls.Add(this.label23);
            this.gbDataSummary.Controls.Add(this.cmbSpeedUnit);
            this.gbDataSummary.Controls.Add(this.label22);
            this.gbDataSummary.Controls.Add(this.label21);
            this.gbDataSummary.Controls.Add(this.label20);
            this.gbDataSummary.Controls.Add(this.label16);
            this.gbDataSummary.Controls.Add(this.label12);
            this.gbDataSummary.Controls.Add(this.label8);
            this.gbDataSummary.Controls.Add(this.lblMinSpeed);
            this.gbDataSummary.Controls.Add(this.label4);
            this.gbDataSummary.Controls.Add(this.label19);
            this.gbDataSummary.Controls.Add(this.label15);
            this.gbDataSummary.Controls.Add(this.label11);
            this.gbDataSummary.Controls.Add(this.label7);
            this.gbDataSummary.Controls.Add(this.lblAvgSpeed);
            this.gbDataSummary.Controls.Add(this.label3);
            this.gbDataSummary.Controls.Add(this.label18);
            this.gbDataSummary.Controls.Add(this.label14);
            this.gbDataSummary.Controls.Add(this.label10);
            this.gbDataSummary.Controls.Add(this.label6);
            this.gbDataSummary.Controls.Add(this.lblMaxSpeed);
            this.gbDataSummary.Controls.Add(this.label2);
            this.gbDataSummary.Controls.Add(this.label17);
            this.gbDataSummary.Controls.Add(this.label13);
            this.gbDataSummary.Controls.Add(this.label9);
            this.gbDataSummary.Controls.Add(this.label5);
            this.gbDataSummary.Controls.Add(this.label1);
            this.gbDataSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDataSummary.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDataSummary.Location = new System.Drawing.Point(0, 198);
            this.gbDataSummary.Name = "gbDataSummary";
            this.gbDataSummary.Size = new System.Drawing.Size(414, 230);
            this.gbDataSummary.TabIndex = 1;
            this.gbDataSummary.TabStop = false;
            this.gbDataSummary.Text = "SUMMARY";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(145, 64);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(13, 19);
            this.label23.TabIndex = 0;
            this.label23.Text = ":";
            // 
            // cmbSpeedUnit
            // 
            this.cmbSpeedUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSpeedUnit.FormattingEnabled = true;
            this.cmbSpeedUnit.Items.AddRange(new object[] {
            "km/h",
            "mph"});
            this.cmbSpeedUnit.Location = new System.Drawing.Point(73, 60);
            this.cmbSpeedUnit.Name = "cmbSpeedUnit";
            this.cmbSpeedUnit.Size = new System.Drawing.Size(70, 27);
            this.cmbSpeedUnit.TabIndex = 5;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(11, 208);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(399, 19);
            this.label22.TabIndex = 4;
            this.label22.Text = "------------------------------------------------------------------------------";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(11, 45);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(399, 19);
            this.label21.TabIndex = 0;
            this.label21.Text = "------------------------------------------------------------------------------";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(357, 184);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(18, 19);
            this.label20.TabIndex = 3;
            this.label20.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(357, 154);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(18, 19);
            this.label16.TabIndex = 3;
            this.label16.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(357, 124);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(18, 19);
            this.label12.TabIndex = 3;
            this.label12.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(357, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 19);
            this.label8.TabIndex = 3;
            this.label8.Text = "0";
            // 
            // lblMinSpeed
            // 
            this.lblMinSpeed.AutoSize = true;
            this.lblMinSpeed.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinSpeed.Location = new System.Drawing.Point(357, 64);
            this.lblMinSpeed.Name = "lblMinSpeed";
            this.lblMinSpeed.Size = new System.Drawing.Size(18, 19);
            this.lblMinSpeed.TabIndex = 3;
            this.lblMinSpeed.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(324, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Minimum";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(272, 184);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(18, 19);
            this.label19.TabIndex = 2;
            this.label19.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(272, 154);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(18, 19);
            this.label15.TabIndex = 2;
            this.label15.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(272, 124);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 19);
            this.label11.TabIndex = 2;
            this.label11.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(272, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 19);
            this.label7.TabIndex = 2;
            this.label7.Text = "0";
            // 
            // lblAvgSpeed
            // 
            this.lblAvgSpeed.AutoSize = true;
            this.lblAvgSpeed.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvgSpeed.Location = new System.Drawing.Point(272, 64);
            this.lblAvgSpeed.Name = "lblAvgSpeed";
            this.lblAvgSpeed.Size = new System.Drawing.Size(18, 19);
            this.lblAvgSpeed.TabIndex = 2;
            this.lblAvgSpeed.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Average";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(187, 184);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(18, 19);
            this.label18.TabIndex = 0;
            this.label18.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(187, 154);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(18, 19);
            this.label14.TabIndex = 0;
            this.label14.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(187, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 19);
            this.label10.TabIndex = 0;
            this.label10.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(187, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "0";
            // 
            // lblMaxSpeed
            // 
            this.lblMaxSpeed.AutoSize = true;
            this.lblMaxSpeed.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxSpeed.Location = new System.Drawing.Point(187, 64);
            this.lblMaxSpeed.Name = "lblMaxSpeed";
            this.lblMaxSpeed.Size = new System.Drawing.Size(18, 19);
            this.lblMaxSpeed.TabIndex = 0;
            this.lblMaxSpeed.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Maximum";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(19, 184);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(112, 19);
            this.label17.TabIndex = 0;
            this.label17.Text = "Power (watt):";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 154);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(144, 19);
            this.label13.TabIndex = 0;
            this.label13.Text = "Heart Rate (bpm):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "Altitude (m/ft):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Cadence (rpm):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Speed";
            // 
            // gbParameterInfo
            // 
            this.gbParameterInfo.Controls.Add(this.label29);
            this.gbParameterInfo.Controls.Add(this.label30);
            this.gbParameterInfo.Controls.Add(this.label31);
            this.gbParameterInfo.Controls.Add(this.label32);
            this.gbParameterInfo.Controls.Add(this.label33);
            this.gbParameterInfo.Controls.Add(this.lblWeight);
            this.gbParameterInfo.Controls.Add(this.lblInterval);
            this.gbParameterInfo.Controls.Add(this.label24);
            this.gbParameterInfo.Controls.Add(this.lblVO2max);
            this.gbParameterInfo.Controls.Add(this.lblStartTime);
            this.gbParameterInfo.Controls.Add(this.label25);
            this.gbParameterInfo.Controls.Add(this.lblRestHR);
            this.gbParameterInfo.Controls.Add(this.lblDate);
            this.gbParameterInfo.Controls.Add(this.label26);
            this.gbParameterInfo.Controls.Add(this.lblMaxHR);
            this.gbParameterInfo.Controls.Add(this.lblSMode);
            this.gbParameterInfo.Controls.Add(this.label27);
            this.gbParameterInfo.Controls.Add(this.lblLength);
            this.gbParameterInfo.Controls.Add(this.lblDeviceVersion);
            this.gbParameterInfo.Controls.Add(this.label28);
            this.gbParameterInfo.Controls.Add(this.lblMonitorType);
            this.gbParameterInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbParameterInfo.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbParameterInfo.Location = new System.Drawing.Point(0, 0);
            this.gbParameterInfo.Name = "gbParameterInfo";
            this.gbParameterInfo.Size = new System.Drawing.Size(414, 198);
            this.gbParameterInfo.TabIndex = 0;
            this.gbParameterInfo.TabStop = false;
            this.gbParameterInfo.Text = "GENERAL PARAMETERS";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(210, 172);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(64, 19);
            this.label29.TabIndex = 6;
            this.label29.Text = "Weight:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(210, 142);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(73, 19);
            this.label30.TabIndex = 7;
            this.label30.Text = "VO2max:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(210, 112);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(72, 19);
            this.label31.TabIndex = 8;
            this.label31.Text = "Rest HR:";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(210, 82);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(71, 19);
            this.label32.TabIndex = 9;
            this.label32.Text = "Max HR:";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(210, 52);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(64, 19);
            this.label33.TabIndex = 10;
            this.label33.Text = "Length:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(19, 172);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(72, 19);
            this.label24.TabIndex = 1;
            this.label24.Text = "Interval:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(19, 142);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(90, 19);
            this.label25.TabIndex = 2;
            this.label25.Text = "Start Time:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(19, 112);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(47, 19);
            this.label26.TabIndex = 3;
            this.label26.Text = "Date:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(19, 82);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(62, 19);
            this.label27.TabIndex = 4;
            this.label27.Text = "SMode:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(19, 52);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(120, 19);
            this.label28.TabIndex = 5;
            this.label28.Text = "Device Version:";
            // 
            // lblMonitorType
            // 
            this.lblMonitorType.AutoSize = true;
            this.lblMonitorType.Location = new System.Drawing.Point(73, 22);
            this.lblMonitorType.Name = "lblMonitorType";
            this.lblMonitorType.Size = new System.Drawing.Size(224, 19);
            this.lblMonitorType.TabIndex = 0;
            this.lblMonitorType.Text = "HEART RATE MONITOR TYPE";
            // 
            // dgvHRMData
            // 
            this.dgvHRMData.AllowUserToAddRows = false;
            this.dgvHRMData.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvHRMData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHRMData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHRMData.BackgroundColor = System.Drawing.Color.White;
            this.dgvHRMData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHRMData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SNo,
            this.Speed,
            this.Cadence,
            this.Altitude,
            this.HeartRate,
            this.Power});
            this.dgvHRMData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHRMData.Location = new System.Drawing.Point(0, 61);
            this.dgvHRMData.Name = "dgvHRMData";
            this.dgvHRMData.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHRMData.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHRMData.RowHeadersVisible = false;
            this.dgvHRMData.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvHRMData.Size = new System.Drawing.Size(746, 430);
            this.dgvHRMData.TabIndex = 2;
            // 
            // SNo
            // 
            this.SNo.FillWeight = 30F;
            this.SNo.HeaderText = "S.N.";
            this.SNo.Name = "SNo";
            this.SNo.ReadOnly = true;
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
            // HeartRate
            // 
            this.HeartRate.HeaderText = "Heart Rate (bpm)";
            this.HeartRate.Name = "HeartRate";
            this.HeartRate.ReadOnly = true;
            // 
            // Power
            // 
            this.Power.FillWeight = 90F;
            this.Power.HeaderText = "Power (watt)";
            this.Power.Name = "Power";
            this.Power.ReadOnly = true;
            // 
            // lblDeviceVersion
            // 
            this.lblDeviceVersion.AutoSize = true;
            this.lblDeviceVersion.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeviceVersion.Location = new System.Drawing.Point(145, 52);
            this.lblDeviceVersion.Name = "lblDeviceVersion";
            this.lblDeviceVersion.Size = new System.Drawing.Size(18, 19);
            this.lblDeviceVersion.TabIndex = 5;
            this.lblDeviceVersion.Text = "0";
            // 
            // lblSMode
            // 
            this.lblSMode.AutoSize = true;
            this.lblSMode.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSMode.Location = new System.Drawing.Point(82, 82);
            this.lblSMode.Name = "lblSMode";
            this.lblSMode.Size = new System.Drawing.Size(18, 19);
            this.lblSMode.TabIndex = 4;
            this.lblSMode.Text = "0";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(67, 112);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(18, 19);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "0";
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartTime.Location = new System.Drawing.Point(110, 142);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(18, 19);
            this.lblStartTime.TabIndex = 2;
            this.lblStartTime.Text = "0";
            // 
            // lblInterval
            // 
            this.lblInterval.AutoSize = true;
            this.lblInterval.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterval.Location = new System.Drawing.Point(90, 172);
            this.lblInterval.Name = "lblInterval";
            this.lblInterval.Size = new System.Drawing.Size(18, 19);
            this.lblInterval.TabIndex = 1;
            this.lblInterval.Text = "0";
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLength.Location = new System.Drawing.Point(285, 52);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(18, 19);
            this.lblLength.TabIndex = 0;
            this.lblLength.Text = "0";
            // 
            // lblMaxHR
            // 
            this.lblMaxHR.AutoSize = true;
            this.lblMaxHR.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxHR.Location = new System.Drawing.Point(285, 82);
            this.lblMaxHR.Name = "lblMaxHR";
            this.lblMaxHR.Size = new System.Drawing.Size(18, 19);
            this.lblMaxHR.TabIndex = 4;
            this.lblMaxHR.Text = "0";
            // 
            // lblRestHR
            // 
            this.lblRestHR.AutoSize = true;
            this.lblRestHR.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestHR.Location = new System.Drawing.Point(285, 112);
            this.lblRestHR.Name = "lblRestHR";
            this.lblRestHR.Size = new System.Drawing.Size(18, 19);
            this.lblRestHR.TabIndex = 3;
            this.lblRestHR.Text = "0";
            // 
            // lblVO2max
            // 
            this.lblVO2max.AutoSize = true;
            this.lblVO2max.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVO2max.Location = new System.Drawing.Point(285, 142);
            this.lblVO2max.Name = "lblVO2max";
            this.lblVO2max.Size = new System.Drawing.Size(18, 19);
            this.lblVO2max.TabIndex = 2;
            this.lblVO2max.Text = "0";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.Location = new System.Drawing.Point(285, 172);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(18, 19);
            this.lblWeight.TabIndex = 1;
            this.lblWeight.Text = "0";
            // 
            // DataSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1162, 491);
            this.Controls.Add(this.dgvHRMData);
            this.Controls.Add(this.pnlDataSummary);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DataSummary";
            this.Text = "DataSummary";
            this.Load += new System.EventHandler(this.DataSummary_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlDataSummary.ResumeLayout(false);
            this.gbDataSummary.ResumeLayout(false);
            this.gbDataSummary.PerformLayout();
            this.gbParameterInfo.ResumeLayout(false);
            this.gbParameterInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHRMData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlDataSummary;
        private System.Windows.Forms.GroupBox gbDataSummary;
        private System.Windows.Forms.GroupBox gbParameterInfo;
        private System.Windows.Forms.Label lblMonitorType;
        private System.Windows.Forms.DataGridView dgvHRMData;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblMinSpeed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblAvgSpeed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblMaxSpeed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox cmbSpeedUnit;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Speed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cadence;
        private System.Windows.Forms.DataGridViewTextBoxColumn Altitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeartRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Power;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblInterval;
        private System.Windows.Forms.Label lblVO2max;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.Label lblRestHR;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblMaxHR;
        private System.Windows.Forms.Label lblSMode;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblDeviceVersion;
    }
}