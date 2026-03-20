namespace ConsoleApp1.Models;

public class Banque
{
    public string Nom { get; init; }
    private Dictionary<string, Compte> account = new Dictionary<string, Compte>();

    public Banque(string nom)
    {
        Nom = nom;
    }

    public void AddAccount(Compte nouveauCompte)
    {
        account.Add(nouveauCompte.Numero, nouveauCompte);
    }

    public void DeleteAccount(Compte supprimerCompte)
    {
        account.Remove(supprimerCompte.Numero);
    }

    public void ShowAccount()
    {
        foreach (KeyValuePair<string, Compte> n in account)
        {
            Console.WriteLine($"le compte au numéro {n.Key} à comme solde {n.Value.Solde}");
        }
    }
}