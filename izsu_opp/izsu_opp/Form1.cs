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
        public Form1(abone gelen)
        {
            InitializeComponent();
        }
       static List<abone> deger = new List<abone>();
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            abone müsteri = new abone();
            müsteri.aboneno = Convert.ToInt32(txtaboneno.Text);
            müsteri.adsoyad = txtisim.Text;
            müsteri.ilkdurum = Convert.ToInt32(txtilk.Text);
            müsteri.sondurum = Convert.ToInt32(txtson.Text);
            string abonetürü = radioev.Checked == true ? "ev" : "kurum";
            müsteri.ödemetürü = abonetürü;
            listBox1.Items.Add(müsteri);
            deger.Add(müsteri);








        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            abone müsteri = (abone)listBox1.SelectedItem;
            double ödeme = müsteri.odemeyap(müsteri.ilkdurum, müsteri.sondurum, müsteri.ödemetürü);
            DialogResult result = MessageBox.Show("Ödeme Tutarı: " + ödeme + "\nÖdeme ekranına aktarılıyorsunuz", "Ödeme Ekranı", MessageBoxButtons.OKCancel);
            müsteri.güncelborc = ödeme;
            if (result == DialogResult.OK)
            {
                listBox2.Items.Add(deger);
                Form2 frm = new Form2(müsteri);
                frm.Show();
                
            }


            


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var item in deger)
            {
                listBox1.Items.Add(item);
            }
        }
    }

    
    }
    

