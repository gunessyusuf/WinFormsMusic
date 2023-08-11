using System.ComponentModel;

namespace WinFormsMusic.DTOs
{
    public class TurDTO
    {
        [DisplayName("ID")]
        public int Id { get; set; }

        [DisplayName("Şarkının Türü")]
        public string Adi { get; set; } = null!;
    }
}
