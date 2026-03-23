using ConsoleApp1.Models;


User personne = new User("Aiesi", "Mirko", new DateTime(2001, 03, 10));
Courant compte = new Courant("BE69 1430 8701 1278", personne, -50 );
Epargne epargne = new Epargne("BE69 1430 8701 1278", personne, new DateTime(2026,3,19));

compte.Depot(14);
epargne.Depot(500);

//Console.WriteLine($"Bonjour {personne.Name} {personne.Prenom}, tu possèdes {compte.Solde} sur ton compte courrant {compte.Numero} et sur l'épargne {epargne.Solde}");
compte.AppliquerInteret();
epargne.AppliquerInteret();
//Console.WriteLine($"Solde sur le compte courrant apres les interet {compte.Solde} sur l'épargne {epargne.Solde}");
