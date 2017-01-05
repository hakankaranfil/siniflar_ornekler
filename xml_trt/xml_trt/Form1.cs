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

namespace xml_trt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        XmlDocument xmlDoc = new XmlDocument();
        XmlNodeList barajTitleList, barajDescriptionList;


        private void button1_Click(object sender, EventArgs e)
        {

            xmlDoc.Load("http://www.trt.net.tr/rss/gundem.rss");

            barajTitleList = xmlDoc.SelectNodes("//channel/item/title");
            barajDescriptionList = xmlDoc.SelectNodes("//channel/item/description"); //Doluluk Yüzde Değeri
            //barajDateList = xmlDoc.SelectNodes("//channel/item/pubDate");

            for (int i = 0; i < barajTitleList.Count; i++)
            {
                haber b = new haber(barajTitleList[i].InnerText, barajDescriptionList[i].InnerText);
                //b.tarih = Convert.ToDateTime(barajDateList[i].InnerText);
                listBox1.Items.Add(b);
            }
        }
    }
}
