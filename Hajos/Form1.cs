namespace Hajos
{
    public partial class Form1 : Form
    {
        List<K�rd�s> �sszesK�rd�s; //referencia -> mem�ri�ban nem foglaltunk helyet neki, null �rt�k
        List<K�rd�s> AktualisK�rd�s = new List<K�rd�s>();
        int MegjelenitettK�rd�sekSz�ma = 0;
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            �sszesK�rd�s = Beolvas();
            for (int i = 0; i < 3; i++)
            {
                AktualisK�rd�s.Add(�sszesK�rd�s[0]);
                �sszesK�rd�s.RemoveAt(0);
            }
            dataGridView1.DataSource = AktualisK�rd�s;

            K�rd�sMegjelen�t�se(AktualisK�rd�s[MegjelenitettK�rd�sekSz�ma]);
            label1.BackColor = Color.LightPink;
        }

        void K�rd�sMegjelen�t�se(K�rd�s k�rd�s)
        {
            label1.Text = k�rd�s.K�rd�sSz�veg;
            textBox1.Text = k�rd�s.V�lasz1;
            textBox2.Text = k�rd�s.V�lasz2;
            textBox3.Text = k�rd�s.V�lasz3;

            if (string.IsNullOrEmpty(k�rd�s.URL))
            {
                pictureBox1.Visible = false;
            }
            else
            {
                pictureBox1.Visible = true;
                pictureBox1.Load("https://storage.altinum.hu/hajo/" + k�rd�s.URL);
            }

            //if (k�rd�s.HelyesV�laszokSz�ma == 3) 
            //{
            //    AktualisK�rd�s.RemoveAt(MegjelenitettK�rd�sekSz�ma);
            //    AktualisK�rd�s.Add(�sszesK�rd�s[0]);
            //}
            //dataGridView1.DataSource = null;
            //dataGridView1.DataSource = AktualisK�rd�s;

        }


        //F�jl beolvas�sa
        List<K�rd�s> Beolvas()
        {
            List<K�rd�s> k�rd�sek = new List<K�rd�s>();
            StreamReader be = new StreamReader("hajozasi_szabalyzat_kerdessor_BOM.txt", true);
            while (!be.EndOfStream)
            {
                string sor = be.ReadLine() ?? "n/a";
                string[] line = sor.Split("\t");

                if (line.Length != 7) continue;

                K�rd�s k = new K�rd�s();
                k.K�rd�sSz�veg = line[1].Trim('"');
                k.V�lasz1 = line[2].Trim('"');
                k.V�lasz2 = line[3].Trim('"');
                k.V�lasz3 = line[4].Trim('"');
                k.URL = line[5].Trim('"');

                int x = 0;
                int.TryParse(line[6], out x);

                k.HelyesV�lasz = x;


                k�rd�sek.Add(k);
            }
            be.Close();

            return k�rd�sek;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //tov�bb gomb
        private void button1_Click(object sender, EventArgs e)
        {
            MegjelenitettK�rd�sekSz�ma++;
            if (MegjelenitettK�rd�sekSz�ma == AktualisK�rd�s.Count) MegjelenitettK�rd�sekSz�ma = 0;
            if (AktualisK�rd�s[MegjelenitettK�rd�sekSz�ma].HelyesV�laszokSz�ma == 3)
            {
                AktualisK�rd�s.RemoveAt(MegjelenitettK�rd�sekSz�ma);
                AktualisK�rd�s.Add(�sszesK�rd�s[0]);

            }

            K�rd�sMegjelen�t�se(AktualisK�rd�s[MegjelenitettK�rd�sekSz�ma]);
            textBox1.BackColor = Color.White;
            textBox2.BackColor = Color.White;
            textBox3.BackColor = Color.White;
            dataGridView1.DataSource = AktualisK�rd�s;
            
        }


        //3 v�lasz
        private void textBox1_Click(object sender, EventArgs e)
        {
            
            if(AktualisK�rd�s[MegjelenitettK�rd�sekSz�ma].HelyesV�lasz == 1)
            {
                textBox1.BackColor = Color.LightGreen;
                AktualisK�rd�s[MegjelenitettK�rd�sekSz�ma].HelyesV�laszokSz�ma++;
            }
            else 
            {
                textBox1.BackColor = Color.DarkSalmon;
                AktualisK�rd�s[MegjelenitettK�rd�sekSz�ma].HelyesV�laszokSz�ma = 0;
            }
            //T�r�l();

        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            if (AktualisK�rd�s[MegjelenitettK�rd�sekSz�ma].HelyesV�lasz == 2)
            {
                textBox2.BackColor = Color.LightGreen;
                AktualisK�rd�s[MegjelenitettK�rd�sekSz�ma].HelyesV�laszokSz�ma++;
            }
            else
            {
                textBox2.BackColor = Color.DarkSalmon;
                AktualisK�rd�s[MegjelenitettK�rd�sekSz�ma].HelyesV�laszokSz�ma = 0;
            }
            //T�r�l();
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            if (AktualisK�rd�s[MegjelenitettK�rd�sekSz�ma].HelyesV�lasz == 3)
            {
                textBox3.BackColor = Color.LightGreen;
                AktualisK�rd�s[MegjelenitettK�rd�sekSz�ma].HelyesV�laszokSz�ma++;
            }
            else
            {
                textBox3.BackColor = Color.DarkSalmon;
                AktualisK�rd�s[MegjelenitettK�rd�sekSz�ma].HelyesV�laszokSz�ma = 0;
            }
            //T�r�l();
        }
        
        void T�r�l()
        {
            if (AktualisK�rd�s[MegjelenitettK�rd�sekSz�ma].HelyesV�laszokSz�ma == 3)
            {
                AktualisK�rd�s.RemoveAt(MegjelenitettK�rd�sekSz�ma);
                AktualisK�rd�s.Add(�sszesK�rd�s[0]);

            }
            //dataGridView1.DataSource = AktualisK�rd�s;
        }

        
    }
}