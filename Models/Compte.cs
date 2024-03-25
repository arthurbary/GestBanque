﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Compte
    {
        public string Numero { get; set; }
        public Personne Titulaire { get; set; }
        public double Sold { get; private set; }
        public static double operator +(double amount, Compte compte)
        {
            return (amount < 0 ? 0 : amount) + (compte.Sold < 0 ? 0 : compte.Sold);
        }

        public virtual void Retrait(double montant)
        {
            
            if (montant < 0)
            {
                Console.WriteLine($"Le montant {montant} n'est pas valid");
                return;
            }
            Sold -= montant;
            Console.WriteLine($"Le montant {montant} a ete retiré");
        }

        public void Depot(double montant)
        {
            if (montant < 0)
            {
                Console.WriteLine($"Le montant {montant} n'est pas valid");
                return;
            }
            Sold += montant;
            Console.WriteLine($"Le montant {montant} a ete versé sur votre compte ${Sold}");
        }
    }
}