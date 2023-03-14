
namespace ClowderTask.View
{
    partial class HomeView
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
            this.taskButton = new System.Windows.Forms.Button();
            this.shopButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // taskButton
            // 
            this.taskButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.taskButton.Location = new System.Drawing.Point(108, 342);
            this.taskButton.Name = "taskButton";
            this.taskButton.Size = new System.Drawing.Size(104, 49);
            this.taskButton.TabIndex = 0;
            this.taskButton.Text = "Tasks";
            this.taskButton.UseVisualStyleBackColor = false;
            this.taskButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // shopButton
            // 
            this.shopButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.shopButton.Location = new System.Drawing.Point(311, 342);
            this.shopButton.Name = "shopButton";
            this.shopButton.Size = new System.Drawing.Size(104, 49);
            this.shopButton.TabIndex = 1;
            this.shopButton.Text = "Points Shop";
            this.shopButton.UseVisualStyleBackColor = false;
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.settingsButton.Location = new System.Drawing.Point(530, 342);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(104, 49);
            this.settingsButton.TabIndex = 2;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = false;
            // 
            // HomeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.shopButton);
            this.Controls.Add(this.taskButton);
            this.Name = "HomeView";
            this.Text = "HomeView";
            this.Load += new System.EventHandler(this.HomeView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button taskButton;
        private System.Windows.Forms.Button shopButton;
        private System.Windows.Forms.Button settingsButton;
    }
}