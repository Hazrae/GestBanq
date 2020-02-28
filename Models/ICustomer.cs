using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public interface ICustomer
    {
        double Solde {get;}

        void Retrait(double Montant);
        void Depot(double Montant);
        

    }
}
