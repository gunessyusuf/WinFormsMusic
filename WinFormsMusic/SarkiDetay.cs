using Microsoft.EntityFrameworkCore;
using WinFormsMusic.Contexts;
using WinFormsMusic.DTOs;
using WinFormsMusic.Entities;

namespace WinFormsMusic
{
    public partial class SarkiDetay : Form
    {
        int _sarkiId;

        MusicContext _db = new MusicContext();
        public SarkiDetay(int sarkiId)
        {
            _sarkiId = sarkiId;
            InitializeComponent();
        }

        private void SarkiDetay_Load(object sender, EventArgs e)
        {
            try
            {
                
                SarkiDetayiniDoldur();
            }
            catch (Exception exc)
            {

                MessageBox.Show("Hata meydana geldi (" + exc.Message + " | " + exc.InnerException?.Message + ")", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void SarkiDetayiniDoldur()
        {
            SarkiDTO varolanSarki;

            IQueryable<SarkiDTO> sarkiQuery = _db.Sarki.Include(sarki => sarki.Sarkici).Include(sarki => sarki.SarkiTur).ThenInclude(sarkitur => sarkitur.Tur).Select(sarki => new SarkiDTO()
            {
                Id = sarki.Id,
                Adi = sarki.Adi,
                Sure = sarki.Sure,
                SarkiciAdiSoyadiGosterim = sarki.Sarkici.Ad + " " + sarki.Sarkici.Soyad,
                
                TurleriGosterim = string.Join("\r\n", sarki.SarkiTur.Select(sarkiTur => sarkiTur.Tur.Adi))
            });

            varolanSarki = sarkiQuery.SingleOrDefault(sarki => sarki.Id == _sarkiId);

            lAdi.Text = varolanSarki.Adi;
            lSure.Text = varolanSarki.Sure.ToString();
            lSarkiciAdiSoyadi.Text = varolanSarki.SarkiciAdiSoyadiGosterim;
            lTurleri.Text = varolanSarki.TurleriGosterim;
        }
    }
}
