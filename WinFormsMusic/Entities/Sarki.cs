namespace WinFormsMusic.Entities;

public partial class Sarki
{
    public int Id { get; set; }

    public string Adi { get; set; } = null!;

    public TimeSpan? Sure { get; set; }

    public int? SarkiciId { get; set; }

    public virtual ICollection<SarkiTur> SarkiTur { get; set; } = new List<SarkiTur>();

    public virtual Sarkici? Sarkici { get; set; }
}
