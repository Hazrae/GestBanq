using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Courant : Compte
    {
        
        private double _ligneDeCredit; // supérieur ou = 0
        
              
        public double LigneDeCredit
        {
            get
            {
                return _ligneDeCredit;
            }
            set
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



