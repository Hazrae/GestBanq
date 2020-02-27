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
            if ((Solde - Montant) < -LigneDeCredit)
            {
                return; // à remplacer éventuellement par une erreur
            }
            else
            {
                if (Montant <= 0)
                    return; // à remplacer éventuellement par une erreur

                base.Retrait(Montant);
            }
        }
    }



}



