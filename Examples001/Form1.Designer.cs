namespace Examples001
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
            this.lblFiyat = new System.Windows.Forms.Label();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.chkNakit = new System.Windows.Forms.CheckBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.chkKampanya = new System.Windows.Forms.CheckBox();
            this.chkDevamli = new System.Windows.Forms.CheckBox();
            this.lblSonFiyat = new System.Windows.Forms.Label();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFiyat.Location = new System.Drawing.Point(20, 31);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(101, 20);
            this.lblFiyat.TabIndex = 0;
            this.lblFiyat.Text = "Ürün Fiyatı:";
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(125, 31);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(100, 20);
            this.txtFiyat.TabIndex = 1;
            // 
            // chkNakit
            // 
            this.chkNakit.AutoSize = true;
            this.chkNakit.Location = new System.Drawing.Point(33, 83);
            this.chkNakit.Name = "chkNakit";
            this.chkNakit.Size = new System.Drawing.Size(88, 17);
            this.chkNakit.TabIndex = 2;
            this.chkNakit.Text = "Nakit Ödeme";
            this.chkNakit.UseVisualStyleBackColor = true;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapla.Location = new System.Drawing.Point(33, 118);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(123, 23);
            this.btnHesapla.TabIndex = 3;
            this.btnHesapla.Text = "Fiyat Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // chkKampanya
            // 
            this.chkKampanya.AutoSize = true;
            this.chkKampanya.Location = new System.Drawing.Point(119, 83);
            this.chkKampanya.Name = "chkKampanya";
            this.chkKampanya.Size = new System.Drawing.Size(106, 17);
            this.chkKampanya.TabIndex = 4;
            this.chkKampanya.Text = "Kampanyalı Ürün";
            this.chkKampanya.UseVisualStyleBackColor = true;
            // 
            // chkDevamli
            // 
            this.chkDevamli.AutoSize = true;
            this.chkDevamli.Location = new System.Drawing.Point(231, 83);
            this.chkDevamli.Name = "chkDevamli";
            this.chkDevamli.Size = new System.Drawing.Size(101, 17);
            this.chkDevamli.TabIndex = 5;
            this.chkDevamli.Text = "Devamlı Müşteri";
            this.chkDevamli.UseVisualStyleBackColor = true;
            // 
            // lblSonFiyat
            // 
            this.lblSonFiyat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSonFiyat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSonFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonFiyat.ForeColor = System.Drawing.Color.Lime;
            this.lblSonFiyat.Location = new System.Drawing.Point(137, 167);
            this.lblSonFiyat.Name = "lblSonFiyat";
            this.lblSonFiyat.Size = new System.Drawing.Size(195, 31);
            this.lblSonFiyat.TabIndex = 6;
            this.lblSonFiyat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.Location = new System.Drawing.Point(190, 118);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(117, 23);
            this.btnTemizle.TabIndex = 7;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(8, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "İndirimli Tutar:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 230);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.lblSonFiyat);
            this.Controls.Add(this.chkDevamli);
            this.Controls.Add(this.chkKampanya);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.chkNakit);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.lblFiyat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.CheckBox chkNakit;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.CheckBox chkKampanya;
        private System.Windows.Forms.CheckBox chkDevamli;
        private System.Windows.Forms.Label lblSonFiyat;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Label label1;
    }
}

