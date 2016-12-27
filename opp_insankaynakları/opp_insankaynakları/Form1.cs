using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace opp_insankaynakları
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            satıstemsilcisi.maas = 1500;
            numericmaas.Value = Convert.ToDecimal(satıstemsilcisi.maas);
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            satıstemsilcisi st = new satıstemsilcisi();
            st.elementürü = comboBox1.SelectedItem.ToString();
            numericmaas.Enabled = false;
            st.sskno = Convert.ToInt32(numericsskno.Value);
            listBox1.Items.Add(st);
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            numericsatısadet.Enabled = false;
            btngüncelle.Enabled = false;
            numericmaas.Enabled = false;
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            satıstemsilcisi st = (satıstemsilcisi)listBox1.SelectedItem;

            comboBox1.Enabled = false;
            numericmaas.Enabled = false;
            numericsskno.Enabled = false;
            numericsatısadet.Enabled = true;
           btngüncelle.Enabled = true;


            numericsskno.Value = st.sskno;
            //numericmaas.Value = Convert.ToDecimal(st.maas);
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
           satıstemsilcisi st = (satıstemsilcisi)listBox1.SelectedItem;

            int satisAdeti = Convert.ToInt32(numericsatısadet.Value);
            numericmaas.Value = Convert.ToDecimal(st.zamyap(satisAdeti));
        }
    }
}
