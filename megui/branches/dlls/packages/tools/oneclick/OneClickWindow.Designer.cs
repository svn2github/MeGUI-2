namespace MeGUI
{
    partial class OneClickWindow
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.locationGroupBox = new System.Windows.Forms.GroupBox();
            this.chapterFile = new MeGUI.FileBar();
            this.workingDirectory = new MeGUI.FileBar();
            this.chapterLabel = new System.Windows.Forms.Label();
            this.workingDirectoryLabel = new System.Windows.Forms.Label();
            this.workingName = new System.Windows.Forms.TextBox();
            this.projectNameLabel = new System.Windows.Forms.Label();
            this.avsBox = new System.Windows.Forms.GroupBox();
            this.profileControl1 = new MeGUI.core.details.video.ProfileControl();
            this.autoDeint = new System.Windows.Forms.CheckBox();
            this.signalAR = new System.Windows.Forms.CheckBox();
            this.AR = new System.Windows.Forms.TextBox();
            this.outputResolutionLabel = new System.Windows.Forms.Label();
            this.horizontalResolution = new System.Windows.Forms.NumericUpDown();
            this.arComboBox = new System.Windows.Forms.ComboBox();
            this.ARLabel = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.IOGroupbox = new System.Windows.Forms.GroupBox();
            this.output = new MeGUI.FileBar();
            this.input = new MeGUI.FileBar();
            this.outputLabel = new System.Windows.Forms.Label();
            this.inputLabel = new System.Windows.Forms.Label();
            this.targetGroupBox = new System.Windows.Forms.GroupBox();
            this.filesizeKB = new System.Windows.Forms.TextBox();
            this.inKBLabel = new System.Windows.Forms.Label();
            this.filesizeComboBox = new System.Windows.Forms.ComboBox();
            this.filesizeLabel = new System.Windows.Forms.Label();
            this.audioGroupbox = new System.Windows.Forms.GroupBox();
            this.clearAudio2Button = new System.Windows.Forms.Button();
            this.clearAudio1Button = new System.Windows.Forms.Button();
            this.track2Label = new System.Windows.Forms.Label();
            this.track1Label = new System.Windows.Forms.Label();
            this.track2 = new System.Windows.Forms.ComboBox();
            this.track1 = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.encoderConfigTab = new System.Windows.Forms.TabPage();
            this.audioIOGroupBox = new System.Windows.Forms.GroupBox();
            this.audioProfileControl = new MeGUI.core.details.video.ProfileControl();
            this.externalInput = new System.Windows.Forms.CheckBox();
            this.audioCodecLabel = new System.Windows.Forms.Label();
            this.dontEncodeAudio = new System.Windows.Forms.CheckBox();
            this.audioInput = new System.Windows.Forms.TextBox();
            this.audioInputOpenButton = new System.Windows.Forms.Button();
            this.audioTrack2 = new System.Windows.Forms.RadioButton();
            this.audioTrack1 = new System.Windows.Forms.RadioButton();
            this.deleteAudioButton = new System.Windows.Forms.Button();
            this.audioCodec = new System.Windows.Forms.ComboBox();
            this.videoGroupBox = new System.Windows.Forms.GroupBox();
            this.videoProfileControl = new MeGUI.core.details.video.ProfileControl();
            this.addPrerenderJob = new System.Windows.Forms.CheckBox();
            this.videoCodecLabel = new System.Windows.Forms.Label();
            this.videoCodec = new System.Windows.Forms.ComboBox();
            this.splitOutput = new System.Windows.Forms.CheckBox();
            this.splitSize = new System.Windows.Forms.TextBox();
            this.containerFormatLabel = new System.Windows.Forms.Label();
            this.containerFormat = new System.Windows.Forms.ComboBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.showAdvancedOptions = new System.Windows.Forms.CheckBox();
            this.shutdownCheckBox = new System.Windows.Forms.CheckBox();
            this.goButton = new System.Windows.Forms.Button();
            this.profileControl2 = new MeGUI.core.details.video.ProfileControl();
            this.tabPage2.SuspendLayout();
            this.locationGroupBox.SuspendLayout();
            this.avsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.horizontalResolution)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.IOGroupbox.SuspendLayout();
            this.targetGroupBox.SuspendLayout();
            this.audioGroupbox.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.encoderConfigTab.SuspendLayout();
            this.audioIOGroupBox.SuspendLayout();
            this.videoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.locationGroupBox);
            this.tabPage2.Controls.Add(this.avsBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(440, 252);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Advanced Config";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // locationGroupBox
            // 
            this.locationGroupBox.Controls.Add(this.chapterFile);
            this.locationGroupBox.Controls.Add(this.workingDirectory);
            this.locationGroupBox.Controls.Add(this.chapterLabel);
            this.locationGroupBox.Controls.Add(this.workingDirectoryLabel);
            this.locationGroupBox.Controls.Add(this.workingName);
            this.locationGroupBox.Controls.Add(this.projectNameLabel);
            this.locationGroupBox.Location = new System.Drawing.Point(8, 6);
            this.locationGroupBox.Name = "locationGroupBox";
            this.locationGroupBox.Size = new System.Drawing.Size(424, 95);
            this.locationGroupBox.TabIndex = 23;
            this.locationGroupBox.TabStop = false;
            this.locationGroupBox.Text = "Extra IO";
            // 
            // chapterFile
            // 
            this.chapterFile.Filename = "";
            this.chapterFile.Filter = "Chapter files (*.txt)|*.txt";
            this.chapterFile.FolderMode = false;
            this.chapterFile.Location = new System.Drawing.Point(120, 38);
            this.chapterFile.Name = "chapterFile";
            this.chapterFile.ReadOnly = true;
            this.chapterFile.SaveMode = false;
            this.chapterFile.Size = new System.Drawing.Size(288, 26);
            this.chapterFile.TabIndex = 39;
            this.chapterFile.Title = null;
            // 
            // workingDirectory
            // 
            this.workingDirectory.Filename = "";
            this.workingDirectory.Filter = null;
            this.workingDirectory.FolderMode = true;
            this.workingDirectory.Location = new System.Drawing.Point(120, 8);
            this.workingDirectory.Name = "workingDirectory";
            this.workingDirectory.ReadOnly = true;
            this.workingDirectory.SaveMode = false;
            this.workingDirectory.Size = new System.Drawing.Size(288, 26);
            this.workingDirectory.TabIndex = 38;
            this.workingDirectory.Title = null;
            this.workingDirectory.FileSelected += new MeGUI.FileBarEventHandler(this.workingDirectory_FileSelected);
            // 
            // chapterLabel
            // 
            this.chapterLabel.Location = new System.Drawing.Point(16, 41);
            this.chapterLabel.Name = "chapterLabel";
            this.chapterLabel.Size = new System.Drawing.Size(100, 13);
            this.chapterLabel.TabIndex = 36;
            this.chapterLabel.Text = "Chapter file";
            // 
            // workingDirectoryLabel
            // 
            this.workingDirectoryLabel.Location = new System.Drawing.Point(16, 15);
            this.workingDirectoryLabel.Name = "workingDirectoryLabel";
            this.workingDirectoryLabel.Size = new System.Drawing.Size(100, 13);
            this.workingDirectoryLabel.TabIndex = 32;
            this.workingDirectoryLabel.Text = "Working Directory";
            // 
            // workingName
            // 
            this.workingName.Location = new System.Drawing.Point(120, 64);
            this.workingName.Name = "workingName";
            this.workingName.Size = new System.Drawing.Size(288, 20);
            this.workingName.TabIndex = 30;
            this.workingName.TextChanged += new System.EventHandler(this.workingName_TextChanged);
            // 
            // projectNameLabel
            // 
            this.projectNameLabel.Location = new System.Drawing.Point(16, 67);
            this.projectNameLabel.Name = "projectNameLabel";
            this.projectNameLabel.Size = new System.Drawing.Size(73, 16);
            this.projectNameLabel.TabIndex = 31;
            this.projectNameLabel.Text = "Project Name";
            // 
            // avsBox
            // 
            this.avsBox.Controls.Add(this.profileControl1);
            this.avsBox.Controls.Add(this.autoDeint);
            this.avsBox.Controls.Add(this.signalAR);
            this.avsBox.Controls.Add(this.AR);
            this.avsBox.Controls.Add(this.outputResolutionLabel);
            this.avsBox.Controls.Add(this.horizontalResolution);
            this.avsBox.Controls.Add(this.arComboBox);
            this.avsBox.Controls.Add(this.ARLabel);
            this.avsBox.Location = new System.Drawing.Point(8, 107);
            this.avsBox.Name = "avsBox";
            this.avsBox.Size = new System.Drawing.Size(424, 124);
            this.avsBox.TabIndex = 23;
            this.avsBox.TabStop = false;
            this.avsBox.Text = "AviSynth setup";
            // 
            // profileControl1
            // 
            this.profileControl1.LabelText = "AVS profile";
            this.profileControl1.Location = new System.Drawing.Point(19, 69);
            this.profileControl1.Name = "profileControl1";
            this.profileControl1.Size = new System.Drawing.Size(389, 29);
            this.profileControl1.TabIndex = 21;
            // 
            // autoDeint
            // 
            this.autoDeint.AutoSize = true;
            this.autoDeint.Location = new System.Drawing.Point(123, 101);
            this.autoDeint.Name = "autoDeint";
            this.autoDeint.Size = new System.Drawing.Size(138, 17);
            this.autoDeint.TabIndex = 20;
            this.autoDeint.Text = "Automatic Deinterlacing";
            this.autoDeint.UseVisualStyleBackColor = true;
            // 
            // signalAR
            // 
            this.signalAR.Location = new System.Drawing.Point(270, 43);
            this.signalAR.Name = "signalAR";
            this.signalAR.Size = new System.Drawing.Size(82, 24);
            this.signalAR.TabIndex = 5;
            this.signalAR.Text = "Signal AR";
            // 
            // AR
            // 
            this.AR.Location = new System.Drawing.Point(224, 43);
            this.AR.Name = "AR";
            this.AR.ReadOnly = true;
            this.AR.Size = new System.Drawing.Size(40, 20);
            this.AR.TabIndex = 2;
            this.AR.Text = "1.778";
            // 
            // outputResolutionLabel
            // 
            this.outputResolutionLabel.Location = new System.Drawing.Point(16, 20);
            this.outputResolutionLabel.Name = "outputResolutionLabel";
            this.outputResolutionLabel.Size = new System.Drawing.Size(100, 13);
            this.outputResolutionLabel.TabIndex = 3;
            this.outputResolutionLabel.Text = "Output Resolution";
            // 
            // horizontalResolution
            // 
            this.horizontalResolution.Increment = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.horizontalResolution.Location = new System.Drawing.Point(120, 16);
            this.horizontalResolution.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.horizontalResolution.Minimum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.horizontalResolution.Name = "horizontalResolution";
            this.horizontalResolution.Size = new System.Drawing.Size(64, 20);
            this.horizontalResolution.TabIndex = 0;
            this.horizontalResolution.Value = new decimal(new int[] {
            640,
            0,
            0,
            0});
            // 
            // arComboBox
            // 
            this.arComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.arComboBox.Items.AddRange(new object[] {
            "ITU 16:9",
            "ITU 4:3",
            "1:1",
            "Custom",
            "Auto-detect later"});
            this.arComboBox.Location = new System.Drawing.Point(224, 16);
            this.arComboBox.Name = "arComboBox";
            this.arComboBox.Size = new System.Drawing.Size(161, 21);
            this.arComboBox.TabIndex = 1;
            this.arComboBox.SelectedIndexChanged += new System.EventHandler(this.arComboBox_SelectedIndexChanged);
            // 
            // ARLabel
            // 
            this.ARLabel.Location = new System.Drawing.Point(192, 20);
            this.ARLabel.Name = "ARLabel";
            this.ARLabel.Size = new System.Drawing.Size(24, 13);
            this.ARLabel.TabIndex = 4;
            this.ARLabel.Text = "AR:";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.IOGroupbox);
            this.tabPage1.Controls.Add(this.targetGroupBox);
            this.tabPage1.Controls.Add(this.audioGroupbox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(440, 252);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Basic IO";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // IOGroupbox
            // 
            this.IOGroupbox.Controls.Add(this.output);
            this.IOGroupbox.Controls.Add(this.input);
            this.IOGroupbox.Controls.Add(this.outputLabel);
            this.IOGroupbox.Controls.Add(this.inputLabel);
            this.IOGroupbox.Location = new System.Drawing.Point(8, 6);
            this.IOGroupbox.Name = "IOGroupbox";
            this.IOGroupbox.Size = new System.Drawing.Size(424, 76);
            this.IOGroupbox.TabIndex = 14;
            this.IOGroupbox.TabStop = false;
            this.IOGroupbox.Text = "Input/Output";
            // 
            // output
            // 
            this.output.Filename = "";
            this.output.Filter = "MP4 Files|*.mp4";
            this.output.FolderMode = false;
            this.output.Location = new System.Drawing.Point(123, 42);
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.SaveMode = true;
            this.output.Size = new System.Drawing.Size(285, 26);
            this.output.TabIndex = 4;
            this.output.Title = null;
            this.output.FileSelected += new MeGUI.FileBarEventHandler(this.output_FileSelected);
            // 
            // input
            // 
            this.input.Filename = "";
            this.input.Filter = "VOB Files (*.vob)|*.vob|MPEG-1/2 Program Streams (*.mpg)|*.mpg|Transport Streams " +
                "(*.ts)|*.ts|All DGIndex supported files|*.vob;*.mpg;*.mpeg;*.m2v;*.mpv;*.tp;*.ts" +
                ";*.trp;*.pva;*.vro";
            this.input.FolderMode = false;
            this.input.Location = new System.Drawing.Point(123, 13);
            this.input.Name = "input";
            this.input.ReadOnly = true;
            this.input.SaveMode = false;
            this.input.Size = new System.Drawing.Size(285, 26);
            this.input.TabIndex = 3;
            this.input.Title = null;
            this.input.FileSelected += new MeGUI.FileBarEventHandler(this.input_FileSelected);
            // 
            // outputLabel
            // 
            this.outputLabel.Location = new System.Drawing.Point(16, 48);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(100, 13);
            this.outputLabel.TabIndex = 0;
            this.outputLabel.Text = "Output file";
            // 
            // inputLabel
            // 
            this.inputLabel.Location = new System.Drawing.Point(16, 22);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(100, 13);
            this.inputLabel.TabIndex = 2;
            this.inputLabel.Text = "Input file";
            // 
            // targetGroupBox
            // 
            this.targetGroupBox.Controls.Add(this.profileControl2);
            this.targetGroupBox.Controls.Add(this.filesizeKB);
            this.targetGroupBox.Controls.Add(this.inKBLabel);
            this.targetGroupBox.Controls.Add(this.filesizeComboBox);
            this.targetGroupBox.Controls.Add(this.filesizeLabel);
            this.targetGroupBox.Location = new System.Drawing.Point(6, 176);
            this.targetGroupBox.Name = "targetGroupBox";
            this.targetGroupBox.Size = new System.Drawing.Size(424, 71);
            this.targetGroupBox.TabIndex = 18;
            this.targetGroupBox.TabStop = false;
            this.targetGroupBox.Text = "Target";
            // 
            // filesizeKB
            // 
            this.filesizeKB.Location = new System.Drawing.Point(298, 41);
            this.filesizeKB.Name = "filesizeKB";
            this.filesizeKB.ReadOnly = true;
            this.filesizeKB.Size = new System.Drawing.Size(112, 20);
            this.filesizeKB.TabIndex = 20;
            // 
            // inKBLabel
            // 
            this.inKBLabel.Location = new System.Drawing.Point(242, 45);
            this.inKBLabel.Name = "inKBLabel";
            this.inKBLabel.Size = new System.Drawing.Size(50, 13);
            this.inKBLabel.TabIndex = 22;
            this.inKBLabel.Text = "In KB:";
            // 
            // filesizeComboBox
            // 
            this.filesizeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filesizeComboBox.Location = new System.Drawing.Point(125, 41);
            this.filesizeComboBox.Name = "filesizeComboBox";
            this.filesizeComboBox.Size = new System.Drawing.Size(111, 21);
            this.filesizeComboBox.TabIndex = 19;
            this.filesizeComboBox.SelectedIndexChanged += new System.EventHandler(this.filesizeComboBox_SelectedIndexChanged);
            // 
            // filesizeLabel
            // 
            this.filesizeLabel.Location = new System.Drawing.Point(18, 44);
            this.filesizeLabel.Name = "filesizeLabel";
            this.filesizeLabel.Size = new System.Drawing.Size(90, 13);
            this.filesizeLabel.TabIndex = 21;
            this.filesizeLabel.Text = "Filesize";
            // 
            // audioGroupbox
            // 
            this.audioGroupbox.Controls.Add(this.clearAudio2Button);
            this.audioGroupbox.Controls.Add(this.clearAudio1Button);
            this.audioGroupbox.Controls.Add(this.track2Label);
            this.audioGroupbox.Controls.Add(this.track1Label);
            this.audioGroupbox.Controls.Add(this.track2);
            this.audioGroupbox.Controls.Add(this.track1);
            this.audioGroupbox.Location = new System.Drawing.Point(6, 88);
            this.audioGroupbox.Name = "audioGroupbox";
            this.audioGroupbox.Size = new System.Drawing.Size(424, 82);
            this.audioGroupbox.TabIndex = 5;
            this.audioGroupbox.TabStop = false;
            this.audioGroupbox.Text = "Audio";
            // 
            // clearAudio2Button
            // 
            this.clearAudio2Button.Location = new System.Drawing.Point(386, 48);
            this.clearAudio2Button.Name = "clearAudio2Button";
            this.clearAudio2Button.Size = new System.Drawing.Size(24, 23);
            this.clearAudio2Button.TabIndex = 18;
            this.clearAudio2Button.Text = "X";
            this.clearAudio2Button.Click += new System.EventHandler(this.clearAudio2Button_Click);
            // 
            // clearAudio1Button
            // 
            this.clearAudio1Button.Location = new System.Drawing.Point(386, 24);
            this.clearAudio1Button.Name = "clearAudio1Button";
            this.clearAudio1Button.Size = new System.Drawing.Size(24, 23);
            this.clearAudio1Button.TabIndex = 17;
            this.clearAudio1Button.Text = "X";
            this.clearAudio1Button.Click += new System.EventHandler(this.clearAudio1Button_Click);
            // 
            // track2Label
            // 
            this.track2Label.Location = new System.Drawing.Point(18, 51);
            this.track2Label.Name = "track2Label";
            this.track2Label.Size = new System.Drawing.Size(72, 23);
            this.track2Label.TabIndex = 16;
            this.track2Label.Text = "Track 2";
            // 
            // track1Label
            // 
            this.track1Label.Location = new System.Drawing.Point(18, 27);
            this.track1Label.Name = "track1Label";
            this.track1Label.Size = new System.Drawing.Size(72, 23);
            this.track1Label.TabIndex = 15;
            this.track1Label.Text = "Track 1";
            // 
            // track2
            // 
            this.track2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.track2.Location = new System.Drawing.Point(125, 50);
            this.track2.Name = "track2";
            this.track2.Size = new System.Drawing.Size(253, 21);
            this.track2.TabIndex = 14;
            this.track2.SelectedIndexChanged += new System.EventHandler(this.track1_SelectedIndexChanged);
            // 
            // track1
            // 
            this.track1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.track1.Location = new System.Drawing.Point(125, 24);
            this.track1.Name = "track1";
            this.track1.Size = new System.Drawing.Size(253, 21);
            this.track1.TabIndex = 13;
            this.track1.SelectedIndexChanged += new System.EventHandler(this.track1_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.encoderConfigTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(448, 278);
            this.tabControl1.TabIndex = 0;
            // 
            // encoderConfigTab
            // 
            this.encoderConfigTab.Controls.Add(this.audioIOGroupBox);
            this.encoderConfigTab.Controls.Add(this.videoGroupBox);
            this.encoderConfigTab.Controls.Add(this.splitOutput);
            this.encoderConfigTab.Controls.Add(this.splitSize);
            this.encoderConfigTab.Controls.Add(this.containerFormatLabel);
            this.encoderConfigTab.Controls.Add(this.containerFormat);
            this.encoderConfigTab.Location = new System.Drawing.Point(4, 22);
            this.encoderConfigTab.Name = "encoderConfigTab";
            this.encoderConfigTab.Padding = new System.Windows.Forms.Padding(3);
            this.encoderConfigTab.Size = new System.Drawing.Size(440, 252);
            this.encoderConfigTab.TabIndex = 2;
            this.encoderConfigTab.Text = "Encoder Config";
            this.encoderConfigTab.UseVisualStyleBackColor = true;
            // 
            // audioIOGroupBox
            // 
            this.audioIOGroupBox.Controls.Add(this.audioProfileControl);
            this.audioIOGroupBox.Controls.Add(this.externalInput);
            this.audioIOGroupBox.Controls.Add(this.audioCodecLabel);
            this.audioIOGroupBox.Controls.Add(this.dontEncodeAudio);
            this.audioIOGroupBox.Controls.Add(this.audioInput);
            this.audioIOGroupBox.Controls.Add(this.audioInputOpenButton);
            this.audioIOGroupBox.Controls.Add(this.audioTrack2);
            this.audioIOGroupBox.Controls.Add(this.audioTrack1);
            this.audioIOGroupBox.Controls.Add(this.deleteAudioButton);
            this.audioIOGroupBox.Controls.Add(this.audioCodec);
            this.audioIOGroupBox.Location = new System.Drawing.Point(6, 89);
            this.audioIOGroupBox.Name = "audioIOGroupBox";
            this.audioIOGroupBox.Size = new System.Drawing.Size(426, 104);
            this.audioIOGroupBox.TabIndex = 32;
            this.audioIOGroupBox.TabStop = false;
            this.audioIOGroupBox.Text = "Audio";
            // 
            // audioProfileControl
            // 
            this.audioProfileControl.LabelText = "Audio Profile";
            this.audioProfileControl.Location = new System.Drawing.Point(9, 69);
            this.audioProfileControl.Name = "audioProfileControl";
            this.audioProfileControl.Size = new System.Drawing.Size(407, 29);
            this.audioProfileControl.TabIndex = 33;
            // 
            // externalInput
            // 
            this.externalInput.AutoSize = true;
            this.externalInput.Location = new System.Drawing.Point(9, 23);
            this.externalInput.Name = "externalInput";
            this.externalInput.Size = new System.Drawing.Size(90, 17);
            this.externalInput.TabIndex = 32;
            this.externalInput.Text = "External input";
            this.externalInput.UseVisualStyleBackColor = true;
            this.externalInput.CheckedChanged += new System.EventHandler(this.externalInput_CheckedChanged);
            // 
            // audioCodecLabel
            // 
            this.audioCodecLabel.AutoSize = true;
            this.audioCodecLabel.Location = new System.Drawing.Point(6, 50);
            this.audioCodecLabel.Name = "audioCodecLabel";
            this.audioCodecLabel.Size = new System.Drawing.Size(38, 13);
            this.audioCodecLabel.TabIndex = 31;
            this.audioCodecLabel.Text = "Codec";
            this.audioCodecLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dontEncodeAudio
            // 
            this.dontEncodeAudio.Location = new System.Drawing.Point(256, 47);
            this.dontEncodeAudio.Name = "dontEncodeAudio";
            this.dontEncodeAudio.Size = new System.Drawing.Size(122, 21);
            this.dontEncodeAudio.TabIndex = 30;
            this.dontEncodeAudio.Text = "Keep original track";
            this.dontEncodeAudio.CheckedChanged += new System.EventHandler(this.dontEncodeAudio_CheckedChanged);
            // 
            // audioInput
            // 
            this.audioInput.Location = new System.Drawing.Point(113, 19);
            this.audioInput.Name = "audioInput";
            this.audioInput.ReadOnly = true;
            this.audioInput.Size = new System.Drawing.Size(256, 20);
            this.audioInput.TabIndex = 6;
            // 
            // audioInputOpenButton
            // 
            this.audioInputOpenButton.Location = new System.Drawing.Point(383, 19);
            this.audioInputOpenButton.Name = "audioInputOpenButton";
            this.audioInputOpenButton.Size = new System.Drawing.Size(24, 23);
            this.audioInputOpenButton.TabIndex = 7;
            this.audioInputOpenButton.Text = "...";
            this.audioInputOpenButton.Visible = false;
            this.audioInputOpenButton.Click += new System.EventHandler(this.audioInputOpenButton_Click);
            // 
            // audioTrack2
            // 
            this.audioTrack2.Location = new System.Drawing.Point(75, 0);
            this.audioTrack2.Name = "audioTrack2";
            this.audioTrack2.Size = new System.Drawing.Size(24, 16);
            this.audioTrack2.TabIndex = 20;
            this.audioTrack2.Text = "2";
            this.audioTrack2.CheckedChanged += new System.EventHandler(this.audioTrack1_CheckedChanged);
            // 
            // audioTrack1
            // 
            this.audioTrack1.Checked = true;
            this.audioTrack1.Location = new System.Drawing.Point(48, 0);
            this.audioTrack1.Name = "audioTrack1";
            this.audioTrack1.Size = new System.Drawing.Size(24, 16);
            this.audioTrack1.TabIndex = 19;
            this.audioTrack1.TabStop = true;
            this.audioTrack1.Text = "1";
            this.audioTrack1.CheckedChanged += new System.EventHandler(this.audioTrack1_CheckedChanged);
            // 
            // deleteAudioButton
            // 
            this.deleteAudioButton.Location = new System.Drawing.Point(383, 45);
            this.deleteAudioButton.Name = "deleteAudioButton";
            this.deleteAudioButton.Size = new System.Drawing.Size(24, 23);
            this.deleteAudioButton.TabIndex = 6;
            this.deleteAudioButton.Text = "X";
            this.deleteAudioButton.Click += new System.EventHandler(this.deleteAudioButton_Click);
            // 
            // audioCodec
            // 
            this.audioCodec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.audioCodec.Location = new System.Drawing.Point(113, 44);
            this.audioCodec.Name = "audioCodec";
            this.audioCodec.Size = new System.Drawing.Size(122, 21);
            this.audioCodec.TabIndex = 7;
            // 
            // videoGroupBox
            // 
            this.videoGroupBox.Controls.Add(this.videoProfileControl);
            this.videoGroupBox.Controls.Add(this.addPrerenderJob);
            this.videoGroupBox.Controls.Add(this.videoCodecLabel);
            this.videoGroupBox.Controls.Add(this.videoCodec);
            this.videoGroupBox.Location = new System.Drawing.Point(3, 6);
            this.videoGroupBox.Name = "videoGroupBox";
            this.videoGroupBox.Size = new System.Drawing.Size(429, 77);
            this.videoGroupBox.TabIndex = 31;
            this.videoGroupBox.TabStop = false;
            this.videoGroupBox.Text = "Video";
            // 
            // videoProfileControl
            // 
            this.videoProfileControl.LabelText = "Video Profile";
            this.videoProfileControl.Location = new System.Drawing.Point(12, 42);
            this.videoProfileControl.Name = "videoProfileControl";
            this.videoProfileControl.Size = new System.Drawing.Size(407, 29);
            this.videoProfileControl.TabIndex = 17;
            // 
            // addPrerenderJob
            // 
            this.addPrerenderJob.AutoSize = true;
            this.addPrerenderJob.Location = new System.Drawing.Point(259, 22);
            this.addPrerenderJob.Name = "addPrerenderJob";
            this.addPrerenderJob.Size = new System.Drawing.Size(127, 17);
            this.addPrerenderJob.TabIndex = 16;
            this.addPrerenderJob.Text = "Add pre-rendering job";
            this.addPrerenderJob.UseVisualStyleBackColor = true;
            // 
            // videoCodecLabel
            // 
            this.videoCodecLabel.Location = new System.Drawing.Point(9, 18);
            this.videoCodecLabel.Name = "videoCodecLabel";
            this.videoCodecLabel.Size = new System.Drawing.Size(100, 23);
            this.videoCodecLabel.TabIndex = 7;
            this.videoCodecLabel.Text = "Codec";
            this.videoCodecLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // videoCodec
            // 
            this.videoCodec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.videoCodec.Location = new System.Drawing.Point(116, 20);
            this.videoCodec.Name = "videoCodec";
            this.videoCodec.Size = new System.Drawing.Size(122, 21);
            this.videoCodec.TabIndex = 8;
            // 
            // splitOutput
            // 
            this.splitOutput.AutoSize = true;
            this.splitOutput.Location = new System.Drawing.Point(262, 199);
            this.splitOutput.Name = "splitOutput";
            this.splitOutput.Size = new System.Drawing.Size(69, 17);
            this.splitOutput.TabIndex = 29;
            this.splitOutput.Text = "Split Size";
            // 
            // splitSize
            // 
            this.splitSize.Enabled = false;
            this.splitSize.Location = new System.Drawing.Point(351, 197);
            this.splitSize.Name = "splitSize";
            this.splitSize.Size = new System.Drawing.Size(64, 20);
            this.splitSize.TabIndex = 28;
            this.splitSize.Text = "0";
            // 
            // containerFormatLabel
            // 
            this.containerFormatLabel.Location = new System.Drawing.Point(21, 204);
            this.containerFormatLabel.Name = "containerFormatLabel";
            this.containerFormatLabel.Size = new System.Drawing.Size(92, 13);
            this.containerFormatLabel.TabIndex = 27;
            this.containerFormatLabel.Text = "Container Format";
            // 
            // containerFormat
            // 
            this.containerFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.containerFormat.Location = new System.Drawing.Point(119, 197);
            this.containerFormat.Name = "containerFormat";
            this.containerFormat.Size = new System.Drawing.Size(122, 21);
            this.containerFormat.TabIndex = 26;
            this.containerFormat.SelectedIndexChanged += new System.EventHandler(this.containerFormat_SelectedIndexChanged_1);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "IFO Files|*.ifo|VOB Files (*.vob)|*.vob|MPEG-1/2 Program Streams (*.mpg)|*.mpg|Tr" +
                "ansport Streams (*.ts)|*.ts";
            // 
            // showAdvancedOptions
            // 
            this.showAdvancedOptions.AutoSize = true;
            this.showAdvancedOptions.Location = new System.Drawing.Point(4, 306);
            this.showAdvancedOptions.Name = "showAdvancedOptions";
            this.showAdvancedOptions.Size = new System.Drawing.Size(144, 17);
            this.showAdvancedOptions.TabIndex = 31;
            this.showAdvancedOptions.Text = "Show Advanced Options";
            this.showAdvancedOptions.UseVisualStyleBackColor = true;
            this.showAdvancedOptions.CheckedChanged += new System.EventHandler(this.showAdvancedOptions_CheckedChanged);
            // 
            // shutdownCheckBox
            // 
            this.shutdownCheckBox.AutoSize = true;
            this.shutdownCheckBox.Location = new System.Drawing.Point(4, 283);
            this.shutdownCheckBox.Name = "shutdownCheckBox";
            this.shutdownCheckBox.Size = new System.Drawing.Size(145, 17);
            this.shutdownCheckBox.TabIndex = 30;
            this.shutdownCheckBox.Text = "Shutdown after encoding";
            this.shutdownCheckBox.UseVisualStyleBackColor = true;
            this.shutdownCheckBox.CheckedChanged += new System.EventHandler(this.shutdownCheckBox_CheckedChanged);
            // 
            // goButton
            // 
            this.goButton.Location = new System.Drawing.Point(351, 283);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(75, 23);
            this.goButton.TabIndex = 29;
            this.goButton.Text = "Go!";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // profileControl2
            // 
            this.profileControl2.LabelText = "One Click profile";
            this.profileControl2.Location = new System.Drawing.Point(21, 12);
            this.profileControl2.Name = "profileControl2";
            this.profileControl2.Size = new System.Drawing.Size(389, 29);
            this.profileControl2.TabIndex = 23;
            // 
            // OneClickWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 335);
            this.Controls.Add(this.showAdvancedOptions);
            this.Controls.Add(this.shutdownCheckBox);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "OneClickWindow";
            this.Text = "One Click Encoder";
            this.tabPage2.ResumeLayout(false);
            this.locationGroupBox.ResumeLayout(false);
            this.locationGroupBox.PerformLayout();
            this.avsBox.ResumeLayout(false);
            this.avsBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.horizontalResolution)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.IOGroupbox.ResumeLayout(false);
            this.targetGroupBox.ResumeLayout(false);
            this.targetGroupBox.PerformLayout();
            this.audioGroupbox.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.encoderConfigTab.ResumeLayout(false);
            this.encoderConfigTab.PerformLayout();
            this.audioIOGroupBox.ResumeLayout(false);
            this.audioIOGroupBox.PerformLayout();
            this.videoGroupBox.ResumeLayout(false);
            this.videoGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.GroupBox audioGroupbox;
        private System.Windows.Forms.Button clearAudio2Button;
        private System.Windows.Forms.Button clearAudio1Button;
        private System.Windows.Forms.Label track2Label;
        private System.Windows.Forms.Label track1Label;
        private System.Windows.Forms.ComboBox track2;
        private System.Windows.Forms.ComboBox track1;
        private System.Windows.Forms.GroupBox IOGroupbox;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.GroupBox avsBox;
        private System.Windows.Forms.CheckBox signalAR;
        private System.Windows.Forms.TextBox AR;
        private System.Windows.Forms.Label outputResolutionLabel;
        private System.Windows.Forms.NumericUpDown horizontalResolution;
        private System.Windows.Forms.ComboBox arComboBox;
        private System.Windows.Forms.Label ARLabel;
        private System.Windows.Forms.GroupBox locationGroupBox;
        private System.Windows.Forms.Label workingDirectoryLabel;
        private System.Windows.Forms.TextBox workingName;
        private System.Windows.Forms.Label projectNameLabel;
        private System.Windows.Forms.GroupBox targetGroupBox;
        private System.Windows.Forms.TextBox filesizeKB;
        private System.Windows.Forms.Label inKBLabel;
        private System.Windows.Forms.ComboBox filesizeComboBox;
        private System.Windows.Forms.Label filesizeLabel;
        private System.Windows.Forms.Label chapterLabel;
        private System.Windows.Forms.CheckBox autoDeint;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TabPage encoderConfigTab;
        private System.Windows.Forms.CheckBox dontEncodeAudio;
        private System.Windows.Forms.CheckBox splitOutput;
        private System.Windows.Forms.TextBox splitSize;
        private System.Windows.Forms.Label containerFormatLabel;
        private System.Windows.Forms.ComboBox containerFormat;
        private System.Windows.Forms.GroupBox videoGroupBox;
        private System.Windows.Forms.CheckBox addPrerenderJob;
        private System.Windows.Forms.Label videoCodecLabel;
        private System.Windows.Forms.ComboBox videoCodec;
        private System.Windows.Forms.GroupBox audioIOGroupBox;
        private System.Windows.Forms.Label audioCodecLabel;
        private System.Windows.Forms.TextBox audioInput;
        private System.Windows.Forms.Button audioInputOpenButton;
        private System.Windows.Forms.RadioButton audioTrack2;
        private System.Windows.Forms.RadioButton audioTrack1;
        private System.Windows.Forms.Button deleteAudioButton;
        private System.Windows.Forms.ComboBox audioCodec;
        private System.Windows.Forms.CheckBox externalInput;
        private System.Windows.Forms.CheckBox showAdvancedOptions;
        private System.Windows.Forms.CheckBox shutdownCheckBox;
        private System.Windows.Forms.Button goButton;
        private MeGUI.core.details.video.ProfileControl profileControl1;
        private MeGUI.core.details.video.ProfileControl audioProfileControl;
        private MeGUI.core.details.video.ProfileControl videoProfileControl;
        private FileBar input;
        private FileBar output;
        private FileBar workingDirectory;
        private FileBar chapterFile;
        private MeGUI.core.details.video.ProfileControl profileControl2;


    }
}