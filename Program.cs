
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
