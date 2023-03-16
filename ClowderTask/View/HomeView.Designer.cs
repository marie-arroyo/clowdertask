﻿using System;

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

        public void OpenSettingsScreen()
        {
            // create a new instance of the settings view
            var settingsView = new SettingsView();
            // show the settings view as a dialog
            settingsView.ShowDialog();
        }

        public void OpenShopScreen()
        {
            // create a new instance of the settings view
            var shopView = new ShopView();
            // show the settings view as a dialog
            shopView.ShowDialog();
        }

        public void OpenTaskScreen()
        {
            // create a new instance of the settings view
            var taskView = new TaskView();
            // show the settings view as a dialog
            taskView.ShowDialog();
        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeView));
            this.taskButton = new System.Windows.Forms.Button();
            this.shopButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.taskButton.Click += new System.EventHandler(this.taskButton_Click);
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
            this.shopButton.Click += new System.EventHandler(this.shopButton_Click);
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
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(136, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(498, 247);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(13, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(199, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // HomeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.shopButton);
            this.Controls.Add(this.taskButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomeView";
            this.Text = "ClowderTask";
            this.Load += new System.EventHandler(this.HomeView_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.HomeView_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button taskButton;
        private System.Windows.Forms.Button shopButton;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}