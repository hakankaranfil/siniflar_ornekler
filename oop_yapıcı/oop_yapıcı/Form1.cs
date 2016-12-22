using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_yapıcı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pozisyon = comboBox1.SelectedItem.ToString();
            oyuncu futbolcu = new oyuncu("hakan");
            MessageBox.Show(futbolcu.adi);
        }
    }
}
