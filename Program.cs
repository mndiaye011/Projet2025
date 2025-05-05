Toile toile1 = new Toile("MYBLUE", 33.5, 45.0, true, false);
Toile toile2 = new Toile("MYRED", 25.0, 30.0, false, true);
Toile toile3 = new Toile("MYGREEN", 20.0, 25.0, true, true);
Toile toile4 = new Toile("MYYELLOW", 15.0, 20.0, false, false);


List<Toile> toiles = new List<Toile>();
toiles.Add(toile1);
toiles.Add(toile2);
toiles.Add(toile3); 
toiles.Add(toile4);
toiles.Add(new Toile("MYBLACK", 10.0, 15.0, true, false));


foreach ( var toile in toiles)
{
    Console.WriteLine($"{toile}");
}



Musee musee = new Musee(new List<Chambre>(), "Aquitaine");
/*
Mur mur1 = new Mur(true);    
Mur mur2 = new Mur(false);
Mur mur3 = new Mur(true);
Mur mur4 = new Mur(false);
*/

Mur mur1 = new Mur(false);    
Mur mur2 = new Mur(false);
Mur mur3 = new Mur(false);
Mur mur4 = new Mur(false);


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

