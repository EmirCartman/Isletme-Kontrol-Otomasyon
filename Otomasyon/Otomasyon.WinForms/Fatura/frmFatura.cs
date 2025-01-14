using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.Entity;
using System.Runtime.Remoting.Messaging;
using Otomasyon.Entities.Model;
using System.Data.Entity.Infrastructure;

namespace Otomasyon.WinForms.Fatura
{
    public partial class frmFatura : DevExpress.XtraEditors.XtraForm
    {

       private OtomasyonContext context = new OtomasyonContext();
        public frmFatura()
        {
            InitializeComponent();
            context.Fatura.Load();
            gridControl1.DataSource = context.Fatura.Local.ToBindingList();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                context.SaveChanges();
                gridView1.RefreshData();
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show($"Hata: {ex.InnerException?.InnerException?.Message}");
            }
        }


        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili olan Fatura silinsin mi?","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                gridView1.DeleteSelectedRows();
                context.SaveChanges();

            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }   
}