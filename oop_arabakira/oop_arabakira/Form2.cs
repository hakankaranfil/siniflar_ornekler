using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_arabakira
{
    public partial class Form2 : Form
    {
        arabakira araba2 = new arabakira();
        public Form2(arabakira gelenmüsteri)
        {
            InitializeComponent();
            txtücret.Text = gelenmüsteri.ucret.ToString();
            txtgün.Text = gelenmüsteri.gunluk.ToString();
            araba2 = gelenmüsteri;
        }

        private void txtgün_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnhesapla_Click(object sender, EventArgs e)
        {
            araba2.adsoyad = txtadsoyad.Text;
            araba2.tckimlik =int.Parse( txtkimlik.Text);
            Form1 frm = new Form1(araba2);
            frm.Show();
            this.Hide();

           
            
       
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txtgün.Enabled = false;
            txtücret.Enabled = false;
        }
    }
}
