// See https://aka.ms/new-console-template for more information
using Models;

Banque bbl = new Banque();

Personne doeJhon = new Personne()
{
    Nom = "Doe",
    Prenom = "Jhon",
    DateNaiss = new DateTime(1980, 3, 2)
};

Personne doeJane = new Personne()
{
    Nom = "Doe",
    Prenom = "Jane",
    DateNaiss = new DateTime(1980, 3, 2)
};

Courant compte = new Courant()
{
    Titulaire = doeJane,
    Numero = "US1234-5678-1234"
};

compte.Depot(1000000);

bbl.Ajouter(compte);
 