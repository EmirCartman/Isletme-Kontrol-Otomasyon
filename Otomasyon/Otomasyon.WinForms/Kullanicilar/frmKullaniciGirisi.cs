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
    public partial class frmKullaniciGirisi : DevExpress.XtraEditors.XtraForm
    {
        private bool giris;
        private OtomasyonContext context = new OtomasyonContext();
       private  KullaniciHareketleriDal kulllaniciHareketleriDal = new KullaniciHareketleriDal();
        private KullaniciHareketleri entity = new KullaniciHareketleri();
        void BilgileriGetir()
        {
            if (Properties.Settings.Default.BeniHatirla)
            { 
            txtKullaniciAdi.Text = Properties.Settings.Default.KullaniciAdi;
            txtParola.Text = Properties.Settings.Default.Parola;
                checkBeniHatirla.Checked = true;
            }
            else
            {
                txtKullaniciAdi.Text = null;
                txtParola.Text = null;
                checkBeniHatirla.Checked = false;
            }
        }
        void BilgileriKaydet()
        {
            if (checkBeniHatirla.Checked)
            {
                Properties.Settings.Default.KullaniciAdi = txtKullaniciAdi.Text;
                Properties.Settings.Default.Parola = txtParola.Text;
                Properties.Settings.Default.BeniHatirla = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.KullaniciAdi =null;
                Properties.Settings.Default.Parola = null;
                Properties.Settings.Default.BeniHatirla = false;
            }
        }


        public frmKullaniciGirisi()
        {
            InitializeComponent();
            BilgileriGetir();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            if (!giris)
            {
                Application.Exit();

            }
        }

        private void frmKullaniciGirisi_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!giris)
            {
                Application.Exit();

            }
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            var model = context.Kullanicilar.FirstOrDefault(k => k.KullaniciAdi == txtKullaniciAdi.Text && k.Parola == txtParola.Text);

            if(model !=null)
            {
                giris = true;
                BilgileriKaydet();
                entity.KullaniciId = model.Id;
                string aciklama = model.KullaniciAdi+" adlı kullanıcı sisteme giriş yaptı.";
               
                kulllaniciHareketleriDal.KullaniciHareketleriEkle(context, entity,aciklama);
                this.Close();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış.", "Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void frmKaydol_Click(object sender, EventArgs e)
        {
            frmKaydol frm = new frmKaydol(new Entities.Model.Kullanicilar());
            frm.ShowDialog();
        }

        private void btnSifremiUnuttum_Click(object sender, EventArgs e)
        {
            frmParolamiUnuttum frm = new frmParolamiUnuttum();
            frm.ShowDialog();
        }
    }
}