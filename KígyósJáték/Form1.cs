using System.Runtime.Intrinsics.X86;

namespace KígyósJáték
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int fej_X = 100;
        int fej_Y = 100;

        int irány_X = 1;
        int irány_Y = 0;
        int lépésSzám;
        int hossz = 5;

        Random rn = new Random();
        List<KígyóElem> kígyó = new List<KígyóElem>();
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < rn.Next(1, 3); i++)
            {
                Alma alma = new Alma();
                alma.Top = rn.Next(ClientRectangle.Height / KígyóElem.méret) * KígyóElem.méret;
                alma.Left = rn.Next(ClientRectangle.Width / KígyóElem.méret) * KígyóElem.méret;
                Controls.Add(alma);
            }
            
                Méreg méreg = new Méreg();
                méreg.Top = rn.Next(ClientRectangle.Height / KígyóElem.méret) * KígyóElem.méret;
                méreg.Left = rn.Next(ClientRectangle.Width / KígyóElem.méret) * KígyóElem.méret;
                Controls.Add(méreg);
            


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lépésSzám++;

            //Növekedés

            fej_X += irány_X * KígyóElem.méret;
            fej_Y += irány_Y * KígyóElem.méret;

            foreach (object elem in Controls)
            {
                if (elem is KígyóElem)
                {
                    KígyóElem k = (KígyóElem)elem;
                    if (k.Top == fej_Y && k.Left == fej_X)
                    {
                        timer1.Enabled = false;
                        MessageBox.Show("GAME OVER");
                    }
                }

                if (elem is Alma)
                {
                    Alma a = (Alma)elem;
                    if (a.Top == fej_Y && a.Left == fej_X)
                    {
                        hossz++;
                        Controls.Remove(a);

                        for (int i = 0; i < rn.Next(3); i++)
                        {
                            Alma alma = new Alma();
                            alma.Top = rn.Next(ClientRectangle.Height / KígyóElem.méret) * KígyóElem.méret;
                            alma.Left = rn.Next(ClientRectangle.Width / KígyóElem.méret) * KígyóElem.méret;
                            Controls.Add(alma);
                        }
                    }
                }

                if (elem is Méreg)
                {
                    Méreg m = (Méreg)elem;
                    if (m.Top == fej_Y && m.Left == fej_X)
                    {
                        timer1.Enabled = false;
                        MessageBox.Show("GAME OVER");
                    }
                }
            }

            KígyóElem kígyóElem = new KígyóElem();
            kígyóElem.Top = fej_Y;
            kígyóElem.Left = fej_X;

            kígyó.Add(kígyóElem);

            if (kígyó.Count > hossz)
            {
                KígyóElem levág = kígyó[0];
                Controls.Remove(levág);
                kígyó.RemoveAt(0);
            }

            Controls.Add(kígyóElem);
            if (lépésSzám % 2 == 0) kígyóElem.BackColor = Color.LightPink;
        }



        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                irány_X = 0;
                irány_Y = -1;
            }
            if (e.KeyCode == Keys.Down)
            {
                irány_X = 0;
                irány_Y = 1;
            }
            if (e.KeyCode == Keys.Left)
            {
                irány_X = -1;
                irány_Y = 0;
            }
            if (e.KeyCode == Keys.Right)
            {
                irány_X = 1;
                irány_Y = 0;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Méreg méreg = new Méreg();
            méreg.Top = rn.Next(ClientRectangle.Height / KígyóElem.méret) * KígyóElem.méret;
            méreg.Left = rn.Next(ClientRectangle.Width / KígyóElem.méret) * KígyóElem.méret;
            Controls.Add(méreg);
        }
    }
}