namespace JYM_Project
{
    partial class Inventry
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
            this.equipmentNameLabel = new System.Windows.Forms.Label();
            this.equipmentNameTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.inventryFormLabel = new System.Windows.Forms.Label();
            this.inventryGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.inventryGroupBox.SuspendLayout();
            this.SuspendLayout();
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
            // equipmentNameLabel
            // 
            this.equipmentNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equipmentNameLabel.Location = new System.Drawing.Point(16, 143);
            this.equipmentNameLabel.Name = "equipmentNameLabel";
            this.equipmentNameLabel.Size = new System.Drawing.Size(145, 55);
            this.equipmentNameLabel.TabIndex = 1;
            this.equipmentNameLabel.Text = "Equipment Name";
            // 
            // equipmentNameTextBox
            // 
            this.equipmentNameTextBox.Location = new System.Drawing.Point(186, 143);
            this.equipmentNameTextBox.Multiline = true;
            this.equipmentNameTextBox.Name = "equipmentNameTextBox";
            this.equipmentNameTextBox.Size = new System.Drawing.Size(257, 43);
            this.equipmentNameTextBox.TabIndex = 7;
            this.equipmentNameTextBox.TextChanged += new System.EventHandler(this.memberShipNameTextBox_TextChanged);
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
            // inventryFormLabel
            // 
            this.inventryFormLabel.AutoSize = true;
            this.inventryFormLabel.BackColor = System.Drawing.SystemColors.Highlight;
            this.inventryFormLabel.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventryFormLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.inventryFormLabel.Location = new System.Drawing.Point(191, 18);
            this.inventryFormLabel.Name = "inventryFormLabel";
            this.inventryFormLabel.Size = new System.Drawing.Size(321, 53);
            this.inventryFormLabel.TabIndex = 16;
            this.inventryFormLabel.Text = "Inventry Form";
            // 
            // inventryGroupBox
            // 
            this.inventryGroupBox.Controls.Add(this.inventryFormLabel);
            this.inventryGroupBox.Controls.Add(this.deleteButton);
            this.inventryGroupBox.Controls.Add(this.updateButton);
            this.inventryGroupBox.Controls.Add(this.addButton);
            this.inventryGroupBox.Controls.Add(this.equipmentNameTextBox);
            this.inventryGroupBox.Controls.Add(this.equipmentNameLabel);
            this.inventryGroupBox.Controls.Add(this.dataGridView1);
            this.inventryGroupBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.inventryGroupBox.Location = new System.Drawing.Point(12, 12);
            this.inventryGroupBox.Name = "inventryGroupBox";
            this.inventryGroupBox.Size = new System.Drawing.Size(776, 426);
            this.inventryGroupBox.TabIndex = 2;
            this.inventryGroupBox.TabStop = false;
            this.inventryGroupBox.Text = "Inventry";
            // 
            // Inventry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.inventryGroupBox);
            this.Name = "Inventry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventry";
            this.Load += new System.EventHandler(this.Inventry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.inventryGroupBox.ResumeLayout(false);
            this.inventryGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label equipmentNameLabel;
        private System.Windows.Forms.TextBox equipmentNameTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label inventryFormLabel;
        private System.Windows.Forms.GroupBox inventryGroupBox;
    }
}