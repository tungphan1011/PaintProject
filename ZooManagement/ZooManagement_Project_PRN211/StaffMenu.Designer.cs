﻿namespace ZooManagement_Project_PRN211
{
    partial class StaffMenu
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
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(186, 35);
            label1.Name = "label1";
            label1.Size = new Size(409, 46);
            label1.TabIndex = 0;
            label1.Text = "Welcome To Staff Menu ";
            // 
            // button1
            // 
            button1.Location = new Point(33, 113);
            button1.Name = "button1";
            button1.Size = new Size(205, 94);
            button1.TabIndex = 1;
            button1.Text = "Management ZooTrainer Account";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // StaffMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "StaffMenu";
            Text = "StaffMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
    }
}