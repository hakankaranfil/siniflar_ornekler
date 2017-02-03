using CodeFirstSimple2Benzer.DBCom;
using CodeFirstSimple2Benzer.DBCom.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeFirstSimple2Benzer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (ProductContext context = new ProductContext())
            {
                var result = context.Category.ToList();
                if (result.Count==0)
                {
                    context.Category.Add(new Category { CategoryName = "oyun konsolu" });
                    context.Category.Add(new Category { CategoryName = "pc" });
                    context.Category.Add(new Category { CategoryName = "Beyaz Eşya" });
                    context.SaveChanges();
                }

                result = context.Category.ToList();
                foreach (var item in result)
                {
                    comboBox1.Items.Add(item);
                }
              
            }
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            Product urun = new Product();
            urun.ProductName = textBox1.Text;
            urun.ProductPrice =int.Parse( textBox2.Text);
            Category c =(Category) comboBox1.SelectedItem;
            urun.CategoryID = c.CategoryID;
            using(ProductContext context = new ProductContext())
            {
                context.Product.Add(urun);
                context.SaveChanges();
            dataGridView1.DataSource=    context.Product.ToList();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (ProductContext context = new ProductContext())
            {
                dataGridView1.DataSource = context.Product.ToList();
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            Product urun = new Product();
            //urun.ProductID=int.Parse( dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            using(ProductContext context = new ProductContext())
            {

                var users = context.Product.Where(u => u.ProductID == int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString()) );

                foreach (var u in users)
                {
                   context.u
                }

                context.SaveChanges();
            }

        }

          
    }
}
