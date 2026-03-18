using ConsoleApp1.Models;

Console.WriteLine("Hello, World!");
 
Courant c = new Courant();
User personne = new User();

c.Numero = "10.0";
personne.Name= "Aiesi";
personne.Prenom = "Mirko";

c.Titulaire = personne ;

Console.WriteLine(c.Titulaire.Name);