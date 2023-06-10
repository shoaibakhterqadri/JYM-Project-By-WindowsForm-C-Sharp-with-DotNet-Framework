namespace JYM_Project
{
    partial class Manage
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
            this.ManageGroupBox = new System.Windows.Forms.GroupBox();
            this.mangaeLabel = new System.Windows.Forms.Label();
            this.venderButton = new System.Windows.Forms.Button();
            this.inventryButton = new System.Windows.Forms.Button();
            this.dealButton = new System.Windows.Forms.Button();
            this.trainerButton = new System.Windows.Forms.Button();
            this.ManageGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ManageGroupBox
            // 
            this.ManageGroupBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ManageGroupBox.Controls.Add(this.mangaeLabel);
            this.ManageGroupBox.Controls.Add(this.venderButton);
            this.ManageGroupBox.Controls.Add(this.inventryButton);
            this.ManageGroupBox.Controls.Add(this.dealButton);
            this.ManageGroupBox.Controls.Add(this.trainerButton);
            this.ManageGroupBox.Location = new System.Drawing.Point(50, 37);
            this.ManageGroupBox.Name = "ManageGroupBox";
            this.ManageGroupBox.Size = new System.Drawing.Size(692, 371);
            this.ManageGroupBox.TabIndex = 2;
            this.ManageGroupBox.TabStop = false;
            this.ManageGroupBox.Text = "Manage";
            this.ManageGroupBox.Enter += new System.EventHandler(this.ManageGroupBox_Enter);
            // 
            // mangaeLabel
            // 
            this.mangaeLabel.AllowDrop = true;
            this.mangaeLabel.AutoSize = true;
            this.mangaeLabel.BackColor = System.Drawing.Color.DodgerBlue;
            this.mangaeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mangaeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mangaeLabel.Location = new System.Drawing.Point(237, 129);
            this.mangaeLabel.Name = "mangaeLabel";
            this.mangaeLabel.Padding = new System.Windows.Forms.Padding(35);
            this.mangaeLabel.Size = new System.Drawing.Size(210, 108);
            this.mangaeLabel.TabIndex = 7;
            this.mangaeLabel.Text = "Manage";
            // 
            // venderButton
            // 
            this.venderButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.venderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.venderButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.venderButton.Location = new System.Drawing.Point(471, 40);
            this.venderButton.Name = "venderButton";
            this.venderButton.Size = new System.Drawing.Size(183, 76);
            this.venderButton.TabIndex = 6;
            this.venderButton.Text = "Vender";
            this.venderButton.UseVisualStyleBackColor = false;
            this.venderButton.Click += new System.EventHandler(this.maintainerButton_Click);
            // 
            // inventryButton
            // 
            this.inventryButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.inventryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventryButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.inventryButton.Location = new System.Drawing.Point(471, 263);
            this.inventryButton.Name = "inventryButton";
            this.inventryButton.Size = new System.Drawing.Size(183, 76);
            this.inventryButton.TabIndex = 5;
            this.inventryButton.Text = "Inventry";
            this.inventryButton.UseVisualStyleBackColor = false;
            this.inventryButton.Click += new System.EventHandler(this.inventryButton_Click);
            // 
            // dealButton
            // 
            this.dealButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.dealButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dealButton.Location = new System.Drawing.Point(34, 263);
            this.dealButton.Name = "dealButton";
            this.dealButton.Size = new System.Drawing.Size(183, 76);
            this.dealButton.TabIndex = 4;
            this.dealButton.Text = "Deals Section";
            this.dealButton.UseVisualStyleBackColor = false;
            this.dealButton.Click += new System.EventHandler(this.dealButton_Click);
            // 
            // trainerButton
            // 
            this.trainerButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.trainerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trainerButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.trainerButton.Location = new System.Drawing.Point(34, 40);
            this.trainerButton.Name = "trainerButton";
            this.trainerButton.Size = new System.Drawing.Size(183, 76);
            this.trainerButton.TabIndex = 0;
            this.trainerButton.Text = "Trainer";
            this.trainerButton.UseVisualStyleBackColor = false;
            this.trainerButton.Click += new System.EventHandler(this.trainerButton_Click);
            // 
            // Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ManageGroupBox);
            this.Name = "Manage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage";
            this.ManageGroupBox.ResumeLayout(false);
            this.ManageGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ManageGroupBox;
        private System.Windows.Forms.Button trainerButton;
        private System.Windows.Forms.Button venderButton;
        private System.Windows.Forms.Button inventryButton;
        private System.Windows.Forms.Button dealButton;
        private System.Windows.Forms.Label mangaeLabel;
    }
}