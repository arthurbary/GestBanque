using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Courant
    {
        public string Numero { get; set; }
        public double Sold { get; private set; }
        public double LigneDeCredit {  get; set; }
        public Personne Titulaire { get; set; }

        public void Retrait(double Montant)
        {
            Console.WriteLine();
        }

        public void Depot(double Montant)
        {
            Console.WriteLine();
        }

    }
}
