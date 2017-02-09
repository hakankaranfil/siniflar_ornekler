namespace IzsuFramework
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
            this.groupAboneBilgi = new System.Windows.Forms.GroupBox();
            this.comboabonetur = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtadsoyad = new System.Windows.Forms.TextBox();
            this.txtAboneNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnekle = new System.Windows.Forms.Button();
            this.txtfaturaadsoyad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtfaturaAboneNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tarih = new System.Windows.Forms.DateTimePicker();
            this.btngetir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtguncel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtönceki = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.txttoplamborc = new System.Windows.Forms.TextBox();
            this.groupAboneBilgi.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupAboneBilgi
            // 
            this.groupAboneBilgi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupAboneBilgi.Controls.Add(this.comboabonetur);
            this.groupAboneBilgi.Controls.Add(this.label6);
            this.groupAboneBilgi.Controls.Add(this.label5);
            this.groupAboneBilgi.Controls.Add(this.txtadsoyad);
            this.groupAboneBilgi.Controls.Add(this.txtAboneNo);
            this.groupAboneBilgi.Controls.Add(this.label1);
            this.groupAboneBilgi.Controls.Add(this.btnkaydet);
            this.groupAboneBilgi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupAboneBilgi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupAboneBilgi.Location = new System.Drawing.Point(13, 13);
            this.groupAboneBilgi.Margin = new System.Windows.Forms.Padding(4);
            this.groupAboneBilgi.Name = "groupAboneBilgi";
            this.groupAboneBilgi.Padding = new System.Windows.Forms.Padding(4);
            this.groupAboneBilgi.Size = new System.Drawing.Size(341, 230);
            this.groupAboneBilgi.TabIndex = 1;
            this.groupAboneBilgi.TabStop = false;
            this.groupAboneBilgi.Text = "groupBox1";
            // 
            // comboabonetur
            // 
            this.comboabonetur.FormattingEnabled = true;
            this.comboabonetur.Location = new System.Drawing.Point(160, 138);
            this.comboabonetur.Margin = new System.Windows.Forms.Padding(4);
            this.comboabonetur.Name = "comboabonetur";
            this.comboabonetur.Size = new System.Drawing.Size(160, 24);
            this.comboabonetur.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(8, 139);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Abone Türü:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(13, 87);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ad Soyad:";
            // 
            // txtadsoyad
            // 
            this.txtadsoyad.Location = new System.Drawing.Point(160, 90);
            this.txtadsoyad.Margin = new System.Windows.Forms.Padding(4);
            this.txtadsoyad.Name = "txtadsoyad";
            this.txtadsoyad.Size = new System.Drawing.Size(132, 22);
            this.txtadsoyad.TabIndex = 9;
            // 
            // txtAboneNo
            // 
            this.txtAboneNo.Location = new System.Drawing.Point(160, 39);
            this.txtAboneNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtAboneNo.Name = "txtAboneNo";
            this.txtAboneNo.Size = new System.Drawing.Size(132, 22);
            this.txtAboneNo.TabIndex = 1;
            this.txtAboneNo.Leave += new System.EventHandler(this.txtAboneNo_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(9, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Abone No:";
            // 
            // btnkaydet
            // 
            this.btnkaydet.BackColor = System.Drawing.Color.Yellow;
            this.btnkaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkaydet.Location = new System.Drawing.Point(55, 175);
            this.btnkaydet.Margin = new System.Windows.Forms.Padding(4);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(245, 48);
            this.btnkaydet.TabIndex = 2;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = false;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.btnekle);
            this.groupBox1.Controls.Add(this.txtfaturaadsoyad);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtfaturaAboneNo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tarih);
            this.groupBox1.Controls.Add(this.btngetir);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtguncel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtönceki);
            this.groupBox1.Location = new System.Drawing.Point(13, 259);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(341, 317);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Abone Türü";
            // 
            // btnekle
            // 
            this.btnekle.BackColor = System.Drawing.Color.Aqua;
            this.btnekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnekle.Location = new System.Drawing.Point(0, 242);
            this.btnekle.Margin = new System.Windows.Forms.Padding(4);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(160, 48);
            this.btnekle.TabIndex = 12;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = false;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // txtfaturaadsoyad
            // 
            this.txtfaturaadsoyad.Location = new System.Drawing.Point(188, 74);
            this.txtfaturaadsoyad.Margin = new System.Windows.Forms.Padding(4);
            this.txtfaturaadsoyad.Name = "txtfaturaadsoyad";
            this.txtfaturaadsoyad.Size = new System.Drawing.Size(132, 22);
            this.txtfaturaadsoyad.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(16, 81);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 25);
            this.label8.TabIndex = 11;
            this.label8.Text = "Ad Soyad:";
            // 
            // txtfaturaAboneNo
            // 
            this.txtfaturaAboneNo.Location = new System.Drawing.Point(188, 36);
            this.txtfaturaAboneNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtfaturaAboneNo.Name = "txtfaturaAboneNo";
            this.txtfaturaAboneNo.Size = new System.Drawing.Size(132, 22);
            this.txtfaturaAboneNo.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(13, 36);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Abone No:";
            // 
            // tarih
            // 
            this.tarih.Location = new System.Drawing.Point(188, 187);
            this.tarih.Margin = new System.Windows.Forms.Padding(4);
            this.tarih.Name = "tarih";
            this.tarih.Size = new System.Drawing.Size(153, 22);
            this.tarih.TabIndex = 8;
            // 
            // btngetir
            // 
            this.btngetir.BackColor = System.Drawing.Color.Aqua;
            this.btngetir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngetir.Location = new System.Drawing.Point(168, 242);
            this.btngetir.Margin = new System.Windows.Forms.Padding(4);
            this.btngetir.Name = "btngetir";
            this.btngetir.Size = new System.Drawing.Size(160, 48);
            this.btngetir.TabIndex = 3;
            this.btngetir.Text = "Getir";
            this.btngetir.UseVisualStyleBackColor = false;
            this.btngetir.Click += new System.EventHandler(this.btngetir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(13, 187);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tarih:";
            // 
            // txtguncel
            // 
            this.txtguncel.Location = new System.Drawing.Point(188, 149);
            this.txtguncel.Margin = new System.Windows.Forms.Padding(4);
            this.txtguncel.Name = "txtguncel";
            this.txtguncel.Size = new System.Drawing.Size(132, 22);
            this.txtguncel.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(16, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Önceki Sayaç:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(13, 146);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Güncel Sayaç:";
            // 
            // txtönceki
            // 
            this.txtönceki.Location = new System.Drawing.Point(188, 106);
            this.txtönceki.Margin = new System.Windows.Forms.Padding(4);
            this.txtönceki.Name = "txtönceki";
            this.txtönceki.Size = new System.Drawing.Size(132, 22);
            this.txtönceki.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(361, 188);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(530, 388);
            this.dataGridView1.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(486, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 17);
            this.label9.TabIndex = 4;
            this.label9.Text = "Toplam Borç:";
            // 
            // txttoplamborc
            // 
            this.txttoplamborc.Location = new System.Drawing.Point(584, 69);
            this.txttoplamborc.Name = "txttoplamborc";
            this.txttoplamborc.Size = new System.Drawing.Size(141, 22);
            this.txttoplamborc.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 589);
            this.Controls.Add(this.txttoplamborc);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupAboneBilgi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupAboneBilgi.ResumeLayout(false);
            this.groupAboneBilgi.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupAboneBilgi;
        private System.Windows.Forms.ComboBox comboabonetur;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtadsoyad;
        private System.Windows.Forms.TextBox txtAboneNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.TextBox txtfaturaadsoyad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtfaturaAboneNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker tarih;
        private System.Windows.Forms.Button btngetir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtguncel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtönceki;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txttoplamborc;
    }
}

