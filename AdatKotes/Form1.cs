using CsvHelper;
using System.ComponentModel;
using System.Formats.Asn1;
using System.Globalization;

namespace AdatKotes
{
    public partial class Form1 : Form
    {
        BindingList<CountryData> countryList = new();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            try
            {
                //csv file -> copy if newer
                StreamReader sr = new StreamReader("european_countries.csv");
                var csv = new CsvReader(sr, CultureInfo.InvariantCulture);
                var tömb = csv.GetRecords<CountryData>();

                foreach (var item in tömb)
                {
                    countryList.Add(item);
                }
                sr.Close();                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            countryDataBindingSource.DataSource = countryList;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            FormEditCountry fec = new FormEditCountry();
            if (countryDataBindingSource.Current is CountryData)
            {
                fec.EditedCountryData = countryDataBindingSource.Current as CountryData;
                fec.Show();
            }
            else
            {
                MessageBox.Show("Elõször meg kell nyitni egy fájlt!");
            }

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamWriter sw = new StreamWriter(sfd.FileName);
                    var csv = new CsvWriter(sw, CultureInfo.InvariantCulture);
                    csv.WriteRecords(countryList);

                    sw.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            
        }
    }
}