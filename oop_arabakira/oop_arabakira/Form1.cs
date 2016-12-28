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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        fiat _fiat = new fiat();
        honda _honda = new honda();
        mercedes _mercedes = new mercedes();
        bmw _bmw = new bmw();
        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "fiat")
            {
                int gunsayısı = Convert.ToInt32(txtgün.Text);
                int sonuc = (_fiat.hesapla(gunsayısı));

                listBox1.Items.Add("marka=" + _fiat.marka + " " + "model=" + _fiat.model + " " + "yakıt tüketim=" + _fiat.yakıttüketim + " " + "ücret=" + sonuc);
            }
            else if (comboBox1.SelectedItem.ToString() == "honda")
            {
                listBox1.Items.Add("marka="+ _honda.marka + " "+"model=" + _honda.model + " " +"yakıt tüketim="+ _honda.yakıttüketim + " " +"ücret="+ _honda.ucret);
            }
            else if (comboBox1.SelectedItem.ToString() == "mercedes")
            {
                listBox1.Items.Add("marka=" + _mercedes.marka + " " + "model=" + _mercedes.model + " " + "yakıt tüketim=" + _mercedes.yakıttüketim + " " + "ücret=" + _mercedes.ucret);
            }
            else
            {
                listBox1.Items.Add("marka=" + _bmw.marka + " " + "model=" + _bmw.model + " " + "yakıt tüketim=" + _bmw.yakıttüketim + " " + "ücret=" + _bmw.ucret);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //txtgün.Enabled = false;
            //btnhesapla.Enabled = false;
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {

        }
        //{
        //    txtgün.Enabled = true;
        //    btnhesapla.Enabled = true;
        //}

        private void btnhesapla_Click(object sender, EventArgs e)
        {
            //if (listBox1.SelectedItem.ToString()==
            //{

            //}
        }
    }
}
