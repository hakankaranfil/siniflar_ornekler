namespace oop_kenkart
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
            this.groupkart = new System.Windows.Forms.GroupBox();
            this.radioogrenci = new System.Windows.Forms.RadioButton();
            this.radioogretmen = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.radiotam = new System.Windows.Forms.RadioButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbakiye = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupkart.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupkart
            // 
            this.groupkart.Controls.Add(this.radiotam);
            this.groupkart.Controls.Add(this.button1);
            this.groupkart.Controls.Add(this.radioogretmen);
            this.groupkart.Controls.Add(this.radioogrenci);
            this.groupkart.Location = new System.Drawing.Point(2, 12);
            this.groupkart.Name = "groupkart";
            this.groupkart.Size = new System.Drawing.Size(193, 170);
            this.groupkart.TabIndex = 0;
            this.groupkart.TabStop = false;
            this.groupkart.Text = "Kart oluştur";
            // 
            // radioogrenci
            // 
            this.radioogrenci.AutoSize = true;
            this.radioogrenci.Location = new System.Drawing.Point(7, 46);
            this.radioogrenci.Name = "radioogrenci";
            this.radioogrenci.Size = new System.Drawing.Size(60, 17);
            this.radioogrenci.TabIndex = 0;
            this.radioogrenci.TabStop = true;
            this.radioogrenci.Text = "öğrenci";
            this.radioogrenci.UseVisualStyleBackColor = true;
            this.radioogrenci.CheckedChanged += new System.EventHandler(this.radioogrenci_CheckedChanged);
            // 
            // radioogretmen
            // 
            this.radioogretmen.AutoSize = true;
            this.radioogretmen.Location = new System.Drawing.Point(73, 46);
            this.radioogretmen.Name = "radioogretmen";
            this.radioogretmen.Size = new System.Drawing.Size(69, 17);
            this.radioogretmen.TabIndex = 1;
            this.radioogretmen.TabStop = true;
            this.radioogretmen.Text = "öğretmen";
            this.radioogretmen.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radiotam
            // 
            this.radiotam.AutoSize = true;
            this.radiotam.Location = new System.Drawing.Point(148, 46);
            this.radiotam.Name = "radiotam";
            this.radiotam.Size = new System.Drawing.Size(42, 17);
            this.radiotam.TabIndex = 3;
            this.radiotam.TabStop = true;
            this.radiotam.Text = "tam";
            this.radiotam.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(2, 197);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(222, 147);
            this.listBox1.TabIndex = 1;
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtbakiye);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(201, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 81);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(68, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "okuladi:";
            // 
            // txtbakiye
            // 
            this.txtbakiye.Location = new System.Drawing.Point(68, 55);
            this.txtbakiye.Name = "txtbakiye";
            this.txtbakiye.Size = new System.Drawing.Size(100, 20);
            this.txtbakiye.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "bakiye:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(386, 350);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupkart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupkart.ResumeLayout(false);
            this.groupkart.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupkart;
        private System.Windows.Forms.RadioButton radiotam;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioogretmen;
        private System.Windows.Forms.RadioButton radioogrenci;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbakiye;
    }
}

