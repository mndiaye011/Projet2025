public class Toile : OeuvreDart
{

    public TypeOeuvreDart TypeOeuvreDart { get; set; }
    public Toile(string titre, double largeur, double hauteur, bool estLumineuse, bool couleursChaudes) : base(titre, largeur, hauteur, estLumineuse, couleursChaudes)
    {
        TypeOeuvreDart = TypeOeuvreDart.Toile;
    }

    public override string ToString()
    {
        return base.ToString() + " TypeOeuvreDart: " + TypeOeuvreDart;
    }
}

