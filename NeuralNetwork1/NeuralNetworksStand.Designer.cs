namespace NeuralNetwork1
{
    partial class NeuralNetworksStand
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            this.ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.resolutionsBox = new System.Windows.Forms.ComboBox();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.button_F = new System.Windows.Forms.Button();
            this.ProcessButton = new System.Windows.Forms.Button();
            this.cb_cur_class = new System.Windows.Forms.ComboBox();
            this.ticksLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tresholdTrackBar = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.recognizedBox = new System.Windows.Forms.PictureBox();
            this.processedImgBox = new System.Windows.Forms.PictureBox();
            this.originalImageBox = new System.Windows.Forms.PictureBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbVideoSource = new System.Windows.Forms.ComboBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.check_photo = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.infoStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.st_lable = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LoadDataset = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.netTypeBox = new System.Windows.Forms.ComboBox();
            this.parallelCheckBox = new System.Windows.Forms.CheckBox();
            this.netStructureBox = new System.Windows.Forms.TextBox();
            this.recreateNetButton = new System.Windows.Forms.Button();
            this.classCounter = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.testNetButton = new System.Windows.Forms.Button();
            this.netTrainButton = new System.Windows.Forms.Button();
            this.AccuracyCounter = new System.Windows.Forms.TrackBar();
            this.EpochesCounter = new System.Windows.Forms.NumericUpDown();
            this.TrainingSizeCounter = new System.Windows.Forms.NumericUpDown();
            this.elapsedTimeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            label2 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            this.tabPage2.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tresholdTrackBar)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recognizedBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processedImgBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.originalImageBox)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccuracyCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EpochesCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrainingSizeCounter)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(116, 72);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(136, 24);
            label2.TabIndex = 2;
            label2.Text = "Структура сети";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(12, 112);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(251, 24);
            label4.TabIndex = 5;
            label4.Text = "Размер обучающей выборки";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(104, 154);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(160, 24);
            label5.TabIndex = 7;
            label5.Text = "Количество эпох";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(34, 298);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(90, 24);
            label6.TabIndex = 9;
            label6.Text = "Точность";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(882, 545);
            label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(70, 24);
            label7.TabIndex = 14;
            label7.Text = "Status:";
            // 
            // ToolStripMenuItem
            // 
            this.ToolStripMenuItem.Name = "ToolStripMenuItem";
            this.ToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.PowderBlue;
            this.tabPage2.Controls.Add(this.resolutionsBox);
            this.tabPage2.Controls.Add(this.controlPanel);
            this.tabPage2.Controls.Add(this.ticksLabel);
            this.tabPage2.Controls.Add(this.statusLabel);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.StartButton);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.cmbVideoSource);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1591, 1057);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Камера";
            // 
            // resolutionsBox
            // 
            this.resolutionsBox.AllowDrop = true;
            this.resolutionsBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.resolutionsBox.FormattingEnabled = true;
            this.resolutionsBox.Location = new System.Drawing.Point(12, 926);
            this.resolutionsBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.resolutionsBox.Name = "resolutionsBox";
            this.resolutionsBox.Size = new System.Drawing.Size(325, 28);
            this.resolutionsBox.TabIndex = 44;
            // 
            // controlPanel
            // 
            this.controlPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.controlPanel.Controls.Add(this.button_F);
            this.controlPanel.Controls.Add(this.ProcessButton);
            this.controlPanel.Controls.Add(this.cb_cur_class);
            this.controlPanel.Enabled = false;
            this.controlPanel.Location = new System.Drawing.Point(776, 894);
            this.controlPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(665, 90);
            this.controlPanel.TabIndex = 43;
            // 
            // button_F
            // 
            this.button_F.Location = new System.Drawing.Point(446, 20);
            this.button_F.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_F.Name = "button_F";
            this.button_F.Size = new System.Drawing.Size(152, 46);
            this.button_F.TabIndex = 2;
            this.button_F.Text = "Поймать";
            this.button_F.UseVisualStyleBackColor = true;
            this.button_F.Click += new System.EventHandler(this.button_F_Click);
            // 
            // ProcessButton
            // 
            this.ProcessButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ProcessButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProcessButton.Location = new System.Drawing.Point(249, 20);
            this.ProcessButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProcessButton.Name = "ProcessButton";
            this.ProcessButton.Size = new System.Drawing.Size(188, 46);
            this.ProcessButton.TabIndex = 1;
            this.ProcessButton.Text = "Сохранить";
            this.ProcessButton.UseVisualStyleBackColor = true;
            this.ProcessButton.Click += new System.EventHandler(this.ProcessButton_Click);
            // 
            // cb_cur_class
            // 
            this.cb_cur_class.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cb_cur_class.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_cur_class.FormattingEnabled = true;
            this.cb_cur_class.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cb_cur_class.Location = new System.Drawing.Point(6, 30);
            this.cb_cur_class.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_cur_class.Name = "cb_cur_class";
            this.cb_cur_class.Size = new System.Drawing.Size(218, 28);
            this.cb_cur_class.TabIndex = 1;
            // 
            // ticksLabel
            // 
            this.ticksLabel.AutoSize = true;
            this.ticksLabel.Location = new System.Drawing.Point(368, 897);
            this.ticksLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ticksLabel.Name = "ticksLabel";
            this.ticksLabel.Size = new System.Drawing.Size(194, 20);
            this.ticksLabel.TabIndex = 42;
            this.ticksLabel.Text = "Ticks for frame processing";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusLabel.Location = new System.Drawing.Point(5, 808);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(112, 32);
            this.statusLabel.TabIndex = 40;
            this.statusLabel.Text = "Статус:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.tresholdTrackBar);
            this.panel2.Location = new System.Drawing.Point(777, 717);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(662, 310);
            this.panel2.TabIndex = 39;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(516, 130);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(128, 24);
            this.checkBox1.TabIndex = 24;
            this.checkBox1.Text = "Обработать";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(494, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Порог";
            // 
            // tresholdTrackBar
            // 
            this.tresholdTrackBar.LargeChange = 1;
            this.tresholdTrackBar.Location = new System.Drawing.Point(456, 48);
            this.tresholdTrackBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tresholdTrackBar.Maximum = 255;
            this.tresholdTrackBar.Name = "tresholdTrackBar";
            this.tresholdTrackBar.Size = new System.Drawing.Size(210, 69);
            this.tresholdTrackBar.TabIndex = 22;
            this.tresholdTrackBar.TickFrequency = 25;
            this.tresholdTrackBar.Value = 35;
            this.tresholdTrackBar.ValueChanged += new System.EventHandler(this.tresholdTrackBar_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.PowderBlue;
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.recognizedBox);
            this.groupBox2.Controls.Add(this.processedImgBox);
            this.groupBox2.Controls.Add(this.originalImageBox);
            this.groupBox2.Location = new System.Drawing.Point(0, 5);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(1464, 798);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Камера";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1117, 50);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(159, 20);
            this.label15.TabIndex = 4;
            this.label15.Text = "То, что отправляем";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(664, 49);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 20);
            this.label13.TabIndex = 3;
            this.label13.Text = "Обработка";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(205, 50);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 20);
            this.label12.TabIndex = 2;
            this.label12.Text = "Лайв";
            // 
            // recognizedBox
            // 
            this.recognizedBox.Location = new System.Drawing.Point(966, 74);
            this.recognizedBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.recognizedBox.Name = "recognizedBox";
            this.recognizedBox.Size = new System.Drawing.Size(450, 500);
            this.recognizedBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.recognizedBox.TabIndex = 0;
            this.recognizedBox.TabStop = false;
            // 
            // processedImgBox
            // 
            this.processedImgBox.Location = new System.Drawing.Point(482, 74);
            this.processedImgBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.processedImgBox.Name = "processedImgBox";
            this.processedImgBox.Size = new System.Drawing.Size(450, 500);
            this.processedImgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.processedImgBox.TabIndex = 0;
            this.processedImgBox.TabStop = false;
            // 
            // originalImageBox
            // 
            this.originalImageBox.Location = new System.Drawing.Point(4, 74);
            this.originalImageBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.originalImageBox.Name = "originalImageBox";
            this.originalImageBox.Size = new System.Drawing.Size(450, 500);
            this.originalImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.originalImageBox.TabIndex = 1;
            this.originalImageBox.TabStop = false;
            // 
            // StartButton
            // 
            this.StartButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartButton.Location = new System.Drawing.Point(148, 808);
            this.StartButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(188, 46);
            this.StartButton.TabIndex = 36;
            this.StartButton.Text = "Старт";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 850);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(119, 20);
            this.label14.TabIndex = 35;
            this.label14.Text = "Выбор камеры";
            // 
            // cmbVideoSource
            // 
            this.cmbVideoSource.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbVideoSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVideoSource.FormattingEnabled = true;
            this.cmbVideoSource.Location = new System.Drawing.Point(10, 885);
            this.cmbVideoSource.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbVideoSource.Name = "cmbVideoSource";
            this.cmbVideoSource.Size = new System.Drawing.Size(326, 28);
            this.cmbVideoSource.TabIndex = 41;
            this.cmbVideoSource.SelectedIndexChanged += new System.EventHandler(this.cmbVideoSource_SelectionChangeCommitted);
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.BackColor = System.Drawing.Color.PowderBlue;
            this.tabPage1.Controls.Add(this.check_photo);
            this.tabPage1.Controls.Add(this.statusStrip1);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.st_lable);
            this.tabPage1.Controls.Add(label7);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.elapsedTimeLabel);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.progressBar1);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(1591, 1057);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Обучение";
            // 
            // check_photo
            // 
            this.check_photo.Location = new System.Drawing.Point(836, 812);
            this.check_photo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.check_photo.Name = "check_photo";
            this.check_photo.Size = new System.Drawing.Size(189, 57);
            this.check_photo.TabIndex = 16;
            this.check_photo.Text = "Проверить фото";
            this.check_photo.UseVisualStyleBackColor = true;
            this.check_photo.Click += new System.EventHandler(this.check_photo_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(4, 1020);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1583, 32);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // infoStatusLabel
            // 
            this.infoStatusLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.infoStatusLabel.Name = "infoStatusLabel";
            this.infoStatusLabel.Size = new System.Drawing.Size(119, 25);
            this.infoStatusLabel.Text = "Обучите сеть";
            this.infoStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(9, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(748, 767);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // st_lable
            // 
            this.st_lable.AutoSize = true;
            this.st_lable.Location = new System.Drawing.Point(946, 545);
            this.st_lable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.st_lable.Name = "st_lable";
            this.st_lable.Size = new System.Drawing.Size(63, 24);
            this.st_lable.TabIndex = 15;
            this.st_lable.Text = "NONE";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LoadDataset);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.netTypeBox);
            this.groupBox1.Controls.Add(this.parallelCheckBox);
            this.groupBox1.Controls.Add(this.netStructureBox);
            this.groupBox1.Controls.Add(this.recreateNetButton);
            this.groupBox1.Controls.Add(this.classCounter);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.testNetButton);
            this.groupBox1.Controls.Add(this.netTrainButton);
            this.groupBox1.Controls.Add(this.AccuracyCounter);
            this.groupBox1.Controls.Add(label6);
            this.groupBox1.Controls.Add(this.EpochesCounter);
            this.groupBox1.Controls.Add(label5);
            this.groupBox1.Controls.Add(this.TrainingSizeCounter);
            this.groupBox1.Controls.Add(label4);
            this.groupBox1.Controls.Add(label2);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(836, 80);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(632, 460);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры сети";
            // 
            // LoadDataset
            // 
            this.LoadDataset.Location = new System.Drawing.Point(450, 110);
            this.LoadDataset.Name = "LoadDataset";
            this.LoadDataset.Size = new System.Drawing.Size(176, 37);
            this.LoadDataset.TabIndex = 22;
            this.LoadDataset.Text = "Загрузить данные";
            this.LoadDataset.UseVisualStyleBackColor = true;
            this.LoadDataset.Click += new System.EventHandler(this.LoadDataset_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(194, 34);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 24);
            this.label11.TabIndex = 21;
            this.label11.Text = "Сеть";
            // 
            // netTypeBox
            // 
            this.netTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.netTypeBox.FormattingEnabled = true;
            this.netTypeBox.Location = new System.Drawing.Point(249, 30);
            this.netTypeBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.netTypeBox.Name = "netTypeBox";
            this.netTypeBox.Size = new System.Drawing.Size(180, 32);
            this.netTypeBox.TabIndex = 20;
            // 
            // parallelCheckBox
            // 
            this.parallelCheckBox.AutoSize = true;
            this.parallelCheckBox.Checked = true;
            this.parallelCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.parallelCheckBox.Location = new System.Drawing.Point(51, 374);
            this.parallelCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.parallelCheckBox.Name = "parallelCheckBox";
            this.parallelCheckBox.Size = new System.Drawing.Size(231, 28);
            this.parallelCheckBox.TabIndex = 19;
            this.parallelCheckBox.Text = "Параллельный расчёт";
            this.parallelCheckBox.UseVisualStyleBackColor = true;
            // 
            // netStructureBox
            // 
            this.netStructureBox.Location = new System.Drawing.Point(250, 68);
            this.netStructureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.netStructureBox.Name = "netStructureBox";
            this.netStructureBox.Size = new System.Drawing.Size(178, 33);
            this.netStructureBox.TabIndex = 18;
            this.netStructureBox.Text = "100;400;50;10";
            // 
            // recreateNetButton
            // 
            this.recreateNetButton.Location = new System.Drawing.Point(116, 248);
            this.recreateNetButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.recreateNetButton.Name = "recreateNetButton";
            this.recreateNetButton.Size = new System.Drawing.Size(210, 46);
            this.recreateNetButton.TabIndex = 17;
            this.recreateNetButton.Text = "Cоздать сеть";
            this.recreateNetButton.UseVisualStyleBackColor = true;
            this.recreateNetButton.Click += new System.EventHandler(this.button3_Click);
            this.recreateNetButton.MouseEnter += new System.EventHandler(this.recreateNetButton_MouseEnter);
            // 
            // classCounter
            // 
            this.classCounter.Location = new System.Drawing.Point(250, 192);
            this.classCounter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.classCounter.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.classCounter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.classCounter.Name = "classCounter";
            this.classCounter.Size = new System.Drawing.Size(180, 33);
            this.classCounter.TabIndex = 16;
            this.classCounter.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.classCounter.ValueChanged += new System.EventHandler(this.classCounter_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(75, 192);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(185, 24);
            this.label10.TabIndex = 15;
            this.label10.Text = "Количество классов";
            // 
            // testNetButton
            // 
            this.testNetButton.Location = new System.Drawing.Point(244, 402);
            this.testNetButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.testNetButton.Name = "testNetButton";
            this.testNetButton.Size = new System.Drawing.Size(150, 46);
            this.testNetButton.TabIndex = 14;
            this.testNetButton.Text = "Тест";
            this.testNetButton.UseVisualStyleBackColor = true;
            this.testNetButton.Click += new System.EventHandler(this.button2_Click);
            this.testNetButton.MouseEnter += new System.EventHandler(this.testNetButton_MouseEnter);
            // 
            // netTrainButton
            // 
            this.netTrainButton.Location = new System.Drawing.Point(46, 402);
            this.netTrainButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.netTrainButton.Name = "netTrainButton";
            this.netTrainButton.Size = new System.Drawing.Size(150, 46);
            this.netTrainButton.TabIndex = 11;
            this.netTrainButton.Text = "Обучить";
            this.netTrainButton.UseVisualStyleBackColor = true;
            this.netTrainButton.Click += new System.EventHandler(this.button1_Click);
            this.netTrainButton.MouseEnter += new System.EventHandler(this.netTrainButton_MouseEnter);
            // 
            // AccuracyCounter
            // 
            this.AccuracyCounter.Location = new System.Drawing.Point(38, 323);
            this.AccuracyCounter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AccuracyCounter.Maximum = 100;
            this.AccuracyCounter.Name = "AccuracyCounter";
            this.AccuracyCounter.Size = new System.Drawing.Size(368, 69);
            this.AccuracyCounter.TabIndex = 10;
            this.AccuracyCounter.TickFrequency = 10;
            this.AccuracyCounter.Value = 100;
            // 
            // EpochesCounter
            // 
            this.EpochesCounter.Location = new System.Drawing.Point(250, 150);
            this.EpochesCounter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EpochesCounter.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.EpochesCounter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.EpochesCounter.Name = "EpochesCounter";
            this.EpochesCounter.Size = new System.Drawing.Size(180, 33);
            this.EpochesCounter.TabIndex = 8;
            this.EpochesCounter.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // TrainingSizeCounter
            // 
            this.TrainingSizeCounter.Location = new System.Drawing.Point(250, 110);
            this.TrainingSizeCounter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TrainingSizeCounter.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.TrainingSizeCounter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TrainingSizeCounter.Name = "TrainingSizeCounter";
            this.TrainingSizeCounter.Size = new System.Drawing.Size(180, 33);
            this.TrainingSizeCounter.TabIndex = 6;
            this.TrainingSizeCounter.Value = new decimal(new int[] {
            700,
            0,
            0,
            0});
            // 
            // elapsedTimeLabel
            // 
            this.elapsedTimeLabel.AutoSize = true;
            this.elapsedTimeLabel.Location = new System.Drawing.Point(848, 710);
            this.elapsedTimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.elapsedTimeLabel.Name = "elapsedTimeLabel";
            this.elapsedTimeLabel.Size = new System.Drawing.Size(68, 24);
            this.elapsedTimeLabel.TabIndex = 12;
            this.elapsedTimeLabel.Text = "Время:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(836, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выберите сеть, обучите или протестируйте";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(840, 670);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(436, 34);
            this.progressBar1.Step = 1;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1308, 670);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 24);
            this.label8.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1284, 670);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 240);
            this.label9.TabIndex = 7;
            this.label9.Text = "0:\r\n1:\r\n2:\r\n3:\r\n4:\r\n5:\r\n6:\r\n7:\r\n8:\r\n9:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1599, 1090);
            this.tabControl1.TabIndex = 16;
            this.tabControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            // 
            // NeuralNetworksStand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1443, 904);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "NeuralNetworksStand";
            this.Text = "Продвинутый студенческий перспетрон";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.controlPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tresholdTrackBar)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recognizedBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processedImgBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.originalImageBox)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccuracyCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EpochesCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrainingSizeCounter)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox resolutionsBox;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Button button_F;
        private System.Windows.Forms.Button ProcessButton;
        private System.Windows.Forms.ComboBox cb_cur_class;
        private System.Windows.Forms.Label ticksLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar tresholdTrackBar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox recognizedBox;
        private System.Windows.Forms.PictureBox processedImgBox;
        private System.Windows.Forms.PictureBox originalImageBox;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbVideoSource;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button check_photo;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel infoStatusLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label st_lable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button LoadDataset;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox netTypeBox;
        private System.Windows.Forms.CheckBox parallelCheckBox;
        private System.Windows.Forms.TextBox netStructureBox;
        private System.Windows.Forms.Button recreateNetButton;
        private System.Windows.Forms.NumericUpDown classCounter;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button testNetButton;
        private System.Windows.Forms.Button netTrainButton;
        private System.Windows.Forms.TrackBar AccuracyCounter;
        private System.Windows.Forms.NumericUpDown EpochesCounter;
        private System.Windows.Forms.NumericUpDown TrainingSizeCounter;
        private System.Windows.Forms.Label elapsedTimeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
    }
}
