using ConsoleApp1.Models;

namespace ConsoleApp1.Interfaces;

public interface IBanker : ICustomer
{
    void AppliquerInteret();
    User Titulaire { get; }
    string Numero { get; }
}