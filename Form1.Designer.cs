namespace MRRC
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewFleet = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewCustomers = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.FleetGroupBox = new System.Windows.Forms.GroupBox();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.ModifyButton = new System.Windows.Forms.Button();
            this.AddGroupBox = new System.Windows.Forms.GroupBox();
            this.AddCancelButton = new System.Windows.Forms.Button();
            this.AddAddButton = new System.Windows.Forms.Button();
            this.GPSCheck = new System.Windows.Forms.CheckBox();
            this.SunRoofCheck = new System.Windows.Forms.CheckBox();
            this.DailyRateUpDown = new System.Windows.Forms.NumericUpDown();
            this.SeatsUpDown = new System.Windows.Forms.NumericUpDown();
            this.FuelCombo = new System.Windows.Forms.ComboBox();
            this.TransmissionCombo = new System.Windows.Forms.ComboBox();
            this.ClassCombo = new System.Windows.Forms.ComboBox();
            this.MakeText = new System.Windows.Forms.TextBox();
            this.ModelText = new System.Windows.Forms.TextBox();
            this.ColourText = new System.Windows.Forms.TextBox();
            this.FuelLabel = new System.Windows.Forms.Label();
            this.ClassLabel = new System.Windows.Forms.Label();
            this.SeatLabel = new System.Windows.Forms.Label();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.DailyRateLabel = new System.Windows.Forms.Label();
            this.GPSLabel = new System.Windows.Forms.Label();
            this.ColourLabel = new System.Windows.Forms.Label();
            this.SunRoofLabel = new System.Windows.Forms.Label();
            this.TransmissionLabel = new System.Windows.Forms.Label();
            this.YearLabel = new System.Windows.Forms.Label();
            this.RegoLabel = new System.Windows.Forms.Label();
            this.MakeLabel = new System.Windows.Forms.Label();
            this.MandatoryParamGroup = new System.Windows.Forms.GroupBox();
            this.YearMaskedText = new System.Windows.Forms.MaskedTextBox();
            this.RegoMaskedText = new System.Windows.Forms.MaskedTextBox();
            this.OptionalParamGroup = new System.Windows.Forms.GroupBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFleet)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).BeginInit();
            this.FleetGroupBox.SuspendLayout();
            this.AddGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DailyRateUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeatsUpDown)).BeginInit();
            this.MandatoryParamGroup.SuspendLayout();
            this.OptionalParamGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 70);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(904, 318);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewFleet);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(896, 292);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Fleet";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewFleet
            // 
            this.dataGridViewFleet.AllowUserToAddRows = false;
            this.dataGridViewFleet.AllowUserToDeleteRows = false;
            this.dataGridViewFleet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewFleet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFleet.Location = new System.Drawing.Point(3, 6);
            this.dataGridViewFleet.Name = "dataGridViewFleet";
            this.dataGridViewFleet.ReadOnly = true;
            this.dataGridViewFleet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFleet.Size = new System.Drawing.Size(887, 280);
            this.dataGridViewFleet.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewCustomers);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(896, 292);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Customer";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCustomers
            // 
            this.dataGridViewCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomers.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewCustomers.Name = "dataGridViewCustomers";
            this.dataGridViewCustomers.ReadOnly = true;
            this.dataGridViewCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCustomers.Size = new System.Drawing.Size(884, 284);
            this.dataGridViewCustomers.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(896, 292);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Rental Report";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(896, 292);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Rental Search";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(518, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "MATES RATES RENT A CAR";
            // 
            // FleetGroupBox
            // 
            this.FleetGroupBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.FleetGroupBox.Controls.Add(this.RemoveButton);
            this.FleetGroupBox.Controls.Add(this.AddButton);
            this.FleetGroupBox.Controls.Add(this.ModifyButton);
            this.FleetGroupBox.Location = new System.Drawing.Point(12, 388);
            this.FleetGroupBox.Name = "FleetGroupBox";
            this.FleetGroupBox.Size = new System.Drawing.Size(900, 50);
            this.FleetGroupBox.TabIndex = 4;
            this.FleetGroupBox.TabStop = false;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(668, 6);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(232, 44);
            this.RemoveButton.TabIndex = 3;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(0, 6);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(232, 44);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ModifyButton
            // 
            this.ModifyButton.Location = new System.Drawing.Point(342, 6);
            this.ModifyButton.Name = "ModifyButton";
            this.ModifyButton.Size = new System.Drawing.Size(232, 44);
            this.ModifyButton.TabIndex = 1;
            this.ModifyButton.Text = "Modify";
            this.ModifyButton.UseVisualStyleBackColor = true;
            // 
            // AddGroupBox
            // 
            this.AddGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddGroupBox.Controls.Add(this.OptionalParamGroup);
            this.AddGroupBox.Controls.Add(this.MandatoryParamGroup);
            this.AddGroupBox.Controls.Add(this.AddCancelButton);
            this.AddGroupBox.Controls.Add(this.AddAddButton);
            this.AddGroupBox.Location = new System.Drawing.Point(12, 232);
            this.AddGroupBox.Name = "AddGroupBox";
            this.AddGroupBox.Size = new System.Drawing.Size(900, 206);
            this.AddGroupBox.TabIndex = 1;
            this.AddGroupBox.TabStop = false;
            this.AddGroupBox.Visible = false;
            // 
            // AddCancelButton
            // 
            this.AddCancelButton.Location = new System.Drawing.Point(668, 115);
            this.AddCancelButton.Name = "AddCancelButton";
            this.AddCancelButton.Size = new System.Drawing.Size(210, 71);
            this.AddCancelButton.TabIndex = 27;
            this.AddCancelButton.Text = "Cancel";
            this.AddCancelButton.UseVisualStyleBackColor = true;
            this.AddCancelButton.Click += new System.EventHandler(this.AddCancelButton_Click);
            // 
            // AddAddButton
            // 
            this.AddAddButton.Location = new System.Drawing.Point(668, 23);
            this.AddAddButton.Name = "AddAddButton";
            this.AddAddButton.Size = new System.Drawing.Size(210, 71);
            this.AddAddButton.TabIndex = 26;
            this.AddAddButton.Text = "Add Car";
            this.AddAddButton.UseVisualStyleBackColor = true;
            this.AddAddButton.Click += new System.EventHandler(this.AddAddButton_Click);
            // 
            // GPSCheck
            // 
            this.GPSCheck.AutoSize = true;
            this.GPSCheck.Location = new System.Drawing.Point(352, 51);
            this.GPSCheck.Name = "GPSCheck";
            this.GPSCheck.Size = new System.Drawing.Size(15, 14);
            this.GPSCheck.TabIndex = 25;
            this.GPSCheck.UseVisualStyleBackColor = true;
            // 
            // SunRoofCheck
            // 
            this.SunRoofCheck.AutoSize = true;
            this.SunRoofCheck.Location = new System.Drawing.Point(352, 25);
            this.SunRoofCheck.Name = "SunRoofCheck";
            this.SunRoofCheck.Size = new System.Drawing.Size(15, 14);
            this.SunRoofCheck.TabIndex = 24;
            this.SunRoofCheck.UseVisualStyleBackColor = true;
            // 
            // DailyRateUpDown
            // 
            this.DailyRateUpDown.Location = new System.Drawing.Point(125, 98);
            this.DailyRateUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.DailyRateUpDown.Name = "DailyRateUpDown";
            this.DailyRateUpDown.Size = new System.Drawing.Size(69, 20);
            this.DailyRateUpDown.TabIndex = 23;
            // 
            // SeatsUpDown
            // 
            this.SeatsUpDown.Location = new System.Drawing.Point(125, 73);
            this.SeatsUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.SeatsUpDown.Name = "SeatsUpDown";
            this.SeatsUpDown.Size = new System.Drawing.Size(69, 20);
            this.SeatsUpDown.TabIndex = 22;
            // 
            // FuelCombo
            // 
            this.FuelCombo.FormattingEnabled = true;
            this.FuelCombo.Items.AddRange(new object[] {
            "Petrol",
            "Diesel"});
            this.FuelCombo.Location = new System.Drawing.Point(125, 47);
            this.FuelCombo.Name = "FuelCombo";
            this.FuelCombo.Size = new System.Drawing.Size(118, 21);
            this.FuelCombo.TabIndex = 21;
            // 
            // TransmissionCombo
            // 
            this.TransmissionCombo.FormattingEnabled = true;
            this.TransmissionCombo.Items.AddRange(new object[] {
            "Automatic",
            "Manual"});
            this.TransmissionCombo.Location = new System.Drawing.Point(125, 20);
            this.TransmissionCombo.Name = "TransmissionCombo";
            this.TransmissionCombo.Size = new System.Drawing.Size(118, 21);
            this.TransmissionCombo.TabIndex = 20;
            // 
            // ClassCombo
            // 
            this.ClassCombo.FormattingEnabled = true;
            this.ClassCombo.Items.AddRange(new object[] {
            "Commercial",
            "Economy ",
            "Family",
            "Luxury"});
            this.ClassCombo.Location = new System.Drawing.Point(70, 99);
            this.ClassCombo.Name = "ClassCombo";
            this.ClassCombo.Size = new System.Drawing.Size(118, 21);
            this.ClassCombo.TabIndex = 19;
            // 
            // MakeText
            // 
            this.MakeText.Location = new System.Drawing.Point(70, 46);
            this.MakeText.Name = "MakeText";
            this.MakeText.Size = new System.Drawing.Size(118, 20);
            this.MakeText.TabIndex = 18;
            // 
            // ModelText
            // 
            this.ModelText.Location = new System.Drawing.Point(70, 73);
            this.ModelText.Name = "ModelText";
            this.ModelText.Size = new System.Drawing.Size(118, 20);
            this.ModelText.TabIndex = 17;
            // 
            // ColourText
            // 
            this.ColourText.Location = new System.Drawing.Point(125, 125);
            this.ColourText.Name = "ColourText";
            this.ColourText.Size = new System.Drawing.Size(118, 20);
            this.ColourText.TabIndex = 13;
            // 
            // FuelLabel
            // 
            this.FuelLabel.AutoSize = true;
            this.FuelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FuelLabel.Location = new System.Drawing.Point(77, 49);
            this.FuelLabel.Name = "FuelLabel";
            this.FuelLabel.Size = new System.Drawing.Size(42, 16);
            this.FuelLabel.TabIndex = 11;
            this.FuelLabel.Text = "Fuel:";
            // 
            // ClassLabel
            // 
            this.ClassLabel.AutoSize = true;
            this.ClassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassLabel.Location = new System.Drawing.Point(13, 99);
            this.ClassLabel.Name = "ClassLabel";
            this.ClassLabel.Size = new System.Drawing.Size(51, 16);
            this.ClassLabel.TabIndex = 10;
            this.ClassLabel.Text = "Class:";
            // 
            // SeatLabel
            // 
            this.SeatLabel.AutoSize = true;
            this.SeatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeatLabel.Location = new System.Drawing.Point(67, 74);
            this.SeatLabel.Name = "SeatLabel";
            this.SeatLabel.Size = new System.Drawing.Size(52, 16);
            this.SeatLabel.TabIndex = 9;
            this.SeatLabel.Text = "Seats:";
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelLabel.Location = new System.Drawing.Point(9, 74);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(55, 16);
            this.ModelLabel.TabIndex = 8;
            this.ModelLabel.Text = "Model:";
            // 
            // DailyRateLabel
            // 
            this.DailyRateLabel.AutoSize = true;
            this.DailyRateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DailyRateLabel.Location = new System.Drawing.Point(34, 98);
            this.DailyRateLabel.Name = "DailyRateLabel";
            this.DailyRateLabel.Size = new System.Drawing.Size(85, 16);
            this.DailyRateLabel.TabIndex = 7;
            this.DailyRateLabel.Text = "Daily Rate:";
            // 
            // GPSLabel
            // 
            this.GPSLabel.AutoSize = true;
            this.GPSLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPSLabel.Location = new System.Drawing.Point(303, 49);
            this.GPSLabel.Name = "GPSLabel";
            this.GPSLabel.Size = new System.Drawing.Size(43, 16);
            this.GPSLabel.TabIndex = 6;
            this.GPSLabel.Text = "GPS:";
            // 
            // ColourLabel
            // 
            this.ColourLabel.AutoSize = true;
            this.ColourLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColourLabel.Location = new System.Drawing.Point(62, 125);
            this.ColourLabel.Name = "ColourLabel";
            this.ColourLabel.Size = new System.Drawing.Size(57, 16);
            this.ColourLabel.TabIndex = 5;
            this.ColourLabel.Text = "Colour:";
            // 
            // SunRoofLabel
            // 
            this.SunRoofLabel.AutoSize = true;
            this.SunRoofLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SunRoofLabel.Location = new System.Drawing.Point(271, 24);
            this.SunRoofLabel.Name = "SunRoofLabel";
            this.SunRoofLabel.Size = new System.Drawing.Size(75, 16);
            this.SunRoofLabel.TabIndex = 4;
            this.SunRoofLabel.Text = "Sun Roof:";
            // 
            // TransmissionLabel
            // 
            this.TransmissionLabel.AutoSize = true;
            this.TransmissionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransmissionLabel.Location = new System.Drawing.Point(14, 21);
            this.TransmissionLabel.Name = "TransmissionLabel";
            this.TransmissionLabel.Size = new System.Drawing.Size(105, 16);
            this.TransmissionLabel.TabIndex = 3;
            this.TransmissionLabel.Text = "Transmission:";
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearLabel.Location = new System.Drawing.Point(19, 126);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(45, 16);
            this.YearLabel.TabIndex = 2;
            this.YearLabel.Text = "Year:";
            // 
            // RegoLabel
            // 
            this.RegoLabel.AutoSize = true;
            this.RegoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegoLabel.Location = new System.Drawing.Point(14, 21);
            this.RegoLabel.Name = "RegoLabel";
            this.RegoLabel.Size = new System.Drawing.Size(50, 16);
            this.RegoLabel.TabIndex = 1;
            this.RegoLabel.Text = "Rego:";
            // 
            // MakeLabel
            // 
            this.MakeLabel.AutoSize = true;
            this.MakeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MakeLabel.Location = new System.Drawing.Point(14, 46);
            this.MakeLabel.Name = "MakeLabel";
            this.MakeLabel.Size = new System.Drawing.Size(50, 16);
            this.MakeLabel.TabIndex = 0;
            this.MakeLabel.Text = "Make:";
            // 
            // MandatoryParamGroup
            // 
            this.MandatoryParamGroup.Controls.Add(this.RegoMaskedText);
            this.MandatoryParamGroup.Controls.Add(this.YearMaskedText);
            this.MandatoryParamGroup.Controls.Add(this.ClassCombo);
            this.MandatoryParamGroup.Controls.Add(this.MakeText);
            this.MandatoryParamGroup.Controls.Add(this.ModelText);
            this.MandatoryParamGroup.Controls.Add(this.ClassLabel);
            this.MandatoryParamGroup.Controls.Add(this.ModelLabel);
            this.MandatoryParamGroup.Controls.Add(this.RegoLabel);
            this.MandatoryParamGroup.Controls.Add(this.MakeLabel);
            this.MandatoryParamGroup.Controls.Add(this.YearLabel);
            this.MandatoryParamGroup.Location = new System.Drawing.Point(10, 16);
            this.MandatoryParamGroup.Name = "MandatoryParamGroup";
            this.MandatoryParamGroup.Size = new System.Drawing.Size(203, 152);
            this.MandatoryParamGroup.TabIndex = 28;
            this.MandatoryParamGroup.TabStop = false;
            this.MandatoryParamGroup.Text = "Mandatory Fields";
            // 
            // YearMaskedText
            // 
            this.YearMaskedText.Location = new System.Drawing.Point(70, 126);
            this.YearMaskedText.Mask = "0000";
            this.YearMaskedText.Name = "YearMaskedText";
            this.YearMaskedText.Size = new System.Drawing.Size(48, 20);
            this.YearMaskedText.TabIndex = 29;
            this.YearMaskedText.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // RegoMaskedText
            // 
            this.RegoMaskedText.Location = new System.Drawing.Point(70, 22);
            this.RegoMaskedText.Mask = "000LLL";
            this.RegoMaskedText.Name = "RegoMaskedText";
            this.RegoMaskedText.Size = new System.Drawing.Size(48, 20);
            this.RegoMaskedText.TabIndex = 30;
            // 
            // OptionalParamGroup
            // 
            this.OptionalParamGroup.Controls.Add(this.GPSCheck);
            this.OptionalParamGroup.Controls.Add(this.SunRoofCheck);
            this.OptionalParamGroup.Controls.Add(this.DailyRateUpDown);
            this.OptionalParamGroup.Controls.Add(this.SeatsUpDown);
            this.OptionalParamGroup.Controls.Add(this.FuelCombo);
            this.OptionalParamGroup.Controls.Add(this.TransmissionCombo);
            this.OptionalParamGroup.Controls.Add(this.ColourText);
            this.OptionalParamGroup.Controls.Add(this.FuelLabel);
            this.OptionalParamGroup.Controls.Add(this.SeatLabel);
            this.OptionalParamGroup.Controls.Add(this.DailyRateLabel);
            this.OptionalParamGroup.Controls.Add(this.GPSLabel);
            this.OptionalParamGroup.Controls.Add(this.ColourLabel);
            this.OptionalParamGroup.Controls.Add(this.SunRoofLabel);
            this.OptionalParamGroup.Controls.Add(this.TransmissionLabel);
            this.OptionalParamGroup.Location = new System.Drawing.Point(238, 16);
            this.OptionalParamGroup.Name = "OptionalParamGroup";
            this.OptionalParamGroup.Size = new System.Drawing.Size(378, 152);
            this.OptionalParamGroup.TabIndex = 29;
            this.OptionalParamGroup.TabStop = false;
            this.OptionalParamGroup.Text = "Optional Paramaters";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(928, 450);
            this.Controls.Add(this.AddGroupBox);
            this.Controls.Add(this.FleetGroupBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "MRRC";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFleet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).EndInit();
            this.FleetGroupBox.ResumeLayout(false);
            this.AddGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DailyRateUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeatsUpDown)).EndInit();
            this.MandatoryParamGroup.ResumeLayout(false);
            this.MandatoryParamGroup.PerformLayout();
            this.OptionalParamGroup.ResumeLayout(false);
            this.OptionalParamGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridViewFleet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox FleetGroupBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridViewCustomers;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button ModifyButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.GroupBox AddGroupBox;
        private System.Windows.Forms.Label FuelLabel;
        private System.Windows.Forms.Label ClassLabel;
        private System.Windows.Forms.Label SeatLabel;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.Label DailyRateLabel;
        private System.Windows.Forms.Label GPSLabel;
        private System.Windows.Forms.Label ColourLabel;
        private System.Windows.Forms.Label SunRoofLabel;
        private System.Windows.Forms.Label TransmissionLabel;
        private System.Windows.Forms.Label YearLabel;
        private System.Windows.Forms.Label RegoLabel;
        private System.Windows.Forms.Label MakeLabel;
        private System.Windows.Forms.TextBox MakeText;
        private System.Windows.Forms.TextBox ModelText;
        private System.Windows.Forms.TextBox ColourText;
        private System.Windows.Forms.CheckBox GPSCheck;
        private System.Windows.Forms.CheckBox SunRoofCheck;
        private System.Windows.Forms.NumericUpDown DailyRateUpDown;
        private System.Windows.Forms.NumericUpDown SeatsUpDown;
        private System.Windows.Forms.ComboBox FuelCombo;
        private System.Windows.Forms.ComboBox TransmissionCombo;
        private System.Windows.Forms.ComboBox ClassCombo;
        private System.Windows.Forms.Button AddCancelButton;
        private System.Windows.Forms.Button AddAddButton;
        private System.Windows.Forms.GroupBox MandatoryParamGroup;
        private System.Windows.Forms.MaskedTextBox YearMaskedText;
        private System.Windows.Forms.MaskedTextBox RegoMaskedText;
        private System.Windows.Forms.GroupBox OptionalParamGroup;
    }
}

