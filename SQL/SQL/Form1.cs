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


namespace SQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection baglan = new SqlConnection("Server=ALS-YG39104-J04;Database=Northwind;UID=sa;PWD=123456789?");//mssql connection string
            //SqlCommand cmd = new SqlCommand("INSERT INTO Categories(CategoryName,Description) values ('Yeni kategori','açıklama')", baglan);
            //baglan.Open();
            //cmd.ExecuteNonQuery();
            
            //baglan.Close();
            //baglan.Dispose();
            SqlDataAdapter dap = new SqlDataAdapter("SELECT * FROM Ogrenci", baglan);
            DataTable dt = new DataTable();
            dap.Fill(dt);
            dataGridView1.DataSource = dt;

            

            

        }
    }
}
