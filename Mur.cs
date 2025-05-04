public class Mur
{
    private string couleursChaudes;


    public string CouleursChaudes
    {
        get {return couleursChaudes;}
        set {couleursChaudes = value;}
    }

    public Mur (string couleursChaudes)
    {
        this.couleursChaudes = couleursChaudes;
        
    }

    public override string ToString()
    {
        return $"type de couleurs: {couleursChaudes}";
    }

}