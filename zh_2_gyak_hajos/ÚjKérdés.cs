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
    public partial class ÚjKérdés : Form
    {
        public Kérdés Újkérdés= new Kérdés();
        public ÚjKérdés()
        {
            InitializeComponent();
        }

        private void ÚjKérdés_Load(object sender, EventArgs e)
        {
            kérdésBindingSource.DataSource = Újkérdés;
        }
    }
}
