namespace MultiscaleModelling
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxNeighbourhood = new System.Windows.Forms.ComboBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.numericUpDownWidth = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownHeight = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.numericUpDownNumberOfGrain = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.labelGBPer = new System.Windows.Forms.Label();
            this.ImportFromFile = new System.Windows.Forms.Button();
            this.saveToBmp = new System.Windows.Forms.Button();
            this.SaveToTxt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Inclusion = new System.Windows.Forms.Label();
            this.numericSizeOfInclusions = new System.Windows.Forms.NumericUpDown();
            this.numericAmountOfInclusions = new System.Windows.Forms.NumericUpDown();
            this.comboBoxTypeOfInclusion = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.numericMooreProbability = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.SelectGrains = new System.Windows.Forms.Button();
            this.StrucutreType = new System.Windows.Forms.ComboBox();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.numericUpDownGBSize = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonGenerateGB = new System.Windows.Forms.Button();
            this.buttonRemoveColors = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.GBL = new System.Windows.Forms.Label();
            this.GB = new System.Windows.Forms.Label();
            this.checkBoxMC = new System.Windows.Forms.CheckBox();
            this.numericUpDownJ = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.numericUpDownMCIterations = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.radioButtonAny = new System.Windows.Forms.RadioButton();
            this.radioButtonGB = new System.Windows.Forms.RadioButton();
            this.buttonRecrystallization = new System.Windows.Forms.Button();
            this.numericUpDownRecrStates = new System.Windows.Forms.NumericUpDown();
            this.comboBoxNucleationType = new System.Windows.Forms.ComboBox();
            this.numericUpDownRecIterations = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTotalNucleons = new System.Windows.Forms.NumericUpDown();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.buttonCalculateEnergy = new System.Windows.Forms.Button();
            this.checkBoxEnergy = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberOfGrain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSizeOfInclusions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAmountOfInclusions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMooreProbability)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGBSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownJ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMCIterations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRecrStates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRecIterations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTotalNucleons)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(126, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(0, 0);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(455, 540);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Width";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 540);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Height";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(644, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Neighbourhood type";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // comboBoxNeighbourhood
            // 
            this.comboBoxNeighbourhood.FormattingEnabled = true;
            this.comboBoxNeighbourhood.Items.AddRange(new object[] {
            "Von Neumann",
            "Moore",
            "Extended"});
            this.comboBoxNeighbourhood.Location = new System.Drawing.Point(786, 116);
            this.comboBoxNeighbourhood.Name = "comboBoxNeighbourhood";
            this.comboBoxNeighbourhood.Size = new System.Drawing.Size(120, 21);
            this.comboBoxNeighbourhood.TabIndex = 6;
            this.comboBoxNeighbourhood.SelectedIndexChanged += new System.EventHandler(this.comboBoxNeighbourhood_SelectedIndexChanged);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(13, 227);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(80, 80);
            this.buttonStart.TabIndex = 9;
            this.buttonStart.Text = "show grains";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(0, 0);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 54;
            // 
            // buttonRestart
            // 
            this.buttonRestart.Location = new System.Drawing.Point(13, 399);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(80, 80);
            this.buttonRestart.TabIndex = 11;
            this.buttonRestart.Text = "Restart";
            this.buttonRestart.UseVisualStyleBackColor = true;
            this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
            // 
            // numericUpDownWidth
            // 
            this.numericUpDownWidth.Location = new System.Drawing.Point(415, 556);
            this.numericUpDownWidth.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownWidth.Name = "numericUpDownWidth";
            this.numericUpDownWidth.Size = new System.Drawing.Size(126, 20);
            this.numericUpDownWidth.TabIndex = 12;
            this.numericUpDownWidth.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDownWidth.ValueChanged += new System.EventHandler(this.NumericUpDownWidth_ValueChanged);
            // 
            // numericUpDownHeight
            // 
            this.numericUpDownHeight.Location = new System.Drawing.Point(183, 556);
            this.numericUpDownHeight.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownHeight.Name = "numericUpDownHeight";
            this.numericUpDownHeight.Size = new System.Drawing.Size(126, 20);
            this.numericUpDownHeight.TabIndex = 13;
            this.numericUpDownHeight.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDownHeight.ValueChanged += new System.EventHandler(this.NumericUpDownHeight_ValueChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // numericUpDownNumberOfGrain
            // 
            this.numericUpDownNumberOfGrain.Location = new System.Drawing.Point(786, 90);
            this.numericUpDownNumberOfGrain.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDownNumberOfGrain.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNumberOfGrain.Name = "numericUpDownNumberOfGrain";
            this.numericUpDownNumberOfGrain.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownNumberOfGrain.TabIndex = 15;
            this.numericUpDownNumberOfGrain.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownNumberOfGrain.ValueChanged += new System.EventHandler(this.numericUpDownNumberOfGrain_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(644, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "number of grains";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1004, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // timer2
            // 
            this.timer2.Interval = 500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // labelGBPer
            // 
            this.labelGBPer.AutoSize = true;
            this.labelGBPer.Location = new System.Drawing.Point(680, 294);
            this.labelGBPer.Name = "labelGBPer";
            this.labelGBPer.Size = new System.Drawing.Size(0, 13);
            this.labelGBPer.TabIndex = 42;
            // 
            // ImportFromFile
            // 
            this.ImportFromFile.Location = new System.Drawing.Point(13, 182);
            this.ImportFromFile.Name = "ImportFromFile";
            this.ImportFromFile.Size = new System.Drawing.Size(80, 27);
            this.ImportFromFile.TabIndex = 51;
            this.ImportFromFile.Text = "Import";
            this.ImportFromFile.UseVisualStyleBackColor = true;
            this.ImportFromFile.Click += new System.EventHandler(this.Button3_Click);
            // 
            // saveToBmp
            // 
            this.saveToBmp.Location = new System.Drawing.Point(13, 103);
            this.saveToBmp.Name = "saveToBmp";
            this.saveToBmp.Size = new System.Drawing.Size(80, 27);
            this.saveToBmp.TabIndex = 52;
            this.saveToBmp.Text = "Save to bmp";
            this.saveToBmp.UseVisualStyleBackColor = true;
            this.saveToBmp.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // SaveToTxt
            // 
            this.SaveToTxt.Location = new System.Drawing.Point(13, 143);
            this.SaveToTxt.Name = "SaveToTxt";
            this.SaveToTxt.Size = new System.Drawing.Size(80, 27);
            this.SaveToTxt.TabIndex = 53;
            this.SaveToTxt.Text = "Save to txt";
            this.SaveToTxt.UseVisualStyleBackColor = true;
            this.SaveToTxt.Click += new System.EventHandler(this.SaveToTxt_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 80);
            this.button1.TabIndex = 55;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Inclusion
            // 
            this.Inclusion.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Inclusion.AutoSize = true;
            this.Inclusion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Inclusion.Location = new System.Drawing.Point(757, 150);
            this.Inclusion.Name = "Inclusion";
            this.Inclusion.Size = new System.Drawing.Size(51, 15);
            this.Inclusion.TabIndex = 56;
            this.Inclusion.Text = "Inclusion";
            this.Inclusion.Click += new System.EventHandler(this.Label4_Click);
            // 
            // numericSizeOfInclusions
            // 
            this.numericSizeOfInclusions.Location = new System.Drawing.Point(786, 209);
            this.numericSizeOfInclusions.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericSizeOfInclusions.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericSizeOfInclusions.Name = "numericSizeOfInclusions";
            this.numericSizeOfInclusions.Size = new System.Drawing.Size(120, 20);
            this.numericSizeOfInclusions.TabIndex = 22;
            this.numericSizeOfInclusions.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericSizeOfInclusions.ValueChanged += new System.EventHandler(this.NumericSizeOfInclusions_ValueChanged);
            // 
            // numericAmountOfInclusions
            // 
            this.numericAmountOfInclusions.Location = new System.Drawing.Point(786, 183);
            this.numericAmountOfInclusions.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericAmountOfInclusions.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericAmountOfInclusions.Name = "numericAmountOfInclusions";
            this.numericAmountOfInclusions.Size = new System.Drawing.Size(120, 20);
            this.numericAmountOfInclusions.TabIndex = 21;
            this.numericAmountOfInclusions.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericAmountOfInclusions.ValueChanged += new System.EventHandler(this.NumericAmountOfInclusions_ValueChanged);
            // 
            // comboBoxTypeOfInclusion
            // 
            this.comboBoxTypeOfInclusion.FormattingEnabled = true;
            this.comboBoxTypeOfInclusion.Items.AddRange(new object[] {
            "Circle",
            "Square"});
            this.comboBoxTypeOfInclusion.Location = new System.Drawing.Point(786, 235);
            this.comboBoxTypeOfInclusion.Name = "comboBoxTypeOfInclusion";
            this.comboBoxTypeOfInclusion.Size = new System.Drawing.Size(120, 21);
            this.comboBoxTypeOfInclusion.TabIndex = 24;
            this.comboBoxTypeOfInclusion.SelectedIndexChanged += new System.EventHandler(this.ComboBoxTypeOfInclusion_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(644, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 57;
            this.label4.Text = "Type of inclusion";
            this.label4.Click += new System.EventHandler(this.Label4_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(644, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 58;
            this.label6.Text = "Size of Inclusion";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(644, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 13);
            this.label7.TabIndex = 59;
            this.label7.Text = "Amount of inclusions";
            this.label7.Click += new System.EventHandler(this.Label7_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(912, 182);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 76);
            this.button2.TabIndex = 60;
            this.button2.Text = "Add Inclusion";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // numericMooreProbability
            // 
            this.numericMooreProbability.Location = new System.Drawing.Point(912, 117);
            this.numericMooreProbability.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericMooreProbability.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericMooreProbability.Name = "numericMooreProbability";
            this.numericMooreProbability.Size = new System.Drawing.Size(42, 20);
            this.numericMooreProbability.TabIndex = 61;
            this.numericMooreProbability.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericMooreProbability.ValueChanged += new System.EventHandler(this.NumericUpDown1_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(960, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 13);
            this.label8.TabIndex = 62;
            this.label8.Text = "%";
            this.label8.Click += new System.EventHandler(this.Label8_Click);
            // 
            // SelectGrains
            // 
            this.SelectGrains.Location = new System.Drawing.Point(700, 264);
            this.SelectGrains.Name = "SelectGrains";
            this.SelectGrains.Size = new System.Drawing.Size(80, 162);
            this.SelectGrains.TabIndex = 63;
            this.SelectGrains.Text = "Select";
            this.SelectGrains.UseVisualStyleBackColor = true;
            this.SelectGrains.Click += new System.EventHandler(this.SelectGrains_Click);
            // 
            // StrucutreType
            // 
            this.StrucutreType.FormattingEnabled = true;
            this.StrucutreType.Items.AddRange(new object[] {
            "Substructure",
            "Dual phase"});
            this.StrucutreType.Location = new System.Drawing.Point(786, 277);
            this.StrucutreType.Name = "StrucutreType";
            this.StrucutreType.Size = new System.Drawing.Size(120, 21);
            this.StrucutreType.TabIndex = 64;
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(912, 264);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(80, 78);
            this.buttonGenerate.TabIndex = 66;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.ButtonGenerate_Click);
            // 
            // numericUpDownGBSize
            // 
            this.numericUpDownGBSize.Location = new System.Drawing.Point(786, 364);
            this.numericUpDownGBSize.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDownGBSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownGBSize.Name = "numericUpDownGBSize";
            this.numericUpDownGBSize.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownGBSize.TabIndex = 68;
            this.numericUpDownGBSize.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numericUpDownGBSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(807, 348);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 69;
            this.label9.Text = "Size of border";
            this.label9.Click += new System.EventHandler(this.Label9_Click);
            // 
            // buttonGenerateGB
            // 
            this.buttonGenerateGB.Location = new System.Drawing.Point(912, 348);
            this.buttonGenerateGB.Name = "buttonGenerateGB";
            this.buttonGenerateGB.Size = new System.Drawing.Size(80, 78);
            this.buttonGenerateGB.TabIndex = 70;
            this.buttonGenerateGB.Text = "Generate";
            this.buttonGenerateGB.UseVisualStyleBackColor = true;
            this.buttonGenerateGB.Click += new System.EventHandler(this.ButtonGenerateGB_Click);
            // 
            // buttonRemoveColors
            // 
            this.buttonRemoveColors.Location = new System.Drawing.Point(786, 405);
            this.buttonRemoveColors.Margin = new System.Windows.Forms.Padding(0);
            this.buttonRemoveColors.Name = "buttonRemoveColors";
            this.buttonRemoveColors.Size = new System.Drawing.Size(120, 21);
            this.buttonRemoveColors.TabIndex = 71;
            this.buttonRemoveColors.Text = "Remove except GB";
            this.buttonRemoveColors.UseVisualStyleBackColor = true;
            this.buttonRemoveColors.Click += new System.EventHandler(this.ButtonRemoveColors_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(783, 387);
            this.label10.Margin = new System.Windows.Forms.Padding(0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 72;
            this.label10.Text = "%GB";
            this.label10.Click += new System.EventHandler(this.Label10_Click);
            // 
            // GBL
            // 
            this.GBL.AutoSize = true;
            this.GBL.Location = new System.Drawing.Point(906, 413);
            this.GBL.Margin = new System.Windows.Forms.Padding(0);
            this.GBL.Name = "GBL";
            this.GBL.Size = new System.Drawing.Size(0, 13);
            this.GBL.TabIndex = 73;
            // 
            // GB
            // 
            this.GB.AutoSize = true;
            this.GB.Location = new System.Drawing.Point(813, 387);
            this.GB.Margin = new System.Windows.Forms.Padding(0);
            this.GB.Name = "GB";
            this.GB.Size = new System.Drawing.Size(30, 13);
            this.GB.TabIndex = 74;
            this.GB.Text = "%GB";
            // 
            // checkBoxMC
            // 
            this.checkBoxMC.AutoSize = true;
            this.checkBoxMC.Location = new System.Drawing.Point(647, 44);
            this.checkBoxMC.Name = "checkBoxMC";
            this.checkBoxMC.Size = new System.Drawing.Size(83, 17);
            this.checkBoxMC.TabIndex = 75;
            this.checkBoxMC.Text = "Monte Carlo";
            this.checkBoxMC.UseVisualStyleBackColor = true;
            this.checkBoxMC.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // numericUpDownJ
            // 
            this.numericUpDownJ.DecimalPlaces = 2;
            this.numericUpDownJ.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownJ.Location = new System.Drawing.Point(909, 41);
            this.numericUpDownJ.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownJ.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownJ.Name = "numericUpDownJ";
            this.numericUpDownJ.Size = new System.Drawing.Size(43, 20);
            this.numericUpDownJ.TabIndex = 76;
            this.numericUpDownJ.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(960, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(12, 13);
            this.label11.TabIndex = 77;
            this.label11.Text = "J";
            // 
            // numericUpDownMCIterations
            // 
            this.numericUpDownMCIterations.Location = new System.Drawing.Point(786, 41);
            this.numericUpDownMCIterations.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDownMCIterations.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMCIterations.Name = "numericUpDownMCIterations";
            this.numericUpDownMCIterations.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownMCIterations.TabIndex = 78;
            this.numericUpDownMCIterations.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(729, 45);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 79;
            this.label12.Text = "iteriations";
            // 
            // radioButtonAny
            // 
            this.radioButtonAny.AutoSize = true;
            this.radioButtonAny.Location = new System.Drawing.Point(786, 435);
            this.radioButtonAny.Name = "radioButtonAny";
            this.radioButtonAny.Size = new System.Drawing.Size(72, 17);
            this.radioButtonAny.TabIndex = 46;
            this.radioButtonAny.TabStop = true;
            this.radioButtonAny.Text = "Anywhere";
            this.radioButtonAny.UseVisualStyleBackColor = true;
            this.radioButtonAny.CheckedChanged += new System.EventHandler(this.RadioButtonAny_CheckedChanged);
            // 
            // radioButtonGB
            // 
            this.radioButtonGB.AutoSize = true;
            this.radioButtonGB.Location = new System.Drawing.Point(786, 458);
            this.radioButtonGB.Name = "radioButtonGB";
            this.radioButtonGB.Size = new System.Drawing.Size(40, 17);
            this.radioButtonGB.TabIndex = 45;
            this.radioButtonGB.TabStop = true;
            this.radioButtonGB.Text = "GB";
            this.radioButtonGB.UseVisualStyleBackColor = true;
            // 
            // buttonRecrystallization
            // 
            this.buttonRecrystallization.Location = new System.Drawing.Point(700, 432);
            this.buttonRecrystallization.Name = "buttonRecrystallization";
            this.buttonRecrystallization.Size = new System.Drawing.Size(80, 147);
            this.buttonRecrystallization.TabIndex = 81;
            this.buttonRecrystallization.Text = "Recrystal.";
            this.buttonRecrystallization.UseVisualStyleBackColor = true;
            this.buttonRecrystallization.Click += new System.EventHandler(this.ButtonRecrystallization_Click);
            // 
            // numericUpDownRecrStates
            // 
            this.numericUpDownRecrStates.Location = new System.Drawing.Point(786, 506);
            this.numericUpDownRecrStates.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDownRecrStates.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownRecrStates.Name = "numericUpDownRecrStates";
            this.numericUpDownRecrStates.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownRecrStates.TabIndex = 82;
            this.numericUpDownRecrStates.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownRecrStates.ValueChanged += new System.EventHandler(this.NumericUpDownRecrStates_ValueChanged);
            // 
            // comboBoxNucleationType
            // 
            this.comboBoxNucleationType.FormattingEnabled = true;
            this.comboBoxNucleationType.Items.AddRange(new object[] {
            "Constant",
            "Increasing",
            "BeginOfSimulation"});
            this.comboBoxNucleationType.Location = new System.Drawing.Point(786, 532);
            this.comboBoxNucleationType.Name = "comboBoxNucleationType";
            this.comboBoxNucleationType.Size = new System.Drawing.Size(120, 21);
            this.comboBoxNucleationType.TabIndex = 83;
            this.comboBoxNucleationType.SelectedIndexChanged += new System.EventHandler(this.ComboBoxNucleationType_SelectedIndexChanged);
            // 
            // numericUpDownRecIterations
            // 
            this.numericUpDownRecIterations.Location = new System.Drawing.Point(786, 481);
            this.numericUpDownRecIterations.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownRecIterations.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownRecIterations.Name = "numericUpDownRecIterations";
            this.numericUpDownRecIterations.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownRecIterations.TabIndex = 84;
            this.numericUpDownRecIterations.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numericUpDownTotalNucleons
            // 
            this.numericUpDownTotalNucleons.Location = new System.Drawing.Point(786, 559);
            this.numericUpDownTotalNucleons.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownTotalNucleons.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownTotalNucleons.Name = "numericUpDownTotalNucleons";
            this.numericUpDownTotalNucleons.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownTotalNucleons.TabIndex = 85;
            this.numericUpDownTotalNucleons.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(912, 508);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(85, 13);
            this.label21.TabIndex = 86;
            this.label21.Text = "Recrystal. states";
            this.label21.Click += new System.EventHandler(this.Label21_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(912, 535);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(85, 13);
            this.label22.TabIndex = 87;
            this.label22.Text = "Nucleation Type";
            this.label22.Click += new System.EventHandler(this.Label22_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(912, 483);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(56, 13);
            this.label23.TabIndex = 88;
            this.label23.Text = "Interations";
            this.label23.Click += new System.EventHandler(this.Label23_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(912, 563);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(94, 13);
            this.label24.TabIndex = 89;
            this.label24.Text = "nucleaons amount";
            // 
            // buttonCalculateEnergy
            // 
            this.buttonCalculateEnergy.Location = new System.Drawing.Point(13, 485);
            this.buttonCalculateEnergy.Name = "buttonCalculateEnergy";
            this.buttonCalculateEnergy.Size = new System.Drawing.Size(80, 80);
            this.buttonCalculateEnergy.TabIndex = 90;
            this.buttonCalculateEnergy.Text = "Calculate Energy";
            this.buttonCalculateEnergy.UseVisualStyleBackColor = true;
            this.buttonCalculateEnergy.Click += new System.EventHandler(this.ButtonCalculateEnergy_Click);
            // 
            // checkBoxEnergy
            // 
            this.checkBoxEnergy.AutoSize = true;
            this.checkBoxEnergy.Location = new System.Drawing.Point(13, 571);
            this.checkBoxEnergy.Name = "checkBoxEnergy";
            this.checkBoxEnergy.Size = new System.Drawing.Size(89, 17);
            this.checkBoxEnergy.TabIndex = 91;
            this.checkBoxEnergy.Text = "Show Energy";
            this.checkBoxEnergy.UseVisualStyleBackColor = true;
            this.checkBoxEnergy.CheckedChanged += new System.EventHandler(this.CheckBoxEnergy_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 591);
            this.Controls.Add(this.checkBoxEnergy);
            this.Controls.Add(this.buttonCalculateEnergy);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.numericUpDownTotalNucleons);
            this.Controls.Add(this.numericUpDownRecIterations);
            this.Controls.Add(this.comboBoxNucleationType);
            this.Controls.Add(this.numericUpDownRecrStates);
            this.Controls.Add(this.buttonRecrystallization);
            this.Controls.Add(this.radioButtonAny);
            this.Controls.Add(this.radioButtonGB);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.numericUpDownMCIterations);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.numericUpDownJ);
            this.Controls.Add(this.checkBoxMC);
            this.Controls.Add(this.GB);
            this.Controls.Add(this.GBL);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.buttonRemoveColors);
            this.Controls.Add(this.buttonGenerateGB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.numericUpDownGBSize);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.StrucutreType);
            this.Controls.Add(this.SelectGrains);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numericMooreProbability);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxTypeOfInclusion);
            this.Controls.Add(this.numericAmountOfInclusions);
            this.Controls.Add(this.numericSizeOfInclusions);
            this.Controls.Add(this.Inclusion);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SaveToTxt);
            this.Controls.Add(this.saveToBmp);
            this.Controls.Add(this.ImportFromFile);
            this.Controls.Add(this.labelGBPer);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.numericUpDownNumberOfGrain);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDownHeight);
            this.Controls.Add(this.numericUpDownWidth);
            this.Controls.Add(this.buttonRestart);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.comboBoxNeighbourhood);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1020, 630);
            this.MinimumSize = new System.Drawing.Size(1020, 630);
            this.Name = "Form1";
            this.Text = "Multiscale Modelling";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberOfGrain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSizeOfInclusions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAmountOfInclusions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMooreProbability)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGBSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownJ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMCIterations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRecrStates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRecIterations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTotalNucleons)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxNeighbourhood;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonRestart;
        private System.Windows.Forms.NumericUpDown numericUpDownWidth;
        private System.Windows.Forms.NumericUpDown numericUpDownHeight;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown numericUpDownNumberOfGrain;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label labelGBPer;
      private System.Windows.Forms.Button ImportFromFile;
      private System.Windows.Forms.Button saveToBmp;
      private System.Windows.Forms.Button SaveToTxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Inclusion;
        private System.Windows.Forms.NumericUpDown numericSizeOfInclusions;
        private System.Windows.Forms.NumericUpDown numericAmountOfInclusions;
        private System.Windows.Forms.ComboBox comboBoxTypeOfInclusion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown numericMooreProbability;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button SelectGrains;
        private System.Windows.Forms.ComboBox StrucutreType;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.NumericUpDown numericUpDownGBSize;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonGenerateGB;
        private System.Windows.Forms.Button buttonRemoveColors;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label GBL;
        private System.Windows.Forms.Label GB;
        private System.Windows.Forms.CheckBox checkBoxMC;
        private System.Windows.Forms.NumericUpDown numericUpDownJ;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numericUpDownMCIterations;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton radioButtonAny;
        private System.Windows.Forms.RadioButton radioButtonGB;
        private System.Windows.Forms.Button buttonRecrystallization;
        private System.Windows.Forms.NumericUpDown numericUpDownRecrStates;
        private System.Windows.Forms.ComboBox comboBoxNucleationType;
        private System.Windows.Forms.NumericUpDown numericUpDownRecIterations;
        private System.Windows.Forms.NumericUpDown numericUpDownTotalNucleons;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button buttonCalculateEnergy;
        private System.Windows.Forms.CheckBox checkBoxEnergy;
    }
}

