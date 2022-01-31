using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BullsEyeGame
{
    public partial class FormNumberOfChances : Form
    {
        private int m_NumberOfChances = 4;

        public FormNumberOfChances()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public int NumberOfChances
        {
            get
            {
                return this.m_NumberOfChances;
            }
            set
            {
                this.m_NumberOfChances = value;
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonNumberOfChances_Click(object sender, EventArgs e)
        {
            NumberOfChances++;
            if (NumberOfChances > 10)
            {
                NumberOfChances = 4;
            }

            (sender as Button).Text = "Number of chances: " + m_NumberOfChances.ToString();
        }
    }
}
