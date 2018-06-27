namespace DonetskCulture
{
    partial class ControlForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ManagersOfCollectivesButton = new System.Windows.Forms.Button();
            this.CollectivesButton = new System.Windows.Forms.Button();
            this.HeadsOfEstablishmentsButton = new System.Windows.Forms.Button();
            this.EstablishmentsButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ManagersOfCollectivesButton);
            this.groupBox1.Controls.Add(this.CollectivesButton);
            this.groupBox1.Controls.Add(this.HeadsOfEstablishmentsButton);
            this.groupBox1.Controls.Add(this.EstablishmentsButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 210);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Таблиці";
            // 
            // ManagersOfCollectivesButton
            // 
            this.ManagersOfCollectivesButton.Location = new System.Drawing.Point(29, 164);
            this.ManagersOfCollectivesButton.Name = "ManagersOfCollectivesButton";
            this.ManagersOfCollectivesButton.Size = new System.Drawing.Size(133, 23);
            this.ManagersOfCollectivesButton.TabIndex = 3;
            this.ManagersOfCollectivesButton.Text = "Керівники колективів";
            this.ManagersOfCollectivesButton.UseVisualStyleBackColor = true;
            this.ManagersOfCollectivesButton.Click += new System.EventHandler(this.ManagersOfCollectivesButton_Click);
            // 
            // CollectivesButton
            // 
            this.CollectivesButton.Location = new System.Drawing.Point(29, 124);
            this.CollectivesButton.Name = "CollectivesButton";
            this.CollectivesButton.Size = new System.Drawing.Size(133, 23);
            this.CollectivesButton.TabIndex = 1;
            this.CollectivesButton.Text = "Колективи";
            this.CollectivesButton.UseVisualStyleBackColor = true;
            this.CollectivesButton.Click += new System.EventHandler(this.CollectivesButton_Click);
            // 
            // HeadsOfEstablishmentsButton
            // 
            this.HeadsOfEstablishmentsButton.Location = new System.Drawing.Point(15, 70);
            this.HeadsOfEstablishmentsButton.Name = "HeadsOfEstablishmentsButton";
            this.HeadsOfEstablishmentsButton.Size = new System.Drawing.Size(168, 36);
            this.HeadsOfEstablishmentsButton.TabIndex = 2;
            this.HeadsOfEstablishmentsButton.Text = "Керівники закладів культури\r\n(адміністративний корпус)";
            this.HeadsOfEstablishmentsButton.UseVisualStyleBackColor = true;
            // 
            // EstablishmentsButton
            // 
            this.EstablishmentsButton.Location = new System.Drawing.Point(29, 30);
            this.EstablishmentsButton.Name = "EstablishmentsButton";
            this.EstablishmentsButton.Size = new System.Drawing.Size(133, 23);
            this.EstablishmentsButton.TabIndex = 0;
            this.EstablishmentsButton.Text = "Заклади культури";
            this.EstablishmentsButton.UseVisualStyleBackColor = true;
            this.EstablishmentsButton.Click += new System.EventHandler(this.EstablishmentsButton_Click);
            // 
            // ControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 285);
            this.Controls.Add(this.groupBox1);
            this.Name = "ControlForm";
            this.Text = "ControlForm";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ManagersOfCollectivesButton;
        private System.Windows.Forms.Button HeadsOfEstablishmentsButton;
        private System.Windows.Forms.Button CollectivesButton;
        private System.Windows.Forms.Button EstablishmentsButton;
    }
}