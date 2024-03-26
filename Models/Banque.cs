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

        private Dictionary<string, Compte> _comptesCourant = new Dictionary<string, Compte>();

        public Compte this[string numero]
        {
            get
            {
                return _comptesCourant[numero];
            }
        }

        public void Ajouter(Compte compte)
        {
            _comptesCourant.Add(compte.Numero, compte);
        }

        public void Supprimer(string numero)
        {
            _comptesCourant.Remove(numero);
        }

        public double AvoirDesComptes(Personne titulaire)
        {
            double avoir = 0D;
            //va directement chercher la value d'une paire key/value
            foreach (Compte compte in _comptesCourant.Values)
            {
                if(titulaire == compte.Titulaire)
                {
                        avoir = avoir + compte;
                }
            }
            return avoir;
        }
    }
}

