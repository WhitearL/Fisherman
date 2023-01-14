namespace WowFishingAssist
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pbViewPane = new System.Windows.Forms.PictureBox();
            this.buStartStop = new System.Windows.Forms.Button();
            this.buApplySettings = new System.Windows.Forms.Button();
            this.rbGreyScaleFilter = new System.Windows.Forms.RadioButton();
            this.rbBlueFilter = new System.Windows.Forms.RadioButton();
            this.rbGreenFilter = new System.Windows.Forms.RadioButton();
            this.rbRedFilter = new System.Windows.Forms.RadioButton();
            this.rbNoFiltering = new System.Windows.Forms.RadioButton();
            this.cbSellJunk = new System.Windows.Forms.CheckBox();
            this.lblCastCount = new System.Windows.Forms.Label();
            this.titleCastCount = new System.Windows.Forms.Label();
            this.lblLureStatus = new System.Windows.Forms.Label();
            this.titleLureStatus = new System.Windows.Forms.Label();
            this.cbUseBait = new System.Windows.Forms.CheckBox();
            this.titleMaxBobClickTime = new System.Windows.Forms.Label();
            this.titleMinBobClickTime = new System.Windows.Forms.Label();
            this.numMaxBobClickTime = new System.Windows.Forms.NumericUpDown();
            this.numMinBobClickTime = new System.Windows.Forms.NumericUpDown();
            this.cbSuppressNoise = new System.Windows.Forms.CheckBox();
            this.numMsPerBackgroupUpdate = new System.Windows.Forms.NumericUpDown();
            this.numPerBackgroundUpdate = new System.Windows.Forms.NumericUpDown();
            this.numCastsBeforeSell = new System.Windows.Forms.NumericUpDown();
            this.numDifferenceThreshold = new System.Windows.Forms.NumericUpDown();
            this.titleCastsBeforeSell = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numTimeToHoldClick = new System.Windows.Forms.NumericUpDown();
            this.titleMillisecondsPerBackgroundUpdate = new System.Windows.Forms.Label();
            this.titleTimeToHoldClick = new System.Windows.Forms.Label();
            this.titleFramesPerBackgroundUpdate = new System.Windows.Forms.Label();
            this.titleDifferenceThreshold = new System.Windows.Forms.Label();
            this.titleDetectionSettings = new System.Windows.Forms.Label();
            this.titleCurrentCastsBeforeSell = new System.Windows.Forms.Label();
            this.lblCurrentCastsBeforeSell = new System.Windows.Forms.Label();
            this.titleSystemMetrics = new System.Windows.Forms.Label();
            this.titleSystemSettings = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbViewPane)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxBobClickTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinBobClickTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMsPerBackgroupUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPerBackgroundUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCastsBeforeSell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDifferenceThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeToHoldClick)).BeginInit();
            this.SuspendLayout();
            // 
            // pbViewPane
            // 
            this.pbViewPane.Location = new System.Drawing.Point(58, 12);
            this.pbViewPane.Name = "pbViewPane";
            this.pbViewPane.Size = new System.Drawing.Size(419, 229);
            this.pbViewPane.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbViewPane.TabIndex = 0;
            this.pbViewPane.TabStop = false;
            // 
            // buStartStop
            // 
            this.buStartStop.Location = new System.Drawing.Point(275, 440);
            this.buStartStop.Name = "buStartStop";
            this.buStartStop.Size = new System.Drawing.Size(241, 31);
            this.buStartStop.TabIndex = 1;
            this.buStartStop.Text = "Start";
            this.buStartStop.UseVisualStyleBackColor = true;
            this.buStartStop.Click += new System.EventHandler(this.buStartStop_Click);
            // 
            // buApplySettings
            // 
            this.buApplySettings.Location = new System.Drawing.Point(13, 440);
            this.buApplySettings.Name = "buApplySettings";
            this.buApplySettings.Size = new System.Drawing.Size(242, 31);
            this.buApplySettings.TabIndex = 10;
            this.buApplySettings.Text = "Apply Settings";
            this.buApplySettings.UseVisualStyleBackColor = true;
            this.buApplySettings.Click += new System.EventHandler(this.buApplySettings_Click);
            // 
            // rbGreyScaleFilter
            // 
            this.rbGreyScaleFilter.AutoSize = true;
            this.rbGreyScaleFilter.Location = new System.Drawing.Point(425, 373);
            this.rbGreyScaleFilter.Name = "rbGreyScaleFilter";
            this.rbGreyScaleFilter.Size = new System.Drawing.Size(77, 17);
            this.rbGreyScaleFilter.TabIndex = 4;
            this.rbGreyScaleFilter.TabStop = true;
            this.rbGreyScaleFilter.Text = "Grey Scale";
            this.rbGreyScaleFilter.UseVisualStyleBackColor = true;
            // 
            // rbBlueFilter
            // 
            this.rbBlueFilter.AutoSize = true;
            this.rbBlueFilter.Location = new System.Drawing.Point(425, 350);
            this.rbBlueFilter.Name = "rbBlueFilter";
            this.rbBlueFilter.Size = new System.Drawing.Size(88, 17);
            this.rbBlueFilter.TabIndex = 3;
            this.rbBlueFilter.TabStop = true;
            this.rbBlueFilter.Text = "Blue Channel";
            this.rbBlueFilter.UseVisualStyleBackColor = true;
            // 
            // rbGreenFilter
            // 
            this.rbGreenFilter.AutoSize = true;
            this.rbGreenFilter.Location = new System.Drawing.Point(425, 326);
            this.rbGreenFilter.Name = "rbGreenFilter";
            this.rbGreenFilter.Size = new System.Drawing.Size(96, 17);
            this.rbGreenFilter.TabIndex = 2;
            this.rbGreenFilter.TabStop = true;
            this.rbGreenFilter.Text = "Green Channel";
            this.rbGreenFilter.UseVisualStyleBackColor = true;
            // 
            // rbRedFilter
            // 
            this.rbRedFilter.AutoSize = true;
            this.rbRedFilter.Location = new System.Drawing.Point(425, 302);
            this.rbRedFilter.Name = "rbRedFilter";
            this.rbRedFilter.Size = new System.Drawing.Size(87, 17);
            this.rbRedFilter.TabIndex = 1;
            this.rbRedFilter.TabStop = true;
            this.rbRedFilter.Text = "Red Channel";
            this.rbRedFilter.UseVisualStyleBackColor = true;
            // 
            // rbNoFiltering
            // 
            this.rbNoFiltering.AutoSize = true;
            this.rbNoFiltering.Checked = true;
            this.rbNoFiltering.Location = new System.Drawing.Point(425, 278);
            this.rbNoFiltering.Name = "rbNoFiltering";
            this.rbNoFiltering.Size = new System.Drawing.Size(68, 17);
            this.rbNoFiltering.TabIndex = 0;
            this.rbNoFiltering.TabStop = true;
            this.rbNoFiltering.Text = "Full Color";
            this.rbNoFiltering.UseVisualStyleBackColor = true;
            // 
            // cbSellJunk
            // 
            this.cbSellJunk.AutoSize = true;
            this.cbSellJunk.Location = new System.Drawing.Point(281, 385);
            this.cbSellJunk.Name = "cbSellJunk";
            this.cbSellJunk.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbSellJunk.Size = new System.Drawing.Size(66, 17);
            this.cbSellJunk.TabIndex = 18;
            this.cbSellJunk.Text = "Sell junk";
            this.cbSellJunk.UseVisualStyleBackColor = true;
            // 
            // lblCastCount
            // 
            this.lblCastCount.AutoEllipsis = true;
            this.lblCastCount.Location = new System.Drawing.Point(347, 276);
            this.lblCastCount.Name = "lblCastCount";
            this.lblCastCount.Size = new System.Drawing.Size(52, 18);
            this.lblCastCount.TabIndex = 24;
            this.lblCastCount.Text = "0";
            this.lblCastCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // titleCastCount
            // 
            this.titleCastCount.AutoSize = true;
            this.titleCastCount.Location = new System.Drawing.Point(282, 279);
            this.titleCastCount.Name = "titleCastCount";
            this.titleCastCount.Size = new System.Drawing.Size(62, 13);
            this.titleCastCount.TabIndex = 25;
            this.titleCastCount.Text = "Cast Count:";
            this.titleCastCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLureStatus
            // 
            this.lblLureStatus.AutoEllipsis = true;
            this.lblLureStatus.AutoSize = true;
            this.lblLureStatus.Location = new System.Drawing.Point(347, 323);
            this.lblLureStatus.Name = "lblLureStatus";
            this.lblLureStatus.Size = new System.Drawing.Size(69, 13);
            this.lblLureStatus.TabIndex = 26;
            this.lblLureStatus.Text = "Lure Inactive";
            this.lblLureStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // titleLureStatus
            // 
            this.titleLureStatus.AutoSize = true;
            this.titleLureStatus.Location = new System.Drawing.Point(282, 323);
            this.titleLureStatus.Name = "titleLureStatus";
            this.titleLureStatus.Size = new System.Drawing.Size(62, 13);
            this.titleLureStatus.TabIndex = 27;
            this.titleLureStatus.Text = "Lure status:";
            this.titleLureStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbUseBait
            // 
            this.cbUseBait.AutoSize = true;
            this.cbUseBait.Location = new System.Drawing.Point(281, 406);
            this.cbUseBait.Name = "cbUseBait";
            this.cbUseBait.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbUseBait.Size = new System.Drawing.Size(66, 17);
            this.cbUseBait.TabIndex = 33;
            this.cbUseBait.Text = "Use Bait";
            this.cbUseBait.UseVisualStyleBackColor = true;
            this.cbUseBait.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // titleMaxBobClickTime
            // 
            this.titleMaxBobClickTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleMaxBobClickTime.AutoSize = true;
            this.titleMaxBobClickTime.Location = new System.Drawing.Point(13, 361);
            this.titleMaxBobClickTime.Name = "titleMaxBobClickTime";
            this.titleMaxBobClickTime.Size = new System.Drawing.Size(140, 13);
            this.titleMaxBobClickTime.TabIndex = 22;
            this.titleMaxBobClickTime.Text = "Maximum Bobber Click Time";
            this.titleMaxBobClickTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // titleMinBobClickTime
            // 
            this.titleMinBobClickTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleMinBobClickTime.AutoSize = true;
            this.titleMinBobClickTime.Location = new System.Drawing.Point(13, 341);
            this.titleMinBobClickTime.Name = "titleMinBobClickTime";
            this.titleMinBobClickTime.Size = new System.Drawing.Size(137, 13);
            this.titleMinBobClickTime.TabIndex = 21;
            this.titleMinBobClickTime.Text = "Minimum Bobber Click Time";
            this.titleMinBobClickTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numMaxBobClickTime
            // 
            this.numMaxBobClickTime.Location = new System.Drawing.Point(206, 357);
            this.numMaxBobClickTime.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numMaxBobClickTime.Name = "numMaxBobClickTime";
            this.numMaxBobClickTime.Size = new System.Drawing.Size(49, 20);
            this.numMaxBobClickTime.TabIndex = 20;
            this.numMaxBobClickTime.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numMaxBobClickTime.ValueChanged += new System.EventHandler(this.numMaxBobClickTime_ValueChanged);
            // 
            // numMinBobClickTime
            // 
            this.numMinBobClickTime.Location = new System.Drawing.Point(206, 337);
            this.numMinBobClickTime.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numMinBobClickTime.Name = "numMinBobClickTime";
            this.numMinBobClickTime.Size = new System.Drawing.Size(49, 20);
            this.numMinBobClickTime.TabIndex = 19;
            this.numMinBobClickTime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMinBobClickTime.ValueChanged += new System.EventHandler(this.numMinBobClickTime_ValueChanged);
            // 
            // cbSuppressNoise
            // 
            this.cbSuppressNoise.AutoSize = true;
            this.cbSuppressNoise.Checked = true;
            this.cbSuppressNoise.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSuppressNoise.Location = new System.Drawing.Point(223, 420);
            this.cbSuppressNoise.Name = "cbSuppressNoise";
            this.cbSuppressNoise.Size = new System.Drawing.Size(15, 14);
            this.cbSuppressNoise.TabIndex = 9;
            this.cbSuppressNoise.UseVisualStyleBackColor = true;
            // 
            // numMsPerBackgroupUpdate
            // 
            this.numMsPerBackgroupUpdate.Location = new System.Drawing.Point(206, 317);
            this.numMsPerBackgroupUpdate.Name = "numMsPerBackgroupUpdate";
            this.numMsPerBackgroupUpdate.Size = new System.Drawing.Size(49, 20);
            this.numMsPerBackgroupUpdate.TabIndex = 8;
            this.numMsPerBackgroupUpdate.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numPerBackgroundUpdate
            // 
            this.numPerBackgroundUpdate.Location = new System.Drawing.Point(206, 297);
            this.numPerBackgroundUpdate.Name = "numPerBackgroundUpdate";
            this.numPerBackgroundUpdate.Size = new System.Drawing.Size(49, 20);
            this.numPerBackgroundUpdate.TabIndex = 7;
            this.numPerBackgroundUpdate.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numCastsBeforeSell
            // 
            this.numCastsBeforeSell.Location = new System.Drawing.Point(206, 397);
            this.numCastsBeforeSell.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numCastsBeforeSell.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numCastsBeforeSell.Name = "numCastsBeforeSell";
            this.numCastsBeforeSell.Size = new System.Drawing.Size(49, 20);
            this.numCastsBeforeSell.TabIndex = 28;
            this.numCastsBeforeSell.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.numCastsBeforeSell.ValueChanged += new System.EventHandler(this.numCastsBeforeSell_ValueChanged);
            // 
            // numDifferenceThreshold
            // 
            this.numDifferenceThreshold.Location = new System.Drawing.Point(206, 277);
            this.numDifferenceThreshold.Name = "numDifferenceThreshold";
            this.numDifferenceThreshold.Size = new System.Drawing.Size(49, 20);
            this.numDifferenceThreshold.TabIndex = 6;
            this.numDifferenceThreshold.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // titleCastsBeforeSell
            // 
            this.titleCastsBeforeSell.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleCastsBeforeSell.AutoSize = true;
            this.titleCastsBeforeSell.Location = new System.Drawing.Point(13, 401);
            this.titleCastsBeforeSell.Name = "titleCastsBeforeSell";
            this.titleCastsBeforeSell.Size = new System.Drawing.Size(105, 13);
            this.titleCastsBeforeSell.TabIndex = 29;
            this.titleCastsBeforeSell.Text = "Sell Junk Cast Count";
            this.titleCastsBeforeSell.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 421);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "SuppressNoise";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numTimeToHoldClick
            // 
            this.numTimeToHoldClick.Location = new System.Drawing.Point(206, 377);
            this.numTimeToHoldClick.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numTimeToHoldClick.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numTimeToHoldClick.Name = "numTimeToHoldClick";
            this.numTimeToHoldClick.Size = new System.Drawing.Size(49, 20);
            this.numTimeToHoldClick.TabIndex = 30;
            this.numTimeToHoldClick.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // titleMillisecondsPerBackgroundUpdate
            // 
            this.titleMillisecondsPerBackgroundUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleMillisecondsPerBackgroundUpdate.AutoSize = true;
            this.titleMillisecondsPerBackgroundUpdate.Location = new System.Drawing.Point(13, 321);
            this.titleMillisecondsPerBackgroundUpdate.Name = "titleMillisecondsPerBackgroundUpdate";
            this.titleMillisecondsPerBackgroundUpdate.Size = new System.Drawing.Size(178, 13);
            this.titleMillisecondsPerBackgroundUpdate.TabIndex = 4;
            this.titleMillisecondsPerBackgroundUpdate.Text = "Milliseconds per background update";
            this.titleMillisecondsPerBackgroundUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // titleTimeToHoldClick
            // 
            this.titleTimeToHoldClick.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleTimeToHoldClick.AutoSize = true;
            this.titleTimeToHoldClick.Location = new System.Drawing.Point(13, 381);
            this.titleTimeToHoldClick.Name = "titleTimeToHoldClick";
            this.titleTimeToHoldClick.Size = new System.Drawing.Size(128, 13);
            this.titleTimeToHoldClick.TabIndex = 31;
            this.titleTimeToHoldClick.Text = "Time to Hold Mouse Click";
            this.titleTimeToHoldClick.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // titleFramesPerBackgroundUpdate
            // 
            this.titleFramesPerBackgroundUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleFramesPerBackgroundUpdate.AutoSize = true;
            this.titleFramesPerBackgroundUpdate.Location = new System.Drawing.Point(13, 301);
            this.titleFramesPerBackgroundUpdate.Name = "titleFramesPerBackgroundUpdate";
            this.titleFramesPerBackgroundUpdate.Size = new System.Drawing.Size(155, 13);
            this.titleFramesPerBackgroundUpdate.TabIndex = 3;
            this.titleFramesPerBackgroundUpdate.Text = "Frames per background update";
            this.titleFramesPerBackgroundUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // titleDifferenceThreshold
            // 
            this.titleDifferenceThreshold.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleDifferenceThreshold.AutoSize = true;
            this.titleDifferenceThreshold.Location = new System.Drawing.Point(13, 281);
            this.titleDifferenceThreshold.Name = "titleDifferenceThreshold";
            this.titleDifferenceThreshold.Size = new System.Drawing.Size(106, 13);
            this.titleDifferenceThreshold.TabIndex = 2;
            this.titleDifferenceThreshold.Text = "Difference Threshold";
            this.titleDifferenceThreshold.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // titleDetectionSettings
            // 
            this.titleDetectionSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleDetectionSettings.AutoSize = true;
            this.titleDetectionSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleDetectionSettings.Location = new System.Drawing.Point(12, 254);
            this.titleDetectionSettings.Name = "titleDetectionSettings";
            this.titleDetectionSettings.Size = new System.Drawing.Size(141, 20);
            this.titleDetectionSettings.TabIndex = 35;
            this.titleDetectionSettings.Text = "Detection Settings";
            this.titleDetectionSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // titleCurrentCastsBeforeSell
            // 
            this.titleCurrentCastsBeforeSell.AutoSize = true;
            this.titleCurrentCastsBeforeSell.Location = new System.Drawing.Point(282, 302);
            this.titleCurrentCastsBeforeSell.Name = "titleCurrentCastsBeforeSell";
            this.titleCurrentCastsBeforeSell.Size = new System.Drawing.Size(66, 13);
            this.titleCurrentCastsBeforeSell.TabIndex = 36;
            this.titleCurrentCastsBeforeSell.Text = "Junk sold in:";
            this.titleCurrentCastsBeforeSell.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCurrentCastsBeforeSell
            // 
            this.lblCurrentCastsBeforeSell.AutoEllipsis = true;
            this.lblCurrentCastsBeforeSell.Location = new System.Drawing.Point(347, 299);
            this.lblCurrentCastsBeforeSell.Name = "lblCurrentCastsBeforeSell";
            this.lblCurrentCastsBeforeSell.Size = new System.Drawing.Size(52, 18);
            this.lblCurrentCastsBeforeSell.TabIndex = 37;
            this.lblCurrentCastsBeforeSell.Text = "0";
            this.lblCurrentCastsBeforeSell.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // titleSystemMetrics
            // 
            this.titleSystemMetrics.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleSystemMetrics.AutoSize = true;
            this.titleSystemMetrics.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleSystemMetrics.Location = new System.Drawing.Point(281, 254);
            this.titleSystemMetrics.Name = "titleSystemMetrics";
            this.titleSystemMetrics.Size = new System.Drawing.Size(117, 20);
            this.titleSystemMetrics.TabIndex = 38;
            this.titleSystemMetrics.Text = "System Metrics";
            this.titleSystemMetrics.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // titleSystemSettings
            // 
            this.titleSystemSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleSystemSettings.AutoSize = true;
            this.titleSystemSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleSystemSettings.Location = new System.Drawing.Point(281, 361);
            this.titleSystemSettings.Name = "titleSystemSettings";
            this.titleSystemSettings.Size = new System.Drawing.Size(125, 20);
            this.titleSystemSettings.TabIndex = 39;
            this.titleSystemSettings.Text = "System Settings";
            this.titleSystemSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(421, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 40;
            this.label1.Text = "Colour Filters";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 486);
            this.Controls.Add(this.rbGreyScaleFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbBlueFilter);
            this.Controls.Add(this.titleSystemSettings);
            this.Controls.Add(this.rbGreenFilter);
            this.Controls.Add(this.cbUseBait);
            this.Controls.Add(this.rbRedFilter);
            this.Controls.Add(this.titleSystemMetrics);
            this.Controls.Add(this.rbNoFiltering);
            this.Controls.Add(this.lblCurrentCastsBeforeSell);
            this.Controls.Add(this.titleCurrentCastsBeforeSell);
            this.Controls.Add(this.numDifferenceThreshold);
            this.Controls.Add(this.numPerBackgroundUpdate);
            this.Controls.Add(this.numMinBobClickTime);
            this.Controls.Add(this.numMsPerBackgroupUpdate);
            this.Controls.Add(this.numMaxBobClickTime);
            this.Controls.Add(this.numTimeToHoldClick);
            this.Controls.Add(this.numCastsBeforeSell);
            this.Controls.Add(this.titleDetectionSettings);
            this.Controls.Add(this.titleFramesPerBackgroundUpdate);
            this.Controls.Add(this.cbSuppressNoise);
            this.Controls.Add(this.titleLureStatus);
            this.Controls.Add(this.lblLureStatus);
            this.Controls.Add(this.titleMillisecondsPerBackgroundUpdate);
            this.Controls.Add(this.titleCastCount);
            this.Controls.Add(this.titleMaxBobClickTime);
            this.Controls.Add(this.lblCastCount);
            this.Controls.Add(this.titleCastsBeforeSell);
            this.Controls.Add(this.cbSellJunk);
            this.Controls.Add(this.titleTimeToHoldClick);
            this.Controls.Add(this.titleMinBobClickTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buApplySettings);
            this.Controls.Add(this.titleDifferenceThreshold);
            this.Controls.Add(this.buStartStop);
            this.Controls.Add(this.pbViewPane);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(551, 525);
            this.MinimumSize = new System.Drawing.Size(551, 525);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Fisherman";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbViewPane)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxBobClickTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinBobClickTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMsPerBackgroupUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPerBackgroundUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCastsBeforeSell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDifferenceThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeToHoldClick)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbViewPane;
        private System.Windows.Forms.Button buStartStop;
        private System.Windows.Forms.Button buApplySettings;
        private System.Windows.Forms.RadioButton rbBlueFilter;
        private System.Windows.Forms.RadioButton rbGreenFilter;
        private System.Windows.Forms.RadioButton rbRedFilter;
        private System.Windows.Forms.RadioButton rbNoFiltering;
        private System.Windows.Forms.RadioButton rbGreyScaleFilter;
        private System.Windows.Forms.CheckBox cbSellJunk;
        private System.Windows.Forms.Label lblCastCount;
        private System.Windows.Forms.Label titleCastCount;
        private System.Windows.Forms.Label lblLureStatus;
        private System.Windows.Forms.Label titleLureStatus;
        private System.Windows.Forms.CheckBox cbUseBait;
        private System.Windows.Forms.Label titleMaxBobClickTime;
        private System.Windows.Forms.Label titleMinBobClickTime;
        private System.Windows.Forms.NumericUpDown numMaxBobClickTime;
        private System.Windows.Forms.NumericUpDown numMinBobClickTime;
        private System.Windows.Forms.CheckBox cbSuppressNoise;
        private System.Windows.Forms.NumericUpDown numMsPerBackgroupUpdate;
        private System.Windows.Forms.NumericUpDown numPerBackgroundUpdate;
        private System.Windows.Forms.NumericUpDown numCastsBeforeSell;
        private System.Windows.Forms.NumericUpDown numDifferenceThreshold;
        private System.Windows.Forms.Label titleCastsBeforeSell;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numTimeToHoldClick;
        private System.Windows.Forms.Label titleMillisecondsPerBackgroundUpdate;
        private System.Windows.Forms.Label titleTimeToHoldClick;
        private System.Windows.Forms.Label titleFramesPerBackgroundUpdate;
        private System.Windows.Forms.Label titleDifferenceThreshold;
        private System.Windows.Forms.Label titleDetectionSettings;
        private System.Windows.Forms.Label titleCurrentCastsBeforeSell;
        private System.Windows.Forms.Label lblCurrentCastsBeforeSell;
        private System.Windows.Forms.Label titleSystemMetrics;
        private System.Windows.Forms.Label titleSystemSettings;
        private System.Windows.Forms.Label label1;
    }
}

