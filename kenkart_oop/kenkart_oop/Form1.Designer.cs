namespace kenkart_oop
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioogrenci = new System.Windows.Forms.RadioButton();
            this.radioogretmen = new System.Windows.Forms.RadioButton();
            this.radiotam = new System.Windows.Forms.RadioButton();
            this.btnekle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbakiye = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(0, 264);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(281, 196);
            this.listBox1.TabIndex = 0;
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnekle);
            this.groupBox1.Controls.Add(this.radiotam);
            this.groupBox1.Controls.Add(this.radioogretmen);
            this.groupBox1.Controls.Add(this.radioogrenci);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 180);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // radioogrenci
            // 
            this.radioogrenci.AutoSize = true;
            this.radioogrenci.Location = new System.Drawing.Point(7, 22);
            this.radioogrenci.Name = "radioogrenci";
            this.radioogrenci.Size = new System.Drawing.Size(76, 21);
            this.radioogrenci.TabIndex = 0;
            this.radioogrenci.TabStop = true;
            this.radioogrenci.Text = "öğrenci";
            this.radioogrenci.UseVisualStyleBackColor = true;
            // 
            // radioogretmen
            // 
            this.radioogretmen.AutoSize = true;
            this.radioogretmen.Location = new System.Drawing.Point(89, 21);
            this.radioogretmen.Name = "radioogretmen";
            this.radioogretmen.Size = new System.Drawing.Size(89, 21);
            this.radioogretmen.TabIndex = 1;
            this.radioogretmen.TabStop = true;
            this.radioogretmen.Text = "öğretmen";
            this.radioogretmen.UseVisualStyleBackColor = true;
            // 
            // radiotam
            // 
            this.radiotam.AutoSize = true;
            this.radiotam.Location = new System.Drawing.Point(184, 22);
            this.radiotam.Name = "radiotam";
            this.radiotam.Size = new System.Drawing.Size(52, 21);
            this.radiotam.TabIndex = 2;
            this.radiotam.TabStop = true;
            this.radiotam.Text = "tam";
            this.radiotam.UseVisualStyleBackColor = true;
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(24, 129);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(113, 32);
            this.btnekle.TabIndex = 3;
            this.btnekle.Text = "ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // txtbakiye
            // 
            this.txtbakiye.Location = new System.Drawing.Point(396, 25);
            this.txtbakiye.Name = "txtbakiye";
            this.txtbakiye.Size = new System.Drawing.Size(100, 22);
            this.txtbakiye.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 472);
            this.Controls.Add(this.txtbakiye);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radiotam;
        private System.Windows.Forms.RadioButton radioogretmen;
        private System.Windows.Forms.RadioButton radioogrenci;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbakiye;
    }
}

