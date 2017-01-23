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

namespace spor_merkezi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        SqlConnection baglan = new SqlConnection("Server=ALS-YG39104-J04;Database=Northwind;UID=sa;PWD=123456789?");

        
        private void btngöster_Click(object sender, EventArgs e)
        {
            

            baglan.Open();
            SqlDataAdapter dap = new SqlDataAdapter("SELECT*FROM Musteri", baglan);
            DataTable dt = new DataTable();
            dap.Fill(dt);
            dataGridView1.DataSource = dt;
            baglan.Close();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            int kayitno = int.Parse(txtkayıtno.Text);
            string adsoyad = txtadsoyad.Text;
            string sure = (cmbsure.SelectedItem.ToString());
            string ucret = (txtucret.Text);
            baglan.Open();
            SqlCommand kmt = new SqlCommand("INSERT INTO Musteri (kayitno,Adisoyadi,Sure,Ucret) VALUES('" + kayitno + " ',' " + adsoyad + "',' " + sure + "',' " + ucret + "')", baglan);
            kmt.ExecuteNonQuery();
            baglan.Close();



        }


        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void cmbsure_SelectedIndexChanged(object sender, EventArgs e)
        {
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
                txtucret.Text = "850";
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglan.Open();
            int kayitid = int.Parse(txtkayıtno.Text);
            SqlCommand kmt = new SqlCommand("DELETE FROM Musteri where kayitno="+kayitid, baglan);
            kmt.ExecuteNonQuery();
            baglan.Close();
        }
    }
}
