namespace WinFormsMusic.Entities;

public partial class SarkiTur
{
    public int SarkiId { get; set; }

    public int TurId { get; set; }

    public string? Id { get; set; }

    public virtual Sarki Sarki { get; set; } = null!;

    public virtual Tur Tur { get; set; } = null!;
}
