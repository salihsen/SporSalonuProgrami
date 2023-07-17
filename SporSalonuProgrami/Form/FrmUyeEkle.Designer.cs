
namespace SporSalonuProgrami
{
    partial class XtraFormUyeEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraFormUyeEkle));
            this.txtNot = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbxUyelikTipi = new System.Windows.Forms.ComboBox();
            this.cmbxOzelDersAliyorMu = new System.Windows.Forms.ComboBox();
            this.cmbxKanGrubu = new System.Windows.Forms.ComboBox();
            this.cmbxCinsiyet = new System.Windows.Forms.ComboBox();
            this.dtmpkrBitisTarihi = new System.Windows.Forms.DateTimePicker();
            this.dtmpkrBaslangicTarihi = new System.Windows.Forms.DateTimePicker();
            this.dtmpkrDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtTellNo = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNot
            // 
            this.txtNot.Location = new System.Drawing.Point(120, 259);
            this.txtNot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNot.Multiline = true;
            this.txtNot.Name = "txtNot";
            this.txtNot.Size = new System.Drawing.Size(191, 41);
            this.txtNot.TabIndex = 121;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(342, 8);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 14);
            this.label11.TabIndex = 120;
            this.label11.Text = "Üyelik Tipi :";
            // 
            // cmbxUyelikTipi
            // 
            this.cmbxUyelikTipi.FormattingEnabled = true;
            this.cmbxUyelikTipi.Items.AddRange(new object[] {
            "1 Aylik = 350 TL",
            "3 Aylik = 900 TL",
            "6 Aylik = 1600TL",
            "1 Yıllık =2200 TL"});
            this.cmbxUyelikTipi.Location = new System.Drawing.Point(446, 5);
            this.cmbxUyelikTipi.Margin = new System.Windows.Forms.Padding(5);
            this.cmbxUyelikTipi.Name = "cmbxUyelikTipi";
            this.cmbxUyelikTipi.Size = new System.Drawing.Size(226, 22);
            this.cmbxUyelikTipi.TabIndex = 119;
            this.cmbxUyelikTipi.SelectedIndexChanged += new System.EventHandler(this.cmbxUyelikTipi_SelectedIndexChanged);
            // 
            // cmbxOzelDersAliyorMu
            // 
            this.cmbxOzelDersAliyorMu.FormattingEnabled = true;
            this.cmbxOzelDersAliyorMu.Items.AddRange(new object[] {
            "Evet",
            "Hayır"});
            this.cmbxOzelDersAliyorMu.Location = new System.Drawing.Point(120, 215);
            this.cmbxOzelDersAliyorMu.Margin = new System.Windows.Forms.Padding(5);
            this.cmbxOzelDersAliyorMu.Name = "cmbxOzelDersAliyorMu";
            this.cmbxOzelDersAliyorMu.Size = new System.Drawing.Size(191, 22);
            this.cmbxOzelDersAliyorMu.TabIndex = 118;
            // 
            // cmbxKanGrubu
            // 
            this.cmbxKanGrubu.FormattingEnabled = true;
            this.cmbxKanGrubu.Items.AddRange(new object[] {
            "ARH+",
            "ARH-",
            "ABRH+",
            "ABRH-",
            "BRH+",
            "BRH+",
            "0RH+",
            "0RH-"});
            this.cmbxKanGrubu.Location = new System.Drawing.Point(120, 134);
            this.cmbxKanGrubu.Margin = new System.Windows.Forms.Padding(5);
            this.cmbxKanGrubu.Name = "cmbxKanGrubu";
            this.cmbxKanGrubu.Size = new System.Drawing.Size(191, 22);
            this.cmbxKanGrubu.TabIndex = 117;
            // 
            // cmbxCinsiyet
            // 
            this.cmbxCinsiyet.FormattingEnabled = true;
            this.cmbxCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cmbxCinsiyet.Location = new System.Drawing.Point(120, 90);
            this.cmbxCinsiyet.Margin = new System.Windows.Forms.Padding(5);
            this.cmbxCinsiyet.Name = "cmbxCinsiyet";
            this.cmbxCinsiyet.Size = new System.Drawing.Size(191, 22);
            this.cmbxCinsiyet.TabIndex = 116;
            // 
            // dtmpkrBitisTarihi
            // 
            this.dtmpkrBitisTarihi.Location = new System.Drawing.Point(446, 134);
            this.dtmpkrBitisTarihi.Margin = new System.Windows.Forms.Padding(5);
            this.dtmpkrBitisTarihi.Name = "dtmpkrBitisTarihi";
            this.dtmpkrBitisTarihi.Size = new System.Drawing.Size(226, 22);
            this.dtmpkrBitisTarihi.TabIndex = 115;
            // 
            // dtmpkrBaslangicTarihi
            // 
            this.dtmpkrBaslangicTarihi.Location = new System.Drawing.Point(446, 89);
            this.dtmpkrBaslangicTarihi.Margin = new System.Windows.Forms.Padding(5);
            this.dtmpkrBaslangicTarihi.Name = "dtmpkrBaslangicTarihi";
            this.dtmpkrBaslangicTarihi.Size = new System.Drawing.Size(226, 22);
            this.dtmpkrBaslangicTarihi.TabIndex = 114;
            // 
            // dtmpkrDogumTarihi
            // 
            this.dtmpkrDogumTarihi.Location = new System.Drawing.Point(446, 49);
            this.dtmpkrDogumTarihi.Margin = new System.Windows.Forms.Padding(5);
            this.dtmpkrDogumTarihi.Name = "dtmpkrDogumTarihi";
            this.dtmpkrDogumTarihi.Size = new System.Drawing.Size(226, 22);
            this.dtmpkrDogumTarihi.TabIndex = 113;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 259);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 14);
            this.label10.TabIndex = 112;
            this.label10.Text = "Not :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 217);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 14);
            this.label9.TabIndex = 111;
            this.label9.Text = "P.Coaching :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(342, 139);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 14);
            this.label8.TabIndex = 110;
            this.label8.Text = "Bitiş Tarihi :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(342, 92);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 14);
            this.label7.TabIndex = 109;
            this.label7.Text = "Başlangıç Tarihi :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 182);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 14);
            this.label6.TabIndex = 108;
            this.label6.Text = "Mail :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 140);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 14);
            this.label5.TabIndex = 106;
            this.label5.Text = "Kan Grubu :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 92);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 14);
            this.label4.TabIndex = 105;
            this.label4.Text = "Cinsiyet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(342, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 14);
            this.label3.TabIndex = 104;
            this.label3.Text = "Doğum Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 14);
            this.label2.TabIndex = 103;
            this.label2.Text = "Telefon No :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 14);
            this.label1.TabIndex = 100;
            this.label1.Text = "Ad Soyad :";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Appearance.Options.UseFont = true;
            this.btnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.ImageOptions.Image")));
            this.btnKaydet.Location = new System.Drawing.Point(559, 177);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(5);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(113, 54);
            this.btnKaydet.TabIndex = 101;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(120, 5);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(191, 22);
            this.txtAdSoyad.TabIndex = 122;
            // 
            // txtTellNo
            // 
            this.txtTellNo.Location = new System.Drawing.Point(120, 47);
            this.txtTellNo.Name = "txtTellNo";
            this.txtTellNo.Size = new System.Drawing.Size(191, 22);
            this.txtTellNo.TabIndex = 123;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(120, 179);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(191, 22);
            this.txtMail.TabIndex = 124;
            // 
            // XtraFormUyeEkle
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 311);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtTellNo);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.txtNot);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbxUyelikTipi);
            this.Controls.Add(this.cmbxOzelDersAliyorMu);
            this.Controls.Add(this.cmbxKanGrubu);
            this.Controls.Add(this.cmbxCinsiyet);
            this.Controls.Add(this.dtmpkrBitisTarihi);
            this.Controls.Add(this.dtmpkrBaslangicTarihi);
            this.Controls.Add(this.dtmpkrDogumTarihi);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "XtraFormUyeEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uye Ekle";
            this.Load += new System.EventHandler(this.XtraFormUyeEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNot;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbxUyelikTipi;
        private System.Windows.Forms.ComboBox cmbxOzelDersAliyorMu;
        private System.Windows.Forms.ComboBox cmbxKanGrubu;
        private System.Windows.Forms.ComboBox cmbxCinsiyet;
        private System.Windows.Forms.DateTimePicker dtmpkrBitisTarihi;
        private System.Windows.Forms.DateTimePicker dtmpkrBaslangicTarihi;
        private System.Windows.Forms.DateTimePicker dtmpkrDogumTarihi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtTellNo;
        private System.Windows.Forms.TextBox txtMail;
    }
}