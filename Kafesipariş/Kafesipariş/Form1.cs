﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kafesipariş
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        int sayac = 1;
        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            comboyemek.Items.Add("Kuru Fasulye");
            comboyemek.Items.Add("Tavuklu Pilav");
            comboyemek.Items.Add("simit+tost");
            comboyemek.Items.Add("lazanya");
            comboicecek.Items.Add("su");
            comboicecek.Items.Add("Kola");
            comboicecek.Items.Add("limonata");
            comboicecek.Items.Add("çay");
            comboicecek.Items.Add("kahve");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if ((i != 4 || j > 1) && (i != 4 || j < 8))
                    {
                        Button btn = new Button();
                        btn.Width = 30;
                        btn.Height = 30;
                        btn.Text = sayac.ToString();

                        btn.Left = (btn.Width * j);
                        btn.Top = (btn.Height * i);
                        sayac++;
                        btn.Click += Button_Click;
                        this.Controls.Add(btn);
                    }
                }
            }
        }
        private void Button_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            listBox1.Items.Clear();


            Button masa = sender as Button;
            //_masa.masano = masa.Text;
            //labelmasano.Text = _masa.masano;

        }
    }
}
