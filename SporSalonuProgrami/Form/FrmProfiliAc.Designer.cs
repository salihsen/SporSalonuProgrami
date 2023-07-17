
namespace SporSalonuProgrami
{
    partial class XtraFormProfiliAc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraFormProfiliAc));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnAntreman = new DevExpress.XtraBars.BarButtonItem();
            this.btnUrunVeHizmetler = new DevExpress.XtraBars.BarButtonItem();
            this.btnOlculer = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnGüncelle = new DevExpress.XtraEditors.SimpleButton();
            this.dtmpckBitisTarihi = new System.Windows.Forms.DateTimePicker();
            this.dtmpckBaslangicTarihi = new System.Windows.Forms.DateTimePicker();
            this.dtmpckrDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbxUyelikTipi = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNot = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbxPCoaching = new System.Windows.Forms.ComboBox();
            this.cmbxKanGrubu = new System.Windows.Forms.ComboBox();
            this.cmbxCinsiyet = new System.Windows.Forms.ComboBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtTellNo = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnAntreman,
            this.btnUrunVeHizmetler,
            this.btnOlculer});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 4;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.OptionsMenuMinWidth = 385;
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(857, 150);
            // 
            // btnAntreman
            // 
            this.btnAntreman.Caption = "Antreman";
            this.btnAntreman.Id = 1;
            this.btnAntreman.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAntreman.ImageOptions.Image")));
            this.btnAntreman.Name = "btnAntreman";
            this.btnAntreman.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnAntreman.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAntreman_ItemClick);
            // 
            // btnUrunVeHizmetler
            // 
            this.btnUrunVeHizmetler.Caption = "Ürün Ve Hizmetler";
            this.btnUrunVeHizmetler.Id = 2;
            this.btnUrunVeHizmetler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUrunVeHizmetler.ImageOptions.Image")));
            this.btnUrunVeHizmetler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnUrunVeHizmetler.ImageOptions.LargeImage")));
            this.btnUrunVeHizmetler.Name = "btnUrunVeHizmetler";
            this.btnUrunVeHizmetler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUrunVeHizmetler_ItemClick);
            // 
            // btnOlculer
            // 
            this.btnOlculer.Caption = "Ölçüler";
            this.btnOlculer.Id = 3;
            this.btnOlculer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOlculer.ImageOptions.Image")));
            this.btnOlculer.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnOlculer.ImageOptions.LargeImage")));
            this.btnOlculer.Name = "btnOlculer";
            this.btnOlculer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnOlculer_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Üye Profil Bilgileri";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnAntreman);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnUrunVeHizmetler);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnOlculer);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(14, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(834, 308);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnGüncelle);
            this.groupBox3.Controls.Add(this.dtmpckBitisTarihi);
            this.groupBox3.Controls.Add(this.dtmpckBaslangicTarihi);
            this.groupBox3.Controls.Add(this.dtmpckrDogumTarihi);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.cmbxUyelikTipi);
            this.groupBox3.Location = new System.Drawing.Point(395, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(426, 273);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGüncelle.ImageOptions.Image")));
            this.btnGüncelle.Location = new System.Drawing.Point(199, 160);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(164, 51);
            this.btnGüncelle.TabIndex = 21;
            this.btnGüncelle.Text = "GÜNCELLE";
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // dtmpckBitisTarihi
            // 
            this.dtmpckBitisTarihi.Location = new System.Drawing.Point(165, 115);
            this.dtmpckBitisTarihi.Name = "dtmpckBitisTarihi";
            this.dtmpckBitisTarihi.Size = new System.Drawing.Size(233, 22);
            this.dtmpckBitisTarihi.TabIndex = 20;
            // 
            // dtmpckBaslangicTarihi
            // 
            this.dtmpckBaslangicTarihi.Location = new System.Drawing.Point(165, 84);
            this.dtmpckBaslangicTarihi.Name = "dtmpckBaslangicTarihi";
            this.dtmpckBaslangicTarihi.Size = new System.Drawing.Size(233, 22);
            this.dtmpckBaslangicTarihi.TabIndex = 19;
            // 
            // dtmpckrDogumTarihi
            // 
            this.dtmpckrDogumTarihi.Location = new System.Drawing.Point(165, 49);
            this.dtmpckrDogumTarihi.Name = "dtmpckrDogumTarihi";
            this.dtmpckrDogumTarihi.Size = new System.Drawing.Size(233, 22);
            this.dtmpckrDogumTarihi.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 121);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 14);
            this.label11.TabIndex = 17;
            this.label11.Text = "Bitis Tarihi :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 14);
            this.label10.TabIndex = 16;
            this.label10.Text = "Başlangıç Tarihi";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 14);
            this.label9.TabIndex = 15;
            this.label9.Text = "Doğum Tarihi :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 14);
            this.label8.TabIndex = 14;
            this.label8.Text = "Üyelik Tipi :";
            // 
            // cmbxUyelikTipi
            // 
            this.cmbxUyelikTipi.FormattingEnabled = true;
            this.cmbxUyelikTipi.Items.AddRange(new object[] {
            "1 Aylık",
            "3 Aylık",
            "6 Aylık ",
            "1 Yıllık"});
            this.cmbxUyelikTipi.Location = new System.Drawing.Point(165, 16);
            this.cmbxUyelikTipi.Name = "cmbxUyelikTipi";
            this.cmbxUyelikTipi.Size = new System.Drawing.Size(233, 22);
            this.cmbxUyelikTipi.TabIndex = 14;
            this.cmbxUyelikTipi.SelectedIndexChanged += new System.EventHandler(this.cmbxUyelikTipi_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtNot);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cmbxPCoaching);
            this.groupBox2.Controls.Add(this.cmbxKanGrubu);
            this.groupBox2.Controls.Add(this.cmbxCinsiyet);
            this.groupBox2.Controls.Add(this.txtMail);
            this.groupBox2.Controls.Add(this.txtTellNo);
            this.groupBox2.Controls.Add(this.txtAdSoyad);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(14, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(358, 272);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 14);
            this.label7.TabIndex = 13;
            this.label7.Text = "Not :";
            // 
            // txtNot
            // 
            this.txtNot.Location = new System.Drawing.Point(156, 217);
            this.txtNot.Name = "txtNot";
            this.txtNot.Size = new System.Drawing.Size(174, 22);
            this.txtNot.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 14);
            this.label6.TabIndex = 11;
            this.label6.Text = "P.Coaching :";
            // 
            // cmbxPCoaching
            // 
            this.cmbxPCoaching.FormattingEnabled = true;
            this.cmbxPCoaching.Items.AddRange(new object[] {
            "Evet",
            "Hayır"});
            this.cmbxPCoaching.Location = new System.Drawing.Point(156, 188);
            this.cmbxPCoaching.Name = "cmbxPCoaching";
            this.cmbxPCoaching.Size = new System.Drawing.Size(174, 22);
            this.cmbxPCoaching.TabIndex = 10;
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
            "0RH+",
            "0RH-"});
            this.cmbxKanGrubu.Location = new System.Drawing.Point(156, 118);
            this.cmbxKanGrubu.Name = "cmbxKanGrubu";
            this.cmbxKanGrubu.Size = new System.Drawing.Size(174, 22);
            this.cmbxKanGrubu.TabIndex = 9;
            // 
            // cmbxCinsiyet
            // 
            this.cmbxCinsiyet.FormattingEnabled = true;
            this.cmbxCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cmbxCinsiyet.Location = new System.Drawing.Point(156, 84);
            this.cmbxCinsiyet.Name = "cmbxCinsiyet";
            this.cmbxCinsiyet.Size = new System.Drawing.Size(174, 22);
            this.cmbxCinsiyet.TabIndex = 8;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(156, 150);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(174, 22);
            this.txtMail.TabIndex = 7;
            // 
            // txtTellNo
            // 
            this.txtTellNo.Location = new System.Drawing.Point(156, 49);
            this.txtTellNo.Name = "txtTellNo";
            this.txtTellNo.Size = new System.Drawing.Size(174, 22);
            this.txtTellNo.TabIndex = 6;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(156, 15);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(174, 22);
            this.txtAdSoyad.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 14);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mail :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kan Grubu :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cinsiyet :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Telefon No :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad :";
            // 
            // XtraFormProfiliAc
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 486);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ribbonControl1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "XtraFormProfiliAc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Üye Profil Bilgileri";
            this.Load += new System.EventHandler(this.XtraFormProfiliAc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraEditors.SimpleButton btnGüncelle;
        private System.Windows.Forms.DateTimePicker dtmpckBitisTarihi;
        private System.Windows.Forms.DateTimePicker dtmpckBaslangicTarihi;
        private System.Windows.Forms.DateTimePicker dtmpckrDogumTarihi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbxUyelikTipi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNot;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbxPCoaching;
        private System.Windows.Forms.ComboBox cmbxKanGrubu;
        private System.Windows.Forms.ComboBox cmbxCinsiyet;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtTellNo;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraBars.BarButtonItem btnAntreman;
        private DevExpress.XtraBars.BarButtonItem btnUrunVeHizmetler;
        private DevExpress.XtraBars.BarButtonItem btnOlculer;
    }
}