public class Vitrine : Zone
{
    public TypeZone TypeZone { get; set; }
    public Vitrine(double largeur, double hauteur) : base(largeur, hauteur)
    {
        TypeZone = TypeZone.Antiquite;
    }
}