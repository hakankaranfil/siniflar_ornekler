using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinema_programı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            müsteri _müsteri = new müsteri();
            _müsteri.koltukno = int.Parse(txtkoltukno.Text);
            _müsteri.adsoyad = txtadsoyad.Text;
            _müsteri.durum = radioButton1.Checked == true ? "ögrenci" : "kurum";
            _müsteri.ödeme = _müsteri.ödemeyap(_müsteri.durum);

            listBox1.Items.Add(_müsteri);
            


        }
    }
}
