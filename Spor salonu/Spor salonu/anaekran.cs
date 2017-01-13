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
    public partial class anaekran : Form
    {
        public anaekran()
        {
            InitializeComponent();
        }
        public anaekran(musteri gelenmusteri)
        {
            InitializeComponent();
        }
        musteri _musteri = new musteri();
       
       static List<musteri> abonekontrol = new List<musteri>();

        private void btnekle_Click(object sender, EventArgs e)
        {
           
            _musteri.kayıtno =int.Parse( txtkayıtno.Text);
            _musteri.adsoyad = txtadsoyad.Text;
            _musteri.tckimlik = txttc.Text;
            _musteri.telno = txttel.Text;
            _musteri.kayıtno =int.Parse( txtkayıtno.Text);
           
            if (comboBox1.SelectedItem.ToString() == "1")
            {
                _musteri.sure = "1";
                _musteri.ucret = 100;
            }
         else   if (comboBox1.SelectedItem.ToString() == "3")
            {
                _musteri.sure = "3";
                _musteri.ucret = 250;
            }
         else   if (comboBox1.SelectedItem.ToString() == "6")
            {
                _musteri.sure = "6";
                _musteri.ucret = 450;
            }
            else if (comboBox1.SelectedItem.ToString() == "9")
            {
                _musteri.sure = "9";
                _musteri.ucret = 600;
            }
            else
            {
                _musteri.sure = "12";
                _musteri.ucret = 850;
            }

          
            var result = abonekontrol.FirstOrDefault(x => x.kayıtno == _musteri.kayıtno);
            if (result==null)
            {
                abonekontrol.Add(_musteri);
                MessageBox.Show("KAYDINIZ ALINMIŞTIR");
            }
            else
            {
                MessageBox.Show("Zaten böle bir kayıt mevcut!!!");
            }
            
        }
            private void button1_Click_1(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            txtadsoyad.Visible = true;
            txtkayıtno.Visible = true;
            txttc.Visible = true;
            txttel.Visible = true;
            btnekle.Visible = true;
            comboBox1.Visible = true;
            labelsure.Visible = true;
           
        }

        private void bTNLİSTE_Click(object sender, EventArgs e)
        {
            kayıt_listesi frmkayıt = new kayıt_listesi(_musteri);
            frmkayıt.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
