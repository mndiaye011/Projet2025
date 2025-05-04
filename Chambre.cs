public class Chambre
{

    private string Nom { get; set; }
    private bool luminosite;

    public bool Luminosite
    {
        
        get { return luminosite; }
        set { luminosite = value; }
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
        this.Nom = Nom;
        this.Luminosite = luminosite;
        this.couleurs = couleurs;
        this.murs = murs;
    }

    public override string ToString()
    {
    
        string luminosite = Luminosite ? "lumineuse" : "peu lumineuse"; 
        string couleurs = Couleurs ? "couleurs chaudes" : "couleurs froides"; 

        return $"<<{Nom}>> {luminosite} et aux {couleurs}, Nombre de murs: {Murs.Count}"; 
            

    }





}