using OzanSuDagıtım.DbConnection;
using OzanSuDagıtım.DbConnection.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OzanSuDagıtım
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (OzanSuModel cnn = new OzanSuModel())
            {
                //Product p = new Product();
                //p.ProductName = "Erikli 19lt";
                //p.ProductPrice = 11.5;
                //cnn.Product.Add(new Product { ProductName = "hayat19lt", ProductPrice = 8.45 });
                //cnn.SaveChanges();

                var result = cnn.Product.ToList();
            }

        }
    }
}
