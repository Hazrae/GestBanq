using Models;
using System;
using System.Reflection;

namespace GestBanque
{
    class Program
    {
        static void Main(string[] args)

        {
            Personne p = new Personne("Norris","Chuck", new DateTime(1904, 3, 10));

            Courant c = new Courant("000001",500,p);
            Courant c1 = new Courant("000002", 500, p);

            Courant c2 = new Courant("000003", 500, p);

            Epargne e = new Epargne("000004", p);


            //IBanker bank = new Courant("000005",750,p);
            // ICustomer customer = new Epargne("000006",p);

            try
            {
                e.Depot(500);
                e.Retrait(250);
                c.Depot(1000);
                c1.Retrait(300);
                c2.AppliquerInteret();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType());
                Console.WriteLine(ex.Message);
            }

            Banque b = new Banque("BNP PARIBAS");
            
            b.Ajouter(c);
            b.Ajouter(c1);
            b.Ajouter(e);

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
