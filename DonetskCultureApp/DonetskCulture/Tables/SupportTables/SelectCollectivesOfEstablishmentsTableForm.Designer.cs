﻿namespace DonetskCulture
{
    partial class SelectCollectivesOfEstablishmentsTableForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ShowManagersOfCollectiveButton = new System.Windows.Forms.Button();
            this.AddCollectiveButton = new System.Windows.Forms.Button();
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
            this.dataGridView1.Location = new System.Drawing.Point(0, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(784, 375);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ShowManagersOfCollectiveButton);
            this.panel1.Controls.Add(this.AddCollectiveButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 85);
            this.panel1.TabIndex = 1;
            // 
            // ShowManagersOfCollectiveButton
            // 
            this.ShowManagersOfCollectiveButton.Location = new System.Drawing.Point(145, 23);
            this.ShowManagersOfCollectiveButton.Name = "ShowManagersOfCollectiveButton";
            this.ShowManagersOfCollectiveButton.Size = new System.Drawing.Size(141, 43);
            this.ShowManagersOfCollectiveButton.TabIndex = 1;
            this.ShowManagersOfCollectiveButton.Text = "Відобразити керівників\r\nдля обраного колективу";
            this.ShowManagersOfCollectiveButton.UseVisualStyleBackColor = true;
            this.ShowManagersOfCollectiveButton.Click += new System.EventHandler(this.ShowManagersOfCollectiveButton_Click);
            // 
            // AddCollectiveButton
            // 
            this.AddCollectiveButton.Location = new System.Drawing.Point(22, 23);
            this.AddCollectiveButton.Name = "AddCollectiveButton";
            this.AddCollectiveButton.Size = new System.Drawing.Size(100, 43);
            this.AddCollectiveButton.TabIndex = 0;
            this.AddCollectiveButton.Text = "Добавити колектив";
            this.AddCollectiveButton.UseVisualStyleBackColor = true;
            this.AddCollectiveButton.Click += new System.EventHandler(this.AddCollectiveButton_Click);
            // 
            // SelectCollectivesOfEstablishmentsTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "SelectCollectivesOfEstablishmentsTableForm";
            this.ShowIcon = false;
            this.Text = "Колективи обраного закладу культури";
            this.Load += new System.EventHandler(this.SelectCollectivesOfEstablishmentsTableForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ShowManagersOfCollectiveButton;
        private System.Windows.Forms.Button AddCollectiveButton;
    }
}