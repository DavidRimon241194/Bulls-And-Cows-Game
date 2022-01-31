using System.Drawing;
using System.Windows.Forms;

namespace BullsEyeGame
{
    partial class FormPickAColor
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
            this.m_ButtonPurpel = new System.Windows.Forms.Button();
            this.m_ButtonRed = new System.Windows.Forms.Button();
            this.m_ButtonGreen = new System.Windows.Forms.Button();
            this.m_ButtonAqua = new System.Windows.Forms.Button();
            this.m_ButtonYellow = new System.Windows.Forms.Button();
            this.m_ButtonMaroon = new System.Windows.Forms.Button();
            this.m_ButtonBlue = new System.Windows.Forms.Button();
            this.m_ButtonWhite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // m_ButtonPurpel
            // 
            this.m_ButtonPurpel.BackColor = System.Drawing.Color.Purple;
            this.m_ButtonPurpel.Location = new System.Drawing.Point(12, 12);
            this.m_ButtonPurpel.Name = "m_ButtonPurpel";
            this.m_ButtonPurpel.Size = new System.Drawing.Size(60, 60);
            this.m_ButtonPurpel.TabIndex = 0;
            this.m_ButtonPurpel.UseVisualStyleBackColor = false;
            this.m_ButtonPurpel.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // m_ButtonRed
            // 
            this.m_ButtonRed.BackColor = System.Drawing.Color.Red;
            this.m_ButtonRed.Location = new System.Drawing.Point(78, 12);
            this.m_ButtonRed.Name = "m_ButtonRed";
            this.m_ButtonRed.Size = new System.Drawing.Size(60, 60);
            this.m_ButtonRed.TabIndex = 1;
            this.m_ButtonRed.UseVisualStyleBackColor = false;
            this.m_ButtonRed.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // m_ButtonGreen
            // 
            this.m_ButtonGreen.BackColor = System.Drawing.Color.Lime;
            this.m_ButtonGreen.Location = new System.Drawing.Point(144, 12);
            this.m_ButtonGreen.Name = "m_ButtonGreen";
            this.m_ButtonGreen.Size = new System.Drawing.Size(60, 60);
            this.m_ButtonGreen.TabIndex = 2;
            this.m_ButtonGreen.UseVisualStyleBackColor = false;
            this.m_ButtonGreen.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // m_ButtonAqua
            // 
            this.m_ButtonAqua.BackColor = System.Drawing.Color.Aqua;
            this.m_ButtonAqua.Location = new System.Drawing.Point(210, 12);
            this.m_ButtonAqua.Name = "m_ButtonAqua";
            this.m_ButtonAqua.Size = new System.Drawing.Size(60, 60);
            this.m_ButtonAqua.TabIndex = 3;
            this.m_ButtonAqua.UseVisualStyleBackColor = false;
            this.m_ButtonAqua.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // m_ButtonYellow
            // 
            this.m_ButtonYellow.BackColor = System.Drawing.Color.Yellow;
            this.m_ButtonYellow.Location = new System.Drawing.Point(78, 78);
            this.m_ButtonYellow.Name = "m_ButtonYellow";
            this.m_ButtonYellow.Size = new System.Drawing.Size(60, 60);
            this.m_ButtonYellow.TabIndex = 4;
            this.m_ButtonYellow.UseVisualStyleBackColor = false;
            this.m_ButtonYellow.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // m_ButtonMaroon
            // 
            this.m_ButtonMaroon.BackColor = System.Drawing.Color.Maroon;
            this.m_ButtonMaroon.Location = new System.Drawing.Point(144, 78);
            this.m_ButtonMaroon.Name = "m_ButtonMaroon";
            this.m_ButtonMaroon.Size = new System.Drawing.Size(60, 60);
            this.m_ButtonMaroon.TabIndex = 5;
            this.m_ButtonMaroon.UseVisualStyleBackColor = false;
            this.m_ButtonMaroon.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // m_ButtonBlue
            // 
            this.m_ButtonBlue.BackColor = System.Drawing.Color.Blue;
            this.m_ButtonBlue.Location = new System.Drawing.Point(12, 78);
            this.m_ButtonBlue.Name = "m_ButtonBlue";
            this.m_ButtonBlue.Size = new System.Drawing.Size(60, 60);
            this.m_ButtonBlue.TabIndex = 6;
            this.m_ButtonBlue.UseVisualStyleBackColor = false;
            this.m_ButtonBlue.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // m_ButtonWhite
            // 
            this.m_ButtonWhite.BackColor = System.Drawing.Color.White;
            this.m_ButtonWhite.Location = new System.Drawing.Point(210, 78);
            this.m_ButtonWhite.Name = "m_ButtonWhite";
            this.m_ButtonWhite.Size = new System.Drawing.Size(60, 60);
            this.m_ButtonWhite.TabIndex = 7;
            this.m_ButtonWhite.UseVisualStyleBackColor = false;
            this.m_ButtonWhite.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // FormPickAColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 151);
            this.Controls.Add(this.m_ButtonWhite);
            this.Controls.Add(this.m_ButtonBlue);
            this.Controls.Add(this.m_ButtonMaroon);
            this.Controls.Add(this.m_ButtonYellow);
            this.Controls.Add(this.m_ButtonAqua);
            this.Controls.Add(this.m_ButtonGreen);
            this.Controls.Add(this.m_ButtonRed);
            this.Controls.Add(this.m_ButtonPurpel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormPickAColor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pick A Color:";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button m_ButtonPurpel;
        private System.Windows.Forms.Button m_ButtonRed;
        private System.Windows.Forms.Button m_ButtonGreen;
        private System.Windows.Forms.Button m_ButtonAqua;
        private System.Windows.Forms.Button m_ButtonYellow;
        private System.Windows.Forms.Button m_ButtonMaroon;
        private System.Windows.Forms.Button m_ButtonBlue;
        private System.Windows.Forms.Button m_ButtonWhite;
    }
}