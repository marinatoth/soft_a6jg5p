using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using zh_2_gyak;

namespace zh_2_gyak_Futok
{
    public partial class FormAddÚjFutó : Form
    {
        public Futók ÚjFutó = new Futók();
        public FormAddÚjFutó()
        {
            InitializeComponent();
        }

        private void FormAddÚjFutó_Load(object sender, EventArgs e)
        {
            futókBindingSource.DataSource = ÚjFutó;
        }
    }
}
