namespace ConsoleApp1.Models;

public class Banque
{
    public string Nom { get; set; }
    private Dictionary<string, Compte> account = new Dictionary<string, Compte>();

    public void AddAccount(Compte nouveauCompte)
    {
        account.Add(nouveauCompte.Numero, nouveauCompte);
    }

    public void DeleteAccount(Compte supprimerCompte)
    {
        account.Remove(supprimerCompte.Numero);
    }
}