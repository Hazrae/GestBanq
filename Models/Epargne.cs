using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Epargne : Compte
    {
        private DateTime _datedernierretrait;

        public Epargne(string num,Personne titu) : base (num,titu)
        {

        }
        public Epargne(string num, Personne titu, double solde) : base(num, titu,solde)
        {

        }

        public Epargne(DateTime date, string num, Personne titu, double solde) : base(num, titu, solde)
        {
            Datedernierretrait = date;
        }

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

        protected override double CalculInteret()
        {
            return Solde * 0.045;
        }
    }
}
