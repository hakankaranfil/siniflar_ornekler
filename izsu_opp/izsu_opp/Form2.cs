using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace izsu_opp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
        }

        public Form2(abone aboneform2)
        {
            InitializeComponent();
            textBox1.Text = aboneform2.aboneno.ToString();
            textBox2.Text = aboneform2.adsoyad;
            textBox3.Text = aboneform2.odemeyap(aboneform2.ilkdurum,aboneform2.sondurum,aboneform2.ödemetürü).ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
             
            Form3 frm = new Form3();
            frm.Show();
        }
    }
}
