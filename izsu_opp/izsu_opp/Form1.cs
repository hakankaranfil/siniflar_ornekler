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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            abone müsteri = new abone();
            müsteri.aboneno = txtaboneno.Text;
            müsteri.adsoyad = txtisim.Text;
            müsteri.ilkdurum =Convert.ToInt32( txtilk.Text);
            müsteri.sondurum = Convert.ToInt32(txtson.Text);
            string abonetürü = radioev.Checked == true ? "ev":"kurum";
            müsteri.ödemetürü = abonetürü;
            listBox1.Items.Add(müsteri);

        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            abone müsteri = (abone)listBox1.SelectedItem;
            double ödeme = müsteri.odemeyap(müsteri.ilkdurum, müsteri.sondurum,müsteri.ödemetürü );
            DialogResult result = MessageBox.Show("Ödeme Tutarı: " + ödeme + "\nÖdeme Yapmak İstiyor Musunu?", "Ödeme Ekranı", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Form2 frm = new Form2(müsteri);
                frm.Show();

            }

        }
    }
}
