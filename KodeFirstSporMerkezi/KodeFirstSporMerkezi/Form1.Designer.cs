namespace KodeFirstSporMerkezi
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
            this.txtad = new System.Windows.Forms.TextBox();
            this.txttel = new System.Windows.Forms.TextBox();
            this.cmbsure = new System.Windows.Forms.ComboBox();
            this.txtucret = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnekle = new System.Windows.Forms.Button();
            this.datakayit = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtkayıttarih = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbitistarih = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.datakayit)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(176, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "AdSoyad:";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(176, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tel:";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(176, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Süre:";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(176, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ücret:";
            this.label4.Visible = false;
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(311, 0);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(100, 20);
            this.txtad.TabIndex = 4;
            this.txtad.Visible = false;
            // 
            // txttel
            // 
            this.txttel.Location = new System.Drawing.Point(311, 34);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(100, 20);
            this.txttel.TabIndex = 5;
            this.txttel.Visible = false;
            // 
            // cmbsure
            // 
            this.cmbsure.FormattingEnabled = true;
            this.cmbsure.Items.AddRange(new object[] {
            "1",
            "3",
            "6",
            "9",
            "12"});
            this.cmbsure.Location = new System.Drawing.Point(311, 69);
            this.cmbsure.Name = "cmbsure";
            this.cmbsure.Size = new System.Drawing.Size(100, 21);
            this.cmbsure.TabIndex = 6;
            this.cmbsure.Visible = false;
            this.cmbsure.SelectedIndexChanged += new System.EventHandler(this.cmbsure_SelectedIndexChanged);
            // 
            // txtucret
            // 
            this.txtucret.Location = new System.Drawing.Point(311, 107);
            this.txtucret.Name = "txtucret";
            this.txtucret.Size = new System.Drawing.Size(100, 20);
            this.txtucret.TabIndex = 7;
            this.txtucret.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 37);
            this.button1.TabIndex = 8;
            this.button1.Text = "Yeni Kayıt Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(180, 217);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(101, 33);
            this.btnekle.TabIndex = 9;
            this.btnekle.Text = "Yeni Kayıt Ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Visible = false;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // datakayit
            // 
            this.datakayit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datakayit.Location = new System.Drawing.Point(3, 256);
            this.datakayit.Name = "datakayit";
            this.datakayit.Size = new System.Drawing.Size(675, 150);
            this.datakayit.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 67);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 43);
            this.button2.TabIndex = 11;
            this.button2.Text = "Kayıtlı Bilgileri Göster";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(176, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Kayıt Tarihi:";
            this.label5.Visible = false;
            // 
            // txtkayıttarih
            // 
            this.txtkayıttarih.Location = new System.Drawing.Point(311, 150);
            this.txtkayıttarih.Name = "txtkayıttarih";
            this.txtkayıttarih.Size = new System.Drawing.Size(100, 20);
            this.txtkayıttarih.TabIndex = 13;
            this.txtkayıttarih.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtkayıttarih.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(176, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Bitiş Tarihi:";
            this.label6.Visible = false;
            // 
            // txtbitistarih
            // 
            this.txtbitistarih.Location = new System.Drawing.Point(311, 183);
            this.txtbitistarih.Name = "txtbitistarih";
            this.txtbitistarih.Size = new System.Drawing.Size(100, 20);
            this.txtbitistarih.TabIndex = 15;
            this.txtbitistarih.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 407);
            this.Controls.Add(this.txtbitistarih);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtkayıttarih);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.datakayit);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtucret);
            this.Controls.Add(this.cmbsure);
            this.Controls.Add(this.txttel);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.datakayit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.ComboBox cmbsure;
        private System.Windows.Forms.TextBox txtucret;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.DataGridView datakayit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtkayıttarih;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbitistarih;
    }
}

