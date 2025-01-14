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
using Otomasyon.Entities.DAL;
using Otomasyon.Entities.Model;

namespace Otomasyon.WinForms.Urunler
{
    public partial class frmUrunKaydet : DevExpress.XtraEditors.XtraForm
    {
        private DepoDal depoDal = new DepoDal();
       private OtomasyonContext context = new OtomasyonContext();
       private UrunDal urunDal = new UrunDal();
        private Urun _entity;
        public bool kaydet = false;
        public frmUrunKaydet(Urun entity)
        {
            _entity = entity;
            InitializeComponent();
            lookUpDepo.Properties.DataSource = depoDal.GetAll(context);
            lookUpDepo.DataBindings.Add("EditValue", _entity, "DepoId");
            txtUrunAdi.DataBindings.Add("Text", _entity, "UrunAdi");
            txtUrunKodu.DataBindings.Add("Text", _entity, "UrunKodu");
            calcBirimFiyati1.DataBindings.Add("Text", _entity, "BirimFiyati1",true);
            calcBirimFiyati2.DataBindings.Add("Text", _entity, "BirimFiyati2",true);
            txtAciklama.DataBindings.Add("Text", _entity, "Aciklama");
            dateEdit1.DataBindings.Add("Text", _entity, "Tarih");
        }

        private void btnUrunKaydet_Click(object sender, EventArgs e)
        {
            if (urunDal.AddOrUpdate(context, _entity))
            {
                urunDal.Save(context);
                kaydet = true;
                this.Close();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}