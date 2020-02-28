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

        public string Numero
        {
            get
            {
                return _numero;
            }
            set
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
            set
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
                return; // à remplacer éventuellement par une erreur
            if (Montant <= 0)
                return;
            ; // à remplacer éventuellement par une erreur
            Solde -= Montant;
        }

        public void Depot(double Montant)
        {
            if (Montant <= 0)
                return; // à remplacer éventuellement par une erreur

            Solde += Montant;
        }

        public void AppliquerInteret()
        {
            Solde += CalculInteret();
        }


     

    }
}
