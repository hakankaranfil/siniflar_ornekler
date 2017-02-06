using KodeFirstSporMerkezi.DbContext;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KodeFirstSporMerkezi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DateTime bugun, bitis;
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            txtad.Visible = true;
            txttel.Visible = true;
            txtucret.Visible = true;
            cmbsure.Visible = true;
            btnekle.Visible = true;
            txtkayıttarih.Visible = true;
            txtbitistarih.Visible = true;
            txtkayıttarih.Text =DateTime.Now.ToShortDateString();


        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            MusBilgi musteri = new MusBilgi();
            musteri.Musadsoyad = txtad.Text;
            musteri.Mustel = txttel.Text;
            musteri.Mussure = int.Parse(cmbsure.SelectedItem.ToString());
            musteri.Musucret = int.Parse(txtucret.Text);
            musteri.Muskayit = txtkayıttarih.Text;
            musteri.Musbitis = txtbitistarih.Text;
            using (SporContext context = new SporContext())
            {

                context.MusBilgi.Add(musteri);
                context.SaveChanges();
                var result = context.MusBilgi.ToList();
                datakayit.DataSource = result;


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SporContext context = new SporContext())
            {
                datakayit.DataSource = context.MusBilgi.ToList();
            }
        }

        private void cmbsure_SelectedIndexChanged(object sender, EventArgs e)
        {

            //txtucret.Text = cmbsure.SelectedValue.ToString();
            if (cmbsure.SelectedItem.ToString() == "1")
            {
                txtucret.Text = "100";
            }
            else if (cmbsure.SelectedItem.ToString() == "3")
            {
                txtucret.Text = "250";
            }
            else if (cmbsure.SelectedItem.ToString() == "6")
            {
                txtucret.Text = "450";
            }
            else if (cmbsure.SelectedItem.ToString() == "9")
            {
                txtucret.Text = "600";
            }
            else
            {
                txtucret.Text = "900";
            }
            bugun = Convert.ToDateTime(txtkayıttarih.Text);
            bitis = bugun.AddMonths(int.Parse(cmbsure.SelectedItem.ToString()));
            txtbitistarih.Text =bitis.ToShortDateString();

        
        }
    }
    }

