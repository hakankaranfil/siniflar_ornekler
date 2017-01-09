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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        musteri _musteri = new musteri();
        int kayıt = 1;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            _musteri.kayıtno =int.Parse( txtkayıtno.Text);
            _musteri.adsoyad = txtadsoyad.Text;
            _musteri.tckimlik = txttc.Text;
            _musteri.telno = txttel.Text;
            int i = dataGridView1.Rows.Add();



            dataGridView1.Rows[i].Cells[0].Value = kayıt;
            kayıt++;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtkayıtno.Text = kayıt.ToString();
        }
    }
}
