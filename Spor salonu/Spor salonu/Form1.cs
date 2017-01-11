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
        public Form1(musteri gelenmusteri)
        {
            InitializeComponent();
        }
        musteri _musteri = new musteri();
       
       static List<musteri> abonekontrol = new List<musteri>();

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
            _musteri.kayıtno =int.Parse( txtkayıtno.Text);
            int i = dataGridView1.Rows.Add();
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
                listBox1.Items.Add(_musteri);
                
            }
            else
            {
                
            }
         

            //dataGridView1.Rows[i].Cells[0].Value = _musteri.kayıtno;
            //dataGridView1.Rows[i].Cells[1].Value = _musteri.adsoyad;
            //dataGridView1.Rows[i].Cells[2].Value = _musteri.tckimlik;
            //dataGridView1.Rows[i].Cells[3].Value = _musteri.telno;


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var item in abonekontrol)
            {
                listBox1.Items.Add(item);
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            musteri _musteri = (musteri)listBox1.SelectedItem;
            Form2 frm2 = new Form2(_musteri);
            frm2.Show();
            this.Hide();
        }
    }
}
