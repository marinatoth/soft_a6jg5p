namespace jatek
{
    public partial class Form1 : Form
    {
        int sorszam;
        public Form1()
        {
            InitializeComponent();

            StreamReader be = new StreamReader("jatek2.txt");
            while (!be.EndOfStream && sorszam<121)
            {
                string kerdes = be.ReadLine();
                string v1 = be.ReadLine();
                string v2 = be.ReadLine();
                string v3 = be.ReadLine();
                string v4 = be.ReadLine();
                int helyes = int.Parse(be.ReadLine());

                KérdésUserControl Kcontrol = new KérdésUserControl(helyes);
                Controls.Add(Kcontrol);
                Kcontrol.Top = (Kcontrol.Height + 1) * sorszam;

                Kcontrol.label1.Text = kerdes;
                Kcontrol.button1.Text = v1;
                Kcontrol.button2.Text = v2;
                Kcontrol.button3.Text = v3;
                Kcontrol.button4.Text = v4;
                
                
                sorszam++;
            }


            be.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}