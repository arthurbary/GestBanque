using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Courant : Compte
    {        
        private double _ligneDeCredit;

        public Courant(string Numero, Personne Titulaire) : base(Numero, Titulaire)
        {
        }

        public Courant(string Numero, Personne Titulaire, double solde) : base(Numero, Titulaire)
        {
        }
        public Courant(string Numero, double ligneDeCredit, Personne Titulaire) : base(Numero, Titulaire)
        {
            _ligneDeCredit = ligneDeCredit;
        }

        public double LigneDeCredit {  get
            {
                return _ligneDeCredit;
            }
            set 
            {
                if( _ligneDeCredit < 0 )
                {
                    throw new InvalidOperationException("La ligne de credit doit etre un chiffre positif ou zéro");
                } else
                {
                    _ligneDeCredit = value;
                }
            }
        }
        public override void Retrait(double montant)
        {
            double ancienSolde = Solde;
            Retrait(montant, LigneDeCredit);
            if (ancienSolde >= 0 && Solde < 0)
            {
                RaisePassageEnNegatifEvent();
            }
        }
        protected override double CalculInteret()
        {
            return Solde * (Solde < 0 ? 0.0975 : 0.03);
        }
    }
}
