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
        public override void Retrait(double montant)
        {
            Retrait(montant, _ligneDeCredit);
        }
    }
}
