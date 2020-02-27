using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Banque
    {
        public string Nom { get; set; }
        
        private Dictionary<string, Compte> _comptes;
      
        public Dictionary<string, Compte> Comptes
        {
            //retourne le dico avec les compte ou le crée
            get
            {
                return _comptes ??= new Dictionary<string, Compte>();
            }
        }

        public Compte this[string numero]
        {
            //retourne un objet Courant en fonction de son numero
            get
            {
                return Comptes[numero];
            }
        }

        public void ajouter(Compte Compte)
        {
            Comptes.Add(Compte.Numero, Compte);
           //ou  Comptes[Compte.Numero] = Compte;
        }

        public void supprimer(string Numero)
        {
            if (Comptes[Numero] is null)
                return; // erreur à gérer plus tard
            Comptes.Remove(Numero);
        }

        //Ajouter une méthode « AvoirDesComptes » à la classe « Banque » recevant en paramètre le titulaire(Personne) qui calculera les avoirs de tous
        //ses comptes en utilisant l’opérateur « ».

        public double AvoirDesComptes(Personne p)
        {
            double total = 0;
            foreach (Compte c in Comptes.Values)
            { 
                if (c.Titulaire == p)
                    total += c;
            }
            
            return total;
        }
    }
}
