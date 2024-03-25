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

Courant compte1 = new Courant()
{
    Titulaire = doeJhon,
    Numero = "US1234-5678-2345"
};
compte1.Depot(1000);

Courant compte2 = new Courant()
{
    Titulaire = doeJane,
    Numero = "US1234-5678-3456"
};
compte2.Depot(99.99);

Courant compte3 = new Courant()
{
    Titulaire = doeJane,
    Numero = "US1234-5678-4567"
};
compte3.Depot(9.99);
compte3.Retrait(19.00);

bbl.Ajouter(compte);
bbl.Ajouter(compte1);
bbl.Ajouter(compte2);
bbl.Ajouter(compte3);

Epargne cE = new Epargne()
{ 
    Titulaire = doeJane,
    Numero = "US1234-5678-5678"
};

cE.Depot(1000);
cE.Retrait(10);


Console.WriteLine(bbl.AvoirDesComptes(doeJane));
Console.WriteLine(cE.DateDernierRetrai);
