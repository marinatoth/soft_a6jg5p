using System;

namespace Fibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            List<Sor> sorok = new List<Sor>();

            for (int i = 0; i < 20; i++)
            {
                Sor újsor = new Sor(); //osztály neve = new konstrukror();
                újsor.Sorszám = i;
                újsor.Érték = Fibonacci(i);

                sorok.Add(újsor);

                Button button = new Button();
                button.Text = újsor.Érték.ToString();
                button.Top = i * 27;
                Controls.Add(button);
            }
            dataGridView1.DataSource = sorok;


        }

        int Fibonacci(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            else return Fibonacci(n - 2) + Fibonacci(n - 1);
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}