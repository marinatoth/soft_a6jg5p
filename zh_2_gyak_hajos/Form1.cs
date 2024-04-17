using CsvHelper;
using System.ComponentModel;
using System.Globalization;

namespace zh_2_gyak_hajos
{
    public partial class Form1 : Form
    {
        //k�l�n�ll� lista
        BindingList<K�rd�s> k�rd�sek = new BindingList<K�rd�s>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = k�rd�sek;
            k�rd�sBindingSource.DataSource = k�rd�sek;
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("hajos_szoveg.txt");
                var csv = new CsvReader(sr, CultureInfo.InvariantCulture);
                var t�mb = csv.GetRecords<K�rd�s>();

                foreach(var item in t�mb)
                {
                    k�rd�sek.Add(item);
                }

                sr.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter sw = new StreamWriter(saveFileDialog.FileName);
                    var csv = new CsvWriter(sw, CultureInfo.InvariantCulture);
                    csv.WriteRecords(k�rd�sek);
                    sw.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (k�rd�sBindingSource.Current == null) return;

            if(MessageBox.Show("Biztos?","T�rl�s",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                k�rd�sBindingSource.RemoveCurrent();
            }
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            �jK�rd�s �jK�rd�s = new �jK�rd�s();

            if (�jK�rd�s.ShowDialog() == DialogResult.OK)
            {
                k�rd�sBindingSource.Add(�jK�rd�s.�jk�rd�s);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (k�rd�sBindingSource.Current == null) return;

            FormEdit formEdit = new FormEdit();
            formEdit.�jVizsgaK�rd�s = (K�rd�s)k�rd�sBindingSource.Current;
            formEdit.Show();
        }
    }
}