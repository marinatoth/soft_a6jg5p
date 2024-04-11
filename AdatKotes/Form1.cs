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
            StreamReader sr = new StreamReader("european_countries.csv");
            var csv = new CsvReader(sr, CultureInfo.InvariantCulture);
            var tömb = csv.GetRecords<CountryData>();

            foreach (var item in tömb)
            {
                countryList.Add(item);
            }


            sr.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = countryList;
        }
    }
}