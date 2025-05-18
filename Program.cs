


Toile toile1 = new Toile("MYBLUE", 33.5, 45.0, true, false);
Toile toile2 = new Toile("MYRED", 25.0, 30.0, false, true);
Antiquite antiquite1 = new Antiquite("MYGREEN", 20.0, 25.0, true, true);
Antiquite antiquite2 = new Antiquite("MYYELLOW", 15.0, 20.0, false, false);


List<OeuvreDart> oeuvreDarts = new List<OeuvreDart>();
oeuvreDarts.Add(toile1);
oeuvreDarts.Add(toile2);
oeuvreDarts.Add(antiquite1);
oeuvreDarts.Add(antiquite2);

oeuvreDarts.Add(new Toile("MYBLACK", 10.0, 15.0, true, false));


foreach ( var oeuvreDart in oeuvreDarts)
{
    Console.WriteLine($"{oeuvreDart}");
}



Musee musee = new Musee(new List<Chambre>(), "Aquitaine");
/*
Mur mur1 = new Mur(true);    
Mur mur2 = new Mur(false);
Mur mur3 = new Mur(true);
Mur mur4 = new Mur(false);
*/


Mur mur1 = new Mur(false, new List<Zone> { new Crochet(2.0, 3.0), new Vitrine(20, 30), new Crochet(150, 200) });  
Mur mur2 = new Mur(false, new List<Zone> { new Vitrine(2.0, 3.0), new Vitrine(25, 35), new Crochet(2.0, 3.0) });
Mur mur3 = new Mur(false, new List<Zone> { new Crochet(2.0, 3.0), new Vitrine(26, 30), new Crochet(2.0, 3.0) });
Mur mur4 = new Mur(false, new List<Zone> { new Vitrine(200.0, 300.0), new Crochet(25, 36), new Vitrine(20, 3.0) });


Chambre printemps = new Chambre("Printemps", true, true, new List<Mur> { mur1, mur2, mur3, mur4 });   


musee.AjouterChambre(printemps);

Chambre ete = new Chambre("Eté", true, false, new List<Mur> { mur1, mur2, mur3, mur4 });

musee.AjouterChambre(ete);

Chambre automne = new Chambre("Automne", false, true, new List<Mur> { mur1, mur2, mur3, mur4 });

musee.AjouterChambre(automne);

Chambre hiver = new Chambre("Hiver", false, false, new List<Mur> { mur1, mur2, mur3, mur4 });

musee.AjouterChambre(hiver);

Console.WriteLine(musee.ToString());


// Test de la méthode ChambreAppropriée

Chambre? chambreTrouvee = musee.ChambreAppropriée(toile1.EstLumineuse, toile1.CouleursChaudes);
if (chambreTrouvee != null)
{
    Console.WriteLine($"Chambre trouvée pour la toile 1: {chambreTrouvee.Nom}");
}
else
{
    Console.WriteLine("Aucune chambre trouvée pour la toile 1.");
}


Chambre? chambrePasTrouvee = musee.ChambreAppropriée(toile2.EstLumineuse, toile2.CouleursChaudes);
if (chambrePasTrouvee != null)
{
    Console.WriteLine($"Chambre trouvée pour la toile 2: {chambrePasTrouvee.Nom}");
}
else
{
    Console.WriteLine("Aucune chambre trouvée pour la toile 2.");
}


Console.WriteLine(mur1.ToString());


// Test de la méthode zoneAppropriee
int zoneTrouvee = mur1.zoneAppropriee(toile1.Hauteur, toile1.Largeur);
Console.WriteLine($"Zone trouvée pour la toile 1: {zoneTrouvee}");

// Test de la méthode zoneApproprieeBis
int zoneTrouveeBis = mur4.zoneApproprieeBis(antiquite2);
Console.WriteLine($"Zone Bis trouvée pour l'antiquité 2: {zoneTrouveeBis}");