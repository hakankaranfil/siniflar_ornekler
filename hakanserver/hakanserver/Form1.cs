using hakanserver.DBConnection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hakanserver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (HakanYapi cnn = new HakanYapi())
            {
                Product p = new Product();
                p.ProductName = textBox1.Text;
                cnn.Product.Add(p);
                cnn.SaveChanges();
                dataGridView1.DataSource = cnn.Product.ToList();


               
            }
        }
    }
}
