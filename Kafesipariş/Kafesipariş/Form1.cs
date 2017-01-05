using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kafesipariş
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        masa _masa = new masa();
        siparis _siparis = new siparis();
        
    private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        int sayac = 1;
        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            comboyemek.Items.Add("Kuru Fasulye");
            comboyemek.Items.Add("Tavuklu Pilav");
            comboyemek.Items.Add("simit+tost");
            comboyemek.Items.Add("lazanya");
            comboicecek.Items.Add("su");
            comboicecek.Items.Add("Kola");
            comboicecek.Items.Add("limonata");
            comboicecek.Items.Add("çay");
            comboicecek.Items.Add("kahve");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if ((i != 4 || j > 1) && (i != 4 || j < 8))
                    {
                        Button btn = new Button();
                        btn.Width = 30;
                        btn.Height = 30;
                        btn.Text = sayac.ToString();

                        btn.Left = (btn.Width * j);
                        btn.Top = (btn.Height * i);
                        sayac++;
                        btn.Click += Button_Click;
                        this.Controls.Add(btn);
                    }
                }
            }
        }
        private void Button_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            listBox1.Items.Clear();


            Button masa = sender as Button;
            _masa.masano = int.Parse(masa.Text);
            labelmasa.Text = _masa.masano.ToString();
           }

        private void button1_Click(object sender, EventArgs e)
        {

            
            if (comboyemek.SelectedItem != null && numericUpDownyemek.Value != 0)
            {
                _siparis._yemekadi = comboyemek.SelectedItem.ToString();
                _siparis.yemekadet = int.Parse(numericUpDownyemek.Value.ToString());
                int yemekadet = _siparis.yemekadet;

                if (comboicecek.SelectedItem != null && numericUpDownicecek.Value != 0)
                {
                    _siparis._icecekadi = comboicecek.SelectedItem.ToString();
                    _siparis.icecekadet = int.Parse(numericUpDownicecek.Value.ToString());
                    int siparisadet = _siparis.icecekadet;


                    _masa.siparislist.Add(_siparis);




                    foreach (var item in _masa.siparislist)
                    {
                        listBox1.Items.Add(item.yemekadet + " " + "adet" + " " + item.yemekadi);
                        listBox1.Items.Add(item.icecekadet + " " + "adet" + " " + item._icecekadi);
                        listBox1.Items.Add(_siparis.hesapla(yemekadet,siparisadet));
                    }
                }
            }
            
        }

        private void btnöde_Click(object sender, EventArgs e)
        {
            

        }

}
    }


