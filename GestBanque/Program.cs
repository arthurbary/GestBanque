// See https://aka.ms/new-console-template for more information


using Models;

Console.WriteLine(DateTime.Parse("03-04-2024 11:20:48"));

Banque bbl = new Banque("bbl");

Personne doeJhon = new Personne("Doe", "Jhon", new DateTime(1980, 3, 2));

Personne doeJane = new Personne("Doe", "Jane", new DateTime(1980, 3, 2));

Courant compte = new Courant("US1234-5678-1234", doeJane);
compte.Depot(1000000);

Courant compte1 = new Courant("US1234-5678-2345", doeJhon);
compte1.Depot(1000);

Courant compte2 = new Courant("US1234-5678-3456", doeJane);
compte2.Depot(99.99);

Courant compte3 = new Courant("US1234-5678-4567", doeJane);
compte3.Depot(9.99);
compte3.Retrait(1);


bbl.Ajouter(compte);
bbl.Ajouter(compte1);
bbl.Ajouter(compte2);
bbl.Ajouter(compte3);

Epargne cE = new Epargne("US1234-5678-4567", doeJhon);

cE.Depot(1000);
cE.Retrait(10);


Console.WriteLine(bbl.AvoirDesComptes(doeJane));
Console.WriteLine(cE.DateDernierRetrai);
