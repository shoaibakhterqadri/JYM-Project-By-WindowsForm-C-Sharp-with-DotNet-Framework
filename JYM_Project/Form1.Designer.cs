namespace JYM_Project
{
    partial class LoginForm
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
            this.LoginFormGroup = new System.Windows.Forms.GroupBox();
            this.RoleComboBox = new System.Windows.Forms.ComboBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.LoginFormLabel = new System.Windows.Forms.Label();
            this.RoleLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.LoginFormGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginFormGroup
            // 
            this.LoginFormGroup.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.LoginFormGroup.Controls.Add(this.loginButton);
            this.LoginFormGroup.Controls.Add(this.RoleComboBox);
            this.LoginFormGroup.Controls.Add(this.PasswordTextBox);
            this.LoginFormGroup.Controls.Add(this.UserNameTextBox);
            this.LoginFormGroup.Controls.Add(this.LoginFormLabel);
            this.LoginFormGroup.Controls.Add(this.RoleLabel);
            this.LoginFormGroup.Controls.Add(this.PasswordLabel);
            this.LoginFormGroup.Controls.Add(this.userNameLabel);
            this.LoginFormGroup.Location = new System.Drawing.Point(66, 39);
            this.LoginFormGroup.Name = "LoginFormGroup";
            this.LoginFormGroup.Size = new System.Drawing.Size(682, 369);
            this.LoginFormGroup.TabIndex = 0;
            this.LoginFormGroup.TabStop = false;
            this.LoginFormGroup.Text = "GYM Project";
            this.LoginFormGroup.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // RoleComboBox
            // 
            this.RoleComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.RoleComboBox.DropDownHeight = 120;
            this.RoleComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoleComboBox.FormattingEnabled = true;
            this.RoleComboBox.IntegralHeight = false;
            this.RoleComboBox.Items.AddRange(new object[] {
            "Admin",
            "User",
            "Trainer",
            "Maintainer"});
            this.RoleComboBox.Location = new System.Drawing.Point(278, 227);
            this.RoleComboBox.Name = "RoleComboBox";
            this.RoleComboBox.Size = new System.Drawing.Size(270, 37);
            this.RoleComboBox.TabIndex = 6;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.Location = new System.Drawing.Point(278, 175);
            this.PasswordTextBox.Multiline = true;
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(270, 32);
            this.PasswordTextBox.TabIndex = 5;
            this.PasswordTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameTextBox.Location = new System.Drawing.Point(278, 112);
            this.UserNameTextBox.Multiline = true;
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(270, 32);
            this.UserNameTextBox.TabIndex = 4;
            this.UserNameTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LoginFormLabel
            // 
            this.LoginFormLabel.AutoSize = true;
            this.LoginFormLabel.BackColor = System.Drawing.SystemColors.Highlight;
            this.LoginFormLabel.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginFormLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LoginFormLabel.Location = new System.Drawing.Point(227, 18);
            this.LoginFormLabel.Name = "LoginFormLabel";
            this.LoginFormLabel.Size = new System.Drawing.Size(224, 45);
            this.LoginFormLabel.TabIndex = 3;
            this.LoginFormLabel.Text = "Login Form";
            // 
            // RoleLabel
            // 
            this.RoleLabel.AutoSize = true;
            this.RoleLabel.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoleLabel.Location = new System.Drawing.Point(82, 219);
            this.RoleLabel.Name = "RoleLabel";
            this.RoleLabel.Size = new System.Drawing.Size(77, 32);
            this.RoleLabel.TabIndex = 2;
            this.RoleLabel.Text = "Role:";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(82, 166);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(138, 32);
            this.PasswordLabel.TabIndex = 1;
            this.PasswordLabel.Text = "Password:";
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.Location = new System.Drawing.Point(82, 112);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(152, 32);
            this.userNameLabel.TabIndex = 0;
            this.userNameLabel.Text = "User Name:";
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginButton.Location = new System.Drawing.Point(235, 300);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(148, 45);
            this.loginButton.TabIndex = 7;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LoginFormGroup);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GYM Management System";
            this.LoginFormGroup.ResumeLayout(false);
            this.LoginFormGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox LoginFormGroup;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.Label LoginFormLabel;
        private System.Windows.Forms.Label RoleLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.ComboBox RoleComboBox;
        private System.Windows.Forms.Button loginButton;
    }
}

