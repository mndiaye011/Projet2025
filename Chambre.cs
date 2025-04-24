public class Chambre
{
    private bool forteLuminosite;

    public bool ForteLuminosite
    {
        
        get { return forteLuminosite; }
        set { forteLuminosite = value; }
    }

    private List<Mur> murs;

    public List<Mur> Murs
    {
        get { return murs; }
        set { murs = value; }
    }

    public Chambre(bool forteLuminosite, List<Mur> murs)
    {
        if (murs == null || murs.Count < 4)
        {
            throw new ArgumentException("Une chambre doit avoir au moins 4 murs.");
        }

        this.forteLuminosite = forteLuminosite;
        this.murs = murs;

        this.forteLuminosite = forteLuminosite;
        this.murs = new List<Mur>();

 
    }
 
    public void AjouterMur(Mur mur)
    {
        murs.Add(mur);
    }


    public override string ToString()
    {

        string murs = ""; 
        foreach (Mur mur in Murs)
        {
            murs+=mur.ToString() + " - ";
          
        }
    
        string luminosite = forteLuminosite ? "forte luminosité" : "faible luminosité"; 
        return $"Luminosité : {luminosite}, Nombre de murs: {Murs.Count} murs: {murs} \n"; 
            

    }





}