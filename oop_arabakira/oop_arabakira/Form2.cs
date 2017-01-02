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
    public partial class Form2 : Form
    {
        
        public Form2(arabakira gelenmüsteri)
        {
            InitializeComponent();
            gelenmüsteri.adsoyad = txtadsoyad.Text;
            gelenmüsteri.tckimlik = int.Parse(tckimlik.Text);
            gelenmüsteri.gunluk = int.Parse(txtgün.Text);
            gelenmüsteri.ucret = int.Parse( txtücret.Text);
        }

        private void txtgün_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
