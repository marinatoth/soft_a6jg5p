namespace Hajos
{
    public partial class Form1 : Form
    {
        List<Kérdés> ÖsszesKérdés; //referencia -> memóriában nem foglaltunk helyet neki, null érték
        List<Kérdés> AktualisKérdés = new List<Kérdés>();
        int MegjelenitettKérdésekSzáma = 0;
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            ÖsszesKérdés = Beolvas();
            for (int i = 0; i < 3; i++)
            {
                AktualisKérdés.Add(ÖsszesKérdés[0]);
                ÖsszesKérdés.RemoveAt(0);
            }
            dataGridView1.DataSource = AktualisKérdés;

            KérdésMegjelenítése(AktualisKérdés[MegjelenitettKérdésekSzáma]);
            label1.BackColor = Color.LightPink;
        }

        void KérdésMegjelenítése(Kérdés kérdés)
        {
            label1.Text = kérdés.KérdésSzöveg;
            textBox1.Text = kérdés.Válasz1;
            textBox2.Text = kérdés.Válasz2;
            textBox3.Text = kérdés.Válasz3;

            if (string.IsNullOrEmpty(kérdés.URL))
            {
                pictureBox1.Visible = false;
            }
            else
            {
                pictureBox1.Visible = true;
                pictureBox1.Load("https://storage.altinum.hu/hajo/" + kérdés.URL);
            }

            //if (kérdés.HelyesVálaszokSzáma == 3) 
            //{
            //    AktualisKérdés.RemoveAt(MegjelenitettKérdésekSzáma);
            //    AktualisKérdés.Add(ÖsszesKérdés[0]);
            //}
            //dataGridView1.DataSource = null;
            //dataGridView1.DataSource = AktualisKérdés;

        }


        //Fájl beolvasása
        List<Kérdés> Beolvas()
        {
            List<Kérdés> kérdések = new List<Kérdés>();
            StreamReader be = new StreamReader("hajozasi_szabalyzat_kerdessor_BOM.txt", true);
            while (!be.EndOfStream)
            {
                string sor = be.ReadLine() ?? "n/a";
                string[] line = sor.Split("\t");

                if (line.Length != 7) continue;

                Kérdés k = new Kérdés();
                k.KérdésSzöveg = line[1].Trim('"');
                k.Válasz1 = line[2].Trim('"');
                k.Válasz2 = line[3].Trim('"');
                k.Válasz3 = line[4].Trim('"');
                k.URL = line[5].Trim('"');

                int x = 0;
                int.TryParse(line[6], out x);

                k.HelyesVálasz = x;


                kérdések.Add(k);
            }
            be.Close();

            return kérdések;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //tovább gomb
        private void button1_Click(object sender, EventArgs e)
        {
            MegjelenitettKérdésekSzáma++;
            if (MegjelenitettKérdésekSzáma == AktualisKérdés.Count) MegjelenitettKérdésekSzáma = 0;
            if (AktualisKérdés[MegjelenitettKérdésekSzáma].HelyesVálaszokSzáma == 3)
            {
                AktualisKérdés.RemoveAt(MegjelenitettKérdésekSzáma);
                AktualisKérdés.Add(ÖsszesKérdés[0]);

            }

            KérdésMegjelenítése(AktualisKérdés[MegjelenitettKérdésekSzáma]);
            textBox1.BackColor = Color.White;
            textBox2.BackColor = Color.White;
            textBox3.BackColor = Color.White;
            dataGridView1.DataSource = AktualisKérdés;
            
        }


        //3 válasz
        private void textBox1_Click(object sender, EventArgs e)
        {
            
            if(AktualisKérdés[MegjelenitettKérdésekSzáma].HelyesVálasz == 1)
            {
                textBox1.BackColor = Color.LightGreen;
                AktualisKérdés[MegjelenitettKérdésekSzáma].HelyesVálaszokSzáma++;
            }
            else 
            {
                textBox1.BackColor = Color.DarkSalmon;
                AktualisKérdés[MegjelenitettKérdésekSzáma].HelyesVálaszokSzáma = 0;
            }
            //Töröl();

        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            if (AktualisKérdés[MegjelenitettKérdésekSzáma].HelyesVálasz == 2)
            {
                textBox2.BackColor = Color.LightGreen;
                AktualisKérdés[MegjelenitettKérdésekSzáma].HelyesVálaszokSzáma++;
            }
            else
            {
                textBox2.BackColor = Color.DarkSalmon;
                AktualisKérdés[MegjelenitettKérdésekSzáma].HelyesVálaszokSzáma = 0;
            }
            //Töröl();
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            if (AktualisKérdés[MegjelenitettKérdésekSzáma].HelyesVálasz == 3)
            {
                textBox3.BackColor = Color.LightGreen;
                AktualisKérdés[MegjelenitettKérdésekSzáma].HelyesVálaszokSzáma++;
            }
            else
            {
                textBox3.BackColor = Color.DarkSalmon;
                AktualisKérdés[MegjelenitettKérdésekSzáma].HelyesVálaszokSzáma = 0;
            }
            //Töröl();
        }
        
        void Töröl()
        {
            if (AktualisKérdés[MegjelenitettKérdésekSzáma].HelyesVálaszokSzáma == 3)
            {
                AktualisKérdés.RemoveAt(MegjelenitettKérdésekSzáma);
                AktualisKérdés.Add(ÖsszesKérdés[0]);

            }
            //dataGridView1.DataSource = AktualisKérdés;
        }

        
    }
}