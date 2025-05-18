public class Mur
{

    
    private bool couleursChaudes;


    public bool CouleursChaudes
    {
        get {return couleursChaudes;}
        set {couleursChaudes = value;}
    }

    private List<Zone> zones;
    public List<Zone> Zones
    {
        get {return zones;}
        set {zones = value;}
    }
    public Mur(bool couleursChaudes, List<Zone> zones)
    {
        if (zones == null || zones.Count < 1)
        {
            throw new ArgumentException("Un mur doit avoir au moins 1 zone.");
        }
        this.zones = zones;
        this.couleursChaudes = couleursChaudes;
    }

    public int zoneAppropriee(double hauteur, double largeur)
    {
        foreach (Zone zone in zones)
        {
            if (zone.EstLibre && zone.Hauteur >= hauteur + 80 && zone.Largeur >= largeur + 80)
            {
                return zone.id;
            }
        }
        return 0;
        
    }

    public int zoneApproprieeBis(OeuvreDart oeuvre)
    {
        foreach (Zone zone in zones)
        {
            if ((zone is Crochet && oeuvre is Toile) || (zone is Vitrine && oeuvre is Antiquite))
            {
                if (zone.EstLibre && zone.Hauteur >= oeuvre.Hauteur + 80 && zone.Largeur >= oeuvre.Largeur + 80)
                {
                    return zone.id;
                }
            }
           
         
        }
        return 0;
        
    }
  

    public override string ToString()
    {
        string couleurs = couleursChaudes ? "couleurs chaudes" : "couleurs froides";

        foreach (Zone zone in zones)
        {
            couleurs += $"\nZone {zone.id} : Largeur: {zone.Largeur}, Hauteur: {zone.Hauteur}";
        }

        return $"Chaleur de couleurs: {couleurs}";
    }

}