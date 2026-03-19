namespace ConsoleApp1.Models;

public class Epargne : Compte
{
    public DateTime DateDernierRetrait { get; set; }
    
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