namespace VillogoGomb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int n = 40;


            Button gomb = new Button();
            Controls.Add(gomb);

            gomb.Text = "Hi";
            gomb.Height = n;
            gomb.Width = n;
            gomb.Top = ClientRectangle.Height / 2 - gomb.Height / 2;
            gomb.Left = ClientRectangle.Width / 2 - gomb.Width / 2;



            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    /*   1. feladat
                    
                    VillogoGomb villogoGomb = new VillogoGomb(); 

                    Controls.Add(villogoGomb);
                    villogoGomb.Height = gomb.Height;
                    villogoGomb.Width = gomb.Width;

                    villogoGomb.Top = i * villogoGomb.Height;
                    villogoGomb.Left = j * villogoGomb.Width;

                    villogoGomb.I = i;
                    villogoGomb.J = j;


                     //   2. feladat

                    SzinezoGomb szinezoGomb = new SzinezoGomb();
                    Controls.Add(szinezoGomb);
                    szinezoGomb.Height = n;
                    szinezoGomb.Width = n;
                    szinezoGomb.Text= (i*j).ToString();
                    szinezoGomb.Top = i * szinezoGomb.Height;
                    szinezoGomb.Left = j * szinezoGomb.Width;

                    SzamoloGomb szamoloGomb = new SzamoloGomb();
                    Controls.Add(szamoloGomb);
                    szamoloGomb.Height = n;
                    szamoloGomb.Width = n;

                    szamoloGomb.Top = i * szamoloGomb.Height;
                    szamoloGomb.Left = j * szamoloGomb.Width;*/



                }
            }
            // KÓD HELYRERAKÁS/MEGSZÉPÍTÉS -> ctr k d 

            Random rnd = new Random();
            for (int i = 0; i < 100; i++)
            {
                Button button = new Button();
                Controls.Add(button);
                button.Top = rnd.Next(0, ClientRectangle.Height);
                button.Left = rnd.Next(0, ClientRectangle.Width);
                button.BackColor = Color.FromArgb(rnd.Next(0,255), rnd.Next(0, 255), rnd.Next(0, 255));  //random színek
                button.Width = rnd.Next(0, 80);
                button.Height = rnd.Next(0, 80);
            }
        }
    }
}