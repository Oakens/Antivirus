namespace Antivirus
{
    partial class AntiVirus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AntiVirus));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblNameTitle = new System.Windows.Forms.Label();
            this.textFile = new System.Windows.Forms.TextBox();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.LblHash = new System.Windows.Forms.Label();
            this.txtHash = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.AddButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.DelteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(70, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(149, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Anti-Virus";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // lblNameTitle
            // 
            this.lblNameTitle.AutoSize = true;
            this.lblNameTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblNameTitle.Font = new System.Drawing.Font("Monotype Corsiva", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameTitle.Location = new System.Drawing.Point(2, 0);
            this.lblNameTitle.Name = "lblNameTitle";
            this.lblNameTitle.Size = new System.Drawing.Size(53, 16);
            this.lblNameTitle.TabIndex = 1;
            this.lblNameTitle.Text = "By Mads";
            this.lblNameTitle.Click += new System.EventHandler(this.lblNameTitle_Click);
            // 
            // textFile
            // 
            this.textFile.Location = new System.Drawing.Point(5, 56);
            this.textFile.Name = "textFile";
            this.textFile.Size = new System.Drawing.Size(176, 22);
            this.textFile.TabIndex = 2;
            this.textFile.Text = "Enter Path...";
            // 
            // BrowseButton
            // 
            this.BrowseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrowseButton.Location = new System.Drawing.Point(195, 56);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(75, 22);
            this.BrowseButton.TabIndex = 3;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // LblHash
            // 
            this.LblHash.AutoSize = true;
            this.LblHash.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.LblHash.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHash.Location = new System.Drawing.Point(209, 127);
            this.LblHash.Name = "LblHash";
            this.LblHash.Size = new System.Drawing.Size(45, 17);
            this.LblHash.TabIndex = 4;
            this.LblHash.Text = "Hash";
            // 
            // txtHash
            // 
            this.txtHash.Location = new System.Drawing.Point(5, 127);
            this.txtHash.Name = "txtHash";
            this.txtHash.Size = new System.Drawing.Size(176, 22);
            this.txtHash.TabIndex = 5;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(5, 188);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(54, 17);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Status";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(76, 187);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 17);
            this.lblResult.TabIndex = 7;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(5, 155);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(102, 23);
            this.AddButton.TabIndex = 8;
            this.AddButton.Text = "Add Hash";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DelteBtn
            // 
            this.DelteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelteBtn.Location = new System.Drawing.Point(121, 156);
            this.DelteBtn.Name = "DelteBtn";
            this.DelteBtn.Size = new System.Drawing.Size(98, 23);
            this.DelteBtn.TabIndex = 9;
            this.DelteBtn.Text = "Delete";
            this.DelteBtn.UseVisualStyleBackColor = true;
            this.DelteBtn.Click += new System.EventHandler(this.DelteBtn_Click);
            // 
            // AntiVirus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(294, 270);
            this.Controls.Add(this.DelteBtn);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtHash);
            this.Controls.Add(this.LblHash);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.textFile);
            this.Controls.Add(this.lblNameTitle);
            this.Controls.Add(this.lblTitle);
            this.Name = "AntiVirus";
            this.Text = "Anti-Virus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblNameTitle;
        private System.Windows.Forms.TextBox textFile;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.Label LblHash;
        private System.Windows.Forms.TextBox txtHash;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button DelteBtn;
    }
}

