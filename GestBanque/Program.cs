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
            
            e.Depot(500);
            e.Retrait(250);
            c.Depot(1000);
            c.Depot(500);
            c1.Retrait(250);
            c2.Retrait(500);

            Banque b = new Banque();
            b.Nom = "BNP PARIBAS";
            b.ajouter(c);
            b.ajouter(c1);
            b.ajouter(c2);
            b.ajouter(e);
            Console.WriteLine($"{p.Prenom} {p.Nom} a {b.AvoirDesComptes(p)} sur ses comptes");

           




            Console.WriteLine(c.Solde);
            
        }
    }
}
