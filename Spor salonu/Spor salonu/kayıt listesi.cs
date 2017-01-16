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
    
    public partial class kayıt_listesi : Form
    {
        musteri _musteri = new musteri();
        public kayıt_listesi(musteri gelenkayit)
        {
            InitializeComponent();
            listBox1.Items.Add(gelenkayit);
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            musteri _musteri = (musteri)listBox1.SelectedItem;
            Form2 frm2 = new Form2(_musteri);
            frm2.Show();
            this.Hide();
        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            anaekran anaekranfrm = new anaekran();
            anaekranfrm.Show();
        }
    }
}
