namespace Otomasyon.WinForms.AnaMenu
{
    partial class frmAnaMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnaMenu));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnKullanicilar = new DevExpress.XtraBars.BarButtonItem();
            this.btnKullaniciHareketleri = new DevExpress.XtraBars.BarButtonItem();
            this.btnUrunler = new DevExpress.XtraBars.BarButtonItem();
            this.btnUrunHareketleri = new DevExpress.XtraBars.BarButtonItem();
            this.btnDepo = new DevExpress.XtraBars.BarButtonItem();
            this.btnDepoHareketleri = new DevExpress.XtraBars.BarButtonItem();
            this.btnFatura = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnKullanicilar,
            this.btnKullaniciHareketleri,
            this.btnUrunler,
            this.btnUrunHareketleri,
            this.btnDepo,
            this.btnDepoHareketleri,
            this.btnFatura,
            this.barButtonItem2});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 9;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2});
            this.ribbon.Size = new System.Drawing.Size(1255, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnKullanicilar
            // 
            this.btnKullanicilar.Caption = "Kullanıcılar";
            this.btnKullanicilar.Id = 1;
            this.btnKullanicilar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKullanicilar.ImageOptions.Image")));
            this.btnKullanicilar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnKullanicilar.ImageOptions.LargeImage")));
            this.btnKullanicilar.Name = "btnKullanicilar";
            // 
            // btnKullaniciHareketleri
            // 
            this.btnKullaniciHareketleri.Caption = "Kullanıcı Hareketleri";
            this.btnKullaniciHareketleri.Id = 2;
            this.btnKullaniciHareketleri.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKullaniciHareketleri.ImageOptions.Image")));
            this.btnKullaniciHareketleri.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnKullaniciHareketleri.ImageOptions.LargeImage")));
            this.btnKullaniciHareketleri.Name = "btnKullaniciHareketleri";
            // 
            // btnUrunler
            // 
            this.btnUrunler.Caption = "Ürünler";
            this.btnUrunler.Id = 3;
            this.btnUrunler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUrunler.ImageOptions.Image")));
            this.btnUrunler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnUrunler.ImageOptions.LargeImage")));
            this.btnUrunler.Name = "btnUrunler";
            this.btnUrunler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUrunler_ItemClick);
            // 
            // btnUrunHareketleri
            // 
            this.btnUrunHareketleri.Caption = "Ürün Hareketleri";
            this.btnUrunHareketleri.Id = 4;
            this.btnUrunHareketleri.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUrunHareketleri.ImageOptions.Image")));
            this.btnUrunHareketleri.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnUrunHareketleri.ImageOptions.LargeImage")));
            this.btnUrunHareketleri.Name = "btnUrunHareketleri";
            // 
            // btnDepo
            // 
            this.btnDepo.Caption = "Depo";
            this.btnDepo.Id = 5;
            this.btnDepo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDepo.ImageOptions.Image")));
            this.btnDepo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDepo.ImageOptions.LargeImage")));
            this.btnDepo.Name = "btnDepo";
            // 
            // btnDepoHareketleri
            // 
            this.btnDepoHareketleri.Caption = "Depo Hareketleri";
            this.btnDepoHareketleri.Id = 6;
            this.btnDepoHareketleri.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDepoHareketleri.ImageOptions.Image")));
            this.btnDepoHareketleri.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDepoHareketleri.ImageOptions.LargeImage")));
            this.btnDepoHareketleri.Name = "btnDepoHareketleri";
            // 
            // btnFatura
            // 
            this.btnFatura.Caption = "Fatura";
            this.btnFatura.Id = 7;
            this.btnFatura.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnFatura.ImageOptions.Image")));
            this.btnFatura.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnFatura.ImageOptions.LargeImage")));
            this.btnFatura.Name = "btnFatura";
            this.btnFatura.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnFatura_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Fatura Hareketleri";
            this.barButtonItem2.Id = 8;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4,
            this.ribbonPageGroup5});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "AnaSayfa";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnKullanicilar);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnKullaniciHareketleri);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Kullanıcılar";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnUrunler);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnUrunHareketleri);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Ürünler";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnDepo);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnDepoHareketleri);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Depo";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnFatura);
            this.ribbonPageGroup5.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Faturalar";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Ayarlar";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 754);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1255, 31);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.AppearancePage.Header.BackColor = System.Drawing.Color.White;
            this.xtraTabbedMdiManager1.AppearancePage.Header.Options.UseBackColor = true;
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // frmAnaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 785);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "frmAnaMenu";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Otomasyon";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnKullanicilar;
        private DevExpress.XtraBars.BarButtonItem btnKullaniciHareketleri;
        private DevExpress.XtraBars.BarButtonItem btnUrunler;
        private DevExpress.XtraBars.BarButtonItem btnUrunHareketleri;
        private DevExpress.XtraBars.BarButtonItem btnDepo;
        private DevExpress.XtraBars.BarButtonItem btnDepoHareketleri;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem btnFatura;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
    }
}