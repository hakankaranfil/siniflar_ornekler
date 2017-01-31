using sqlclassörnek.databaseconnection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace sqlclassörnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (cemalDBcontext cnn = new cemalDBcontext())
            {
             var result=   cnn.Urunlers.ToList();
                dataGridView1.DataSource = result;
            }
          
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (cemalDBcontext cnn = new cemalDBcontext())
            {
                Urunler u = new Urunler();
                u.UrunAdi = textBox1.Text;
                u.UrunFiyati = Convert.ToDecimal(textBox2.Text);
                cnn.Urunlers.Add(u);
                cnn.SaveChanges();
            }
        }
    }
}
