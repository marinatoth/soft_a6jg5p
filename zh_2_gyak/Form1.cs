using CsvHelper;
using System.ComponentModel;
using System.Globalization;
using zh_2_gyak_Futok;

namespace zh_2_gyak
{
    public partial class Form1 : Form
    {
        //osztály szinten lista létre hozása
        BindingList<Futók> futók = new BindingList<Futók>();
        public Form1()
        {
            InitializeComponent();
            futókBindingSource.DataSource = futók; //FONTOS!!! elõször datagridview1, utána ...BindingSource
            checkBox1.Checked = true;
        }

        private void buttonBetöltés_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("szoveg.txt");

                var csv = new CsvReader(sr,CultureInfo.InvariantCulture);
                var t = csv.GetRecords<Futók>();

                foreach(var item in t)
                {
                    futók.Add(item);
                }

                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonMentés_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog(); //kell gombhoz
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamWriter sw = new StreamWriter(saveFileDialog.FileName);
                    var csv = new CsvWriter(sw,CultureInfo.InvariantCulture);
                    csv.WriteRecords(futók);

                    sw.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);                    
                }
            }
        }

        private void buttonTörlés_Click(object sender, EventArgs e)
        {
            if (futókBindingSource.Current == null) return;
            if ( MessageBox.Show("A","B",MessageBoxButtons.YesNo) == DialogResult.Yes )
            {
                futókBindingSource.RemoveCurrent();
            }

        }

        private void buttonÚj_Click(object sender, EventArgs e)
        {
            FormAddÚjFutó újFutó = new FormAddÚjFutó();

            if (újFutó.ShowDialog() == DialogResult.OK)
            {
                futókBindingSource.Add(újFutó.ÚjFutó);
            }
        }

        private void buttonSzámolás_Click(object sender, EventArgs e)
        {
            double összeg = 0;
            int darab = 0;

            double minimum = double.MaxValue;

            //átlag
            foreach (var item in futók)
            {
                if (item.Nemzetiseg == "USA")
                {
                    összeg += item.EredmenyPerc;
                    darab++;
                }
            }
            double átlag = összeg / futók.Count;
            
        }
    }
}