using WinFormsMusic.Contexts;
using WinFormsMusic.DTOs;
using WinFormsMusic.Entities;

namespace WinFormsMusic
{
    public partial class SarkiEkle : Form
    {
        MusicContext _db = new MusicContext();
        public SarkiEkle()
        {
            InitializeComponent();
        }

        private void SarkiEkle_Load(object sender, EventArgs e)
        {
            lMesaj.Text = string.Empty;
            SarkiciListesiniDoldur();
            TurListesiniDoldur();
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

        private void bEkle_Click(object sender, EventArgs e)
        {
            try
            {
                lMesaj.Text = string.Empty;

                Sarki yeniSarki = SarkiOlustur();
                if (yeniSarki is not null)
                {
                    Ekle(yeniSarki);
                    lMesaj.Text = "Şarkı başarıyla eklendi.";
                }
            }
            catch (Exception exc)
            {

                lMesaj.Text = "Hata meydana geldi.";
            }
        }

        Sarki SarkiOlustur()
        {
            Sarki yeniSarki;

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

            if (_db.Sarki.Any(sarki => sarki.Adi.ToUpper() == adi.ToUpper()))
            {
                lMesaj.Text = "Girdiğiniz ada sahip şarkı bulunmaktadır.";
                return null;
            }

            yeniSarki = new Sarki()
            {
                Id = 0,
                Adi = adi,
                Sure = TimeSpan.Parse(sure),
                SarkiciId = sarkiciId,

                SarkiTur = turIdleri.Select(turId => new SarkiTur()
                {
                    TurId = turId,
                }).ToList()

            };

            return yeniSarki;
        }

        private void Ekle(Sarki sarki)
        {
            _db.Sarki.Add(sarki);
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
