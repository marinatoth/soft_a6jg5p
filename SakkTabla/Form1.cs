namespace SakkTabla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            /*int m = 40;
            for (int oszlop = 0; oszlop < 8; oszlop++)
            {
                for (int sor = 0; sor < 8; sor++)
                {
                    if (oszlop % 2 == nulla)
                    {
                        if (sor % 2 == nulla)
                        {
                            Button button = new Button();
                            Controls.Add(button);
                            button.Width = m;
                            button.Height = m;
                            button.Top = m * oszlop;
                            button.Left = m * sor;
                            button.BackColor = Color.SandyBrown;
                        }
                    }
                    if (oszlop % 2 == egy)
                    {
                        if (sor % 2 == egy)
                        {
                            Button button = new Button();
                            Controls.Add(button);
                            button.Width = m;
                            button.Height = m;
                            button.Top = m * oszlop;
                            button.Left = m * sor;
                            button.BackColor = Color.SandyBrown;
                        }
                    }
                }
            }*/
        }
        void Sakk1(int nulla1, int nulla2, int egy1, int egy2, System.Drawing.Color szin)
        {
            int m = 40;
            for (int oszlop = 0; oszlop < 8; oszlop++)
            {
                for (int sor = 0; sor < 8; sor++)
                {
                    if (oszlop % 2 == nulla1)
                    {
                        if (sor % 2 == nulla2)
                        {
                            Button button = new Button();
                            Controls.Add(button);
                            button.Width = m;
                            button.Height = m;
                            button.Top = m * oszlop;
                            button.Left = m * sor;
                            button.BackColor = szin;
                        }
                    }
                    if (oszlop % 2 == egy1)
                    {
                        if (sor % 2 == egy2)
                        {
                            Button button = new Button();
                            Controls.Add(button);
                            button.Width = m;
                            button.Height = m;
                            button.Top = m * oszlop;
                            button.Left = m * sor;
                            button.BackColor = szin;
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Sakk1(0, 1, 1, 0, Color.Brown);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sakk1(0, 0, 1, 1, Color.PaleGoldenrod);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //törlés nem sikerült: this.Refresh(); nem jó
        }
    }
}