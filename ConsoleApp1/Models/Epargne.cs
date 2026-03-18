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
}