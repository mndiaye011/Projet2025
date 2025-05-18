public abstract class Zone
{
    private bool estLibre;

    public bool EstLibre
    {

        get { return estLibre; }
        set { estLibre = value; }
    }

    private static int lastId = 0;
    public int id
    {
        get; private set;
    }

    private double largeur;
    public double Largeur
    {
        get { return largeur; }
        set
        {
            if (value > 0)
            {
                largeur = value;
            }
            ;
        }
    }

    private double hauteur;

    public double Hauteur
    {
        get { return hauteur; }
        set
        {
            if (value > 0)
            {
                hauteur = value;
            }
            ;
        }
    }

    public Zone(double largeur, double hauteur)
    {
        this.largeur = largeur;
        this.hauteur = hauteur;
        this.estLibre = true;
        this.id = ++lastId;

    }
}



public enum TypeZone
{
    Toile,
    Antiquite
}