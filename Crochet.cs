public class Crochet : Zone
{
    public TypeZone TypeZone { get; set; }
    public Crochet(double largeur, double hauteur) : base(largeur, hauteur)
    {
        TypeZone = TypeZone.Toile;
    }
}