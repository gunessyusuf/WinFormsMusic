using System.ComponentModel;
using WinFormsMusic.Entities;

namespace WinFormsMusic.DTOs
{
    public class SarkiciDTO
    {
        [DisplayName("ID")]
        public int SarkiciId { get; set; }
        [Browsable(false)]
        public string Ad { get; set; } = null!;

        [Browsable(false)]
        public string Soyad { get; set; } = null!;

        [DisplayName("Adı Soyadı")]
        public string AdiSoyadiGosterim { get; set; }
    }
}
