using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using BullsEyeGame.Controller;


namespace BullsEyeGame
{
    public class RowInTheGame : Control
    {
        public event EventHandler ArrwowClicked;

        private Dictionary<string, string> m_UserChoiseConverter;
        private Dictionary<char, string> m_ResultConverter;
        private int m_RowNumber = 0;
        private Button m_ButtonFirstInRow = new System.Windows.Forms.Button();
        private Button m_ButtonSecondInRow = new System.Windows.Forms.Button();
        private Button m_ButtonFourthInRow = new System.Windows.Forms.Button();
        private Button m_ButtonThirdInRow = new System.Windows.Forms.Button();
        private Button m_ButtonArrow = new System.Windows.Forms.Button();
        private Button m_ButtonFirstResult = new System.Windows.Forms.Button();
        private Button m_ButtonSecondResult = new System.Windows.Forms.Button();
        private Button m_ButtonThirdResult = new System.Windows.Forms.Button();
        private Button m_ButtonFourthResult = new System.Windows.Forms.Button();

        public RowInTheGame(int i_Hight, int i_RowNumber)
        {
            this.m_UserChoiseConverter = new Dictionary<string, string>()
            {
                { eColorUserChoise.Purple.ToString(), "A" },
                { eColorUserChoise.Red.ToString(), "B" },
                { eColorUserChoise.Lime.ToString(), "C" },
                { eColorUserChoise.Aqua.ToString(), "D" },
                { eColorUserChoise.Blue.ToString(), "E" },
                { eColorUserChoise.Yellow.ToString(), "F" },
                { eColorUserChoise.Maroon.ToString(), "G" },
                { eColorUserChoise.White.ToString(), "H" }
            };
            this.m_ResultConverter = new Dictionary<char, string>()
            {
                { 'V', eColorResult.Black.ToString() },
                { 'X', eColorResult.Yellow.ToString() },
                { ' ', eColorResult.Control.ToString() } 
            };

            this.m_RowNumber = i_RowNumber;
            // 
            // m_ButtonFirstInRowOne
            // 
            this.m_ButtonFirstInRow.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.m_ButtonFirstInRow.Location = new System.Drawing.Point(13, 93 + i_Hight);
            this.m_ButtonFirstInRow.Name = "m_ButtonFirstInRowOne";
            this.m_ButtonFirstInRow.Size = new System.Drawing.Size(50, 50);
            this.m_ButtonFirstInRow.TabIndex = 4;
            this.m_ButtonFirstInRow.UseVisualStyleBackColor = false;
            this.m_ButtonFirstInRow.Enabled = false;
            this.m_ButtonFirstInRow.Click += new EventHandler(this.formPickColor_Load);
            // 
            // m_ButtonSecondInRowOne
            // 
            this.m_ButtonSecondInRow.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.m_ButtonSecondInRow.Location = new System.Drawing.Point(68, 93 + i_Hight);
            this.m_ButtonSecondInRow.Name = "m_ButtonSecondInRowOne";
            this.m_ButtonSecondInRow.Size = new System.Drawing.Size(50, 50);
            this.m_ButtonSecondInRow.TabIndex = 5;
            this.m_ButtonSecondInRow.UseVisualStyleBackColor = false;
            this.m_ButtonSecondInRow.Enabled = false;
            this.m_ButtonSecondInRow.Click += new EventHandler(this.formPickColor_Load);
            // 
            // m_ButtonThirdInRowOne
            // 
            this.m_ButtonThirdInRow.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.m_ButtonThirdInRow.Location = new System.Drawing.Point(123, 93 + i_Hight);
            this.m_ButtonThirdInRow.Name = "m_ButtonThirdInRowOne";
            this.m_ButtonThirdInRow.Size = new System.Drawing.Size(50, 50);
            this.m_ButtonThirdInRow.TabIndex = 7;
            this.m_ButtonThirdInRow.UseVisualStyleBackColor = false;
            this.m_ButtonThirdInRow.Enabled = false;
            this.m_ButtonThirdInRow.Click += new EventHandler(this.formPickColor_Load);
            // 
            // m_ButtonFourthInRowOne
            // 
            this.m_ButtonFourthInRow.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.m_ButtonFourthInRow.Location = new System.Drawing.Point(178, 93 + i_Hight);
            this.m_ButtonFourthInRow.Name = "m_ButtonFourthInRowOne";
            this.m_ButtonFourthInRow.Size = new System.Drawing.Size(50, 50);
            this.m_ButtonFourthInRow.TabIndex = 6;
            this.m_ButtonFourthInRow.UseVisualStyleBackColor = false;
            this.m_ButtonFourthInRow.Enabled = false;
            this.m_ButtonFourthInRow.Click += new EventHandler(this.formPickColor_Load);
            // 
            // m_ButtonFirstArrow
            // 
            int buttonFirstArrowTop = m_ButtonFourthInRow.Top + (m_ButtonFourthInRow.Height / 2);
            buttonFirstArrowTop -= m_ButtonFourthInRow.Height / 4;
            this.m_ButtonArrow.Enabled = false;
            this.m_ButtonArrow.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.m_ButtonArrow.Location = new System.Drawing.Point(233, buttonFirstArrowTop);
            this.m_ButtonArrow.Name = "m_ButtonFirstArrow";
            this.m_ButtonArrow.Size = new System.Drawing.Size(50, 25);
            this.m_ButtonArrow.TabIndex = 8;
            this.m_ButtonArrow.Text = "-->>";
            this.m_ButtonArrow.UseVisualStyleBackColor = false;
            this.m_ButtonArrow.Click += new EventHandler(this.buttonArrow_Click);
            // 
            // m_ButtonFirstResultFirstRow
            // 
            this.m_ButtonFirstResult.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.m_ButtonFirstResult.Location = new System.Drawing.Point(288, 95 + i_Hight);
            this.m_ButtonFirstResult.Name = "m_ButtonFirstResultFirstRow";
            this.m_ButtonFirstResult.Size = new System.Drawing.Size(20, 20);
            this.m_ButtonFirstResult.TabIndex = 15;
            this.m_ButtonFirstResult.UseVisualStyleBackColor = false;
            this.m_ButtonFirstResult.Enabled = false;
            // 
            // m_ButtonSecondResultFirstRow
            // 
            this.m_ButtonSecondResult.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.m_ButtonSecondResult.Location = new System.Drawing.Point(318, 95 + i_Hight);
            this.m_ButtonSecondResult.Name = "m_ButtonSecondResultFirstRow";
            this.m_ButtonSecondResult.Size = new System.Drawing.Size(20, 20);
            this.m_ButtonSecondResult.TabIndex = 13;
            this.m_ButtonSecondResult.UseVisualStyleBackColor = false;
            this.m_ButtonSecondResult.Enabled = false;
            // 
            // m_ButtonThirdResultFirstRow
            // 
            this.m_ButtonThirdResult.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.m_ButtonThirdResult.Location = new System.Drawing.Point(288, 121 + i_Hight);
            this.m_ButtonThirdResult.Name = "m_ButtonThirdResultFirstRow";
            this.m_ButtonThirdResult.Size = new System.Drawing.Size(20, 20);
            this.m_ButtonThirdResult.TabIndex = 14;
            this.m_ButtonThirdResult.UseVisualStyleBackColor = false;
            this.m_ButtonThirdResult.Enabled = false;
            // 
            // m_ButtonFourthResultFirstRow
            // 
            this.m_ButtonFourthResult.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.m_ButtonFourthResult.Location = new System.Drawing.Point(318, 121 + i_Hight);
            this.m_ButtonFourthResult.Name = "m_ButtonFourthResultFirstRow";
            this.m_ButtonFourthResult.Size = new System.Drawing.Size(20, 20);
            this.m_ButtonFourthResult.TabIndex = 16;
            this.m_ButtonFourthResult.UseVisualStyleBackColor = false;
            this.m_ButtonFourthResult.Enabled = false;
        }

        public Button[] GetAllButtuns()
        {
            return new Button[]
            {
                m_ButtonFirstInRow, m_ButtonSecondInRow, m_ButtonThirdInRow, m_ButtonFourthInRow, m_ButtonArrow, m_ButtonFirstResult,
                m_ButtonSecondResult, m_ButtonThirdResult, m_ButtonFourthResult,
            };
        }

        private void formPickColor_Load(object sender, EventArgs e)
        {
            FormPickAColor formPickColor = new FormPickAColor();

            formPickColor.ShowDialog();
            if (!checkIfColorAlreadyExist(formPickColor.ButtonColor) && formPickColor.ButtonColor.Name != "Control")
            {
                (sender as Button).BackColor = formPickColor.ButtonColor;
            }

            if (checkIfAllButtonsHaveBackColor())
            {
                m_ButtonArrow.Enabled = true;
            }
            else
            {
                m_ButtonArrow.Enabled = false;
            }
        }

        private bool checkIfAllButtonsHaveBackColor()
        {
            bool isBackColorExist = true;

            if (m_ButtonFirstInRow.BackColor.Name == "Control" || m_ButtonSecondInRow.BackColor.Name == "Control" || m_ButtonThirdInRow.BackColor.Name == "Control" || m_ButtonFourthInRow.BackColor.Name == "Control")
            {
                isBackColorExist = false;
            }

            return isBackColorExist;
        }

        private void buttonArrow_Click(object sender, EventArgs e)
        {
            m_ButtonFirstInRow.Enabled = false;
            m_ButtonSecondInRow.Enabled = false;
            m_ButtonThirdInRow.Enabled = false;
            m_ButtonFourthInRow.Enabled = false;
            m_ButtonArrow.Enabled = false;
            onArrowClicked(EventArgs.Empty);
        }

        private void onArrowClicked(EventArgs e)
        {
            if (ArrwowClicked != null)
            {
                ArrwowClicked.Invoke(this, e);
            }
        }

        private bool checkIfColorAlreadyExist(Color i_ChosenColor)
        {
            bool isColorExistInTheRow = false;

            if (m_ButtonFirstInRow.BackColor == i_ChosenColor || m_ButtonSecondInRow.BackColor == i_ChosenColor || m_ButtonThirdInRow.BackColor == i_ChosenColor || m_ButtonFourthInRow.BackColor == i_ChosenColor)
            {
                isColorExistInTheRow = true;
            }

            return isColorExistInTheRow;
        }

        public void SetAllButtonsEnable(int i_NumberOfRow)
        {
            if (i_NumberOfRow == this.m_RowNumber)
            {
                m_ButtonFirstInRow.Enabled = true;
                m_ButtonSecondInRow.Enabled = true;
                m_ButtonThirdInRow.Enabled = true;
                m_ButtonFourthInRow.Enabled = true;
            }
        }

        public string CreateStringFromColors()
        {
            string userChoise = null;

            userChoise = m_UserChoiseConverter[m_ButtonFirstInRow.BackColor.Name] + m_UserChoiseConverter[m_ButtonSecondInRow.BackColor.Name] + m_UserChoiseConverter[m_ButtonThirdInRow.BackColor.Name] + m_UserChoiseConverter[m_ButtonFourthInRow.BackColor.Name];

            return userChoise;
        }


        public void SetResultButtonsColor(string i_Result)
        {
            this.m_ButtonFirstResult.BackColor = Color.FromName(m_ResultConverter[i_Result[0]]);
            this.m_ButtonSecondResult.BackColor = Color.FromName(m_ResultConverter[i_Result[1]]);
            this.m_ButtonThirdResult.BackColor = Color.FromName(m_ResultConverter[i_Result[2]]);
            this.m_ButtonFourthResult.BackColor = Color.FromName(m_ResultConverter[i_Result[3]]);
        }

    }
}
