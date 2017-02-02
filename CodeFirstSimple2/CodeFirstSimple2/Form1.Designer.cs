namespace CodeFirstSimple2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuislemler = new System.Windows.Forms.ToolStripMenuItem();
            this.Menuİtem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txturunadı = new System.Windows.Forms.TextBox();
            this.numericFiyat = new System.Windows.Forms.NumericUpDown();
            this.CboxUrunKategori = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MenuItemUrunEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericFiyat)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Location = new System.Drawing.Point(67, 190);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(222, 39);
            this.BtnKaydet.TabIndex = 0;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuislemler});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(896, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuislemler
            // 
            this.menuislemler.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemUrunEkle,
            this.Menuİtem});
            this.menuislemler.Name = "menuislemler";
            this.menuislemler.Size = new System.Drawing.Size(60, 20);
            this.menuislemler.Text = "İşlemler";
            this.menuislemler.Click += new System.EventHandler(this.işlemlerToolStripMenuItem_Click);
            // 
            // Menuİtem
            // 
            this.Menuİtem.Name = "Menuİtem";
            this.Menuİtem.Size = new System.Drawing.Size(152, 22);
            this.Menuİtem.Text = "Tüm Ürünler";
            this.Menuİtem.Click += new System.EventHandler(this.productToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(481, 281);
            this.dataGridView1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CboxUrunKategori);
            this.groupBox1.Controls.Add(this.numericFiyat);
            this.groupBox1.Controls.Add(this.BtnKaydet);
            this.groupBox1.Controls.Add(this.txturunadı);
            this.groupBox1.Location = new System.Drawing.Point(510, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 251);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // txturunadı
            // 
            this.txturunadı.Location = new System.Drawing.Point(67, 29);
            this.txturunadı.Name = "txturunadı";
            this.txturunadı.Size = new System.Drawing.Size(202, 20);
            this.txturunadı.TabIndex = 0;
            // 
            // numericFiyat
            // 
            this.numericFiyat.Location = new System.Drawing.Point(67, 84);
            this.numericFiyat.Name = "numericFiyat";
            this.numericFiyat.Size = new System.Drawing.Size(202, 20);
            this.numericFiyat.TabIndex = 1;
            this.numericFiyat.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CboxUrunKategori
            // 
            this.CboxUrunKategori.FormattingEnabled = true;
            this.CboxUrunKategori.Location = new System.Drawing.Point(67, 142);
            this.CboxUrunKategori.Name = "CboxUrunKategori";
            this.CboxUrunKategori.Size = new System.Drawing.Size(202, 21);
            this.CboxUrunKategori.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "UrunAdı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "UrunFiyat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "UrunKategori";
            // 
            // MenuItemUrunEkle
            // 
            this.MenuItemUrunEkle.Name = "MenuItemUrunEkle";
            this.MenuItemUrunEkle.Size = new System.Drawing.Size(152, 22);
            this.MenuItemUrunEkle.Text = "Ürün Ekle";
            this.MenuItemUrunEkle.Click += new System.EventHandler(this.MenuItemUrunEkle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 365);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "StokTakip";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericFiyat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuislemler;
        private System.Windows.Forms.ToolStripMenuItem Menuİtem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CboxUrunKategori;
        private System.Windows.Forms.NumericUpDown numericFiyat;
        private System.Windows.Forms.TextBox txturunadı;
        private System.Windows.Forms.ToolStripMenuItem MenuItemUrunEkle;
    }
}

