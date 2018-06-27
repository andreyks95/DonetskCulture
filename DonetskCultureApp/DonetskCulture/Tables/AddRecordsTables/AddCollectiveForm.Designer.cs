namespace DonetskCulture.Tables.AddRecordsTables
{
    partial class AddCollectiveForm
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
            this.IDLabel = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.formLabel = new System.Windows.Forms.Label();
            this.formTextBox = new System.Windows.Forms.TextBox();
            this.genreLabel = new System.Windows.Forms.Label();
            this.genreTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rankLabel = new System.Windows.Forms.Label();
            this.CaptionLabel = new System.Windows.Forms.Label();
            this.managerComboBox = new System.Windows.Forms.ComboBox();
            this.ageCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.rankComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.id_managerLabel = new System.Windows.Forms.Label();
            this.AddCollectiveButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(12, 39);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(73, 13);
            this.IDLabel.TabIndex = 0;
            this.IDLabel.Text = "ID колективу";
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(118, 39);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(180, 20);
            this.IDTextBox.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 82);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(94, 13);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Назва колективу";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(118, 79);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(180, 20);
            this.nameTextBox.TabIndex = 3;
            // 
            // formLabel
            // 
            this.formLabel.AutoSize = true;
            this.formLabel.Location = new System.Drawing.Point(12, 121);
            this.formLabel.Name = "formLabel";
            this.formLabel.Size = new System.Drawing.Size(44, 13);
            this.formLabel.TabIndex = 4;
            this.formLabel.Text = "Форма";
            // 
            // formTextBox
            // 
            this.formTextBox.Location = new System.Drawing.Point(118, 118);
            this.formTextBox.Name = "formTextBox";
            this.formTextBox.Size = new System.Drawing.Size(180, 20);
            this.formTextBox.TabIndex = 5;
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Location = new System.Drawing.Point(12, 162);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(36, 13);
            this.genreLabel.TabIndex = 6;
            this.genreLabel.Text = "Жанр";
            // 
            // genreTextBox
            // 
            this.genreTextBox.Location = new System.Drawing.Point(118, 159);
            this.genreTextBox.Name = "genreTextBox";
            this.genreTextBox.Size = new System.Drawing.Size(180, 20);
            this.genreTextBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Вікова категорія";
            // 
            // rankLabel
            // 
            this.rankLabel.AutoSize = true;
            this.rankLabel.Location = new System.Drawing.Point(12, 241);
            this.rankLabel.Name = "rankLabel";
            this.rankLabel.Size = new System.Drawing.Size(44, 13);
            this.rankLabel.TabIndex = 11;
            this.rankLabel.Text = "Звання";
            // 
            // CaptionLabel
            // 
            this.CaptionLabel.AutoSize = true;
            this.CaptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CaptionLabel.Location = new System.Drawing.Point(12, 9);
            this.CaptionLabel.Name = "CaptionLabel";
            this.CaptionLabel.Size = new System.Drawing.Size(286, 13);
            this.CaptionLabel.TabIndex = 12;
            this.CaptionLabel.Text = "Форма для додавання колективу в базу даних";
            // 
            // managerComboBox
            // 
            this.managerComboBox.FormattingEnabled = true;
            this.managerComboBox.Location = new System.Drawing.Point(114, 30);
            this.managerComboBox.Name = "managerComboBox";
            this.managerComboBox.Size = new System.Drawing.Size(180, 21);
            this.managerComboBox.TabIndex = 13;
            this.managerComboBox.Enter += new System.EventHandler(this.managerComboBox_Enter);
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
            this.ageCategoryComboBox.Location = new System.Drawing.Point(118, 199);
            this.ageCategoryComboBox.Name = "ageCategoryComboBox";
            this.ageCategoryComboBox.Size = new System.Drawing.Size(180, 21);
            this.ageCategoryComboBox.TabIndex = 15;
            // 
            // rankComboBox
            // 
            this.rankComboBox.FormattingEnabled = true;
            this.rankComboBox.Items.AddRange(new object[] {
            "Зразковий",
            "Народний"});
            this.rankComboBox.Location = new System.Drawing.Point(118, 241);
            this.rankComboBox.Name = "rankComboBox";
            this.rankComboBox.Size = new System.Drawing.Size(180, 21);
            this.rankComboBox.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.id_managerLabel);
            this.groupBox1.Controls.Add(this.managerComboBox);
            this.groupBox1.Location = new System.Drawing.Point(4, 277);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 65);
            this.groupBox1.TabIndex = 17;
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
            // AddCollectiveButton
            // 
            this.AddCollectiveButton.Location = new System.Drawing.Point(7, 358);
            this.AddCollectiveButton.Name = "AddCollectiveButton";
            this.AddCollectiveButton.Size = new System.Drawing.Size(96, 23);
            this.AddCollectiveButton.TabIndex = 18;
            this.AddCollectiveButton.Text = "Вставити запис";
            this.AddCollectiveButton.UseVisualStyleBackColor = true;
            this.AddCollectiveButton.Click += new System.EventHandler(this.AddCollectiveButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(118, 358);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(107, 23);
            this.ClearButton.TabIndex = 19;
            this.ClearButton.Text = "Очистити форму";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // AddCollectiveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 391);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.AddCollectiveButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rankComboBox);
            this.Controls.Add(this.ageCategoryComboBox);
            this.Controls.Add(this.CaptionLabel);
            this.Controls.Add(this.rankLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.genreTextBox);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.formTextBox);
            this.Controls.Add(this.formLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.IDLabel);
            this.MaximumSize = new System.Drawing.Size(330, 430);
            this.MinimumSize = new System.Drawing.Size(330, 430);
            this.Name = "AddCollectiveForm";
            this.Text = "Додати колектив";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label formLabel;
        private System.Windows.Forms.TextBox formTextBox;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.TextBox genreTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label rankLabel;
        private System.Windows.Forms.Label CaptionLabel;
        private System.Windows.Forms.ComboBox managerComboBox;
        private System.Windows.Forms.ComboBox ageCategoryComboBox;
        private System.Windows.Forms.ComboBox rankComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label id_managerLabel;
        private System.Windows.Forms.Button AddCollectiveButton;
        private System.Windows.Forms.Button ClearButton;
    }
}