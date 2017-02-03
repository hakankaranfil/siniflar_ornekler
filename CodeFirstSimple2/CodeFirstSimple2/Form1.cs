using CodeFirstSimple2.DBCom;
using CodeFirstSimple2.DBCom.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeFirstSimple2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (MarketContext context = new MarketContext())
            {
                //var result = context.Category.ToList();
                //if (result.Count == 0)
                {
                    context.Category.Add(new Category { Categoryname = "Oyun Konsolu" });
                    context.Category.Add(new Category { Categoryname = "Masaüstü Bilgisayar" });
                    context.SaveChanges();
                    //}
                    var result = context.Category.ToList();
                    foreach (var item in result)
                    {
                        CboxUrunKategori.Items.Add(item);
                    }
                }

                groupBox1.Enabled = false;

            }
        }

        private void işlemlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //using (MarketContext conText = new MarketContext())
            //{
            //    var result = conText.Product.ToList();
            //    dataGridView1.DataSource = result;

            //}

        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (MarketContext conText = new MarketContext())
            {
                var result = conText.Product.ToList();
                dataGridView1.DataSource = result;

            }
        
        }

        private void MenuItemUrunEkle_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            
            
           
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            Product urun = new Product();
            urun.ProductName = txturunadı.Text;
            urun.ProductPrice = numericFiyat.Value;
            Category c = (Category)CboxUrunKategori.SelectedItem;
            urun.CategoryID = c.CategoryID;
            using (MarketContext context = new MarketContext())
            {
                context.Product.Add(urun);
                context.SaveChanges();
                context.Product.ToList();
            }

            
        }
    }
}
