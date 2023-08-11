using System.ComponentModel;
using WinFormsMusic.Entities;

namespace WinFormsMusic.DTOs
{
    public class SarkiDTO
    {
        [DisplayName("ID")]
        public int Id { get; set; }

        [DisplayName("Şarkı Adı")]
        public string Adi { get; set; } = null!;

        [Browsable(false)]
        public TimeSpan? Sure { get; set; }

        [DisplayName("Şarkıcı")]
        public string SarkiciAdiSoyadiGosterim { get; set; }

        [DisplayName("Süre")]
        public string SureGosterim { get; set; }

        [DisplayName("Türü")]
        public string TurleriGosterim { get; set; }
    }
}
