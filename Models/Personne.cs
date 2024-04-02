using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Personne
    {
        public string Nom { get; init; }
        public string Prenom { get; init; }
        public DateTime DateNaiss { get; init; }

        public Personne(string nom, string prenom, DateTime dateNaiss)
        {
            Nom = nom;
            Prenom = prenom;
            DateNaiss = dateNaiss;
        }
    }

}
