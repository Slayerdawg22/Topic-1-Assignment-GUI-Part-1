﻿namespace Topic_1_Assignment_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnGood = new System.Windows.Forms.Button();
            this.btnBad = new System.Windows.Forms.Button();
            this.imgGood = new System.Windows.Forms.PictureBox();
            this.imgBad = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgGood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBad)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGood
            // 
            this.btnGood.BackColor = System.Drawing.Color.Lime;
            this.btnGood.Location = new System.Drawing.Point(235, 170);
            this.btnGood.Name = "btnGood";
            this.btnGood.Size = new System.Drawing.Size(154, 76);
            this.btnGood.TabIndex = 0;
            this.btnGood.Text = "Good";
            this.btnGood.UseVisualStyleBackColor = false;
            this.btnGood.Click += new System.EventHandler(this.btnGood_Click);
            // 
            // btnBad
            // 
            this.btnBad.BackColor = System.Drawing.Color.Red;
            this.btnBad.Location = new System.Drawing.Point(409, 170);
            this.btnBad.Name = "btnBad";
            this.btnBad.Size = new System.Drawing.Size(151, 76);
            this.btnBad.TabIndex = 1;
            this.btnBad.Text = "Bad";
            this.btnBad.UseVisualStyleBackColor = false;
            this.btnBad.Click += new System.EventHandler(this.button1_Click);
            // 
            // imgGood
            // 
            this.imgGood.Image = ((System.Drawing.Image)(resources.GetObject("imgGood.Image")));
            this.imgGood.Location = new System.Drawing.Point(319, 287);
            this.imgGood.Name = "imgGood";
            this.imgGood.Size = new System.Drawing.Size(170, 128);
            this.imgGood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgGood.TabIndex = 2;
            this.imgGood.TabStop = false;
            // 
            // imgBad
            // 
            this.imgBad.Image = ((System.Drawing.Image)(resources.GetObject("imgBad.Image")));
            this.imgBad.Location = new System.Drawing.Point(319, 287);
            this.imgBad.Name = "imgBad";
            this.imgBad.Size = new System.Drawing.Size(170, 128);
            this.imgBad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBad.TabIndex = 3;
            this.imgBad.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.imgBad);
            this.Controls.Add(this.imgGood);
            this.Controls.Add(this.btnBad);
            this.Controls.Add(this.btnGood);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imgGood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGood;
        private System.Windows.Forms.Button btnBad;
        private System.Windows.Forms.PictureBox imgGood;
        private System.Windows.Forms.PictureBox imgBad;
    }
}

