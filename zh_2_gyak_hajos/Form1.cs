using CsvHelper;
using System.ComponentModel;
using System.Globalization;

namespace zh_2_gyak_hajos
{
    public partial class Form1 : Form
    {
        //különálló lista
        BindingList<Kérdés> kérdések = new BindingList<Kérdés>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = kérdések;
            kérdésBindingSource.DataSource = kérdések;
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("hajos_szoveg.txt");
                var csv = new CsvReader(sr, CultureInfo.InvariantCulture);
                var tömb = csv.GetRecords<Kérdés>();

                foreach(var item in tömb)
                {
                    kérdések.Add(item);
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
                    csv.WriteRecords(kérdések);
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
            if (kérdésBindingSource.Current == null) return;

            if(MessageBox.Show("Biztos?","Törlés",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                kérdésBindingSource.RemoveCurrent();
            }
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            ÚjKérdés újKérdés = new ÚjKérdés();

            if (újKérdés.ShowDialog() == DialogResult.OK)
            {
                kérdésBindingSource.Add(újKérdés.Újkérdés);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (kérdésBindingSource.Current == null) return;

            FormEdit formEdit = new FormEdit();
            formEdit.ÚjVizsgaKérdés = (Kérdés)kérdésBindingSource.Current;
            formEdit.Show();
        }
    }
}