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
    
    public override void Retrait(double montant)
    {
        double ancienSolde = Solde;

        base.Retrait(montant);

        if (Solde != ancienSolde)
        {
            DateDernierRetrait = DateTime.Now;
        }
        
    }

    protected override double CalculInteret()
    {
        Interet = 4.5;
        ResultInteret = (Solde/100) * Interet;
        return ResultInteret;
    }
}