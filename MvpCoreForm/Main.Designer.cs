﻿namespace MvpCoreForm
{
    partial class Main
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
            taskTree1 = new Uc.CuTree.View.TaskTree();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // taskTree1
            // 
            taskTree1.Dock = DockStyle.Fill;
            taskTree1.Location = new Point(0, 0);
            taskTree1.Name = "taskTree1";
            taskTree1.Size = new Size(248, 450);
            taskTree1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(taskTree1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(248, 450);
            panel1.TabIndex = 1;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Main";
            Text = "Main";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Uc.CuTree.View.TaskTree taskTree1;
        private Panel panel1;
    }
}