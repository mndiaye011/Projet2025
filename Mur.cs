public class Mur
{
    private bool couleursChaudes;

    public bool CouleursChaudes
    {
        get {return couleursChaudes;}
        set {couleursChaudes = value;}
    }

    public Mur (bool couleursChaudes)
    {
        this.couleursChaudes = couleursChaudes;
    }


    public override string ToString()
    {
        string typeDeCouleurs = couleursChaudes ? "couleurs chaudes" : "couleurs froides";
        return $"Couleurs Chaudes: {typeDeCouleurs} \n";
    }

}