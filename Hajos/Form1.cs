namespace Hajos
{
    public partial class Form1 : Form
    {
        List<K�rd�s> �sszesK�rd�s; //referencia -> mem�ri�ban nem foglaltunk helyet neki, null �rt�k
        List<K�rd�s> AktualisK�rd�s = new List<K�rd�s>();
        int MegjelenitettK�rd�sekSz�ma = 5;
        public Form1()
        {
            InitializeComponent();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            �sszesK�rd�s = Beolvas();
            for (int i = 0; i < 6; i++)
            {
                AktualisK�rd�s.Add(�sszesK�rd�s[0]);
                �sszesK�rd�s.RemoveAt(0);
            }
            
        }

        List<K�rd�s> Beolvas() 
        {
            List<K�rd�s> k�rd�sek = new List<K�rd�s>();
            StreamReader be = new StreamReader("hajozasi_szabalyzat_kerdessor_BOM.txt", true);
            while(!be.EndOfStream)
            {
                string sor = be.ReadLine()?? "n/a" ;
                string[] line = sor.Split("\t");

                if (line.Length != 7) continue;

                K�rd�s k= new K�rd�s();
                k.K�rd�sSz�veg = line[1];
                k.V�lasz1 = line[2];
                k.V�lasz2 = line[3];
                k.V�lasz3 = line[4];
                k.URL = line[5];

                int x = 0;
                int.TryParse(line[6], out x);

                k.HelyesV�lasz = x;
                

                k�rd�sek.Add(k);
            }
            be.Close();

            return k�rd�sek;
        }
    }
}