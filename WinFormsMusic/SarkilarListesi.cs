using Microsoft.EntityFrameworkCore;
using WinFormsMusic.Contexts;
using WinFormsMusic.DTOs;
using WinFormsMusic.Entities;

namespace WinFormsMusic
{
    public partial class SarkilarListesi : Form
    {
        MusicContext _db = new MusicContext();
        public SarkilarListesi()
        {
            InitializeComponent();
        }

        private void SarkilarListesi_Load(object sender, EventArgs e)
        {
            try
            {
                lSarkiSayisi.Text = string.Empty;
                SarkiListesiniDoldur();
            }
            catch (Exception exc)
            {

                MessageBox.Show("Hata meydana geldi! (" + exc.Message + " | " + exc.InnerException?.Message + ")", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void SarkiListesiniDoldur()
        {
            IQueryable<SarkiDTO> sarkiQuery = _db.Sarki.Include(sarki => sarki.Sarkici).Include(sarki => sarki.SarkiTur)
                .OrderBy(sarki => sarki.Sarkici.Ad)
                .ThenBy(sarki => sarki.Sarkici.Soyad)
                .ThenBy(sarki => sarki.Adi)
                .Select(sarki => new SarkiDTO()
                {
                    // Þarký
                    Id = sarki.Id,
                    Adi = sarki.Adi,
                    SureGosterim = sarki.Sure.ToString().Substring(0, 8),

                    // Þarkýcý
                    SarkiciAdiSoyadiGosterim = sarki.Sarkici.Ad + " " + sarki.Sarkici.Soyad,

                    TurleriGosterim = string.Join(", ", sarki.SarkiTur.Select(SarkiTur => SarkiTur.Tur.Adi))
                });

            List<SarkiDTO> sarkiListesi = sarkiQuery.ToList();

            dgvSarkilar.DataSource = sarkiListesi;
            dgvSarkilar.ClearSelection();

            lSarkiSayisi.Text = sarkiListesi.Count == 0 ? " Sarký bulunamadý." : sarkiListesi.Count + " sarký bulundu";

            SarkiListeSutunlarýnýDuzenle();
        }

        private void SarkiListeSutunlarýnýDuzenle()
        {
            //dgvSarkilar.Columns["Adý"].Width = 175;
            dgvSarkilar.Columns["Adi"].Width = 200;
            dgvSarkilar.Columns["SarkiciAdiSoyadiGosterim"].Width = 200;
        }

        private void listeleToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                lSarkiSayisi.Text = string.Empty;
                SarkiListesiniDoldur();
            }
            catch (Exception exc)
            {

                MessageBox.Show("Hata meydana geldi! (" + exc.Message + " | " + exc.InnerException?.Message + ")", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SarkiEkle form = new SarkiEkle();
            form.Show();
        }

        private void bDetay_Click(object sender, EventArgs e)
        {
            if (dgvSarkilar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Listeden þarký seçilmelidir!");
                return;
            }
            else
            {
                int sarkiId = Convert.ToInt32(dgvSarkilar.SelectedRows[0].Cells["Id"].Value);

                SarkiDetay form = new SarkiDetay(sarkiId);
                form.Show();
            }
        }

        private void bDuzenle_Click(object sender, EventArgs e)
        {
            if (dgvSarkilar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Listeden þarký seçilmelidir!");
                return;
            }
            else
            {
                int sarkiId = Convert.ToInt32(dgvSarkilar.SelectedRows[0].Cells["Id"].Value);

                SarkiDuzenle form = new SarkiDuzenle(sarkiId);
                form.Show();
            }
        }

        private void bSil_Click(object sender, EventArgs e)
        {
            if (dgvSarkilar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Listeden þarký seçilmelidir!");
                return;
            }
            else
            {
                int sarkiId = Convert.ToInt32(dgvSarkilar.SelectedRows[0].Cells["Id"].Value);

                Sil(sarkiId);

                MessageBox.Show("Þarký baþarýyla silindi");
            }
        }

        private void Sil(int sarkiId)
        {
            Sarki varolanSarki = _db.Sarki.Include(sarki => sarki.SarkiTur).SingleOrDefault(sarki => sarki.Id == sarkiId);

            _db.SarkiTur.RemoveRange(varolanSarki.SarkiTur);
            _db.Sarki.Remove(varolanSarki);
            _db.SaveChanges();
        }
    }
}