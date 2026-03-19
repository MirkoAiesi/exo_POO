namespace ConsoleApp1.Interfaces;

public interface ICustomer
{
    double Solde { get; }
    bool Retrait(double montant);
    bool Depot(double montant);
}