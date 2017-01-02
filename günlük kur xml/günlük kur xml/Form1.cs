using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace günlük_kur_xml
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btngetir_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

            if (comboBox1.SelectedItem.ToString()=="dolar")
            {
                var xmldoc = new XmlDocument();
                xmldoc.Load(" http://www.tcmb.gov.tr/kurlar/today.xml");
                DateTime tarih = Convert.ToDateTime(xmldoc.SelectSingleNode("//Tarih_Date").Attributes["Tarih"].Value);
                string USD = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
                
                dataGridView1.Rows.Add("usd" , tarih.ToString("dd/MM/yyy") , USD);
            }
        }
    }
}
