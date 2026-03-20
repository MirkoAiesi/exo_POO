namespace ConsoleApp1.Models;

public class User
{
    public string Name { get; init; }
    public string Prenom { get; init; }
    public DateTime DateDeNaissance { get; init; }

    public User(string nom, string prenom, DateTime dateDeNaissance)
    {
        Name = nom;
        Prenom = prenom;
        DateDeNaissance = dateDeNaissance;
    }
}