using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace opp_hesap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            porshe superaraba = new porshe();
            tofas duldul = new tofas();
            honsa memur = new honsa();
            MessageBox.Show(superaraba.yazdir());
            MessageBox.Show(superaraba.calistir());
            MessageBox.Show(duldul.yazdir());
            MessageBox.Show(duldul.calistir());
            MessageBox.Show(memur.yazdir());
            MessageBox.Show(memur.calistir());

        }
    }
}
