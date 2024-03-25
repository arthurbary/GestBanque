using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Courant
    {
        public string Numero { get; set; }
        public Personne Titulaire { get; set; }
        public double Sold { get; private set; }
        
        private double _ligneDeCredit;
        public double LigneDeCredit {  get
            {
                return _ligneDeCredit;
            }
            set 
            {
                if( _ligneDeCredit < 0 )
                {
                    Console.WriteLine("La ligne de credit doit etre un chiffre positif ou zéro");
                } else
                {
                    _ligneDeCredit = value;
                }
            }
        }

        public static double operator +(double amount, Courant compte)
        {
            return (amount < 0 ? 0 : amount) + (compte.Sold < 0 ? 0 : compte.Sold);
        }

        public void Retrait(double montant)
        {
            if(Sold - montant > -LigneDeCredit) {
                Console.WriteLine($"Le montant {montant} est superdieur avotre solde({Sold})");
                return;
            }
            
            if (montant < 1) {
                Console.WriteLine($"Le montant {montant} n'est pas valid");
                return;
            }
            Sold -= montant;
            Console.WriteLine($"Le montant {montant} a ete retiré sur votre compte ${Sold}");
        }

        public void Depot(double montant)
        {
            if (montant < 1)
            {
                Console.WriteLine($"Le montant {montant} n'est pas valid");
                return;
            }
            Sold += montant;
            Console.WriteLine($"Le montant {montant} a ete versé sur votre compte ${Sold}");
        }
    }
}
