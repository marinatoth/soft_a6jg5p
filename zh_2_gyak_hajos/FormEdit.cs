using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zh_2_gyak_hajos
{
    public partial class FormEdit : Form
    {
        public Kérdés ÚjVizsgaKérdés = new Kérdés();
        public FormEdit()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormEdit_Load(object sender, EventArgs e)
        {
            kérdésBindingSource.DataSource = ÚjVizsgaKérdés;
        }

        private void buttonOke_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
