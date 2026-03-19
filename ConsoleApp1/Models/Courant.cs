namespace ConsoleApp1.Models;

public class Courant : Compte
{
    private double _ligneDeCredit;
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

    public double LigneDeCredit2
    {
        get => field;
        set => field = value >= 0 ? value: field;
    }

    public override bool Retrait(double montant)
    {
        if (montant <= 0)
        {
            Console.WriteLine("le montant doit etre supérieur à 0 ");
            return false;
        }
        if (Solde - montant > Solde + LigneDeCredit)
        {
            Console.WriteLine("Pas assez d'argent pour retirer ce montant");
            return false;
        }

        Solde -= montant;
        return true;
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