using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Banque
    {
        public string Nom { get; set; }

        private Dictionary<string, Courant> _comptesCourant = new Dictionary<string, Courant>();

        public Courant this[string numero]
        {
            get
            {
                return _comptesCourant[numero];
            }
        }

        public void Ajouter(Courant compte)
        {
            _comptesCourant.Add(compte.Numero, compte);
        }

        public void Supprimer(string numero)
        {
            _comptesCourant.Remove(numero);
        }

        public double AvoirDesComptes(Personne titulaire)
        {
            double avoir = 0;
            foreach (var compte in _comptesCourant)
            {
                Personne titulaireCompte = compte.Value.Titulaire;
                if(titulaire == titulaireCompte)
                {
                        avoir += avoir + compte.Value.Sold;
                }
            }
            return avoir;
        }
    }
}

