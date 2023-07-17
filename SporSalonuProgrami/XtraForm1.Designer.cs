
namespace SporSalonuProgrami
{
    partial class XtraForm1
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUyelerID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAntremanID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTekrar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSilindiMi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.kullaniciAntremanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciAntremanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.kullaniciAntremanBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(879, 408);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colUyelerID,
            this.colAntremanID,
            this.colSet,
            this.colTekrar,
            this.colSilindiMi,
            this.colTarih});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colUyelerID
            // 
            this.colUyelerID.FieldName = "UyelerID";
            this.colUyelerID.Name = "colUyelerID";
            this.colUyelerID.Visible = true;
            this.colUyelerID.VisibleIndex = 1;
            // 
            // colAntremanID
            // 
            this.colAntremanID.FieldName = "AntremanID";
            this.colAntremanID.Name = "colAntremanID";
            this.colAntremanID.Visible = true;
            this.colAntremanID.VisibleIndex = 2;
            // 
            // colSet
            // 
            this.colSet.FieldName = "Set";
            this.colSet.Name = "colSet";
            this.colSet.Visible = true;
            this.colSet.VisibleIndex = 3;
            // 
            // colTekrar
            // 
            this.colTekrar.FieldName = "Tekrar";
            this.colTekrar.Name = "colTekrar";
            this.colTekrar.Visible = true;
            this.colTekrar.VisibleIndex = 4;
            // 
            // colSilindiMi
            // 
            this.colSilindiMi.FieldName = "SilindiMi";
            this.colSilindiMi.Name = "colSilindiMi";
            this.colSilindiMi.Visible = true;
            this.colSilindiMi.VisibleIndex = 5;
            // 
            // colTarih
            // 
            this.colTarih.FieldName = "Tarih";
            this.colTarih.Name = "colTarih";
            this.colTarih.Visible = true;
            this.colTarih.VisibleIndex = 6;
            // 
            // kullaniciAntremanBindingSource
            // 
            this.kullaniciAntremanBindingSource.DataSource = typeof(SporSalonuProgrami.Entity.KullaniciAntreman);
            // 
            // XtraForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 408);
            this.Controls.Add(this.gridControl1);
            this.Name = "XtraForm1";
            this.Text = "XtraForm1";
            this.Load += new System.EventHandler(this.XtraForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciAntremanBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource kullaniciAntremanBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colUyelerID;
        private DevExpress.XtraGrid.Columns.GridColumn colAntremanID;
        private DevExpress.XtraGrid.Columns.GridColumn colSet;
        private DevExpress.XtraGrid.Columns.GridColumn colTekrar;
        private DevExpress.XtraGrid.Columns.GridColumn colSilindiMi;
        private DevExpress.XtraGrid.Columns.GridColumn colTarih;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}