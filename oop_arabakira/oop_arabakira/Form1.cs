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
        
        arabakira kira = new arabakira();
        fiat _fiat = new fiat();
        honda _honda = new honda();
        mercedes _mercedes = new mercedes();
        bmw _bmw = new bmw();
       


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            
            if (comboBox1.SelectedItem.ToString() == "fiat")
            {
                


                listBox1.Items.Add("marka=" + _fiat.marka + " " + "model=" + _fiat.model + " " + "yakıt tüketim=" + _fiat.yakıttüketim + " " + "ücret=" + "");
               
                
            }
            else if (comboBox1.SelectedItem.ToString() == "honda")
            {
                listBox1.Items.Add("marka="+ _honda.marka + " "+"model=" + _honda.model + " " +"yakıt tüketim="+ _honda.yakıttüketim + " " +"ücret="+"");
            
            }
            else if (comboBox1.SelectedItem.ToString() == "mercedes")
            {
                listBox1.Items.Add("marka=" + _mercedes.marka + " " + "model=" + _mercedes.model + " " + "yakıt tüketim=" + _mercedes.yakıttüketim + " " + "ücret=" + kira.guncelborc);
            }
            else
            {
                listBox1.Items.Add("marka=" + _bmw.marka + " " + "model=" + _bmw.model + " " + "yakıt tüketim=" + _bmw.yakıttüketim + " " + "ücret=" + kira.guncelborc);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //txtgün.Enabled = false;
            //btnhesapla.Enabled = false;
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            //DialogResult result = MessageBox.Show("Ödeme Tutarı: " + + "\nÖdeme Yapmak İstiyor Musunu?", "Ödeme Ekranı", MessageBoxButtons.YesNo);

        }


        private void btnhesapla_Click(object sender, EventArgs e)
        {
          
        }
    }
}
