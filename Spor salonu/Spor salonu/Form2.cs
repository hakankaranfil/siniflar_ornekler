using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spor_salonu
{
    public partial class Form2 : Form
    {
        musteri _frm2musteri = new musteri();
        public Form2(musteri gelenmusteri)
        {
            InitializeComponent();
            txtkayıtno.Text = gelenmusteri.kayıtno.ToString();
            txtadsoyad.Text = gelenmusteri.adsoyad;
            txttc.Text = gelenmusteri.tckimlik;
            txttel.Text = gelenmusteri.telno;
            txtsure.Text = gelenmusteri.sure;
            txtucret.Text = gelenmusteri.ucret.ToString();
            _frm2musteri = gelenmusteri;
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            anaekran frm = new anaekran(_frm2musteri);
            frm.Show();
            this.Hide();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kayıt_listesi kayıt = new kayıt_listesi(_frm2musteri);
            kayıt.Show();
            this.Hide();
        }
    }
}
