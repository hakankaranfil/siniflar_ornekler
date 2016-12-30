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


                _fiat.secim = arabatipi.fiat;
                listBox1.Items.Add("marka=" + _fiat.marka + " " + "model=" + _fiat.model + " " + "yakıt tüketim=" + _fiat.yakıttüketim + " " + "günlük=" + _fiat.gunluk);
                
               
                
            }
            else if (comboBox1.SelectedItem.ToString() == "honda")
            {
                listBox1.Items.Add("marka="+ _honda.marka + " "+"model=" + _honda.model + " " +"yakıt tüketim="+ _honda.yakıttüketim + " " +"günlük="+_honda.gunluk);
                _honda.secim = arabatipi.honda;
            
            }
            else if (comboBox1.SelectedItem.ToString() == "mercedes")
            {
                listBox1.Items.Add("marka=" + _mercedes.marka + " " + "model=" + _mercedes.model + " " + "yakıt tüketim=" + _mercedes.yakıttüketim + " " + "günlük=" + _mercedes.gunluk);
                _mercedes.secim = arabatipi.mercedes;
            }
            else
            {
                listBox1.Items.Add("marka=" + _bmw.marka + " " + "model=" + _bmw.model + " " + "yakıt tüketim=" + _bmw.yakıttüketim + " " + "günlük=" + _bmw.gunluk);
                _bmw.secim = arabatipi.mercedes;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //txtgün.Enabled = false;
            //btnhesapla.Enabled = false;
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            arabakira kira = (arabakira)listBox1.SelectedItem;
            DialogResult result = MessageBox.Show("Bilgi ekranına akratılıyorsunuz?", "Bildirim Ekranı", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Form2 frm2 = new Form2(kira);
                frm2.Show();
                this.Hide();
            }
            if (kira.secim == arabatipi.fiat)

            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                _fiat = (fiat)kira;
                listBox1.Items.Add(_fiat);
            }
            else if (kira.secim == arabatipi.honda)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                _honda = (honda)kira;
                listBox1.Items.Add(_honda);
            }
            else if (kira.secim == arabatipi.mercedes)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                _mercedes = (mercedes)kira;
                listBox1.Items.Add(_mercedes);
            }
            else
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                _bmw = (bmw)kira;
                listBox1.Items.Add(_bmw);

            }
     






        }


        private void btnhesapla_Click(object sender, EventArgs e)
        {
          
        }
    }
}
