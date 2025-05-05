public class Chambre
{

    private string nom { get; set; }
    public string Nom
    {
        get { return nom; }
        set { nom = value; }
    }
    private bool estLumineuse;

    public bool EstLumineuse
    {
        
        get { return estLumineuse; }
        set { estLumineuse = value; }
    }

    private bool couleurs;

    public bool Couleurs
    {
        
        get { return couleurs; }
        set { couleurs = value; }
    }

    private List<Mur> murs;

    public List<Mur> Murs
    {
        get { return murs; }
        set { murs = value; }
    }

    public Chambre(string Nom, bool luminosite, bool couleurs, List<Mur> murs)
    {
        if (murs == null || murs.Count < 4)
        {
            throw new ArgumentException("Une chambre doit avoir au moins 4 murs.");
        }
        this.nom = Nom;
        this.EstLumineuse = luminosite;
        this.couleurs = couleurs;
        this.murs = murs;
    }

    public override string ToString()
    {
    
        string luminosite = EstLumineuse ? "lumineuse" : "peu lumineuse"; 
        string couleurs = Couleurs ? "couleurs chaudes" : "couleurs froides"; 

        return $"<<{Nom}>> {luminosite} et aux {couleurs}, Nombre de murs: {Murs.Count}"; 
            

    }





}