using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Epargne : Compte
    {
        DateTime DateDernierRetrai { get; set; }
        public override void Retrait(double montant)
        {
            base.Retrait(montant);
            DateDernierRetrai = DateTime.Now;
        }
    }
}
