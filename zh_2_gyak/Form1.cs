using System.ComponentModel;

namespace zh_2_gyak
{
    public partial class Form1 : Form
    {
        //oszt�ly szinten lista l�tre hoz�sa
        BindingList<Fut�k> fut�k = new BindingList<Fut�k>();
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = fut�k; //FONTOS!!! el�sz�r datagridview1, ut�na b
        }

        private void buttonBet�lt�s_Click(object sender, EventArgs e)
        {

        }
    }
}