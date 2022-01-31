using System.Windows.Forms;
namespace BullsEyeGame
{
    partial class FormGameFlow
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
            this.m_ButtonBlackFirstFromLeft = new System.Windows.Forms.Button();
            this.m_ButtonBlackThirdFromLeft = new System.Windows.Forms.Button();
            this.m_ButtonBlackSecondFromLeft = new System.Windows.Forms.Button();
            this.m_ButtonBlackFourthFromLeft = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // m_ButtonBlackFirstFromLeft
            // 
            this.m_ButtonBlackFirstFromLeft.BackColor = System.Drawing.Color.Black;
            this.m_ButtonBlackFirstFromLeft.Enabled = false;
            this.m_ButtonBlackFirstFromLeft.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.m_ButtonBlackFirstFromLeft.Location = new System.Drawing.Point(13, 13);
            this.m_ButtonBlackFirstFromLeft.Name = "m_ButtonBlackFirstFromLeft";
            this.m_ButtonBlackFirstFromLeft.Size = new System.Drawing.Size(50, 50);
            this.m_ButtonBlackFirstFromLeft.TabIndex = 0;
            this.m_ButtonBlackFirstFromLeft.UseVisualStyleBackColor = false;
            // 
            // m_ButtonBlackThirdFromLeft
            // 
            this.m_ButtonBlackThirdFromLeft.BackColor = System.Drawing.Color.Black;
            this.m_ButtonBlackThirdFromLeft.Enabled = false;
            this.m_ButtonBlackThirdFromLeft.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.m_ButtonBlackThirdFromLeft.Location = new System.Drawing.Point(123, 13);
            this.m_ButtonBlackThirdFromLeft.Name = "m_ButtonBlackThirdFromLeft";
            this.m_ButtonBlackThirdFromLeft.Size = new System.Drawing.Size(50, 50);
            this.m_ButtonBlackThirdFromLeft.TabIndex = 1;
            this.m_ButtonBlackThirdFromLeft.UseVisualStyleBackColor = false;
            // 
            // m_ButtonBlackSecondFromLeft
            // 
            this.m_ButtonBlackSecondFromLeft.BackColor = System.Drawing.Color.Black;
            this.m_ButtonBlackSecondFromLeft.Enabled = false;
            this.m_ButtonBlackSecondFromLeft.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.m_ButtonBlackSecondFromLeft.Location = new System.Drawing.Point(68, 13);
            this.m_ButtonBlackSecondFromLeft.Name = "m_ButtonBlackSecondFromLeft";
            this.m_ButtonBlackSecondFromLeft.Size = new System.Drawing.Size(50, 50);
            this.m_ButtonBlackSecondFromLeft.TabIndex = 2;
            this.m_ButtonBlackSecondFromLeft.UseVisualStyleBackColor = false;
            // 
            // m_ButtonBlackFourthFromLeft
            // 
            this.m_ButtonBlackFourthFromLeft.BackColor = System.Drawing.Color.Black;
            this.m_ButtonBlackFourthFromLeft.Enabled = false;
            this.m_ButtonBlackFourthFromLeft.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.m_ButtonBlackFourthFromLeft.Location = new System.Drawing.Point(178, 13);
            this.m_ButtonBlackFourthFromLeft.Name = "m_ButtonBlackFourthFromLeft";
            this.m_ButtonBlackFourthFromLeft.Size = new System.Drawing.Size(50, 50);
            this.m_ButtonBlackFourthFromLeft.TabIndex = 3;
            this.m_ButtonBlackFourthFromLeft.UseVisualStyleBackColor = false;
            // 
            // FormGameFlow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 334);
            this.Controls.Add(this.m_ButtonBlackFourthFromLeft);
            this.Controls.Add(this.m_ButtonBlackSecondFromLeft);
            this.Controls.Add(this.m_ButtonBlackThirdFromLeft);
            this.Controls.Add(this.m_ButtonBlackFirstFromLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormGameFlow";
            this.Text = "Bool Pgia";
            this.ResumeLayout(false);

        }

        #endregion

        private Button m_ButtonBlackFirstFromLeft;
        private Button m_ButtonBlackThirdFromLeft;
        private Button m_ButtonBlackSecondFromLeft;
        private Button m_ButtonBlackFourthFromLeft;
    }
}