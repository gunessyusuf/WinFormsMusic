namespace WinFormsMusic.Entities;

public partial class Sarkici
{
    public int SarkiciId { get; set; }

    public string Ad { get; set; } = null!;

    public string Soyad { get; set; } = null!;

    public virtual ICollection<Sarki> Sarki { get; set; } = new List<Sarki>();
}
