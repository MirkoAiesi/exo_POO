using ConsoleApp1.Models;

Console.WriteLine("Hello, World!");
 
Courant compte = new Courant();
Epargne epargne = new Epargne();
User personne = new User();

compte.Numero = "BE69 1430 7284 1452";
personne.Name= "Aiesi";
personne.Prenom = "Mirko";
compte.Depot(50);
epargne.Depot(500);


compte.Titulaire = personne ;

Console.WriteLine($"{personne.Name}, tu possèdes {compte.Solde} sur ton compte courrant {compte.Numero} et sur l'épargne {epargne.Solde}");
compte.AppliquerInteret();
epargne.AppliquerInteret();
Console.WriteLine($"Solde sur le compte courrant apres les interet {compte.Solde} sur l'épargne {epargne.Solde}");