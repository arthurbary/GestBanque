using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Banque
    {
        public string Nom { get; init; }

        private Dictionary<string, Compte> _comptesCourant = new Dictionary<string, Compte>();

        public Banque(string nom) 
        {
            Nom = nom;
        }
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
            compte.PassageEnNegatifEvent += PassageEnNegatifAction;
        }

        public void Supprimer(string numero)
        {
            if (!_comptesCourant.ContainsKey(numero))
                return;
            _comptesCourant.Remove(numero);
            Compte compte = this[numero];
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
        private void PassageEnNegatifAction(Compte compte)
        {
            Console.WriteLine($"Le compte numéro '{compte.Numero}' vient de passer en négatif.");
        }

        public int testCountComptes()
        {
            return _comptesCourant.Count;
        }


    }
}

