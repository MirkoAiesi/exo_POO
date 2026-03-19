namespace ConsoleApp1.Interfaces;
/// Les interfaces sont comme des contrats
/// Elles définissent un ensemble de méthodes et de propriétés 
/// que les classes doivent obligatoirement implémenter.
///
/// Une interface ne contient pas (ou très peu) de logique, 
/// seulement des signatures (méthodes sans corps).
/// Exemple : si une interface impose un double Solde { get; }
/// alors la classe doit au minimum fournir un getter.
/// Une classe peut implémenter plusieurs interfaces.
///
/// Différence avec une classe abstraite :
/// - Une interface ne contient pas d'état (pas de variables d'instance classiques)
/// - Une classe abstraite peut contenir des attributs et du code déjà implémenté
/// On peut créer une référence avec une interface ET une classe abstraite,
/// mais on ne peut instancier directement NI une interface NI une classe abstraite.
public interface ICustomer
{
    double Solde { get; }
    bool Retrait(double montant);
    bool Depot(double montant);
}