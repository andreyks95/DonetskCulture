namespace DonetskCulture.Tables
{
    partial class CollectivesTableForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CollectivesTableForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ClearButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.InsertButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.id_managerLabel = new System.Windows.Forms.Label();
            this.managerComboBox = new System.Windows.Forms.ComboBox();
            this.rankComboBox = new System.Windows.Forms.ComboBox();
            this.ageCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.rankLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.genreTextBox = new System.Windows.Forms.TextBox();
            this.genreLabel = new System.Windows.Forms.Label();
            this.formTextBox = new System.Windows.Forms.TextBox();
            this.formLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.HintInputFormLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GroupByNameDGVCheckBox = new System.Windows.Forms.CheckBox();
            this.NavigateGroupBox = new System.Windows.Forms.GroupBox();
            this.lastRecordButton = new System.Windows.Forms.Button();
            this.nextRecordButton = new System.Windows.Forms.Button();
            this.firstRecordButton = new System.Windows.Forms.Button();
            this.previousRecordButton = new System.Windows.Forms.Button();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(347, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(517, 358);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ClearButton);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.rankComboBox);
            this.panel1.Controls.Add(this.ageCategoryComboBox);
            this.panel1.Controls.Add(this.rankLabel);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.genreTextBox);
            this.panel1.Controls.Add(this.genreLabel);
            this.panel1.Controls.Add(this.formTextBox);
            this.panel1.Controls.Add(this.formLabel);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Controls.Add(this.nameLabel);
            this.panel1.Controls.Add(this.IDTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.HintInputFormLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 481);
            this.panel1.TabIndex = 1;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(12, 444);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(107, 23);
            this.ClearButton.TabIndex = 35;
            this.ClearButton.Text = "Очистити форму";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.InsertButton);
            this.groupBox2.Controls.Add(this.DeleteButton);
            this.groupBox2.Controls.Add(this.UpdateButton);
            this.groupBox2.Location = new System.Drawing.Point(7, 378);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(329, 60);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Робота з записами";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.id_managerLabel);
            this.groupBox1.Controls.Add(this.managerComboBox);
            this.groupBox1.Location = new System.Drawing.Point(7, 297);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 65);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Закріпити за цим колективом";
            // 
            // id_managerLabel
            // 
            this.id_managerLabel.AutoSize = true;
            this.id_managerLabel.Location = new System.Drawing.Point(6, 30);
            this.id_managerLabel.Name = "id_managerLabel";
            this.id_managerLabel.Size = new System.Drawing.Size(58, 13);
            this.id_managerLabel.TabIndex = 0;
            this.id_managerLabel.Text = "Керівника";
            // 
            // managerComboBox
            // 
            this.managerComboBox.FormattingEnabled = true;
            this.managerComboBox.Location = new System.Drawing.Point(114, 30);
            this.managerComboBox.Name = "managerComboBox";
            this.managerComboBox.Size = new System.Drawing.Size(200, 21);
            this.managerComboBox.TabIndex = 13;
            this.managerComboBox.Enter += new System.EventHandler(this.managerComboBox_Enter);
            // 
            // rankComboBox
            // 
            this.rankComboBox.FormattingEnabled = true;
            this.rankComboBox.Items.AddRange(new object[] {
            "Зразковий",
            "Народний"});
            this.rankComboBox.Location = new System.Drawing.Point(121, 261);
            this.rankComboBox.Name = "rankComboBox";
            this.rankComboBox.Size = new System.Drawing.Size(200, 21);
            this.rankComboBox.TabIndex = 32;
            // 
            // ageCategoryComboBox
            // 
            this.ageCategoryComboBox.FormattingEnabled = true;
            this.ageCategoryComboBox.Items.AddRange(new object[] {
            "Діти",
            "Підлітки",
            "Молодіжна",
            "Дорослі",
            "Змішана"});
            this.ageCategoryComboBox.Location = new System.Drawing.Point(121, 219);
            this.ageCategoryComboBox.Name = "ageCategoryComboBox";
            this.ageCategoryComboBox.Size = new System.Drawing.Size(200, 21);
            this.ageCategoryComboBox.TabIndex = 31;
            // 
            // rankLabel
            // 
            this.rankLabel.AutoSize = true;
            this.rankLabel.Location = new System.Drawing.Point(15, 261);
            this.rankLabel.Name = "rankLabel";
            this.rankLabel.Size = new System.Drawing.Size(44, 13);
            this.rankLabel.TabIndex = 30;
            this.rankLabel.Text = "Звання";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Вікова категорія";
            // 
            // genreTextBox
            // 
            this.genreTextBox.Location = new System.Drawing.Point(121, 179);
            this.genreTextBox.Name = "genreTextBox";
            this.genreTextBox.Size = new System.Drawing.Size(200, 20);
            this.genreTextBox.TabIndex = 28;
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Location = new System.Drawing.Point(15, 182);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(36, 13);
            this.genreLabel.TabIndex = 27;
            this.genreLabel.Text = "Жанр";
            // 
            // formTextBox
            // 
            this.formTextBox.Location = new System.Drawing.Point(121, 138);
            this.formTextBox.Name = "formTextBox";
            this.formTextBox.Size = new System.Drawing.Size(200, 20);
            this.formTextBox.TabIndex = 26;
            // 
            // formLabel
            // 
            this.formLabel.AutoSize = true;
            this.formLabel.Location = new System.Drawing.Point(15, 141);
            this.formLabel.Name = "formLabel";
            this.formLabel.Size = new System.Drawing.Size(44, 13);
            this.formLabel.TabIndex = 25;
            this.formLabel.Text = "Форма";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(121, 99);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(200, 20);
            this.nameTextBox.TabIndex = 24;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(15, 102);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(94, 13);
            this.nameLabel.TabIndex = 23;
            this.nameLabel.Text = "Назва колективу";
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(121, 59);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(200, 20);
            this.IDTextBox.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "ID колективу";
            // 
            // HintInputFormLabel
            // 
            this.HintInputFormLabel.AutoSize = true;
            this.HintInputFormLabel.BackColor = System.Drawing.Color.Transparent;
            this.HintInputFormLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HintInputFormLabel.Location = new System.Drawing.Point(18, 12);
            this.HintInputFormLabel.Name = "HintInputFormLabel";
            this.HintInputFormLabel.Size = new System.Drawing.Size(307, 16);
            this.HintInputFormLabel.TabIndex = 17;
            this.HintInputFormLabel.Text = "Уведення даних до таблиці \"Колективи\"";
            this.HintInputFormLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.GroupByNameDGVCheckBox);
            this.panel2.Controls.Add(this.NavigateGroupBox);
            this.panel2.Controls.Add(this.SearchLabel);
            this.panel2.Controls.Add(this.SearchTextBox);
            this.panel2.Controls.Add(this.SearchButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(347, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(517, 123);
            this.panel2.TabIndex = 2;
            // 
            // GroupByNameDGVCheckBox
            // 
            this.GroupByNameDGVCheckBox.AutoSize = true;
            this.GroupByNameDGVCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.GroupByNameDGVCheckBox.Checked = true;
            this.GroupByNameDGVCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.GroupByNameDGVCheckBox.Location = new System.Drawing.Point(6, 98);
            this.GroupByNameDGVCheckBox.Name = "GroupByNameDGVCheckBox";
            this.GroupByNameDGVCheckBox.Size = new System.Drawing.Size(171, 17);
            this.GroupByNameDGVCheckBox.TabIndex = 36;
            this.GroupByNameDGVCheckBox.Text = "Згрупувати по назві закладу";
            this.GroupByNameDGVCheckBox.UseVisualStyleBackColor = false;
            this.GroupByNameDGVCheckBox.CheckedChanged += new System.EventHandler(this.GroupByNameDGVCheckBox_CheckedChanged);
            // 
            // NavigateGroupBox
            // 
            this.NavigateGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.NavigateGroupBox.Controls.Add(this.lastRecordButton);
            this.NavigateGroupBox.Controls.Add(this.nextRecordButton);
            this.NavigateGroupBox.Controls.Add(this.firstRecordButton);
            this.NavigateGroupBox.Controls.Add(this.previousRecordButton);
            this.NavigateGroupBox.Font = new System.Drawing.Font("Verdana", 9.5F);
            this.NavigateGroupBox.Location = new System.Drawing.Point(3, 35);
            this.NavigateGroupBox.Name = "NavigateGroupBox";
            this.NavigateGroupBox.Size = new System.Drawing.Size(161, 57);
            this.NavigateGroupBox.TabIndex = 17;
            this.NavigateGroupBox.TabStop = false;
            this.NavigateGroupBox.Text = "Навігація по таблиці";
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
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.BackColor = System.Drawing.Color.Transparent;
            this.SearchLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchLabel.Location = new System.Drawing.Point(9, 9);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(57, 16);
            this.SearchLabel.TabIndex = 16;
            this.SearchLabel.Text = "Пошук";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(87, 9);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(249, 20);
            this.SearchTextBox.TabIndex = 15;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(352, 7);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 14;
            this.SearchButton.Text = "Знайти";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Visible = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // CollectivesTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 481);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.MinimumSize = new System.Drawing.Size(880, 520);
            this.Name = "CollectivesTableForm";
            this.Text = "CollectivesTableForm";
            this.Load += new System.EventHandler(this.CollectivesTableForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.NavigateGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label HintInputFormLabel;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.GroupBox NavigateGroupBox;
        private System.Windows.Forms.Button lastRecordButton;
        private System.Windows.Forms.Button nextRecordButton;
        private System.Windows.Forms.Button firstRecordButton;
        private System.Windows.Forms.Button previousRecordButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label id_managerLabel;
        private System.Windows.Forms.ComboBox managerComboBox;
        private System.Windows.Forms.ComboBox rankComboBox;
        private System.Windows.Forms.ComboBox ageCategoryComboBox;
        private System.Windows.Forms.Label rankLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox genreTextBox;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.TextBox formTextBox;
        private System.Windows.Forms.Label formLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.CheckBox GroupByNameDGVCheckBox;
    }
}