namespace opp_insankaynakları
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericmaas = new System.Windows.Forms.NumericUpDown();
            this.numericsskno = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericsatısadet = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btnekle = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btngüncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericmaas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericsskno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericsatısadet)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "satış temsilcisi"});
            this.comboBox1.Location = new System.Drawing.Point(130, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "çalışan türü";
            // 
            // numericmaas
            // 
            this.numericmaas.DecimalPlaces = 1;
            this.numericmaas.Location = new System.Drawing.Point(130, 75);
            this.numericmaas.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericmaas.Name = "numericmaas";
            this.numericmaas.Size = new System.Drawing.Size(120, 22);
            this.numericmaas.TabIndex = 2;
            // 
            // numericsskno
            // 
            this.numericsskno.Location = new System.Drawing.Point(130, 124);
            this.numericsskno.Name = "numericsskno";
            this.numericsskno.Size = new System.Drawing.Size(120, 22);
            this.numericsskno.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "maaş";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "ssk no:";
            // 
            // numericsatısadet
            // 
            this.numericsatısadet.Location = new System.Drawing.Point(130, 188);
            this.numericsatısadet.Name = "numericsatısadet";
            this.numericsatısadet.Size = new System.Drawing.Size(120, 22);
            this.numericsatısadet.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(13, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "satış adeti";
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(12, 258);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(99, 35);
            this.btnekle.TabIndex = 8;
            this.btnekle.Text = "ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(292, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(317, 212);
            this.listBox1.TabIndex = 9;
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // btngüncelle
            // 
            this.btngüncelle.Location = new System.Drawing.Point(117, 258);
            this.btngüncelle.Name = "btngüncelle";
            this.btngüncelle.Size = new System.Drawing.Size(99, 35);
            this.btngüncelle.TabIndex = 10;
            this.btngüncelle.Text = "güncelle";
            this.btngüncelle.UseVisualStyleBackColor = true;
            this.btngüncelle.Click += new System.EventHandler(this.btngüncelle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 426);
            this.Controls.Add(this.btngüncelle);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericsatısadet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericsskno);
            this.Controls.Add(this.numericmaas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericmaas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericsskno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericsatısadet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericmaas;
        private System.Windows.Forms.NumericUpDown numericsskno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericsatısadet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btngüncelle;
    }
}

