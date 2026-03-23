using ConsoleApp1.Exception;
using ConsoleApp1.Interfaces;

namespace ConsoleApp1.Models;

public abstract class Compte : IBanker //abstract ne peut pas etre instancié, on ne peut pas créer d'objet compte utiliser a des fin d'héritage
{
    public string? Numero { get; private set; }
    public double Solde { get; protected set; }
    public double Interet { get; protected set; }
    public double ResultInteret { get; set; }
    public User? Titulaire { get; private set; }

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

    public virtual void Retrait(double montant)
    
    {
        if (montant <= 0)
        {
            throw new SoldeInsuffisantException($"le montant du retrait doit etre supérieur à 0 !!");
        }
        if (Solde - montant > Solde)
        {
            Console.WriteLine("Pas assez d'argent pour retirer ce montant");
            return;
        }

        Solde -= montant;

    }
    public virtual void Depot(double montant)
    {
        if (montant <= 0)
        {
            Console.WriteLine($"le montant doit etre supérieur à 0 ");
            throw new ArgumentOutOfRangeException();
        }
        else
        {
            Solde += montant;
        }
        
    }

    protected abstract double CalculInteret();

    public void AppliquerInteret()
    {
        Solde = Solde + CalculInteret();
    }
}