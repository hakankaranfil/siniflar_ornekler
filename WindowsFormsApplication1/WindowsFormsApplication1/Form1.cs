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

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        XmlDocument xmlDoc = new XmlDocument();
        XmlNodeList barajTitleList, barajDescriptionList, barajDateList;
        XmlNodeList kesintiTitleList, kesintiDescriptionList, kesintiDateList;

        XmlNodeList haberTitleList, haberLinkList, haberDateList;
        private void button1_Click(object sender, EventArgs e)
        {
            xmlDoc.Load("http://www.izsu.gov.tr/Pages/rss.aspx?rssId=3");

            barajTitleList = xmlDoc.SelectNodes("//channel/item/title");
            barajDescriptionList = xmlDoc.SelectNodes("//channel/item/description"); //Doluluk Yüzde Değeri
            barajDateList = xmlDoc.SelectNodes("//channel/item/pubDate");

            for (int i = 0; i < barajTitleList.Count; i++)
            {
                a b = new a(barajTitleList[i].InnerText, barajDescriptionList[i].InnerText);
                b.tarih = Convert.ToDateTime(barajDateList[i].InnerText);
                listBox1.Items.Add(b);
            }
        }
    }
}
