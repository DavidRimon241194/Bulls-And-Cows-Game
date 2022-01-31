using System.Windows.Forms;
namespace BullsEyeGame
{
    partial class FormNumberOfChances
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
            this.m_ButtonNumberOfChances = new System.Windows.Forms.Button();
            this.m_ButtonStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // m_ButtonNumberOfChances
            // 
            this.m_ButtonNumberOfChances.ForeColor = System.Drawing.SystemColors.ControlText;
            this.m_ButtonNumberOfChances.Location = new System.Drawing.Point(41, 12);
            this.m_ButtonNumberOfChances.Name = "m_ButtonNumberOfChances";
            this.m_ButtonNumberOfChances.Size = new System.Drawing.Size(249, 27);
            this.m_ButtonNumberOfChances.TabIndex = 0;
            this.m_ButtonNumberOfChances.Text = "Number of chances: 4";
            this.m_ButtonNumberOfChances.UseVisualStyleBackColor = true;
            this.m_ButtonNumberOfChances.Click += new System.EventHandler(this.buttonNumberOfChances_Click);
            // 
            // m_ButtonStart
            // 
            this.m_ButtonStart.Location = new System.Drawing.Point(248, 104);
            this.m_ButtonStart.Name = "m_ButtonStart";
            this.m_ButtonStart.Size = new System.Drawing.Size(75, 23);
            this.m_ButtonStart.TabIndex = 1;
            this.m_ButtonStart.Text = "Start";
            this.m_ButtonStart.UseVisualStyleBackColor = true;
            this.m_ButtonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // FormNumberOfChances
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 139);
            this.Controls.Add(this.m_ButtonStart);
            this.Controls.Add(this.m_ButtonNumberOfChances);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormNumberOfChances";
            this.Text = "Bool Pgia";
            this.ResumeLayout(false);

        }

        #endregion
        private Button m_ButtonNumberOfChances;
        private Button m_ButtonStart;
    }
}