namespace JYM_Project
{
    partial class Vender
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
            this.VenderGroupBox = new System.Windows.Forms.GroupBox();
            this.venderFormLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.contactNumberTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.venderNameTextBox = new System.Windows.Forms.TextBox();
            this.contactNumberLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.venderNameLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.VenderGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // VenderGroupBox
            // 
            this.VenderGroupBox.Controls.Add(this.venderFormLabel);
            this.VenderGroupBox.Controls.Add(this.deleteButton);
            this.VenderGroupBox.Controls.Add(this.updateButton);
            this.VenderGroupBox.Controls.Add(this.addButton);
            this.VenderGroupBox.Controls.Add(this.contactNumberTextBox);
            this.VenderGroupBox.Controls.Add(this.emailTextBox);
            this.VenderGroupBox.Controls.Add(this.venderNameTextBox);
            this.VenderGroupBox.Controls.Add(this.contactNumberLabel);
            this.VenderGroupBox.Controls.Add(this.label3);
            this.VenderGroupBox.Controls.Add(this.venderNameLabel);
            this.VenderGroupBox.Controls.Add(this.dataGridView1);
            this.VenderGroupBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.VenderGroupBox.Location = new System.Drawing.Point(12, 12);
            this.VenderGroupBox.Name = "VenderGroupBox";
            this.VenderGroupBox.Size = new System.Drawing.Size(776, 426);
            this.VenderGroupBox.TabIndex = 1;
            this.VenderGroupBox.TabStop = false;
            this.VenderGroupBox.Text = "Trainer";
            // 
            // venderFormLabel
            // 
            this.venderFormLabel.AutoSize = true;
            this.venderFormLabel.BackColor = System.Drawing.SystemColors.Highlight;
            this.venderFormLabel.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.venderFormLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.venderFormLabel.Location = new System.Drawing.Point(254, 18);
            this.venderFormLabel.Name = "venderFormLabel";
            this.venderFormLabel.Size = new System.Drawing.Size(291, 53);
            this.venderFormLabel.TabIndex = 16;
            this.venderFormLabel.Text = "Vender Form";
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteButton.Location = new System.Drawing.Point(476, 368);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(150, 37);
            this.deleteButton.TabIndex = 14;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.updateButton.Location = new System.Drawing.Point(263, 368);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(150, 37);
            this.updateButton.TabIndex = 13;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addButton.Location = new System.Drawing.Point(51, 368);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(150, 37);
            this.addButton.TabIndex = 12;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // contactNumberTextBox
            // 
            this.contactNumberTextBox.Location = new System.Drawing.Point(205, 236);
            this.contactNumberTextBox.Multiline = true;
            this.contactNumberTextBox.Name = "contactNumberTextBox";
            this.contactNumberTextBox.Size = new System.Drawing.Size(231, 31);
            this.contactNumberTextBox.TabIndex = 10;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(205, 168);
            this.emailTextBox.Multiline = true;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(231, 32);
            this.emailTextBox.TabIndex = 9;
            // 
            // venderNameTextBox
            // 
            this.venderNameTextBox.Location = new System.Drawing.Point(205, 105);
            this.venderNameTextBox.Multiline = true;
            this.venderNameTextBox.Name = "venderNameTextBox";
            this.venderNameTextBox.Size = new System.Drawing.Size(231, 32);
            this.venderNameTextBox.TabIndex = 7;
            // 
            // contactNumberLabel
            // 
            this.contactNumberLabel.AutoSize = true;
            this.contactNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactNumberLabel.Location = new System.Drawing.Point(16, 236);
            this.contactNumberLabel.Name = "contactNumberLabel";
            this.contactNumberLabel.Size = new System.Drawing.Size(168, 25);
            this.contactNumberLabel.TabIndex = 4;
            this.contactNumberLabel.Text = "Contact Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email";
            // 
            // venderNameLabel
            // 
            this.venderNameLabel.AutoSize = true;
            this.venderNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.venderNameLabel.Location = new System.Drawing.Point(16, 105);
            this.venderNameLabel.Name = "venderNameLabel";
            this.venderNameLabel.Size = new System.Drawing.Size(144, 25);
            this.venderNameLabel.TabIndex = 1;
            this.venderNameLabel.Text = "Vender Name";
            this.venderNameLabel.Click += new System.EventHandler(this.venderNameLabel_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(476, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(282, 248);
            this.dataGridView1.TabIndex = 0;
            // 
            // Vender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.VenderGroupBox);
            this.Name = "Vender";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vender";
            this.VenderGroupBox.ResumeLayout(false);
            this.VenderGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox VenderGroupBox;
        private System.Windows.Forms.Label venderFormLabel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox contactNumberTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox venderNameTextBox;
        private System.Windows.Forms.Label contactNumberLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label venderNameLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}