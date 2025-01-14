using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using Otomasyon.WinForms.Fatura;
using Otomasyon.WinForms.Urunler;
using Otomasyon.WinForms.Kullanicilar;

namespace Otomasyon.WinForms.AnaMenu
{
    public partial class frmAnaMenu : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        void FormGetir(XtraForm frm)
        {
            frm.MdiParent = this;
            frm.Show();
        }

        public frmAnaMenu()
        {
            InitializeComponent();
            frmKullaniciGirisi frm = new frmKullaniciGirisi();
            frm.ShowDialog();
        }
            
        private void btnFatura_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmFatura frm = new frmFatura();
            frm.ShowDialog();
        }

        private void btnUrunler_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmUrunler frm = new frmUrunler();
            FormGetir(frm);
        }
    }
}