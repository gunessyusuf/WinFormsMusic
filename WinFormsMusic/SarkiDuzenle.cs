using Microsoft.EntityFrameworkCore;
using WinFormsMusic.Contexts;
using WinFormsMusic.DTOs;
using WinFormsMusic.Entities;

namespace WinFormsMusic
{
    public partial class SarkiDuzenle : Form
    {
        int _sarkiId;
        MusicContext _db = new MusicContext();
        public SarkiDuzenle(int sarkiId)
        {
            _sarkiId = sarkiId;
            InitializeComponent();
        }

        private void SarkiDuzenle_Load(object sender, EventArgs e)
        {
            lMesaj.Text = string.Empty;
            SarkiciListesiniDoldur();
            TurListesiniDoldur();
            SarkiDetayiniDoldur();
        }

        private void TurListesiniDoldur()
        {
            IQueryable<TurDTO> turQuery = _db.Tur.OrderBy(tur => tur.Adi).Select(tur => new TurDTO()
            {
                Id = tur.Id,
                Adi = tur.Adi
            });

            lbTurler.DataSource = turQuery.ToList();
            lbTurler.ValueMember = "Id";
            lbTurler.DisplayMember = "Adi";
            lbTurler.ClearSelected();
        }

        private void SarkiciListesiniDoldur()
        {
            List<SarkiciDTO> sarkiciListesi;

            IQueryable<SarkiciDTO> sarkiciQuery = _db.Sarkici.OrderBy(sarkici => sarkici.Ad).ThenBy(sarkici => sarkici.Soyad).Select(sarkici => new SarkiciDTO()
            {
                SarkiciId = sarkici.SarkiciId,
                AdiSoyadiGosterim = sarkici.Ad + " " + sarkici.Soyad,
            });

            sarkiciListesi = sarkiciQuery.ToList();

            sarkiciListesi.Insert(0, new SarkiciDTO()
            {
                SarkiciId = -1,
                AdiSoyadiGosterim = "Seçiniz"
            });

            ddlSarkici.DataSource = sarkiciListesi;
            ddlSarkici.ValueMember = "SarkiciId";
            ddlSarkici.DisplayMember = "AdiSoyAdiGosterim";

        }

        private void SarkiDetayiniDoldur()
        {
            Sarki varolanSarki = _db.Sarki.Include(sarki => sarki.Sarkici).Include(sarki => sarki.SarkiTur).SingleOrDefault(sarki => sarki.Id == _sarkiId);

            if (varolanSarki is null)
            {
                lMesaj.Text = "Şarkı bulunamadı!";
                return;
            }

            tbAdi.Text = varolanSarki.Adi;
            tbSure.Text = varolanSarki.Sure.ToString();
            ddlSarkici.SelectedValue = varolanSarki.SarkiciId;

            //var sarkiTurleri = varolanSarki.SarkiTur.ToList();

            if (varolanSarki.SarkiTur is not null && varolanSarki.SarkiTur.Count > 0)
            {
                for (int i = 0; i < lbTurler.Items.Count; i++)
                {

                    foreach (var sarkiTur in varolanSarki.SarkiTur)
                    {

                        var turDto = lbTurler.Items[i] as TurDTO;
                        if (turDto is not null && turDto.Id == sarkiTur.TurId)
                        {
                            lbTurler.SetSelected(i, true);
                            break;
                        }

                    }

                }
            }

        }

        Sarki SarkiOlustur()
        {
            Sarki varolanSarki = _db.Sarki.Find(_sarkiId);

            string adi = tbAdi.Text;
            if (string.IsNullOrWhiteSpace(adi))
            {
                lMesaj.Text = "Şarkı adı zorunludur!";
                return null;
            }

            string sure = tbSure.Text.ToString().Substring(0, 8);
            if (string.IsNullOrWhiteSpace(sure))
            {
                lMesaj.Text = "Şarkı süresi zorunludur!";
                return null;
            }

            int? sarkiciId = null;
            if (Convert.ToInt32(ddlSarkici.SelectedValue) is not -1)
            {
                sarkiciId = Convert.ToInt32(ddlSarkici.SelectedValue);
            }

            List<int> turIdleri = new List<int>();
            foreach (var item in lbTurler.SelectedItems)
            {
                turIdleri.Add((item as TurDTO).Id);
            }

            if (_db.Sarki.Any(sarki => sarki.Adi.ToUpper() == adi.ToUpper() && sarki.Id != _sarkiId))
            {
                lMesaj.Text = "Girdiğiniz ada sahip şarkı bulunmaktadır.";
                return null;
            }




            varolanSarki.Adi = adi;
            varolanSarki.Sure = TimeSpan.Parse(sure);
            varolanSarki.SarkiciId = sarkiciId;

            varolanSarki.SarkiTur = turIdleri.Select(turId => new SarkiTur()
            {
                TurId = turId,
            }).ToList();



            return varolanSarki;
        }

        private void bGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                lMesaj.Text = string.Empty;

                Sarki varolanSarki = SarkiOlustur();
                if (varolanSarki is not null)
                {
                    Guncelle(varolanSarki);
                    lMesaj.Text = "Şarkı başarıyla güncellendi.";
                }
            }
            catch (Exception exc)
            {

                lMesaj.Text = "Hata meydana geldi.";
            }
        }

        void Guncelle(Sarki sarki)
        {
            _db.Sarki.Update(sarki);
            _db.SaveChanges();
        }

        private void bTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
        private void Temizle()
        {
            tbAdi.Text = string.Empty;
            tbSure.Text = string.Empty;
            ddlSarkici.SelectedValue = -1;
            lbTurler.ClearSelected();
        }
    }
}
