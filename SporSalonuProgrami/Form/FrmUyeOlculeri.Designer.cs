
namespace SporSalonuProgrami
{
    partial class XtraFormUyeOlculeri
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraFormUyeOlculeri));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.güncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUyelerID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBoy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKilo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOmuz = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGogus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKalca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBacak = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSilindiMi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.ribbonControl2 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.olculerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.olculerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.ContextMenuStrip = this.contextMenuStrip1;
            this.gridControl1.DataSource = this.olculerBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 57);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(788, 333);
            this.gridControl1.TabIndex = 21;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.güncelleToolStripMenuItem,
            this.silToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(121, 48);
            // 
            // güncelleToolStripMenuItem
            // 
            this.güncelleToolStripMenuItem.Name = "güncelleToolStripMenuItem";
            this.güncelleToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.güncelleToolStripMenuItem.Text = "&Güncelle";
            this.güncelleToolStripMenuItem.Click += new System.EventHandler(this.güncelleToolStripMenuItem_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.silToolStripMenuItem.Text = "&Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colUyelerID,
            this.colTarih,
            this.colBoy,
            this.colKilo,
            this.colOmuz,
            this.colGogus,
            this.colKol,
            this.colBel,
            this.colKalca,
            this.colBacak,
            this.colSilindiMi});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            // 
            // colUyelerID
            // 
            this.colUyelerID.FieldName = "UyelerID";
            this.colUyelerID.Name = "colUyelerID";
            // 
            // colTarih
            // 
            this.colTarih.FieldName = "Tarih";
            this.colTarih.Name = "colTarih";
            this.colTarih.Visible = true;
            this.colTarih.VisibleIndex = 0;
            // 
            // colBoy
            // 
            this.colBoy.FieldName = "Boy";
            this.colBoy.Name = "colBoy";
            this.colBoy.Visible = true;
            this.colBoy.VisibleIndex = 1;
            // 
            // colKilo
            // 
            this.colKilo.FieldName = "Kilo";
            this.colKilo.Name = "colKilo";
            this.colKilo.Visible = true;
            this.colKilo.VisibleIndex = 2;
            // 
            // colOmuz
            // 
            this.colOmuz.FieldName = "Omuz";
            this.colOmuz.Name = "colOmuz";
            this.colOmuz.Visible = true;
            this.colOmuz.VisibleIndex = 3;
            // 
            // colGogus
            // 
            this.colGogus.FieldName = "Gogus";
            this.colGogus.Name = "colGogus";
            this.colGogus.Visible = true;
            this.colGogus.VisibleIndex = 4;
            // 
            // colKol
            // 
            this.colKol.FieldName = "Kol";
            this.colKol.Name = "colKol";
            this.colKol.Visible = true;
            this.colKol.VisibleIndex = 5;
            // 
            // colBel
            // 
            this.colBel.FieldName = "Bel";
            this.colBel.Name = "colBel";
            this.colBel.Visible = true;
            this.colBel.VisibleIndex = 6;
            // 
            // colKalca
            // 
            this.colKalca.FieldName = "Kalca";
            this.colKalca.Name = "colKalca";
            this.colKalca.Visible = true;
            this.colKalca.VisibleIndex = 7;
            // 
            // colBacak
            // 
            this.colBacak.FieldName = "Bacak";
            this.colBacak.Name = "colBacak";
            this.colBacak.Visible = true;
            this.colBacak.VisibleIndex = 8;
            // 
            // colSilindiMi
            // 
            this.colSilindiMi.FieldName = "SilindiMi";
            this.colSilindiMi.Name = "colSilindiMi";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(131, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(10, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = " ";
            // 
            // ribbonControl2
            // 
            this.ribbonControl2.ExpandCollapseItem.Id = 0;
            this.ribbonControl2.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl2.ExpandCollapseItem,
            this.ribbonControl2.SearchEditItem,
            this.barButtonItem1});
            this.ribbonControl2.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl2.MaxItemId = 2;
            this.ribbonControl2.Name = "ribbonControl2";
            this.ribbonControl2.OptionsMenuMinWidth = 385;
            this.ribbonControl2.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage2});
            this.ribbonControl2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal;
            this.ribbonControl2.Size = new System.Drawing.Size(788, 57);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Yeni Kayıt";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Ölçüler";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPageGroup2.ImageOptions.Image")));
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // olculerBindingSource
            // 
            this.olculerBindingSource.DataSource = typeof(SporSalonuProgrami.Entity.Olculer);
            // 
            // XtraFormUyeOlculeri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 390);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ribbonControl2);
            this.Name = "XtraFormUyeOlculeri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uye Olculeri";
            this.Load += new System.EventHandler(this.XtraFormUyeOlculeri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.olculerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem güncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colUyelerID;
        private DevExpress.XtraGrid.Columns.GridColumn colTarih;
        private DevExpress.XtraGrid.Columns.GridColumn colBoy;
        private DevExpress.XtraGrid.Columns.GridColumn colKilo;
        private DevExpress.XtraGrid.Columns.GridColumn colOmuz;
        private DevExpress.XtraGrid.Columns.GridColumn colGogus;
        private DevExpress.XtraGrid.Columns.GridColumn colKol;
        private DevExpress.XtraGrid.Columns.GridColumn colBel;
        private DevExpress.XtraGrid.Columns.GridColumn colKalca;
        private DevExpress.XtraGrid.Columns.GridColumn colBacak;
        private DevExpress.XtraGrid.Columns.GridColumn colSilindiMi;
        private System.Windows.Forms.BindingSource olculerBindingSource;
    }
}