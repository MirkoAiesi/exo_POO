using ConsoleApp1.Models;

Compte compte = new Courant();
compte.Numero="BE69 1430 8207 1274";
compte.Depot(38);
Banque banque = new Banque();

banque.AddAccount(compte);
banque.ShowAccount();
banque.DeleteAccount(compte);
banque.ShowAccount();