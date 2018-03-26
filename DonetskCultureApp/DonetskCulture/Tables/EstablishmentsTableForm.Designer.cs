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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(347, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(453, 561);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // panel1
            // 
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
            this.panel1.Size = new System.Drawing.Size(347, 561);
            this.panel1.TabIndex = 1;
            // 
            // HintInputFormLabel
            // 
            this.HintInputFormLabel.AutoSize = true;
            this.HintInputFormLabel.Location = new System.Drawing.Point(32, 9);
            this.HintInputFormLabel.Name = "HintInputFormLabel";
            this.HintInputFormLabel.Size = new System.Drawing.Size(254, 13);
            this.HintInputFormLabel.TabIndex = 13;
            this.HintInputFormLabel.Text = "Уведення даних для таблиці \"Заклади культури\"";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(231, 350);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(98, 17);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Не функціонує";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(130, 350);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(84, 17);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Функціонує";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // StateLabel
            // 
            this.StateLabel.AutoSize = true;
            this.StateLabel.Location = new System.Drawing.Point(13, 350);
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
            this.formWorkComboBox.Location = new System.Drawing.Point(130, 296);
            this.formWorkComboBox.Name = "formWorkComboBox";
            this.formWorkComboBox.Size = new System.Drawing.Size(199, 21);
            this.formWorkComboBox.TabIndex = 5;
            // 
            // FormWorkLabel
            // 
            this.FormWorkLabel.AutoSize = true;
            this.FormWorkLabel.Location = new System.Drawing.Point(13, 299);
            this.FormWorkLabel.Name = "FormWorkLabel";
            this.FormWorkLabel.Size = new System.Drawing.Size(96, 26);
            this.FormWorkLabel.TabIndex = 8;
            this.FormWorkLabel.Text = "Форма роботи\r\nзакладу культури";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(130, 207);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(198, 70);
            this.addressTextBox.TabIndex = 4;
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(13, 207);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(47, 13);
            this.AddressLabel.TabIndex = 6;
            this.AddressLabel.Text = "Адреса ";
            // 
            // regionOrCityTextBox
            // 
            this.regionOrCityTextBox.Location = new System.Drawing.Point(130, 166);
            this.regionOrCityTextBox.Name = "regionOrCityTextBox";
            this.regionOrCityTextBox.Size = new System.Drawing.Size(198, 20);
            this.regionOrCityTextBox.TabIndex = 3;
            // 
            // RegionOrCityLabel
            // 
            this.RegionOrCityLabel.AutoSize = true;
            this.RegionOrCityLabel.Location = new System.Drawing.Point(12, 166);
            this.RegionOrCityLabel.Name = "RegionOrCityLabel";
            this.RegionOrCityLabel.Size = new System.Drawing.Size(70, 13);
            this.RegionOrCityLabel.TabIndex = 4;
            this.RegionOrCityLabel.Text = "Район/місто";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(130, 76);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(198, 70);
            this.nameTextBox.TabIndex = 2;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(12, 79);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(96, 26);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Назва \r\nзакладу культури";
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(130, 36);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(198, 20);
            this.IDTextBox.TabIndex = 1;
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(12, 39);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(56, 13);
            this.IDLabel.TabIndex = 0;
            this.IDLabel.Text = "ID запису";
            // 
            // EstablishmentsTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "EstablishmentsTableForm";
            this.Text = "EstablishmentsTableForm";
            this.Load += new System.EventHandler(this.EstablishmentsTableForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
    }
}

