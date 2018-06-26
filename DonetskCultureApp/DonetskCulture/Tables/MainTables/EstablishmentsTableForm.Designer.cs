namespace DonetskCulture
{
    partial class EstablishmentsTableForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EstablishmentsTableForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ClearButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.collectiveOfEstablishmentComboBox = new System.Windows.Forms.ComboBox();
            this.managerOfEstablishmentComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.InsertButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.HintInputFormLabel = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.StateLabel = new System.Windows.Forms.Label();
            this.formWorkComboBox = new System.Windows.Forms.ComboBox();
            this.FormWorkLabel = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.regionOrCityTextBox = new System.Windows.Forms.TextBox();
            this.RegionOrCityLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.IDLabel = new System.Windows.Forms.Label();
            this.lastRecordButton = new System.Windows.Forms.Button();
            this.nextRecordButton = new System.Windows.Forms.Button();
            this.previousRecordButton = new System.Windows.Forms.Button();
            this.firstRecordButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GroupByNameDGVCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ShowHeads_Button = new System.Windows.Forms.Button();
            this.ShowCollectives_Button = new System.Windows.Forms.Button();
            this.NavigateGroupBox = new System.Windows.Forms.GroupBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.NavigateGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(347, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(517, 504);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.ClearButton);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.HintInputFormLabel);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.StateLabel);
            this.panel1.Controls.Add(this.formWorkComboBox);
            this.panel1.Controls.Add(this.FormWorkLabel);
            this.panel1.Controls.Add(this.addressTextBox);
            this.panel1.Controls.Add(this.AddressLabel);
            this.panel1.Controls.Add(this.regionOrCityTextBox);
            this.panel1.Controls.Add(this.RegionOrCityLabel);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Controls.Add(this.NameLabel);
            this.panel1.Controls.Add(this.IDTextBox);
            this.panel1.Controls.Add(this.IDLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 631);
            this.panel1.TabIndex = 1;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(12, 593);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(107, 23);
            this.ClearButton.TabIndex = 22;
            this.ClearButton.Text = "Очистити форму";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.collectiveOfEstablishmentComboBox);
            this.groupBox3.Controls.Add(this.managerOfEstablishmentComboBox);
            this.groupBox3.Location = new System.Drawing.Point(3, 414);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(341, 106);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Закріпити за цим закладом культури";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Керівника";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Колектив";
            // 
            // collectiveOfEstablishmentComboBox
            // 
            this.collectiveOfEstablishmentComboBox.FormattingEnabled = true;
            this.collectiveOfEstablishmentComboBox.Location = new System.Drawing.Point(122, 29);
            this.collectiveOfEstablishmentComboBox.Name = "collectiveOfEstablishmentComboBox";
            this.collectiveOfEstablishmentComboBox.Size = new System.Drawing.Size(198, 21);
            this.collectiveOfEstablishmentComboBox.TabIndex = 1;
            this.collectiveOfEstablishmentComboBox.Enter += new System.EventHandler(this.collectiveOfEstablishmentComboBox_Enter);
            // 
            // managerOfEstablishmentComboBox
            // 
            this.managerOfEstablishmentComboBox.FormattingEnabled = true;
            this.managerOfEstablishmentComboBox.Location = new System.Drawing.Point(122, 66);
            this.managerOfEstablishmentComboBox.Name = "managerOfEstablishmentComboBox";
            this.managerOfEstablishmentComboBox.Size = new System.Drawing.Size(198, 21);
            this.managerOfEstablishmentComboBox.TabIndex = 0;
            this.managerOfEstablishmentComboBox.Enter += new System.EventHandler(this.managerOfEstablishmentComboBox_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.InsertButton);
            this.groupBox1.Controls.Add(this.DeleteButton);
            this.groupBox1.Controls.Add(this.UpdateButton);
            this.groupBox1.Location = new System.Drawing.Point(3, 527);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 60);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Робота з записами";
            // 
            // InsertButton
            // 
            this.InsertButton.Location = new System.Drawing.Point(14, 24);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(92, 23);
            this.InsertButton.TabIndex = 14;
            this.InsertButton.Text = "Вставити";
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(228, 24);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(92, 23);
            this.DeleteButton.TabIndex = 16;
            this.DeleteButton.Text = "Видалити";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(127, 24);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(92, 23);
            this.UpdateButton.TabIndex = 15;
            this.UpdateButton.Text = "Оновити";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // HintInputFormLabel
            // 
            this.HintInputFormLabel.AutoSize = true;
            this.HintInputFormLabel.BackColor = System.Drawing.Color.Transparent;
            this.HintInputFormLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HintInputFormLabel.Location = new System.Drawing.Point(57, 9);
            this.HintInputFormLabel.Name = "HintInputFormLabel";
            this.HintInputFormLabel.Size = new System.Drawing.Size(216, 32);
            this.HintInputFormLabel.TabIndex = 13;
            this.HintInputFormLabel.Text = "Уведення даних до таблиці \r\n\"Заклади культури\"";
            this.HintInputFormLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.Location = new System.Drawing.Point(231, 372);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(98, 17);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Не функціонує";
            this.radioButton2.UseVisualStyleBackColor = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Location = new System.Drawing.Point(130, 372);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(84, 17);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Функціонує";
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // StateLabel
            // 
            this.StateLabel.AutoSize = true;
            this.StateLabel.BackColor = System.Drawing.Color.Transparent;
            this.StateLabel.Location = new System.Drawing.Point(13, 372);
            this.StateLabel.Name = "StateLabel";
            this.StateLabel.Size = new System.Drawing.Size(96, 26);
            this.StateLabel.TabIndex = 10;
            this.StateLabel.Text = "Стан роботи \r\nзакладу культури";
            // 
            // formWorkComboBox
            // 
            this.formWorkComboBox.FormattingEnabled = true;
            this.formWorkComboBox.Items.AddRange(new object[] {
            "Звичайний",
            "Інноваційний монофункціональний",
            "Інноваційний багатофункціональний"});
            this.formWorkComboBox.Location = new System.Drawing.Point(130, 318);
            this.formWorkComboBox.Name = "formWorkComboBox";
            this.formWorkComboBox.Size = new System.Drawing.Size(199, 21);
            this.formWorkComboBox.TabIndex = 5;
            // 
            // FormWorkLabel
            // 
            this.FormWorkLabel.AutoSize = true;
            this.FormWorkLabel.BackColor = System.Drawing.Color.Transparent;
            this.FormWorkLabel.Location = new System.Drawing.Point(13, 321);
            this.FormWorkLabel.Name = "FormWorkLabel";
            this.FormWorkLabel.Size = new System.Drawing.Size(96, 26);
            this.FormWorkLabel.TabIndex = 8;
            this.FormWorkLabel.Text = "Форма роботи\r\nзакладу культури";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(130, 229);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(198, 70);
            this.addressTextBox.TabIndex = 4;
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.BackColor = System.Drawing.Color.Transparent;
            this.AddressLabel.Location = new System.Drawing.Point(13, 229);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(47, 13);
            this.AddressLabel.TabIndex = 6;
            this.AddressLabel.Text = "Адреса ";
            // 
            // regionOrCityTextBox
            // 
            this.regionOrCityTextBox.Location = new System.Drawing.Point(130, 188);
            this.regionOrCityTextBox.Name = "regionOrCityTextBox";
            this.regionOrCityTextBox.Size = new System.Drawing.Size(198, 20);
            this.regionOrCityTextBox.TabIndex = 3;
            // 
            // RegionOrCityLabel
            // 
            this.RegionOrCityLabel.AutoSize = true;
            this.RegionOrCityLabel.BackColor = System.Drawing.Color.Transparent;
            this.RegionOrCityLabel.Location = new System.Drawing.Point(12, 188);
            this.RegionOrCityLabel.Name = "RegionOrCityLabel";
            this.RegionOrCityLabel.Size = new System.Drawing.Size(70, 13);
            this.RegionOrCityLabel.TabIndex = 4;
            this.RegionOrCityLabel.Text = "Район/місто";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(130, 98);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(198, 70);
            this.nameTextBox.TabIndex = 2;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.BackColor = System.Drawing.Color.Transparent;
            this.NameLabel.Location = new System.Drawing.Point(12, 101);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(96, 26);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Назва \r\nзакладу культури";
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(130, 58);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(198, 20);
            this.IDTextBox.TabIndex = 1;
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.BackColor = System.Drawing.Color.Transparent;
            this.IDLabel.Location = new System.Drawing.Point(12, 61);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(56, 13);
            this.IDLabel.TabIndex = 0;
            this.IDLabel.Text = "ID запису";
            // 
            // lastRecordButton
            // 
            this.lastRecordButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lastRecordButton.BackgroundImage")));
            this.lastRecordButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lastRecordButton.Location = new System.Drawing.Point(117, 18);
            this.lastRecordButton.MaximumSize = new System.Drawing.Size(30, 30);
            this.lastRecordButton.MinimumSize = new System.Drawing.Size(30, 30);
            this.lastRecordButton.Name = "lastRecordButton";
            this.lastRecordButton.Size = new System.Drawing.Size(30, 30);
            this.lastRecordButton.TabIndex = 20;
            this.lastRecordButton.UseVisualStyleBackColor = true;
            this.lastRecordButton.Click += new System.EventHandler(this.lastRecordButton_Click);
            // 
            // nextRecordButton
            // 
            this.nextRecordButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("nextRecordButton.BackgroundImage")));
            this.nextRecordButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nextRecordButton.Location = new System.Drawing.Point(81, 18);
            this.nextRecordButton.MaximumSize = new System.Drawing.Size(30, 30);
            this.nextRecordButton.MinimumSize = new System.Drawing.Size(30, 30);
            this.nextRecordButton.Name = "nextRecordButton";
            this.nextRecordButton.Size = new System.Drawing.Size(30, 30);
            this.nextRecordButton.TabIndex = 19;
            this.nextRecordButton.UseVisualStyleBackColor = true;
            this.nextRecordButton.Click += new System.EventHandler(this.nextRecordButton_Click);
            // 
            // previousRecordButton
            // 
            this.previousRecordButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("previousRecordButton.BackgroundImage")));
            this.previousRecordButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.previousRecordButton.Location = new System.Drawing.Point(43, 18);
            this.previousRecordButton.MaximumSize = new System.Drawing.Size(30, 30);
            this.previousRecordButton.MinimumSize = new System.Drawing.Size(30, 30);
            this.previousRecordButton.Name = "previousRecordButton";
            this.previousRecordButton.Size = new System.Drawing.Size(30, 30);
            this.previousRecordButton.TabIndex = 18;
            this.previousRecordButton.UseVisualStyleBackColor = true;
            this.previousRecordButton.Click += new System.EventHandler(this.previousRecordButton_Click);
            // 
            // firstRecordButton
            // 
            this.firstRecordButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("firstRecordButton.BackgroundImage")));
            this.firstRecordButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.firstRecordButton.Location = new System.Drawing.Point(6, 18);
            this.firstRecordButton.MaximumSize = new System.Drawing.Size(30, 30);
            this.firstRecordButton.MinimumSize = new System.Drawing.Size(30, 30);
            this.firstRecordButton.Name = "firstRecordButton";
            this.firstRecordButton.Size = new System.Drawing.Size(30, 30);
            this.firstRecordButton.TabIndex = 17;
            this.firstRecordButton.UseVisualStyleBackColor = true;
            this.firstRecordButton.Click += new System.EventHandler(this.firstRecordButton_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.GroupByNameDGVCheckBox);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.NavigateGroupBox);
            this.panel2.Controls.Add(this.SearchLabel);
            this.panel2.Controls.Add(this.SearchTextBox);
            this.panel2.Controls.Add(this.SearchButton);
            this.panel2.Location = new System.Drawing.Point(347, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(517, 127);
            this.panel2.TabIndex = 2;
            // 
            // GroupByNameDGVCheckBox
            // 
            this.GroupByNameDGVCheckBox.AutoSize = true;
            this.GroupByNameDGVCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.GroupByNameDGVCheckBox.Checked = true;
            this.GroupByNameDGVCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.GroupByNameDGVCheckBox.Location = new System.Drawing.Point(9, 101);
            this.GroupByNameDGVCheckBox.Name = "GroupByNameDGVCheckBox";
            this.GroupByNameDGVCheckBox.Size = new System.Drawing.Size(171, 17);
            this.GroupByNameDGVCheckBox.TabIndex = 5;
            this.GroupByNameDGVCheckBox.Text = "Згрупувати по назві закладу";
            this.GroupByNameDGVCheckBox.UseVisualStyleBackColor = false;
            this.GroupByNameDGVCheckBox.CheckedChanged += new System.EventHandler(this.GroupByNameDGVCheckBox_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.ShowHeads_Button);
            this.groupBox2.Controls.Add(this.ShowCollectives_Button);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 9.5F);
            this.groupBox2.Location = new System.Drawing.Point(166, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(313, 57);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Відобразити для цього закладу культури";
            // 
            // ShowHeads_Button
            // 
            this.ShowHeads_Button.Location = new System.Drawing.Point(146, 22);
            this.ShowHeads_Button.Name = "ShowHeads_Button";
            this.ShowHeads_Button.Size = new System.Drawing.Size(118, 30);
            this.ShowHeads_Button.TabIndex = 1;
            this.ShowHeads_Button.Text = "Керівників";
            this.ShowHeads_Button.UseVisualStyleBackColor = true;
            this.ShowHeads_Button.Click += new System.EventHandler(this.ShowHeads_Button_Click);
            // 
            // ShowCollectives_Button
            // 
            this.ShowCollectives_Button.Location = new System.Drawing.Point(18, 23);
            this.ShowCollectives_Button.Name = "ShowCollectives_Button";
            this.ShowCollectives_Button.Size = new System.Drawing.Size(103, 29);
            this.ShowCollectives_Button.TabIndex = 0;
            this.ShowCollectives_Button.Text = "Колективи";
            this.ShowCollectives_Button.UseVisualStyleBackColor = true;
            this.ShowCollectives_Button.Click += new System.EventHandler(this.ShowCollectives_Button_Click);
            // 
            // NavigateGroupBox
            // 
            this.NavigateGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.NavigateGroupBox.Controls.Add(this.lastRecordButton);
            this.NavigateGroupBox.Controls.Add(this.nextRecordButton);
            this.NavigateGroupBox.Controls.Add(this.firstRecordButton);
            this.NavigateGroupBox.Controls.Add(this.previousRecordButton);
            this.NavigateGroupBox.Font = new System.Drawing.Font("Verdana", 9.5F);
            this.NavigateGroupBox.Location = new System.Drawing.Point(1, 38);
            this.NavigateGroupBox.Name = "NavigateGroupBox";
            this.NavigateGroupBox.Size = new System.Drawing.Size(161, 57);
            this.NavigateGroupBox.TabIndex = 3;
            this.NavigateGroupBox.TabStop = false;
            this.NavigateGroupBox.Text = "Навігація по таблиці";
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.BackColor = System.Drawing.Color.Transparent;
            this.SearchLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchLabel.Location = new System.Drawing.Point(6, 13);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(57, 16);
            this.SearchLabel.TabIndex = 2;
            this.SearchLabel.Text = "Пошук";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(67, 13);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(249, 20);
            this.SearchTextBox.TabIndex = 1;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(344, 13);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 0;
            this.SearchButton.Text = "Знайти";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Visible = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // EstablishmentsTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 631);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.MinimumSize = new System.Drawing.Size(850, 670);
            this.Name = "EstablishmentsTableForm";
            this.Text = "EstablishmentsTableForm";
            this.Load += new System.EventHandler(this.EstablishmentsTableForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.NavigateGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label HintInputFormLabel;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label StateLabel;
        private System.Windows.Forms.ComboBox formWorkComboBox;
        private System.Windows.Forms.Label FormWorkLabel;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.TextBox regionOrCityTextBox;
        private System.Windows.Forms.Label RegionOrCityLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button lastRecordButton;
        private System.Windows.Forms.Button nextRecordButton;
        private System.Windows.Forms.Button previousRecordButton;
        private System.Windows.Forms.Button firstRecordButton;
        private System.Windows.Forms.GroupBox NavigateGroupBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox collectiveOfEstablishmentComboBox;
        private System.Windows.Forms.ComboBox managerOfEstablishmentComboBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ShowHeads_Button;
        private System.Windows.Forms.Button ShowCollectives_Button;
        private System.Windows.Forms.CheckBox GroupByNameDGVCheckBox;
        private System.Windows.Forms.Button ClearButton;
    }
}

