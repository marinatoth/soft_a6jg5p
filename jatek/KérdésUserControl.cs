using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jatek
{
    public partial class KérdésUserControl : UserControl
    {
        int jovalasz;
        public KérdésUserControl(int jovalasz)
        {
            InitializeComponent();
            BackColor = Color.LightGoldenrodYellow;
            this.jovalasz = jovalasz;

        }

        private void KérdésUserControl_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (jovalasz == 1)
            {
                button1.BackColor = Color.Green;
            }
            else button1.BackColor = Color.Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (jovalasz == 2)
            {
                button2.BackColor = Color.Green;
            }
            else button2.BackColor = Color.Red;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (jovalasz == 3)
            {
                button3.BackColor = Color.Green;
            }
            else button3.BackColor = Color.Red;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (jovalasz == 4)
            {
                button4.BackColor = Color.Green;
            }
            else button4.BackColor = Color.Red;
        }
    }
}
