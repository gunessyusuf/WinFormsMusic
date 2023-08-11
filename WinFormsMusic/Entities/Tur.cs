namespace WinFormsMusic.Entities;

public partial class Tur
{
    public int Id { get; set; }

    public string Adi { get; set; } = null!;

    public virtual ICollection<SarkiTur> SarkiTur { get; set; } = new List<SarkiTur>();
}
