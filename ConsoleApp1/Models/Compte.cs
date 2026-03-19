namespace ConsoleApp1.Models;

public abstract class Compte //abstract ne peut pas etre instancié, on ne peut pas créer d'objet compte
{
    public string? Numero { get; set; }
    public double Solde { get; protected set; }
    public double Interet { get; protected set; }
    public double ResultInteret { get; set; }
    public User? Titulaire { get; set; }

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

    
}