namespace DonetskCulture.Tables.MainTables
{
    partial class ManagersCollectivesTableForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagersCollectivesTableForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ClearButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.InsertButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.HintInputFormLabel = new System.Windows.Forms.Label();
            this.mailTextBox = new System.Windows.Forms.TextBox();
            this.IDManagerLabel = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.experienceTextBox = new System.Windows.Forms.TextBox();
            this.RankManagerLabel = new System.Windows.Forms.Label();
            this.educationTextBox = new System.Windows.Forms.TextBox();
            this.EducationLabel = new System.Windows.Forms.Label();
            this.rankManagerTextBox = new System.Windows.Forms.TextBox();
            this.ExperienceLabel = new System.Windows.Forms.Label();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.NavigateGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ClearButton);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.HintInputFormLabel);
            this.panel1.Controls.Add(this.mailTextBox);
            this.panel1.Controls.Add(this.IDManagerLabel);
            this.panel1.Controls.Add(this.phoneTextBox);
            this.panel1.Controls.Add(this.FullNameLabel);
            this.panel1.Controls.Add(this.experienceTextBox);
            this.panel1.Controls.Add(this.RankManagerLabel);
            this.panel1.Controls.Add(this.educationTextBox);
            this.panel1.Controls.Add(this.EducationLabel);
            this.panel1.Controls.Add(this.rankManagerTextBox);
            this.panel1.Controls.Add(this.ExperienceLabel);
            this.panel1.Controls.Add(this.fullNameTextBox);
            this.panel1.Controls.Add(this.PhoneLabel);
            this.panel1.Controls.Add(this.IDTextBox);
            this.panel1.Controls.Add(this.EmailLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 496);
            this.panel1.TabIndex = 0;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(12, 403);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(107, 23);
            this.ClearButton.TabIndex = 31;
            this.ClearButton.Text = "Очистити форму";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.InsertButton);
            this.groupBox1.Controls.Add(this.DeleteButton);
            this.groupBox1.Controls.Add(this.UpdateButton);
            this.groupBox1.Location = new System.Drawing.Point(3, 337);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 60);
            this.groupBox1.TabIndex = 30;
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
            this.DeleteButton.Location = new System.Drawing.Point(213, 24);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(92, 23);
            this.DeleteButton.TabIndex = 16;
            this.DeleteButton.Text = "Видалити";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(112, 24);
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
            this.HintInputFormLabel.Location = new System.Drawing.Point(41, 9);
            this.HintInputFormLabel.Name = "HintInputFormLabel";
            this.HintInputFormLabel.Size = new System.Drawing.Size(216, 32);
            this.HintInputFormLabel.TabIndex = 29;
            this.HintInputFormLabel.Text = "Уведення даних до таблиці \r\n\"Керівники колективів\"";
            this.HintInputFormLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mailTextBox
            // 
            this.mailTextBox.Location = new System.Drawing.Point(108, 297);
            this.mailTextBox.Name = "mailTextBox";
            this.mailTextBox.Size = new System.Drawing.Size(200, 20);
            this.mailTextBox.TabIndex = 28;
            // 
            // IDManagerLabel
            // 
            this.IDManagerLabel.AutoSize = true;
            this.IDManagerLabel.Location = new System.Drawing.Point(12, 58);
            this.IDManagerLabel.Name = "IDManagerLabel";
            this.IDManagerLabel.Size = new System.Drawing.Size(71, 13);
            this.IDManagerLabel.TabIndex = 15;
            this.IDManagerLabel.Text = "ID керівника";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(108, 256);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(200, 20);
            this.phoneTextBox.TabIndex = 27;
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Location = new System.Drawing.Point(12, 94);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(78, 13);
            this.FullNameLabel.TabIndex = 16;
            this.FullNameLabel.Text = "ПІБ керівника";
            // 
            // experienceTextBox
            // 
            this.experienceTextBox.Location = new System.Drawing.Point(108, 215);
            this.experienceTextBox.Name = "experienceTextBox";
            this.experienceTextBox.Size = new System.Drawing.Size(200, 20);
            this.experienceTextBox.TabIndex = 26;
            // 
            // RankManagerLabel
            // 
            this.RankManagerLabel.AutoSize = true;
            this.RankManagerLabel.Location = new System.Drawing.Point(12, 135);
            this.RankManagerLabel.Name = "RankManagerLabel";
            this.RankManagerLabel.Size = new System.Drawing.Size(44, 13);
            this.RankManagerLabel.TabIndex = 17;
            this.RankManagerLabel.Text = "Звання";
            // 
            // educationTextBox
            // 
            this.educationTextBox.Location = new System.Drawing.Point(108, 175);
            this.educationTextBox.Name = "educationTextBox";
            this.educationTextBox.Size = new System.Drawing.Size(200, 20);
            this.educationTextBox.TabIndex = 25;
            // 
            // EducationLabel
            // 
            this.EducationLabel.AutoSize = true;
            this.EducationLabel.Location = new System.Drawing.Point(12, 178);
            this.EducationLabel.Name = "EducationLabel";
            this.EducationLabel.Size = new System.Drawing.Size(40, 13);
            this.EducationLabel.TabIndex = 18;
            this.EducationLabel.Text = "Освіта";
            // 
            // rankManagerTextBox
            // 
            this.rankManagerTextBox.Location = new System.Drawing.Point(108, 135);
            this.rankManagerTextBox.Name = "rankManagerTextBox";
            this.rankManagerTextBox.Size = new System.Drawing.Size(200, 20);
            this.rankManagerTextBox.TabIndex = 24;
            // 
            // ExperienceLabel
            // 
            this.ExperienceLabel.AutoSize = true;
            this.ExperienceLabel.Location = new System.Drawing.Point(12, 221);
            this.ExperienceLabel.Name = "ExperienceLabel";
            this.ExperienceLabel.Size = new System.Drawing.Size(33, 13);
            this.ExperienceLabel.TabIndex = 19;
            this.ExperienceLabel.Text = "Стаж";
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.Location = new System.Drawing.Point(108, 94);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.fullNameTextBox.TabIndex = 23;
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Location = new System.Drawing.Point(11, 259);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(52, 13);
            this.PhoneLabel.TabIndex = 20;
            this.PhoneLabel.Text = "Телефон";
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(108, 55);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(200, 20);
            this.IDTextBox.TabIndex = 22;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(12, 304);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(35, 13);
            this.EmailLabel.TabIndex = 21;
            this.EmailLabel.Text = "E-mail";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.GroupByNameDGVCheckBox);
            this.panel2.Controls.Add(this.NavigateGroupBox);
            this.panel2.Controls.Add(this.SearchLabel);
            this.panel2.Controls.Add(this.SearchTextBox);
            this.panel2.Controls.Add(this.SearchButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(334, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(570, 122);
            this.panel2.TabIndex = 1;
            // 
            // GroupByNameDGVCheckBox
            // 
            this.GroupByNameDGVCheckBox.AutoSize = true;
            this.GroupByNameDGVCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.GroupByNameDGVCheckBox.Checked = true;
            this.GroupByNameDGVCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.GroupByNameDGVCheckBox.Location = new System.Drawing.Point(9, 97);
            this.GroupByNameDGVCheckBox.Name = "GroupByNameDGVCheckBox";
            this.GroupByNameDGVCheckBox.Size = new System.Drawing.Size(227, 17);
            this.GroupByNameDGVCheckBox.TabIndex = 11;
            this.GroupByNameDGVCheckBox.Text = "Згрупувати по ПІБ керівника колективу";
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
            this.NavigateGroupBox.Location = new System.Drawing.Point(1, 34);
            this.NavigateGroupBox.Name = "NavigateGroupBox";
            this.NavigateGroupBox.Size = new System.Drawing.Size(161, 57);
            this.NavigateGroupBox.TabIndex = 9;
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
            this.SearchLabel.Location = new System.Drawing.Point(6, 9);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(57, 16);
            this.SearchLabel.TabIndex = 8;
            this.SearchLabel.Text = "Пошук";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(67, 9);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(249, 20);
            this.SearchTextBox.TabIndex = 7;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(322, 7);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 6;
            this.SearchButton.Text = "Знайти";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(334, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(570, 376);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // ManagersCollectivesTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 496);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(920, 535);
            this.Name = "ManagersCollectivesTableForm";
            this.Text = "ManagersCollectivesTableForm";
            this.Load += new System.EventHandler(this.ManagersCollectivesTableForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.NavigateGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox mailTextBox;
        private System.Windows.Forms.Label IDManagerLabel;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Label FullNameLabel;
        private System.Windows.Forms.TextBox experienceTextBox;
        private System.Windows.Forms.Label RankManagerLabel;
        private System.Windows.Forms.TextBox educationTextBox;
        private System.Windows.Forms.Label EducationLabel;
        private System.Windows.Forms.TextBox rankManagerTextBox;
        private System.Windows.Forms.Label ExperienceLabel;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label HintInputFormLabel;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.CheckBox GroupByNameDGVCheckBox;
        private System.Windows.Forms.GroupBox NavigateGroupBox;
        private System.Windows.Forms.Button lastRecordButton;
        private System.Windows.Forms.Button nextRecordButton;
        private System.Windows.Forms.Button firstRecordButton;
        private System.Windows.Forms.Button previousRecordButton;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button SearchButton;
    }
}