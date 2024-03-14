namespace Hajos
{
    public partial class Form1 : Form
    {
        List<Kérdés> ÖsszesKérdés; //referencia -> memóriában nem foglaltunk helyet neki, null érték
        List<Kérdés> AktualisKérdés = new List<Kérdés>();
        int MegjelenitettKérdésekSzáma = 5;
        public Form1()
        {
            InitializeComponent();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            ÖsszesKérdés = Beolvas();
            for (int i = 0; i < 6; i++)
            {
                AktualisKérdés.Add(ÖsszesKérdés[0]);
                ÖsszesKérdés.RemoveAt(0);
            }
            
        }

        List<Kérdés> Beolvas() 
        {
            List<Kérdés> kérdések = new List<Kérdés>();
            StreamReader be = new StreamReader("hajozasi_szabalyzat_kerdessor_BOM.txt", true);
            while(!be.EndOfStream)
            {
                string sor = be.ReadLine()?? "n/a" ;
                string[] line = sor.Split("\t");

                if (line.Length != 7) continue;

                Kérdés k= new Kérdés();
                k.KérdésSzöveg = line[1];
                k.Válasz1 = line[2];
                k.Válasz2 = line[3];
                k.Válasz3 = line[4];
                k.URL = line[5];

                int x = 0;
                int.TryParse(line[6], out x);

                k.HelyesVálasz = x;
                

                kérdések.Add(k);
            }
            be.Close();

            return kérdések;
        }
    }
}