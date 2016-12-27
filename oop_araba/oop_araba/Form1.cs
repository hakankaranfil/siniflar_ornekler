using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_araba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            int yakıkapasite = Convert.ToInt32(numericyakitkapasite.Value);
         int lttüketim = Convert.ToInt32(numericortalamatüketim100km.Value);

            araba a = new araba(yakıkapasite,lttüketim);
            MessageBox.Show (a.toplamyol.ToString());



            
          
            MessageBox.Show(a.yakıtdepokapasite + "" + "\n" + a.ortalamatüketim + "" + "\n"+a.toplamyol);
        }
    }
}
