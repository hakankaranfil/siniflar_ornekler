namespace oop_araba
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.numericyakitfiyati = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericortalamatüketim100km = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericyakitkapasite = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericyakitfiyati)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericortalamatüketim100km)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericyakitkapasite)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numericUpDown4);
            this.groupBox1.Controls.Add(this.numericyakitfiyati);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numericortalamatüketim100km);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numericyakitkapasite);
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 261);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(58, 212);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 30);
            this.button2.TabIndex = 9;
            this.button2.Text = "k";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 30);
            this.button1.TabIndex = 8;
            this.button1.Text = "ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "mesafe:";
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(141, 152);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown4.TabIndex = 6;
            // 
            // numericyakitfiyati
            // 
            this.numericyakitfiyati.DecimalPlaces = 1;
            this.numericyakitfiyati.Location = new System.Drawing.Point(141, 117);
            this.numericyakitfiyati.Name = "numericyakitfiyati";
            this.numericyakitfiyati.Size = new System.Drawing.Size(120, 20);
            this.numericyakitfiyati.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "yakıt fiyatı";
            // 
            // numericortalamatüketim100km
            // 
            this.numericortalamatüketim100km.Location = new System.Drawing.Point(141, 77);
            this.numericortalamatüketim100km.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericortalamatüketim100km.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericortalamatüketim100km.Name = "numericortalamatüketim100km";
            this.numericortalamatüketim100km.Size = new System.Drawing.Size(120, 20);
            this.numericortalamatüketim100km.TabIndex = 3;
            this.numericortalamatüketim100km.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "100km kaç ltgidiyotr?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "yakıtdepokapasite:";
            // 
            // numericyakitkapasite
            // 
            this.numericyakitkapasite.Location = new System.Drawing.Point(141, 31);
            this.numericyakitkapasite.Maximum = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.numericyakitkapasite.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericyakitkapasite.Name = "numericyakitkapasite";
            this.numericyakitkapasite.Size = new System.Drawing.Size(120, 20);
            this.numericyakitkapasite.TabIndex = 0;
            this.numericyakitkapasite.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 339);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericyakitfiyati)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericortalamatüketim100km)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericyakitkapasite)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.NumericUpDown numericyakitfiyati;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericortalamatüketim100km;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericyakitkapasite;
        private System.Windows.Forms.Button button2;
    }
}

