using System.ComponentModel;

namespace zh_2_gyak
{
    public partial class Form1 : Form
    {
        //osztály szinten lista létre hozása
        BindingList<Futók> futók = new BindingList<Futók>();
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = futók; //FONTOS!!! elõször datagridview1, utána b
        }

        private void buttonBetöltés_Click(object sender, EventArgs e)
        {

        }
    }
}