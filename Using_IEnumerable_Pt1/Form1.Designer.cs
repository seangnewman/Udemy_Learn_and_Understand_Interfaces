﻿namespace Using_IEnumerable_Pt1
{
    partial class Form1
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
            this.animalsListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // animalsListBox
            // 
            this.animalsListBox.FormattingEnabled = true;
            this.animalsListBox.Location = new System.Drawing.Point(13, 52);
            this.animalsListBox.Name = "animalsListBox";
            this.animalsListBox.Size = new System.Drawing.Size(775, 329);
            this.animalsListBox.TabIndex = 0;
            this.animalsListBox.SelectedIndexChanged += new System.EventHandler(this.animalsListBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.animalsListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox animalsListBox;
    }
}

