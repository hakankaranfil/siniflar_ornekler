using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xml_örnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        xmldocuments xmldoc = new xmldocuments();
        xmlnodelist haberlist, haberDescriptionList;

        private void btngetir_Click(object sender, EventArgs e)
        {
            xmldoc.load = ("http://www.trt.net.tr/rss/gundem.rss");
            haberlist = xmldoc.selectnodes("//channel/item/title");
            haberDescriptionList = xmldoc.selectnodes("//channel/item/description");
            for (int i = 0; i < haberlist.count ; i++)
            {

            }


        }
    }
}
