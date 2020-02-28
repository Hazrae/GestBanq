using System;
using System.Collections.Generic;
using System.Text;

namespace Models 
{
    public class Courant : Compte
    {
        
        private double _ligneDeCredit; // supérieur ou = 0

        public Courant(string num, Personne titu) : base(num, titu)
        {
        
        }

        public Courant(string num, Personne titu, double solde) : base(num, titu, solde)
        {
       
        }

        public Courant(string num, double ldc, Personne titu) : base(num, titu)
        {
            LigneDeCredit = ldc;
        }

        public Courant(string num, double ldc,Personne titu, double solde) : base(num, titu, solde)
        {
            LigneDeCredit = ldc;
        }

        public double LigneDeCredit
        {
            get
            {
                return _ligneDeCredit;
            }
            private set
            {
                if (_ligneDeCredit < 0)
                    return; //à remplacer éventuellement par une erreur

               _ligneDeCredit = value;
            }
        }

       
        public override void Retrait(double Montant)
        {
                base.Retrait(Montant,LigneDeCredit);
        }

        protected override double CalculInteret()
        {
            /*if (Solde > 0)
                return Solde * 0.03;
            else
                return Solde * 0.0975;*/

            return Solde * Solde > 0 ? 0.03 : 0.0975;
        }
    }



}



