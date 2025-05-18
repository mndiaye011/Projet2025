public class Antiquite : OeuvreDart
{

    public TypeOeuvreDart TypeOeuvreDart { get; set; }
    public Antiquite(string titre, double largeur, double hauteur, bool estLumineuse, bool couleursChaudes) : base(titre, largeur, hauteur, estLumineuse, couleursChaudes)
    {
        TypeOeuvreDart = TypeOeuvreDart.Antiquite;
    }

    public override string ToString()
    {
        return base.ToString() + " TypeOeuvreDart: " + TypeOeuvreDart;
    }
}
 
