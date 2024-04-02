using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public abstract class Compte : ICustomer, IBanker
    {
        public string Numero { get; private set; }
        public Personne Titulaire { get; private set; }
        public double Solde { get; private set; }

        public event PassageEnNegatifDelegate PassageEnNegatifEvent;
        
        public static double operator +(double amount, Compte compte)
        {
            return (amount < 0 ? 0 : amount) + (compte.Solde < 0 ? 0 : compte.Solde);
        }

        public Compte(string Numero, Personne Titulaire)
        {
            this.Numero = Numero;
            this.Titulaire = Titulaire;
        }

        public Compte(string Numero, Personne Titulaire, double solde) : this(Numero, Titulaire)
        {
            Solde = solde;
        }
        public void Depot(double montant)
        {
            if (montant <= 0)
            {
                throw new ArgumentOutOfRangeException("Montant inférieur à 0");
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
                throw new ArgumentOutOfRangeException("Retrait d'un montant négatif impossible");
            }
            if (Solde - montant < -ligneDeCredit)
            {
                throw new SoldeInsuffisantException("Sold insufisant");
            }
            Solde -= montant;
        }

        protected abstract double CalculInteret();

        public void AppliquerInteret()
        {
            Solde += CalculInteret();
        }

        //rend le delegate passable au enfant
        protected void RaisePassageEnNegatifEvent()
        {
            PassageEnNegatifDelegate? passageEnNegatifEvent = PassageEnNegatifEvent;
            passageEnNegatifEvent?.Invoke(this);
        }
    }
}
