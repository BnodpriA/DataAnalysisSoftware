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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.label34 = new System.Windows.Forms.Label();
            this.pnlDataSummary = new System.Windows.Forms.Panel();
            this.gbDataSummary = new System.Windows.Forms.GroupBox();
            this.label23 = new System.Windows.Forms.Label();
            this.cmbSpeedUnit = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lblMinPower = new System.Windows.Forms.Label();
            this.lblMinHeartRate = new System.Windows.Forms.Label();
            this.lblMinAltitude = new System.Windows.Forms.Label();
            this.lblMinCadence = new System.Windows.Forms.Label();
            this.lblMinSpeed = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAvgPower = new System.Windows.Forms.Label();
            this.lblAvgHeartRate = new System.Windows.Forms.Label();
            this.lblAvgAltitude = new System.Windows.Forms.Label();
            this.lblAvgCadence = new System.Windows.Forms.Label();
            this.lblAvgSpeed = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMaxPower = new System.Windows.Forms.Label();
            this.lblMaxHeartRate = new System.Windows.Forms.Label();
            this.lblMaxAltitude = new System.Windows.Forms.Label();
            this.lblMaxCadence = new System.Windows.Forms.Label();
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
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblInterval = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.lblVO2max = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.lblRestHR = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.lblMaxHR = new System.Windows.Forms.Label();
            this.lblSMode = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblDeviceVersion = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.lblMonitorType = new System.Windows.Forms.Label();
            this.dgvHRMData = new System.Windows.Forms.DataGridView();
            this.SNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeartRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Speed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cadence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Altitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Power = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.gbDataSummary.Controls.Add(this.lblMinPower);
            this.gbDataSummary.Controls.Add(this.lblMinHeartRate);
            this.gbDataSummary.Controls.Add(this.lblMinAltitude);
            this.gbDataSummary.Controls.Add(this.lblMinCadence);
            this.gbDataSummary.Controls.Add(this.lblMinSpeed);
            this.gbDataSummary.Controls.Add(this.label4);
            this.gbDataSummary.Controls.Add(this.lblAvgPower);
            this.gbDataSummary.Controls.Add(this.lblAvgHeartRate);
            this.gbDataSummary.Controls.Add(this.lblAvgAltitude);
            this.gbDataSummary.Controls.Add(this.lblAvgCadence);
            this.gbDataSummary.Controls.Add(this.lblAvgSpeed);
            this.gbDataSummary.Controls.Add(this.label3);
            this.gbDataSummary.Controls.Add(this.lblMaxPower);
            this.gbDataSummary.Controls.Add(this.lblMaxHeartRate);
            this.gbDataSummary.Controls.Add(this.lblMaxAltitude);
            this.gbDataSummary.Controls.Add(this.lblMaxCadence);
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
            this.cmbSpeedUnit.TabIndex = 1;
            this.cmbSpeedUnit.SelectedIndexChanged += new System.EventHandler(this.cmbSpeedUnit_SelectedIndexChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(11, 208);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(399, 19);
            this.label22.TabIndex = 8;
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
            // lblMinPower
            // 
            this.lblMinPower.AutoSize = true;
            this.lblMinPower.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinPower.Location = new System.Drawing.Point(357, 184);
            this.lblMinPower.Name = "lblMinPower";
            this.lblMinPower.Size = new System.Drawing.Size(18, 19);
            this.lblMinPower.TabIndex = 0;
            this.lblMinPower.Text = "0";
            // 
            // lblMinHeartRate
            // 
            this.lblMinHeartRate.AutoSize = true;
            this.lblMinHeartRate.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinHeartRate.Location = new System.Drawing.Point(357, 154);
            this.lblMinHeartRate.Name = "lblMinHeartRate";
            this.lblMinHeartRate.Size = new System.Drawing.Size(18, 19);
            this.lblMinHeartRate.TabIndex = 0;
            this.lblMinHeartRate.Text = "0";
            // 
            // lblMinAltitude
            // 
            this.lblMinAltitude.AutoSize = true;
            this.lblMinAltitude.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinAltitude.Location = new System.Drawing.Point(357, 124);
            this.lblMinAltitude.Name = "lblMinAltitude";
            this.lblMinAltitude.Size = new System.Drawing.Size(18, 19);
            this.lblMinAltitude.TabIndex = 0;
            this.lblMinAltitude.Text = "0";
            // 
            // lblMinCadence
            // 
            this.lblMinCadence.AutoSize = true;
            this.lblMinCadence.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinCadence.Location = new System.Drawing.Point(357, 94);
            this.lblMinCadence.Name = "lblMinCadence";
            this.lblMinCadence.Size = new System.Drawing.Size(18, 19);
            this.lblMinCadence.TabIndex = 0;
            this.lblMinCadence.Text = "0";
            // 
            // lblMinSpeed
            // 
            this.lblMinSpeed.AutoSize = true;
            this.lblMinSpeed.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinSpeed.Location = new System.Drawing.Point(357, 64);
            this.lblMinSpeed.Name = "lblMinSpeed";
            this.lblMinSpeed.Size = new System.Drawing.Size(18, 19);
            this.lblMinSpeed.TabIndex = 0;
            this.lblMinSpeed.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(324, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Minimum";
            // 
            // lblAvgPower
            // 
            this.lblAvgPower.AutoSize = true;
            this.lblAvgPower.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvgPower.Location = new System.Drawing.Point(272, 184);
            this.lblAvgPower.Name = "lblAvgPower";
            this.lblAvgPower.Size = new System.Drawing.Size(18, 19);
            this.lblAvgPower.TabIndex = 0;
            this.lblAvgPower.Text = "0";
            // 
            // lblAvgHeartRate
            // 
            this.lblAvgHeartRate.AutoSize = true;
            this.lblAvgHeartRate.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvgHeartRate.Location = new System.Drawing.Point(272, 154);
            this.lblAvgHeartRate.Name = "lblAvgHeartRate";
            this.lblAvgHeartRate.Size = new System.Drawing.Size(18, 19);
            this.lblAvgHeartRate.TabIndex = 0;
            this.lblAvgHeartRate.Text = "0";
            // 
            // lblAvgAltitude
            // 
            this.lblAvgAltitude.AutoSize = true;
            this.lblAvgAltitude.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvgAltitude.Location = new System.Drawing.Point(272, 124);
            this.lblAvgAltitude.Name = "lblAvgAltitude";
            this.lblAvgAltitude.Size = new System.Drawing.Size(18, 19);
            this.lblAvgAltitude.TabIndex = 0;
            this.lblAvgAltitude.Text = "0";
            // 
            // lblAvgCadence
            // 
            this.lblAvgCadence.AutoSize = true;
            this.lblAvgCadence.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvgCadence.Location = new System.Drawing.Point(272, 94);
            this.lblAvgCadence.Name = "lblAvgCadence";
            this.lblAvgCadence.Size = new System.Drawing.Size(18, 19);
            this.lblAvgCadence.TabIndex = 0;
            this.lblAvgCadence.Text = "0";
            // 
            // lblAvgSpeed
            // 
            this.lblAvgSpeed.AutoSize = true;
            this.lblAvgSpeed.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvgSpeed.Location = new System.Drawing.Point(272, 64);
            this.lblAvgSpeed.Name = "lblAvgSpeed";
            this.lblAvgSpeed.Size = new System.Drawing.Size(18, 19);
            this.lblAvgSpeed.TabIndex = 0;
            this.lblAvgSpeed.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Average";
            // 
            // lblMaxPower
            // 
            this.lblMaxPower.AutoSize = true;
            this.lblMaxPower.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxPower.Location = new System.Drawing.Point(187, 184);
            this.lblMaxPower.Name = "lblMaxPower";
            this.lblMaxPower.Size = new System.Drawing.Size(18, 19);
            this.lblMaxPower.TabIndex = 0;
            this.lblMaxPower.Text = "0";
            // 
            // lblMaxHeartRate
            // 
            this.lblMaxHeartRate.AutoSize = true;
            this.lblMaxHeartRate.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxHeartRate.Location = new System.Drawing.Point(187, 154);
            this.lblMaxHeartRate.Name = "lblMaxHeartRate";
            this.lblMaxHeartRate.Size = new System.Drawing.Size(18, 19);
            this.lblMaxHeartRate.TabIndex = 0;
            this.lblMaxHeartRate.Text = "0";
            // 
            // lblMaxAltitude
            // 
            this.lblMaxAltitude.AutoSize = true;
            this.lblMaxAltitude.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxAltitude.Location = new System.Drawing.Point(187, 124);
            this.lblMaxAltitude.Name = "lblMaxAltitude";
            this.lblMaxAltitude.Size = new System.Drawing.Size(18, 19);
            this.lblMaxAltitude.TabIndex = 0;
            this.lblMaxAltitude.Text = "0";
            // 
            // lblMaxCadence
            // 
            this.lblMaxCadence.AutoSize = true;
            this.lblMaxCadence.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxCadence.Location = new System.Drawing.Point(187, 94);
            this.lblMaxCadence.Name = "lblMaxCadence";
            this.lblMaxCadence.Size = new System.Drawing.Size(18, 19);
            this.lblMaxCadence.TabIndex = 0;
            this.lblMaxCadence.Text = "0";
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
            this.label2.TabIndex = 0;
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
            this.label29.TabIndex = 0;
            this.label29.Text = "Weight:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(210, 142);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(73, 19);
            this.label30.TabIndex = 0;
            this.label30.Text = "VO2max:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(210, 112);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(72, 19);
            this.label31.TabIndex = 0;
            this.label31.Text = "Rest HR:";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(210, 82);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(71, 19);
            this.label32.TabIndex = 0;
            this.label32.Text = "Max HR:";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(210, 52);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(64, 19);
            this.label33.TabIndex = 0;
            this.label33.Text = "Length:";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.Location = new System.Drawing.Point(285, 172);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(18, 19);
            this.lblWeight.TabIndex = 0;
            this.lblWeight.Text = "0";
            // 
            // lblInterval
            // 
            this.lblInterval.AutoSize = true;
            this.lblInterval.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterval.Location = new System.Drawing.Point(90, 172);
            this.lblInterval.Name = "lblInterval";
            this.lblInterval.Size = new System.Drawing.Size(18, 19);
            this.lblInterval.TabIndex = 0;
            this.lblInterval.Text = "0";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(19, 172);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(72, 19);
            this.label24.TabIndex = 0;
            this.label24.Text = "Interval:";
            // 
            // lblVO2max
            // 
            this.lblVO2max.AutoSize = true;
            this.lblVO2max.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVO2max.Location = new System.Drawing.Point(285, 142);
            this.lblVO2max.Name = "lblVO2max";
            this.lblVO2max.Size = new System.Drawing.Size(18, 19);
            this.lblVO2max.TabIndex = 0;
            this.lblVO2max.Text = "0";
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartTime.Location = new System.Drawing.Point(110, 142);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(18, 19);
            this.lblStartTime.TabIndex = 0;
            this.lblStartTime.Text = "0";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(19, 142);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(90, 19);
            this.label25.TabIndex = 0;
            this.label25.Text = "Start Time:";
            // 
            // lblRestHR
            // 
            this.lblRestHR.AutoSize = true;
            this.lblRestHR.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestHR.Location = new System.Drawing.Point(285, 112);
            this.lblRestHR.Name = "lblRestHR";
            this.lblRestHR.Size = new System.Drawing.Size(18, 19);
            this.lblRestHR.TabIndex = 0;
            this.lblRestHR.Text = "0";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(67, 112);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(18, 19);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "0";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(19, 112);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(47, 19);
            this.label26.TabIndex = 0;
            this.label26.Text = "Date:";
            // 
            // lblMaxHR
            // 
            this.lblMaxHR.AutoSize = true;
            this.lblMaxHR.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxHR.Location = new System.Drawing.Point(285, 82);
            this.lblMaxHR.Name = "lblMaxHR";
            this.lblMaxHR.Size = new System.Drawing.Size(18, 19);
            this.lblMaxHR.TabIndex = 0;
            this.lblMaxHR.Text = "0";
            // 
            // lblSMode
            // 
            this.lblSMode.AutoSize = true;
            this.lblSMode.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSMode.Location = new System.Drawing.Point(82, 82);
            this.lblSMode.Name = "lblSMode";
            this.lblSMode.Size = new System.Drawing.Size(18, 19);
            this.lblSMode.TabIndex = 0;
            this.lblSMode.Text = "0";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(19, 82);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(62, 19);
            this.label27.TabIndex = 0;
            this.label27.Text = "SMode:";
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
            // lblDeviceVersion
            // 
            this.lblDeviceVersion.AutoSize = true;
            this.lblDeviceVersion.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeviceVersion.Location = new System.Drawing.Point(145, 52);
            this.lblDeviceVersion.Name = "lblDeviceVersion";
            this.lblDeviceVersion.Size = new System.Drawing.Size(18, 19);
            this.lblDeviceVersion.TabIndex = 0;
            this.lblDeviceVersion.Text = "0";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(19, 52);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(120, 19);
            this.label28.TabIndex = 0;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvHRMData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHRMData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHRMData.BackgroundColor = System.Drawing.Color.White;
            this.dgvHRMData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHRMData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SNo,
            this.HeartRate,
            this.Speed,
            this.Cadence,
            this.Altitude,
            this.Power});
            this.dgvHRMData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHRMData.Location = new System.Drawing.Point(0, 61);
            this.dgvHRMData.Name = "dgvHRMData";
            this.dgvHRMData.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHRMData.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvHRMData.RowHeadersVisible = false;
            this.dgvHRMData.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvHRMData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHRMData.Size = new System.Drawing.Size(746, 430);
            this.dgvHRMData.TabIndex = 2;
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
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblMinPower;
        private System.Windows.Forms.Label lblMinHeartRate;
        private System.Windows.Forms.Label lblMinAltitude;
        private System.Windows.Forms.Label lblMinCadence;
        private System.Windows.Forms.Label lblMinSpeed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAvgPower;
        private System.Windows.Forms.Label lblAvgHeartRate;
        private System.Windows.Forms.Label lblAvgAltitude;
        private System.Windows.Forms.Label lblAvgCadence;
        private System.Windows.Forms.Label lblAvgSpeed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMaxPower;
        private System.Windows.Forms.Label lblMaxHeartRate;
        private System.Windows.Forms.Label lblMaxAltitude;
        private System.Windows.Forms.Label lblMaxCadence;
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
        private System.Windows.Forms.Label lblMaxHR;
        private System.Windows.Forms.Label lblSMode;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblDeviceVersion;
        public System.Windows.Forms.Label lblDate;
        public System.Windows.Forms.DataGridView dgvHRMData;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeartRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Speed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cadence;
        private System.Windows.Forms.DataGridViewTextBoxColumn Altitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn Power;
    }
}