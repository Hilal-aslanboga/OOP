namespace Class
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
            this.txtSalon = new System.Windows.Forms.TextBox();
            this.txtKoltukSayisi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOlustur = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBiletSat = new System.Windows.Forms.Button();
            this.btnBiletIptal = new System.Windows.Forms.Button();
            this.chk_Indirimli = new System.Windows.Forms.CheckBox();
            this.btnBakiye = new System.Windows.Forms.Button();
            this.btnBosKoltuk = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSalon
            // 
            this.txtSalon.Location = new System.Drawing.Point(106, 24);
            this.txtSalon.Name = "txtSalon";
            this.txtSalon.Size = new System.Drawing.Size(100, 22);
            this.txtSalon.TabIndex = 0;
            // 
            // txtKoltukSayisi
            // 
            this.txtKoltukSayisi.Location = new System.Drawing.Point(106, 52);
            this.txtKoltukSayisi.Name = "txtKoltukSayisi";
            this.txtKoltukSayisi.Size = new System.Drawing.Size(100, 22);
            this.txtKoltukSayisi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Salon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Koltuk Sayısı";
            // 
            // btnOlustur
            // 
            this.btnOlustur.Location = new System.Drawing.Point(213, 24);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(202, 50);
            this.btnOlustur.TabIndex = 4;
            this.btnOlustur.Text = "Oluştur";
            this.btnOlustur.UseVisualStyleBackColor = true;
            this.btnOlustur.Click += new System.EventHandler(this.btnOlustur_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chk_Indirimli);
            this.groupBox1.Controls.Add(this.btnBiletIptal);
            this.groupBox1.Controls.Add(this.btnBiletSat);
            this.groupBox1.Location = new System.Drawing.Point(15, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 126);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Satış İptal";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBosKoltuk);
            this.groupBox2.Controls.Add(this.btnBakiye);
            this.groupBox2.Location = new System.Drawing.Point(221, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 126);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rapor";
            // 
            // btnBiletSat
            // 
            this.btnBiletSat.Location = new System.Drawing.Point(7, 72);
            this.btnBiletSat.Name = "btnBiletSat";
            this.btnBiletSat.Size = new System.Drawing.Size(93, 37);
            this.btnBiletSat.TabIndex = 0;
            this.btnBiletSat.Text = "Bilet Sat";
            this.btnBiletSat.UseVisualStyleBackColor = true;
            this.btnBiletSat.Click += new System.EventHandler(this.btnBiletSat_Click);
            // 
            // btnBiletIptal
            // 
            this.btnBiletIptal.Location = new System.Drawing.Point(106, 72);
            this.btnBiletIptal.Name = "btnBiletIptal";
            this.btnBiletIptal.Size = new System.Drawing.Size(85, 37);
            this.btnBiletIptal.TabIndex = 1;
            this.btnBiletIptal.Text = "Bilet İptal";
            this.btnBiletIptal.UseVisualStyleBackColor = true;
            this.btnBiletIptal.Click += new System.EventHandler(this.btnBiletIptal_Click);
            // 
            // chk_Indirimli
            // 
            this.chk_Indirimli.AutoSize = true;
            this.chk_Indirimli.Location = new System.Drawing.Point(7, 45);
            this.chk_Indirimli.Name = "chk_Indirimli";
            this.chk_Indirimli.Size = new System.Drawing.Size(77, 21);
            this.chk_Indirimli.TabIndex = 2;
            this.chk_Indirimli.Text = "İndirimli";
            this.chk_Indirimli.UseVisualStyleBackColor = true;
            // 
            // btnBakiye
            // 
            this.btnBakiye.Location = new System.Drawing.Point(6, 72);
            this.btnBakiye.Name = "btnBakiye";
            this.btnBakiye.Size = new System.Drawing.Size(85, 37);
            this.btnBakiye.TabIndex = 0;
            this.btnBakiye.Text = "Bakiye";
            this.btnBakiye.UseVisualStyleBackColor = true;
            this.btnBakiye.Click += new System.EventHandler(this.btnBakiye_Click);
            // 
            // btnBosKoltuk
            // 
            this.btnBosKoltuk.Location = new System.Drawing.Point(109, 72);
            this.btnBosKoltuk.Name = "btnBosKoltuk";
            this.btnBosKoltuk.Size = new System.Drawing.Size(85, 37);
            this.btnBosKoltuk.TabIndex = 1;
            this.btnBosKoltuk.Text = "Boş Koltuk";
            this.btnBosKoltuk.UseVisualStyleBackColor = true;
            this.btnBosKoltuk.Click += new System.EventHandler(this.btnBosKoltuk_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(15, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 285);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOlustur);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKoltukSayisi);
            this.Controls.Add(this.txtSalon);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSalon;
        private System.Windows.Forms.TextBox txtKoltukSayisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOlustur;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chk_Indirimli;
        private System.Windows.Forms.Button btnBiletIptal;
        private System.Windows.Forms.Button btnBiletSat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBosKoltuk;
        private System.Windows.Forms.Button btnBakiye;
        private System.Windows.Forms.Label label3;
    }
}

