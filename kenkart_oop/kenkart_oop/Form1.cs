using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kenkart_oop
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();




        }
        public Form1(Kart yolcu)
        {
            InitializeComponent();
 




        }
        static List<Kart> kalıcı = new List<Kart>();

        Ogrencikart ogrenci = new Ogrencikart();
        Ogretmenkart ogretmen = new Ogretmenkart();
        Kart tam = new Kart();
        int kartid = 1;

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var item in kalıcı)
            {
                listBox1.Items.Add(item);
            }
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            if (radioogrenci.Checked == true)
            {
                ogrenci.bakiye = Convert.ToDouble(txtbakiye.Text);
                ogrenci.kartID = kartid;
                kartid++;

                ogrenci.kartTuru = YolcuTipi.Ogrenci;
                listBox1.Items.Add(ogrenci);
               kalıcı.Add(ogrenci);
            }
            else if (radioogretmen.Checked == true)
            {
                ogretmen.bakiye = Convert.ToDouble(txtbakiye.Text);
                ogretmen.kartID = kartid;
                kartid++;
                ogretmen.kartTuru = YolcuTipi.Ogretmen;
                listBox1.Items.Add(ogretmen);
              kalıcı.Add(ogretmen);

            }
            else
            {
                tam.bakiye = Convert.ToDouble(txtbakiye.Text);
                tam.kartID = kartid;
                kartid++;
                tam.kartTuru = YolcuTipi.Tam;
                listBox1.Items.Add(tam);
               kalıcı.Add(tam);
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            Kart yolcu = (Kart)listBox1.SelectedItem;

            if (yolcu.kartTuru == YolcuTipi.Ogrenci && (yolcu.bakiye - 1 > 0))
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                ogrenci = (Ogrencikart)yolcu;
                ogrenci.Okut();
                listBox1.Items.Add(ogrenci);
            }
            else if (yolcu.kartTuru == YolcuTipi.Ogretmen && (yolcu.bakiye - 2 > 0))
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                ogretmen = (Ogretmenkart)yolcu;
                ogretmen.Okut();
                listBox1.Items.Add(ogretmen);
            }
            else if (yolcu.kartTuru == YolcuTipi.Tam && (yolcu.bakiye - 3 > 0))
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                tam = (Kart)yolcu;
                tam.Okut();
                listBox1.Items.Add(tam);
            }
            else
            {
                MessageBox.Show("Bakiye Yetersiz!");
            }
            DialogResult result = MessageBox.Show("Bakiye Yüklemek İster Misin?", "Bildirim Ekranı", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Form2 frm2 = new Form2(yolcu);
                frm2.Show();
                this.Hide();
            }
        }
    }
}
