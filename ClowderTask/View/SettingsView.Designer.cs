
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsView));
            this.userLabel = new System.Windows.Forms.Label();
            this.catLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.nameInputBox = new System.Windows.Forms.TextBox();
            this.catNameInputBox = new System.Windows.Forms.TextBox();
            this.passwordInputBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userLabel
            // 
            this.userLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(28, 35);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(81, 17);
            this.userLabel.TabIndex = 0;
            this.userLabel.Text = "Your name:";
            this.userLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // catLabel
            // 
            this.catLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.catLabel.AutoSize = true;
            this.catLabel.Location = new System.Drawing.Point(28, 97);
            this.catLabel.Name = "catLabel";
            this.catLabel.Size = new System.Drawing.Size(72, 17);
            this.catLabel.TabIndex = 1;
            this.catLabel.Text = "Cat name:";
            this.catLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(28, 163);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(73, 17);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Password:";
            this.passwordLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // nameInputBox
            // 
            this.nameInputBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.nameInputBox.Location = new System.Drawing.Point(31, 55);
            this.nameInputBox.Name = "nameInputBox";
            this.nameInputBox.Size = new System.Drawing.Size(100, 22);
            this.nameInputBox.TabIndex = 3;
            // 
            // catNameInputBox
            // 
            this.catNameInputBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.catNameInputBox.Location = new System.Drawing.Point(31, 117);
            this.catNameInputBox.Name = "catNameInputBox";
            this.catNameInputBox.Size = new System.Drawing.Size(100, 22);
            this.catNameInputBox.TabIndex = 4;
            // 
            // passwordInputBox
            // 
            this.passwordInputBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.passwordInputBox.Location = new System.Drawing.Point(31, 183);
            this.passwordInputBox.Name = "passwordInputBox";
            this.passwordInputBox.PasswordChar = '*';
            this.passwordInputBox.Size = new System.Drawing.Size(100, 22);
            this.passwordInputBox.TabIndex = 5;
            this.passwordInputBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(129, 291);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SettingsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 336);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.passwordInputBox);
            this.Controls.Add(this.catNameInputBox);
            this.Controls.Add(this.nameInputBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.catLabel);
            this.Controls.Add(this.userLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsView";
            this.Text = "ClowderTask - Settings";
            this.Load += new System.EventHandler(this.SettingsView_Load);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}