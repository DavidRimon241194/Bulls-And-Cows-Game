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
    public partial class FormPickAColor : Form
    {
        private Color m_ButtonColor = Color.FromKnownColor(KnownColor.Control);

        public FormPickAColor()
        {
            InitializeComponent();
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            m_ButtonColor = (sender as Button).BackColor;
            this.Close();
        }

        public Color ButtonColor
        {
            get { return this.m_ButtonColor; }
        }

    }
}
