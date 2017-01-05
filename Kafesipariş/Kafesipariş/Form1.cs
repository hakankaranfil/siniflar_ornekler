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
            //_masa.masano =Convert.ToInt32( masa.Text);
            //labelmasano.Text =_masa.masano.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            siparis _siparis = new siparis();
            try
            {
                _siparis._yemekadi = comboyemek.SelectedItem.ToString();

                _siparis.yemekList.Add(_siparis);
                _siparis._icecekadi = comboicecek.SelectedItem.ToString();
                _siparis.icecekList.Add(_siparis);
                _masa.siparislist.Add(_siparis);
                foreach (var item in _masa.siparislist)
                {
                    listBox1.Items.Add(item);
                }




                //_siparis._icecekadi = comboicecek.SelectedItem.ToString();
                //_siparis.icecekList.Add(_siparis);

                //foreach (var item in _siparis.icecekList)
                //{
                //    listBox1.Items.Add(item);

                //}
            }
            catch (Exception)
            {

               
            }            
            
          

        }
    }
}
