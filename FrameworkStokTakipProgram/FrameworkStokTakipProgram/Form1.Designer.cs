namespace FrameworkStokTakipProgram
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStokModel = new System.Windows.Forms.TextBox();
            this.txtStokSeri = new System.Windows.Forms.TextBox();
            this.cmbStokTur = new System.Windows.Forms.ComboBox();
            this.txtStokAdet = new System.Windows.Forms.TextBox();
            this.txtKayıtYap = new System.Windows.Forms.TextBox();
            this.tarih = new System.Windows.Forms.DateTimePicker();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnGetir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stok Modeli:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(10, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Stok SeriNo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(14, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stok Adedi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(10, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Stok Türü:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(14, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Kayıt Tarihi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(12, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Kayıt Yapan:";
            // 
            // txtStokModel
            // 
            this.txtStokModel.Location = new System.Drawing.Point(152, 38);
            this.txtStokModel.Name = "txtStokModel";
            this.txtStokModel.Size = new System.Drawing.Size(129, 22);
            this.txtStokModel.TabIndex = 6;
            // 
            // txtStokSeri
            // 
            this.txtStokSeri.Location = new System.Drawing.Point(152, 84);
            this.txtStokSeri.Name = "txtStokSeri";
            this.txtStokSeri.Size = new System.Drawing.Size(129, 22);
            this.txtStokSeri.TabIndex = 7;
            this.txtStokSeri.Leave += new System.EventHandler(this.txtStokSeri_Leave);
            // 
            // cmbStokTur
            // 
            this.cmbStokTur.FormattingEnabled = true;
            this.cmbStokTur.Location = new System.Drawing.Point(152, 262);
            this.cmbStokTur.Name = "cmbStokTur";
            this.cmbStokTur.Size = new System.Drawing.Size(129, 24);
            this.cmbStokTur.TabIndex = 9;
            // 
            // txtStokAdet
            // 
            this.txtStokAdet.Location = new System.Drawing.Point(152, 127);
            this.txtStokAdet.Name = "txtStokAdet";
            this.txtStokAdet.Size = new System.Drawing.Size(129, 22);
            this.txtStokAdet.TabIndex = 8;
            // 
            // txtKayıtYap
            // 
            this.txtKayıtYap.Location = new System.Drawing.Point(152, 211);
            this.txtKayıtYap.Name = "txtKayıtYap";
            this.txtKayıtYap.Size = new System.Drawing.Size(129, 22);
            this.txtKayıtYap.TabIndex = 10;
            // 
            // tarih
            // 
            this.tarih.Location = new System.Drawing.Point(152, 176);
            this.tarih.Name = "tarih";
            this.tarih.Size = new System.Drawing.Size(129, 22);
            this.tarih.TabIndex = 11;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.Aqua;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ForeColor = System.Drawing.Color.Black;
            this.btnKaydet.Location = new System.Drawing.Point(13, 326);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(131, 63);
            this.btnKaydet.TabIndex = 12;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnGetir
            // 
            this.btnGetir.BackColor = System.Drawing.Color.Green;
            this.btnGetir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGetir.ForeColor = System.Drawing.Color.Black;
            this.btnGetir.Location = new System.Drawing.Point(150, 326);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(131, 63);
            this.btnGetir.TabIndex = 13;
            this.btnGetir.Text = "Getir";
            this.btnGetir.UseVisualStyleBackColor = false;
            this.btnGetir.Click += new System.EventHandler(this.btnGetir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 489);
            this.Controls.Add(this.btnGetir);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.tarih);
            this.Controls.Add(this.txtKayıtYap);
            this.Controls.Add(this.cmbStokTur);
            this.Controls.Add(this.txtStokAdet);
            this.Controls.Add(this.txtStokSeri);
            this.Controls.Add(this.txtStokModel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStokModel;
        private System.Windows.Forms.TextBox txtStokSeri;
        private System.Windows.Forms.ComboBox cmbStokTur;
        private System.Windows.Forms.TextBox txtStokAdet;
        private System.Windows.Forms.TextBox txtKayıtYap;
        private System.Windows.Forms.DateTimePicker tarih;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnGetir;
    }
}

