using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public abstract class Compte: ICustomer, IBanker
    {
        public string Numero { get; private set; }
        public Personne Titulaire { get; private set; }
        public double Solde { get; private set; }

        public Compte(string Numero, Personne Titulaire)
        {
            this.Numero = Numero;
            this.Titulaire = Titulaire;
        }

        public Compte(string Numero, Personne Titulaire, double solde) : this(Numero, Titulaire)
        {
            Solde = solde;
        }
        public static double operator +(double amount, Compte compte)
        {
            return (amount < 0 ? 0 : amount) + (compte.Solde < 0 ? 0 : compte.Solde);
        }
        public void Depot(double montant)
        {
            if (montant <= 0)
            {
                Console.WriteLine("Dépot d'un montant négatif impossible"); // => Erreur : Exception
                return;
            }
            Solde += montant;
        }
        public virtual void Retrait(double montant)
        {
            Retrait(montant, 0D);
        }
        protected void Retrait(double montant, double ligneDeCredit)
        {
            if (montant <= 0)
            {
                Console.WriteLine("Retrait d'un montant négatif impossible"); // => Erreur : Exception
                return;
            }
            if (Solde - montant < -ligneDeCredit)
            {
                Console.WriteLine("Solde insuffisant"); // => Erreur : Exception
                return;
            }
            Solde -= montant;
        }

        protected abstract double CalculInteret();

        public void AppliquerInteret() 
        { 
            Solde += CalculInteret(); 
        }
    }
}
