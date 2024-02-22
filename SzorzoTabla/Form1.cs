namespace SzorzoTabla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int oszlop = 1; oszlop <= 10; oszlop++)
            {
                for (int sor = 1; sor <= 10; sor++)
                {
                    Button button = new Button(); // Button osztály button példánya
                    button.Width = 40;
                    button.Height = 40;
                    int num = oszlop * sor;
                    button.Text = num.ToString();
                    button.Left = (oszlop-1) * 40;
                    button.Top = (sor-1) * 40;
                    Controls.Add(button);  //ûrlapra rakjuk a gpmbot
                }
            }

            

            

        }
    }
}