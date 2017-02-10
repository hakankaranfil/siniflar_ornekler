using FrameworkStokTakipProgram.DBLayer;
using FrameworkStokTakipProgram.DBLayer.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrameworkStokTakipProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tarih.Format = DateTimePickerFormat.Custom;
            tarih.CustomFormat = "MM-yyyy";
            tarih.ShowUpDown = true;
            using (StokContext context = new StokContext())
            {
                var result = context.ProductType.ToList();
                foreach (var item in result)
                {
                    cmbStokTur.Items.Add(item);
                }
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            ProductStock product = new ProductStock();
            product.ProductName = txtStokModel.Text;
            product.ProductSerialNumber = (txtStokSeri.Text);
            product.ProductNumber = int.Parse(txtStokAdet.Text);
            product.ProductDate = tarih.Value;
            product.Recorder = txtKayıtYap.Text;
            ProductType pt = (ProductType)cmbStokTur.SelectedItem;
            product.ProductTypeID = pt.ProductTypeID;
            product.ProductTypeName = pt.ProductTypeName;
            using (StokContext context = new StokContext())
            {
                context.ProductSock.Add(product);
                context.SaveChanges();

            }
        }
    }
}
