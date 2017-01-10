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
    public partial class Form2 : Form
    {
        public Form2(musteri gelenmusteri)
        {
            InitializeComponent();
            txtkayıtno.Text = gelenmusteri.kayıtno.ToString();
            txtadsoyad.Text = gelenmusteri.adsoyad;
            txttc.Text = gelenmusteri.tckimlik;
            txttel.Text = gelenmusteri.telno;
            txtsure.Text = gelenmusteri.sure;
            txtucret.Text = gelenmusteri.ucret.ToString();

        }
    }
}
