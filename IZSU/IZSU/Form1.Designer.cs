namespace IZSU
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
            this.txtadsoyad = new System.Windows.Forms.TextBox();
            this.tarih = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtguncel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtönceki = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAboneNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btngetir = new System.Windows.Forms.Button();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textAboneNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textadsoyad = new System.Windows.Forms.TextBox();
            this.btnekle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupAboneBilgi.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupAboneBilgi
            // 
            this.groupAboneBilgi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupAboneBilgi.Controls.Add(this.comboBox1);
            this.groupAboneBilgi.Controls.Add(this.label6);
            this.groupAboneBilgi.Controls.Add(this.label5);
            this.groupAboneBilgi.Controls.Add(this.txtadsoyad);
            this.groupAboneBilgi.Controls.Add(this.txtAboneNo);
            this.groupAboneBilgi.Controls.Add(this.label1);
            this.groupAboneBilgi.Controls.Add(this.btnkaydet);
            this.groupAboneBilgi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupAboneBilgi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupAboneBilgi.Location = new System.Drawing.Point(2, 12);
            this.groupAboneBilgi.Name = "groupAboneBilgi";
            this.groupAboneBilgi.Size = new System.Drawing.Size(291, 187);
            this.groupAboneBilgi.TabIndex = 0;
            this.groupAboneBilgi.TabStop = false;
            this.groupAboneBilgi.Text = "groupBox1";
            // 
            // txtadsoyad
            // 
            this.txtadsoyad.Location = new System.Drawing.Point(120, 73);
            this.txtadsoyad.Name = "txtadsoyad";
            this.txtadsoyad.Size = new System.Drawing.Size(100, 20);
            this.txtadsoyad.TabIndex = 9;
            // 
            // tarih
            // 
            this.tarih.Location = new System.Drawing.Point(141, 152);
            this.tarih.Name = "tarih";
            this.tarih.Size = new System.Drawing.Size(116, 20);
            this.tarih.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(10, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tarih:";
            // 
            // txtguncel
            // 
            this.txtguncel.Location = new System.Drawing.Point(141, 121);
            this.txtguncel.Name = "txtguncel";
            this.txtguncel.Size = new System.Drawing.Size(100, 20);
            this.txtguncel.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(10, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Güncel Sayaç:";
            // 
            // txtönceki
            // 
            this.txtönceki.Location = new System.Drawing.Point(141, 86);
            this.txtönceki.Name = "txtönceki";
            this.txtönceki.Size = new System.Drawing.Size(100, 20);
            this.txtönceki.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Önceki Sayaç:";
            // 
            // txtAboneNo
            // 
            this.txtAboneNo.Location = new System.Drawing.Point(120, 32);
            this.txtAboneNo.Name = "txtAboneNo";
            this.txtAboneNo.Size = new System.Drawing.Size(100, 20);
            this.txtAboneNo.TabIndex = 1;
            this.txtAboneNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAboneNo_KeyDown);
            this.txtAboneNo.Leave += new System.EventHandler(this.txtAboneNo_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(7, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Abone No:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.btnekle);
            this.groupBox1.Controls.Add(this.textadsoyad);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textAboneNo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tarih);
            this.groupBox1.Controls.Add(this.btngetir);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtguncel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtönceki);
            this.groupBox1.Location = new System.Drawing.Point(2, 199);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 249);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Abone Türü";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(120, 112);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // btngetir
            // 
            this.btngetir.BackColor = System.Drawing.Color.Aqua;
            this.btngetir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngetir.Location = new System.Drawing.Point(153, 204);
            this.btngetir.Name = "btngetir";
            this.btngetir.Size = new System.Drawing.Size(120, 39);
            this.btngetir.TabIndex = 3;
            this.btngetir.Text = "Getir";
            this.btngetir.UseVisualStyleBackColor = false;
            // 
            // btnkaydet
            // 
            this.btnkaydet.BackColor = System.Drawing.Color.Yellow;
            this.btnkaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkaydet.Location = new System.Drawing.Point(41, 142);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(184, 39);
            this.btnkaydet.TabIndex = 2;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = false;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(10, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ad Soyad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(6, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Abone Türü:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(10, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Abone No:";
            // 
            // textAboneNo
            // 
            this.textAboneNo.Location = new System.Drawing.Point(141, 29);
            this.textAboneNo.Name = "textAboneNo";
            this.textAboneNo.Size = new System.Drawing.Size(100, 20);
            this.textAboneNo.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(12, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Ad Soyad:";
            // 
            // textadsoyad
            // 
            this.textadsoyad.Location = new System.Drawing.Point(141, 60);
            this.textadsoyad.Name = "textadsoyad";
            this.textadsoyad.Size = new System.Drawing.Size(100, 20);
            this.textadsoyad.TabIndex = 11;
            // 
            // btnekle
            // 
            this.btnekle.BackColor = System.Drawing.Color.Aqua;
            this.btnekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnekle.Location = new System.Drawing.Point(14, 204);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(120, 39);
            this.btnekle.TabIndex = 12;
            this.btnekle.Text = "Getir";
            this.btnekle.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(299, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 39);
            this.button1.TabIndex = 11;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 445);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupAboneBilgi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.groupAboneBilgi.ResumeLayout(false);
            this.groupAboneBilgi.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupAboneBilgi;
        private System.Windows.Forms.TextBox txtAboneNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtguncel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtönceki;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btngetir;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker tarih;
        private System.Windows.Forms.TextBox txtadsoyad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.TextBox textadsoyad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textAboneNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
    }
}

