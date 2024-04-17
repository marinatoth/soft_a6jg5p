using CsvHelper;
using System.ComponentModel;
using System.Globalization;
using zh_2_gyak_Futok;

namespace zh_2_gyak
{
    public partial class Form1 : Form
    {
        //oszt�ly szinten lista l�tre hoz�sa
        BindingList<Fut�k> fut�k = new BindingList<Fut�k>();
        public Form1()
        {
            InitializeComponent();
            fut�kBindingSource.DataSource = fut�k; //FONTOS!!! el�sz�r datagridview1, ut�na ...BindingSource
            checkBox1.Checked = true;
        }

        private void buttonBet�lt�s_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("szoveg.txt");

                var csv = new CsvReader(sr,CultureInfo.InvariantCulture);
                var t = csv.GetRecords<Fut�k>();

                foreach(var item in t)
                {
                    fut�k.Add(item);
                }

                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonMent�s_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog(); //kell gombhoz
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamWriter sw = new StreamWriter(saveFileDialog.FileName);
                    var csv = new CsvWriter(sw,CultureInfo.InvariantCulture);
                    csv.WriteRecords(fut�k);

                    sw.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);                    
                }
            }
        }

        private void buttonT�rl�s_Click(object sender, EventArgs e)
        {
            if (fut�kBindingSource.Current == null) return;
            if ( MessageBox.Show("A","B",MessageBoxButtons.YesNo) == DialogResult.Yes )
            {
                fut�kBindingSource.RemoveCurrent();
            }

        }

        private void button�j_Click(object sender, EventArgs e)
        {
            FormAdd�jFut� �jFut� = new FormAdd�jFut�();

            if (�jFut�.ShowDialog() == DialogResult.OK)
            {
                fut�kBindingSource.Add(�jFut�.�jFut�);
            }
        }

        private void buttonSz�mol�s_Click(object sender, EventArgs e)
        {
            double �sszeg = 0;
            int darab = 0;

            double minimum = double.MaxValue;

            //�tlag
            foreach (var item in fut�k)
            {
                if (item.Nemzetiseg == "USA")
                {
                    �sszeg += item.EredmenyPerc;
                    darab++;
                }
            }
            double �tlag = �sszeg / fut�k.Count;
            
        }
    }
}