using System;
using System.Collections.Generic;


Console.WriteLine("=== TEST DU SYSTÈME DE GESTION DU MUSÉE ===\n");

        // 1. Création des zones pour les murs de la première chambre
        Console.WriteLine("1. Création des zones pour la première chambre...");

                    // Zones pour le mur 1 de la chambre 1
                    Crochet crochet1_1 = new Crochet(200, 300);
                    Crochet crochet1_2 = new Crochet(250, 350);
                    List<Zone> zonesMur1Chambre1 = new List<Zone> { crochet1_1, crochet1_2 };

                    // Zones pour le mur 2 de la chambre 1
                    Vitrine vitrine1_1 = new Vitrine(300, 200);
                    Vitrine vitrine1_2 = new Vitrine(400, 250);
                    List<Zone> zonesMur2Chambre1 = new List<Zone> { vitrine1_1, vitrine1_2 };

                    // Zones pour le mur 3 de la chambre 1
                    Crochet crochet1_3 = new Crochet(220, 320);
                    Vitrine vitrine1_3 = new Vitrine(350, 300);
                    List<Zone> zonesMur3Chambre1 = new List<Zone> { crochet1_3, vitrine1_3 };

                    // Zones pour le mur 4 de la chambre 1
                    Crochet crochet1_4 = new Crochet(300, 400);
                    Vitrine vitrine1_4 = new Vitrine(250, 350);
                    List<Zone> zonesMur4Chambre1 = new List<Zone> { crochet1_4, vitrine1_4 };

                    Console.WriteLine("Zones créées pour la première chambre\n");

                    // 2. Création des murs de la première chambre
                    Console.WriteLine("2. Création des murs de la première chambre...");

                    Mur mur1Chambre1 = new Mur(true, zonesMur1Chambre1);   // Couleurs chaudes
                    Mur mur2Chambre1 = new Mur(false, zonesMur2Chambre1);  // Couleurs froides
                    Mur mur3Chambre1 = new Mur(true, zonesMur3Chambre1);   // Couleurs chaudes
                    Mur mur4Chambre1 = new Mur(false, zonesMur4Chambre1);  // Couleurs froides

                    List<Mur> mursChambre1 = new List<Mur> { mur1Chambre1, mur2Chambre1, mur3Chambre1, mur4Chambre1 };

                    Console.WriteLine("Murs créés pour la première chambre\n");

                    // 3. Création de la première chambre
                    Console.WriteLine("3. Création de la première chambre...");
                    Chambre chambre1 = new Chambre("Salle Renaissance", true, true, mursChambre1);
                    Console.WriteLine(" " + chambre1.ToString() + "\n");

                    // 4. Création des zones pour la deuxième chambre
                    Console.WriteLine("4. Création des zones pour la deuxième chambre...");

                    // Zones pour le mur 1 de la chambre 2
                    Crochet crochet2_1 = new Crochet(180, 280);
                    Crochet crochet2_2 = new Crochet(200, 300);
                    List<Zone> zonesMur1Chambre2 = new List<Zone> { crochet2_1, crochet2_2 };

                    // Zones pour le mur 2 de la chambre 2
                    Vitrine vitrine2_1 = new Vitrine(320, 220);
                    Vitrine vitrine2_2 = new Vitrine(380, 260);
                    List<Zone> zonesMur2Chambre2 = new List<Zone> { vitrine2_1, vitrine2_2 };

                    // Zones pour le mur 3 de la chambre 2
                    Crochet crochet2_3 = new Crochet(240, 340);
                    List<Zone> zonesMur3Chambre2 = new List<Zone> { crochet2_3 };

                    // Zones pour le mur 4 de la chambre 2
                    Vitrine vitrine2_3 = new Vitrine(300, 400);
                    List<Zone> zonesMur4Chambre2 = new List<Zone> { vitrine2_3 };

                    Console.WriteLine("Zones créées pour la deuxième chambre\n");

                    // 5. Création des murs de la deuxième chambre
                    Console.WriteLine("5. Création des murs de la deuxième chambre...");

                    Mur mur1Chambre2 = new Mur(false, zonesMur1Chambre2);  // Couleurs froides
                    Mur mur2Chambre2 = new Mur(false, zonesMur2Chambre2);  // Couleurs froides
                    Mur mur3Chambre2 = new Mur(false, zonesMur3Chambre2);  // Couleurs froides
                    Mur mur4Chambre2 = new Mur(false, zonesMur4Chambre2);  // Couleurs froides

                    List<Mur> mursChambre2 = new List<Mur> { mur1Chambre2, mur2Chambre2, mur3Chambre2, mur4Chambre2 };

                    Console.WriteLine("Murs créés pour la deuxième chambre\n");

                    // 6. Création de la deuxième chambre
                    Console.WriteLine("6. Création de la deuxième chambre...");
                    Chambre chambre2 = new Chambre("Salle Art Moderne", false, false, mursChambre2);
                    Console.WriteLine(chambre2.ToString() + "\n");

                    // 7. Création du musée avec les deux chambres
                    Console.WriteLine("7. Création du musée...");
                    List<Chambre> chambres = new List<Chambre> { chambre1, chambre2 };
                    Musee musee = new Musee(chambres, "Musée des Beaux-Arts");

                    Console.WriteLine(" Musée créé avec succès");
                    Console.WriteLine(musee.ToString());

                    // 8. Création et ajout d'une troisième chambre
                    Console.WriteLine("/n8. Création et ajout d'une troisième chambre...");

                    // Zones pour la chambre 3
                    Crochet crochet3_1 = new Crochet(260, 360);
                    Vitrine vitrine3_1 = new Vitrine(340, 280);
                    List<Zone> zonesMur1Chambre3 = new List<Zone> { crochet3_1, vitrine3_1 };

                    Crochet crochet3_2 = new Crochet(280, 380);
                    List<Zone> zonesMur2Chambre3 = new List<Zone> { crochet3_2 };

                    Vitrine vitrine3_2 = new Vitrine(360, 300);
                    List<Zone> zonesMur3Chambre3 = new List<Zone> { vitrine3_2 };

                    Crochet crochet3_3 = new Crochet(300, 400);
                    Vitrine vitrine3_3 = new Vitrine(320, 420);
                    List<Zone> zonesMur4Chambre3 = new List<Zone> { crochet3_3, vitrine3_3 };

                    // Murs pour la chambre 3
                    Mur mur1Chambre3 = new Mur(true, zonesMur1Chambre3);   // Couleurs chaudes
                    Mur mur2Chambre3 = new Mur(true, zonesMur2Chambre3);   // Couleurs chaudes
                    Mur mur3Chambre3 = new Mur(true, zonesMur3Chambre3);   // Couleurs chaudes
                    Mur mur4Chambre3 = new Mur(true, zonesMur4Chambre3);   // Couleurs chaudes

                    List<Mur> mursChambre3 = new List<Mur> { mur1Chambre3, mur2Chambre3, mur3Chambre3, mur4Chambre3 };

                    Chambre chambre3 = new Chambre("Salle Antiquités Grecques", true, false, mursChambre3);
                    musee.AjouterChambre(chambre3);

                    Console.WriteLine("Troisième chambre ajoutée: " + chambre3.ToString());
                    Console.WriteLine("\nMusée après ajout:");
                    Console.WriteLine(musee.ToString());

                    // 9. Création d'œuvres d'art
                    Console.WriteLine("9. Création d'œuvres d'art...");
                    Toile toile1 = new Toile("La Joconde", 77, 53, false, true);
                    Toile toile2 = new Toile("Les Tournesols", 92, 73, true, true);
                    Antiquite antiquite1 = new Antiquite("Vase Ming", 40, 60, false, false);
                    Antiquite antiquite2 = new Antiquite("Statue Grecque", 80, 200, true, false);

                    Console.WriteLine("Oeuvres créées:");
                    Console.WriteLine("  - " + toile1.ToString());
                    Console.WriteLine("  - " + toile2.ToString());
                    Console.WriteLine("  - " + antiquite1.ToString());
                    Console.WriteLine("  - " + antiquite2.ToString());

                    // 10. Test de recherche de chambre appropriée
                    Console.WriteLine("\n10. Recherche de chambres appropriées pour les œuvres...");

                    // Pour toile1 (pas lumineuse, couleurs chaudes)
                    Chambre? chambrePourToile1 = musee.ChambreAppropriée(toile1.EstLumineuse, toile1.CouleursChaudes);
                    if (chambrePourToile1 != null)
                    {
                        Console.WriteLine($"Chambre trouvée pour '{toile1.Titre}': {chambrePourToile1.Nom}");
                    }

                    // Pour antiquite1 (pas lumineuse, couleurs froides)
                    Chambre? chambrePourAntiquite1 = musee.ChambreAppropriée(antiquite1.EstLumineuse, antiquite1.CouleursChaudes);
                    if (chambrePourAntiquite1 != null)
                    {
                        Console.WriteLine($" Chambre trouvée pour '{antiquite1.Titre}': {chambrePourAntiquite1.Nom}");
                    }

                    // 11. Test de placement d'œuvres dans les zones
                    Console.WriteLine("\n11. Test de placement d'œuvres dans les zones...");

                    // Test pour placer toile1 dans un crochet de la première chambre
                    int zoneId = mur1Chambre1.zoneApproprieeBis(toile1);
                    if (zoneId != 0)
                    {
                        Console.WriteLine($"Zone {zoneId} trouvée pour placer '{toile1.Titre}' sur le mur 1 de {chambre1.Nom}");
                    }
                    else
                    {
                        Console.WriteLine($" Aucune zone trouvée pour placer '{toile1.Titre}' sur le mur 1 de {chambre1.Nom}");
                    }

                    // Test pour placer antiquite1 dans une vitrine de la première chambre
                    int zoneId2 = mur2Chambre1.zoneApproprieeBis(antiquite1);
                    if (zoneId2 != 0)
                    {
                        Console.WriteLine($" Zone {zoneId2} trouvée pour placer '{antiquite1.Titre}' sur le mur 2 de {chambre1.Nom}");
                    }
                    else
                    {
                        Console.WriteLine($" Aucune zone trouvée pour placer '{antiquite1.Titre}' sur le mur 2 de {chambre1.Nom}");
                    }
                    
                    Console.WriteLine("\n=== TEST TERMINÉ AVEC SUCCÈS ===");
