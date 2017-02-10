using IzsuFramework.DataLayer;
using IzsuFramework.DataLayer.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IzsuFramework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            Abone a = new Abone();
            a.AboneNo = int.Parse(txtAboneNo.Text);
            a.AboneAdSoyad = txtadsoyad.Text;
            AboneTuru at = (AboneTuru)comboabonetur.SelectedItem;
            a.AboneTuruID = at.AboneTuruID;
            using (IzsuContext context = new IzsuContext())
            {
                context.Abone.Add(a);
                context.SaveChanges();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            tarih.Format = DateTimePickerFormat.Custom;
            tarih.CustomFormat = "MM-yyyy";
            tarih.ShowUpDown = true;
            using (IzsuContext context = new IzsuContext())
            {
                var result = context.AboneTuru.ToList();

                foreach (var item in result)
                {
                    comboabonetur.Items.Add(item);
                }
            }
        }

        private void txtAboneNo_Leave(object sender, EventArgs e)
        {
            using (IzsuContext context = new IzsuContext())
            {
                int _abone = int.Parse(txtAboneNo.Text);
                var result = context.Abone.FirstOrDefault(a => a.AboneNo == _abone);
                if (result != null)
                {
                    comboabonetur.SelectedIndex = result.AboneTuruID - 1;
                    txtadsoyad.Text = result.AboneAdSoyad;
                    txtfaturaAboneNo.Text = result.AboneNo.ToString();
                    txtfaturaadsoyad.Text = result.AboneAdSoyad;
                }
            }
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            int _aboneno = int.Parse(txtfaturaAboneNo.Text);
            Fatura f = new Fatura();
            f.OncekiSayac = int.Parse(txtönceki.Text);
            f.GuncelSayac = int.Parse(txtguncel.Text);
            f.FaturaTarihi = tarih.Value;
            using (IzsuContext context = new IzsuContext())
            {
                int _aboneID = context.Abone.FirstOrDefault(a => a.AboneNo == _aboneno).AboneID;
                f.AboneID = _aboneID;
                f.OdemeTutari = (decimal)f.OdemeHesapla();
                var result = context.Fatura.FirstOrDefault(fa => fa.AboneID == _aboneID && (fa.FaturaTarihi.Month == tarih.Value.Month && fa.FaturaTarihi.Year == tarih.Value.Year));
                if (result != null)
                {
                    MessageBox.Show
                        (tarih.Value.Month + "-" + tarih.Value.Year
                        + " tarihine ait fatura bulunmaktadır.");
                }
                else
                {
                    context.Fatura.Add(f);
                    context.SaveChanges();
                    MessageBox.Show("Fatura Eklendi");
                }


            }

        }

        private void btngetir_Click(object sender, EventArgs e)
        {
            int _aboneNo = int.Parse(txtfaturaAboneNo.Text);
            using (IzsuContext context = new IzsuContext())
            {
                int abonenoID = context.Abone.FirstOrDefault(a => a.AboneNo == _aboneNo).AboneID;
                var result = context.Fatura.Where(f => f.AboneID ==abonenoID).Select(f => new
                {
                    FaturaID = f.FaturaID,
                    AboneAd = f.Abone.AboneAdSoyad,
                    OdemeTutari = f.OdemeTutari,
                    OdemeDurumu = f.Tahsilat == false ? "Ödenmedi" : "Ödendi",
                    Tarih = f.FaturaTarihi.Month + "-" + f.FaturaTarihi.Year,
                }).ToList();
                decimal toplamBorc = 0;
                foreach (var item in result)
                {
                    if (item.OdemeDurumu == "Ödenmedi")
                    {
                        toplamBorc += item.OdemeTutari;
                    }
                }
                txttoplamborc.Text = toplamBorc.ToString() + " ₺";

              dataGridView1.DataSource = result;


            }



        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            int faturaID = int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());

            DialogResult dr = MessageBox.Show("Ödeme Yapmak İstiyor Musunuz?", "Uyarı", MessageBoxButtons.OKCancel);

            if (dr==DialogResult.OK)
            {
                using (IzsuContext context = new IzsuContext())
                {
                    var result = context.Fatura.FirstOrDefault(fa => fa.FaturaID == faturaID);
                    result.Tahsilat = true;
                    context.SaveChanges();             
                        
                        }
                    
            }

        }
    }
    }

