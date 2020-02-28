using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public abstract class Compte : ICustomer, IBanker
    {
        //***VARIABLES***

        private string _numero;
        private double _solde;
        private Personne _titulaire;
       

        //***METHODES ABSTRAITES***
        protected abstract double CalculInteret();

        public Compte(string num, Personne titu)
        {
            Numero = num;
            Titulaire = titu;
        }

        public Compte(string num, Personne titu, double solde) :this(num,titu)
        {
            Solde = solde;
        }

        public string Numero
        {
            get
            {
                return _numero;
            }
            private set
            {
                _numero = value;
            }
        }
        public double Solde
        {
            get
            {
                return _solde;
            }
            private set
            {
                _solde = value;
            }
        }

        public Personne Titulaire
        {
            get
            {
                return _titulaire;
            }
            private set
            {
                _titulaire = value;
            }
        }

        public static double operator +(double tot, Compte c)
        {
            return ((tot < 0) ? 0 : tot) + ((c.Solde < 0) ? 0 : c.Solde);
        }

        public virtual void Retrait(double Montant)
        {
            if (Montant <= 0) 
                return;
                    ; // à remplacer éventuellement par une erreur
            Solde -= Montant;
        }

        public virtual void Retrait(double Montant, double LigneDeCredit)
        {
            if ((Solde - Montant) < -LigneDeCredit)
                throw new SoldeInsuffisantException();
            if (Montant <= 0)
                return;
            ; // à remplacer éventuellement par une erreur
            Solde -= Montant;
        }

        public void Depot(double Montant)
        {
            if (Montant <= 0)
                throw new ArgumentOutOfRangeException(nameof(Montant));

            Solde += Montant;
        }

        public void AppliquerInteret()
        {
            Solde += CalculInteret();
        }


     

    }
}
