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
        string couleurs = couleursChaudes ? "couleurs chaudes" : "couleurs froides"; 

        return $"Chaleur de couleurs: {couleurs}";
    }

}