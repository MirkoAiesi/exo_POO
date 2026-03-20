using ConsoleApp1.Interfaces;

namespace ConsoleApp1.Models;

public abstract class Compte : IBanker //abstract ne peut pas etre instancié, on ne peut pas créer d'objet compte utiliser a des fin d'héritage
{
    public string? Numero { get; set; }
    public double Solde { get; protected set; }
    public double Interet { get; protected set; }
    public double ResultInteret { get; set; }
    public User? Titulaire { get; set; }

    public Compte(string numero, User titulaire)
    {
        Numero = numero;
        Titulaire = titulaire;
    }
    public Compte(string numero, User titulaire, double solde)
    {
        Numero = numero;
        Titulaire = titulaire;
        Solde = solde;
    }

    public virtual bool Retrait(double montant)
    
    {
        if (montant <= 0)
        {
            Console.WriteLine($"le montant doit etre supérieur à 0 ");
            return false;
        }
        if (Solde - montant > Solde)
        {
            Console.WriteLine("Pas assez d'argent pour retirer ce montant");
            return false;
        }

        Solde -= montant;
        return true;
    }
    public virtual bool Depot(double montant)
    {
        if (montant <= 0)
        {
            Console.WriteLine($"le montant doit etre supérieur à 0 ");
            return false;
        }
        else
        {
            Solde += montant;
            return true;
        }
        
    }

    protected abstract double CalculInteret();

    public void AppliquerInteret()
    {
        Solde = Solde + CalculInteret();
    }
}