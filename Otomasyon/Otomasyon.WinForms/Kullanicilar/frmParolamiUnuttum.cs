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
using Otomasyon.Entities.Model;
using Otomasyon.Entities.DAL;

namespace Otomasyon.WinForms.Kullanicilar
{
    public partial class frmParolamiUnuttum : DevExpress.XtraEditors.XtraForm
    {
        private OtomasyonContext context = new OtomasyonContext();
        private KullanicilarDal kullanicilarDal = new KullanicilarDal();
        private KullaniciHareketleri kullaniciHareketleri = new KullaniciHareketleri();
        private KullaniciHareketleriDal kullaniciHareketleriDal = new KullaniciHareketleriDal();
        public frmParolamiUnuttum()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            var entity = kullanicilarDal.GetByFilter(context, k => k.KullaniciAdi == txtKullaniciAdiEmail.Text || k.Email == txtKullaniciAdiEmail.Text);
            if (entity != null)
            {
                if(entity.HatirlatmaSorusu==txtSoru.Text && entity.Cevap == txtCevap.Text)
                {
                    if (txtYeniParola.Text == txtParolaTekrar.Text)
                    {
                        entity.Parola = txtParolaTekrar.Text;
                        if (kullanicilarDal.AddOrUpdate(context, entity))
                        {
                            kullanicilarDal.Save(context);
                           kullaniciHareketleri.KullaniciId = entity.Id;
                            string aciklama = entity.KullaniciAdi + " adlı kullanıcının parolası yenilendi.";
                            kullaniciHareketleriDal.KullaniciHareketleriEkle(context,kullaniciHareketleri, aciklama);

                            this.Close();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Parolalar uyuşmuyor.");
                    }
                }
                else
                {
                    MessageBox.Show("Girilen soru veya cevap yanlış.");
                }
            }
            else
            {
                MessageBox.Show("Böyle bir kullanıcı bulunamadı.");
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}