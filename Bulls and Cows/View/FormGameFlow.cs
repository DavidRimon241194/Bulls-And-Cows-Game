using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BullsEyeGame.Controller;

namespace BullsEyeGame
{
    public partial class FormGameFlow : Form
    {
        private int m_CurrentNumberOfRow = 1;
        private int m_NumberOfChances = 4;
        private Dictionary<char, string> m_RandomKeyConvertor;
        private GameController m_Manager = new GameController();
        private FormNumberOfChances m_FormNumOfChances = new FormNumberOfChances();
        private List<RowInTheGame> m_ListOfRows = new List<RowInTheGame>();

        public FormGameFlow()
        {
            m_RandomKeyConvertor = new Dictionary<char, string>()
            {
                { 'A' ,eColorUserChoise.Purple.ToString() },
                { 'B', eColorUserChoise.Red.ToString() },
                { 'C', eColorUserChoise.Lime.ToString() },
                { 'D', eColorUserChoise.Aqua.ToString() },
                { 'E', eColorUserChoise.Blue.ToString() },
                { 'F', eColorUserChoise.Yellow.ToString() },
                { 'G', eColorUserChoise.Maroon.ToString() },
                { 'H', eColorUserChoise.White.ToString() }
            };
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void getNumberOfChancesToPlay()
        {
            int height = 0;

            if (m_FormNumOfChances.ShowDialog() == DialogResult.OK)
            {
                m_NumberOfChances = m_FormNumOfChances.NumberOfChances;
                this.m_Manager.NumOfAttempts = m_NumberOfChances;
                InitializeComponent();
                for (int i = 1; i <= m_NumberOfChances; i++)
                {
                    RowInTheGame newRow = new RowInTheGame(height, i);
                    newRow.SetAllButtonsEnable(m_CurrentNumberOfRow);
                    newRow.ArrwowClicked += new EventHandler(buttonArrow_Click);
                    m_ListOfRows.Add(newRow);
                    height += 55;
                    this.Controls.AddRange(newRow.GetAllButtuns());
                }

                this.ClientSize = new Size(355, height + 103 );
                this.Show();
                this.ResumeLayout(false);
            }
        }

        private void buttonArrow_Click(object sender, EventArgs e)
        {
            string result = null;

            m_Manager.SendRequestToTheModel((sender as RowInTheGame).CreateStringFromColors());
            result = m_Manager.GetSpesificResult(m_CurrentNumberOfRow - 1);
            (sender as RowInTheGame).SetResultButtonsColor(result);
            if (m_CurrentNumberOfRow <= m_NumberOfChances && (!m_Manager.IsLose() && !m_Manager.IsWin()))
            {
                m_CurrentNumberOfRow++;
                m_ListOfRows[m_CurrentNumberOfRow - 1].SetAllButtonsEnable(m_CurrentNumberOfRow);
            }
            else
            {
                Color[] rowColors = getRandomResultInColors();
                this.m_ButtonBlackFirstFromLeft.BackColor = rowColors[0];
                this.m_ButtonBlackSecondFromLeft.BackColor = rowColors[1];
                this.m_ButtonBlackThirdFromLeft.BackColor = rowColors[2];
                this.m_ButtonBlackFourthFromLeft.BackColor = rowColors[3];
            }
        }

        private Color[] getRandomResultInColors()
        {
            return new Color[] { Color.FromName(m_RandomKeyConvertor[m_Manager.RandomKey[0]]), Color.FromName(m_RandomKeyConvertor[m_Manager.RandomKey[1]]), Color.FromName(m_RandomKeyConvertor[m_Manager.RandomKey[2]]), Color.FromName(m_RandomKeyConvertor[m_Manager.RandomKey[3]])};
        }

        protected override void OnShown(EventArgs e)
        {
            this.Hide();
            base.OnShown(e);
            getNumberOfChancesToPlay();
        }

    }
}
