using IZSU.DataLayer.DbCom;
using IZSU.DataLayer.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IZSU
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnkaydet.Enabled = false;
            tarih.Format = DateTimePickerFormat.Custom;
            tarih.CustomFormat = "MM-yyyy";
            tarih.ShowUpDown = true;
            using (IzsuDBContext context = new IzsuDBContext())
            {
                var result = context.AboneTuru.ToList();
                foreach (var item in result)
                {
                    comboBox1.Items.Add(item);
                }

            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtAboneNo_KeyDown(object sender, KeyEventArgs e)
        {


        }

        private void txtAboneNo_Leave(object sender, EventArgs e)
        {

            using (IzsuDBContext context = new IzsuDBContext())
            {
                int AboneNo = int.Parse(txtAboneNo.Text);
                var result = context.Abone.FirstOrDefault(x => x.AboneNo == AboneNo);
                if (result != null)
                {
                    txtAboneNo.Enabled = false;
                    txtadsoyad.Enabled = false;
                    txtadsoyad.Text = result.AboneAdSoyad;

                    comboBox1.SelectedIndex = result.AboneTuruId - 1;

                    textadsoyad.Text = txtadsoyad.Text;
                    textAboneNo.Text = txtAboneNo.Text;

                }
                else
                {
                    MessageBox.Show("kullanıcı bulunamadı");
                    btnkaydet.Enabled = true;
                }

            }

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            Abone _abone = new Abone();
            _abone.AboneNo = int.Parse(txtAboneNo.Text);
            _abone.AboneAdSoyad = txtadsoyad.Text;

            AboneTuru at = (AboneTuru)comboBox1.SelectedItem;
            _abone.AboneTuruId = at.AboneTuruID;
            using (IzsuDBContext context = new IzsuDBContext())
            {
                context.Abone.Add(_abone);
                context.SaveChanges();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in groupAboneBilgi.Controls)
            {
                if (ctr is TextBox)
                {
                    ctr.Text = "";
                }

            }
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            int _aboneno=int.Parse(txtAboneNo.Text);
            Fatura f = new Fatura();
          
            f.FaturaTarihi = tarih.Value;
            f.GuncelSayac = int.Parse(txtguncel.Text);
            f.OncekiSayac = int.Parse(txtönceki.Text);
            using (IzsuDBContext context = new IzsuDBContext())
            {
                int aboneID = context.Abone.FirstOrDefault(a => a.AboneNo == _aboneno).AboneTuruId;
                context.Fatura.Add(f);
                context.SaveChanges();
            }
        }

        private void btngetir_Click(object sender, EventArgs e)
        {
            int  _aboneno = int.Parse(txtAboneNo.Text);

            using (IzsuDBContext context = new IzsuDBContext())
            {
                int aboneID = context.Abone.FirstOrDefault(a => a.AboneNo == _aboneno).AboneTuruId;

                dataBilgi.DataSource = context.Fatura.Where(f => f.AboneID == _aboneno).Select(f => new
                {
                    faturaıd = f.FaturaID,

                }).ToList();


              
                   
                





                    
                   



                    }
        }
    }
}

