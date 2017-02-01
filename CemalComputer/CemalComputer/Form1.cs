using CemalComputer.DAl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CemalComputer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //dbfirst işlemi
            using (cemalDBEntities cnn = new cemalDBEntities())
            {
                var result = cnn.Urunler.ToList();
                dataGridView1.DataSource = result;
                //dataGridView1.DataSource = cnn.Urunler.ToList();//datagrid e farklı ekleme 

            }
        }
    }
}
