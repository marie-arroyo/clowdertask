
namespace ClowderTask.View
{
    partial class SettingsView
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
            this.userLabel = new System.Windows.Forms.Label();
            this.catLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.nameInputBox = new System.Windows.Forms.TextBox();
            this.catNameInputBox = new System.Windows.Forms.TextBox();
            this.passwordInputBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(33, 35);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(81, 17);
            this.userLabel.TabIndex = 0;
            this.userLabel.Text = "Your name:";
            this.userLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // catLabel
            // 
            this.catLabel.AutoSize = true;
            this.catLabel.Location = new System.Drawing.Point(42, 97);
            this.catLabel.Name = "catLabel";
            this.catLabel.Size = new System.Drawing.Size(72, 17);
            this.catLabel.TabIndex = 1;
            this.catLabel.Text = "Cat name:";
            this.catLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(41, 163);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(73, 17);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Password:";
            this.passwordLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // nameInputBox
            // 
            this.nameInputBox.Location = new System.Drawing.Point(111, 35);
            this.nameInputBox.Name = "nameInputBox";
            this.nameInputBox.Size = new System.Drawing.Size(100, 22);
            this.nameInputBox.TabIndex = 3;
            // 
            // catNameInputBox
            // 
            this.catNameInputBox.Location = new System.Drawing.Point(111, 97);
            this.catNameInputBox.Name = "catNameInputBox";
            this.catNameInputBox.Size = new System.Drawing.Size(100, 22);
            this.catNameInputBox.TabIndex = 4;
            // 
            // passwordInputBox
            // 
            this.passwordInputBox.Location = new System.Drawing.Point(111, 163);
            this.passwordInputBox.Name = "passwordInputBox";
            this.passwordInputBox.PasswordChar = '*';
            this.passwordInputBox.Size = new System.Drawing.Size(100, 22);
            this.passwordInputBox.TabIndex = 5;
            this.passwordInputBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // SettingsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 336);
            this.Controls.Add(this.passwordInputBox);
            this.Controls.Add(this.catNameInputBox);
            this.Controls.Add(this.nameInputBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.catLabel);
            this.Controls.Add(this.userLabel);
            this.Name = "SettingsView";
            this.Text = "SettingsView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label catLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox nameInputBox;
        private System.Windows.Forms.TextBox catNameInputBox;
        private System.Windows.Forms.TextBox passwordInputBox;
    }
}