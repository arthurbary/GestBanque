using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Epargne : Compte
    {
        public DateTime DateDernierRetrai { get; set; }
        public override void Retrait(double montant)
        {
            double ancientSold = Solde;
            base.Retrait(montant);
            if(Solde != ancientSold)
            {
                DateDernierRetrai = DateTime.Now;
            }
        }

        protected override double CalculInteret()
        {
            return Solde * 0.045;
        }
    }
}
