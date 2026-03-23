using ConsoleApp1.Exception;

namespace ConsoleApp1.Models;

public class Courant : Compte
{
    private double _ligneDeCredit;

    public Courant(string numero, User titulaire, double ligneDeCredit) : base(numero, titulaire)
    {
        _ligneDeCredit = ligneDeCredit;
    }

    public Courant(string numero, User titulaire, double solde, double ligneDeCredit) : base(numero, titulaire, solde)
    {
        _ligneDeCredit = ligneDeCredit;
    }

    public double LigneDeCredit
    {
        get
        {
            return _ligneDeCredit;
        } 

        set
        {
            _ligneDeCredit = value >= 0 ? value : _ligneDeCredit; // condition? si vrai value si faux ligneDeCredit
        } 
            
    }
    
    public override void Retrait(double montant)
    {
        if (montant <= 0)
        {
            throw new SoldeInsuffisantException($"le montant du retrait doit etre supérieur à 0 !!");
        }
        if (Solde - montant > Solde + LigneDeCredit)
        {
            Console.WriteLine("Pas assez d'argent pour retirer ce montant");
            return ;
        }

        Solde -= montant;
    }

    protected override double CalculInteret()
    {
        if (Solde > 0)
        {
            Interet = 3;
            ResultInteret = (Solde/100) * Interet;
            return ResultInteret;
        }
        else
        {
            Interet = 9.75;
            ResultInteret = (Solde/100) * Interet;
            return ResultInteret;
        }
    }
}