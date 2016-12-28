using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_kenkart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ogrenci ogr = new ogrenci();
        ogretmen ogretmen = new ogretmen();
        kart tam = new kart();
        int kartıd = 1;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioogrenci.Checked==true)
            {
                ogr.bakiye = Convert.ToDouble(txtbakiye.Text);
                ogr.kartıd = kartıd;
                kartıd++;
                ogr.okuladi = textBox1.Text;
                listBox1.Items.Add(ogr);
            }
            else if (radioogretmen.Checked==true)
            {
                ogretmen.bakiye = Convert.ToDouble(txtbakiye.Text);
                ogr.kartıd = kartıd;
                kartıd++;
                listBox1.Items.Add(ogretmen);
            }
            else
            {
                tam.bakiye =Convert.ToDouble( txtbakiye.Text);
                tam.kartıd = kartıd;
                kartıd++;
                listBox1.Items.Add(tam);
            }
        }

        private void radioogrenci_CheckedChanged(object sender, EventArgs e)
        {
            //groupBox1.Enabled = radioogrenci.Checked = true ? true : false;
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            var yolcu = listBox1.SelectedItem;
        }
    }
}
