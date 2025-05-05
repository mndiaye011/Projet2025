public class Toile
{
    private string titre;

    public string Titre
    {
        get {return titre;} 
        set {titre = value;}
    }
    private double largeur;
    public double Largeur
    {
        get {return largeur;}
        set {largeur = value;}
    }

    private double hauteur;

    public double Hauteur
    {
        get {return hauteur;}
        set {
            if (value >0)
            {
                hauteur = value;
            };
        }
    }
    private bool estLumineuse;

    public bool EstLumineuse
    {
        get {return estLumineuse;}
        set {estLumineuse = value;}
    }
    private bool couleursChaudes;

    public bool CouleursChaudes
    {
        get {return couleursChaudes;}
        set {couleursChaudes = value;}
    }

    public Toile(string titre, double largeur, double hauteur, bool estLumineuse, bool couleursChaudes)
    {
        this.titre = titre;
        this.largeur = largeur;
        this.hauteur = hauteur;
        this.estLumineuse = estLumineuse;
        this.couleursChaudes = couleursChaudes;
    }

    public override string ToString()
    {
        string luminosite = estLumineuse ? "oui" : "non";
        string typeDeCouleurs = couleursChaudes ? "couleurs chaudes" : "couleurs froides";
        return $"Titre : {titre}, Largeur : {largeur} Hauteur : {hauteur} ,\nAccepte Forte Luminosite: {luminosite}, type de Couleurs: {typeDeCouleurs} \n";
    }
}