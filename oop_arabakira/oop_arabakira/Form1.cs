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
        
        public Form1(arabakira gelen)
        {
            
            
            InitializeComponent();
            
            
            
            


        }
     public void temizle()
        {
            listBox1.Items.Clear();
        }
        static List<arabakira> kiralist = new List<arabakira>();
        
        public  int gun;
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
                
                listBox1.Items.Add(_fiat);
                kiralist.Add(_fiat);
                
               
                
            }
            else if (comboBox1.SelectedItem.ToString() == "honda")
            {
               
                _honda.secim = arabatipi.honda;
                listBox1.Items.Add(_honda);
                kiralist.Add(_honda);


            }
            else if (comboBox1.SelectedItem.ToString() == "mercedes")
            {
             
                _mercedes.secim = arabatipi.mercedes;
                listBox1.Items.Add(_mercedes);
                kiralist.Add(_mercedes);
            }
            else
            {
                
                _bmw.secim = arabatipi.mercedes;
                listBox1.Items.Add(_bmw);
                kiralist.Add(_bmw);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var item in kiralist)
            {
                listBox1.Items.Add(item);
            }
        }


        private void btnhesapla_Click(object sender, EventArgs e)
        {
          
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
          
            arabakira kira = (arabakira)listBox1.SelectedItem;
            gun = int.Parse(textBox1.Text);

            if (kira.secim == arabatipi.fiat)

            {
                
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                _fiat = (fiat)kira;
                _fiat.ucret = _fiat.hesapla(gun);
                listBox1.Items.Add(_fiat);
                //kiralist.Add(_fiat);

            }
            else if (kira.secim == arabatipi.honda)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                _honda = (honda)kira;
                _honda.ucret = _honda.hesapla(gun);
                listBox1.Items.Add(_honda);
                //kiralist.Add(_honda);
            }
            else if (kira.secim == arabatipi.mercedes)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                _mercedes = (mercedes)kira;
                _mercedes.ucret = _mercedes.hesapla(gun);
                listBox1.Items.Add(_mercedes);
                //kiralist.Add(_honda);
            }
            else
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                _bmw = (bmw)kira;
                _bmw.ucret = _bmw.hesapla(gun);
                listBox1.Items.Add(_bmw);
                //kiralist.Add(_bmw);

            }
            kira.gunluk = gun;
            
            

            DialogResult result = MessageBox.Show("Bilgi ekranına akratılıyorsunuz?", "Bildirim Ekranı", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Form2 frm2 = new Form2(kira);
                frm2.Show();
                this.Hide();
                listBox1.Items.Clear();
            }
           
        }
    }
}
