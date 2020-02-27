using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Epargne : Compte
    {
        private DateTime _datedernierretrait;

        public DateTime Datedernierretrait
        {
            get
            {
                return _datedernierretrait;
            }
            set
            {
                if (value > DateTime.Now)
                    return; // erreur, date plus lointaine que la date courante...
                _datedernierretrait = value;
        
            }
        }

        public override void Retrait(double Montant)
        {
                if (Montant <= 0)
                    return; // à remplacer éventuellement par une erreur

                base.Retrait(Montant);
                Datedernierretrait = DateTime.Now;
          
        }
    }
}
