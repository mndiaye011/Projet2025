public class Musee
{
   
    private string nom { get; set; }
    private List<Chambre> chambres;
    
    public List<Chambre> Chambres
    {
        get { return chambres; }
    }
    public Musee(List<Chambre> chambres, string nom)
    {
        this.nom = nom;
        this.chambres = chambres;
    }
   
    public void AjouterChambre(Chambre chambre)
    {
        chambres.Add(chambre);
    }


    public override string ToString()
    {
        string result = $"Nom du musée: {nom}\n Nombre de chambres:{chambres.Count} \nChambres:\n";
        foreach (Chambre chambre in chambres)
        {
            result += chambre.ToString() + "\n";
        }
        return result;
    }

}
