using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spor_salonu
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="admin"&&textBox2.Text=="1234")
            {
                anaekran frm = new anaekran();
                frm.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("hatalı kullanıcı adı veya şifre girdiniz!!!");
            }
        }
    }
}
