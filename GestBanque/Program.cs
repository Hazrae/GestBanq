using Models;
using System;
using System.Reflection;

namespace GestBanque
{
    class Program
    {
        static void Main(string[] args)

        {
            Personne p = new Personne()
            {
                Nom = "Norris",
                Prenom = "Chuck",
                DateNaiss = new DateTime(1904, 3, 10)
            };

            Courant c = new Courant()
            {
                Numero = "000001",
                LigneDeCredit = 500,
                Titulaire = p
            };
            Courant c1 = new Courant()
            {
                Numero = "000002",
                LigneDeCredit = 500,
                Titulaire = p
            };
            Courant c2 = new Courant()
            { 
                Numero = "000003",
                LigneDeCredit = 500,
                Titulaire = p
            };

            Epargne e = new Epargne()
            {
                Numero = "000004",
                Datedernierretrait = DateTime.Now,
                Titulaire = p
            };

            IBanker bank = new Courant();
            ICustomer customer = new Epargne();

                        
            e.Depot(500);
            e.Retrait(250);
            c.Depot(1000);
            c1.Retrait(300);

            Banque b = new Banque();
            b.Nom = "BNP PARIBAS";
            b.ajouter(c);
            b.ajouter(c1);
            b.ajouter(e);

            Console.WriteLine(e.Solde);
            e.AppliquerInteret();
            Console.WriteLine(e.Solde);
            Console.WriteLine(c.Solde);
            c.AppliquerInteret();
            Console.WriteLine(c.Solde);
            Console.WriteLine(c1.Solde);
            c1.AppliquerInteret();
            Console.WriteLine(c1.Solde);



        }
    }
}
