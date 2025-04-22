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
    private bool accepteForteLuminosite;

    public bool AccepteForteLuminosite
    {
        get {return accepteForteLuminosite;}
        set {accepteForteLuminosite = value;}
    }
    private bool couleursChaudes;

    private bool CouleursChaudes
    {
        get {return couleursChaudes;}
        set {couleursChaudes = value;}
    }

    public Toile(string titre, double largeur, double hauteur, bool accepteForteLuminosite, bool couleursChaudes)
    {
        this.titre = titre;
        this.largeur = largeur;
        this.hauteur = hauteur;
        this.accepteForteLuminosite = accepteForteLuminosite;
        this.couleursChaudes = couleursChaudes;
    }

    public override string ToString()
    {
        string luminosite = accepteForteLuminosite ? "Oui" : "Non";
        string typeDeCouleurs = couleursChaudes ? "Oui" : "Non";
        return $"Titre : {titre}, Largeur : {largeur} Hauteur : {hauteur} ,\nAccepte Forte Luminosite: {luminosite}, Couleurs Chaudes: {typeDeCouleurs} \n";
    }
}