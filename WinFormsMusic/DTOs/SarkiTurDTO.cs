using System.ComponentModel;

namespace WinFormsMusic.DTOs
{
    public class SarkiTurDTO
    {
        public int SarkiId { get; set; }

        public int TurId { get; set; }

        [DisplayName("Şarkı")]
        public string SarkiAdi { get; set; }

        [DisplayName("Şarkının Türü")]
        public string TurAdi { get; set; }
    }
}
