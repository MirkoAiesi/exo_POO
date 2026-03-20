namespace ConsoleApp1.Models;

public class Epargne : Compte
{
    public Epargne(string numero, User titulaire, DateTime dateDernierRetrait) : base(numero, titulaire)
    {
        DateDernierRetrait = dateDernierRetrait;
    }

    public Epargne(string numero, User titulaire, double solde, DateTime dateDernierRetrait) : base(numero, titulaire, solde)
    {
        DateDernierRetrait = dateDernierRetrait;
    }

    public DateTime DateDernierRetrait { get; private set; }
    
    public override bool Retrait(double montant)
    {
        if (base.Retrait(montant))
        {
            DateDernierRetrait = DateTime.Now;
            return true;
        }

        return false;
    }

    protected override double CalculInteret()
    {
        Interet = 4.5;
        ResultInteret = (Solde/100) * Interet;
        return ResultInteret;
    }
}