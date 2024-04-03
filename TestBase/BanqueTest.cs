using Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TestBase
{
    public class BanqueTest
    {
        [Theory]
        [InlineData("Nom")]
        [InlineData(null)]
        public void Test_CreeBanque(string name) 
        {
            Banque banque = new Banque(name);
        }

        [Fact]
        public void Test_AjouterCompteCourant()
        {
            //Arrange
            Banque banque = new Banque("BankTest");
            Personne personne = new Personne("Doe", "Jane", new DateTime(1980, 3, 2));
            Courant compteCourant = new Courant("213546dsf", personne);
            //Act
            banque.Ajouter(compteCourant);
            //Assert
            Assert.True(banque.testCountComptes() == 1);
        }

        [Fact]
        public void Test_AjouterCompteCourant_NumeroNull()
        {
            //Arrange
            Banque banque = new Banque("BankTest");
            Personne personne = new Personne("Doe", "Jane", new DateTime(1980, 3, 2));
            Courant compteCourant = new Courant(null, personne);
            //Act
            banque.Ajouter(compteCourant);
            //Assert
            Assert.True(banque.testCountComptes() == 1);
        }

        [Fact]
        public void Test_AjouterCompteCourant_PersonneNull()
        {
            //Arrange
            Banque banque = new Banque("BankTest");
            Personne personne = null;
            string Numero = "BE12234-1234"; 
            Courant compteCourant = new Courant(Numero, personne);
            //Act
            banque.Ajouter(compteCourant);
            //Assert
            Assert.True(banque.testCountComptes() == 1);
        }

        [Fact]
        public void Test_AvoirDesComptes_positif()
        {
            //ARRANGE
            Banque banque = new Banque("BankTest");
            Personne doeJane = new Personne("Doe", "Jane", new DateTime(1980, 3, 2));

            Courant compte = new Courant("US1234-5678-1234", doeJane);
            compte.Depot(10000);

            Courant compte1 = new Courant("US1234-5678-2345", doeJane);
            compte1.Depot(1000);

            Courant compte2 = new Courant("US1234-5678-3456", doeJane);
            compte2.Depot(99.99);

            Courant compte3 = new Courant("US1234-5678-4567", doeJane);
            compte3.Depot(9.99);

            banque.Ajouter(compte);
            banque.Ajouter(compte1);
            banque.Ajouter(compte2);
            banque.Ajouter(compte3);
            //Act
            double result = banque.AvoirDesComptes(doeJane);
            //Assert
            Assert.True( result == 11109.98);
        }

        [Fact]
        public void Test_AvoirDesComptes_Negatif()
        {
            //ARRANGE
            Banque banque = new Banque("BankTest");
            Personne doeJane = new Personne("Doe", "Jane", new DateTime(1980, 3, 2));

            Courant compte = new Courant("US1234-5678-1234", doeJane);
            compte.DepotTest(-10000);

            Courant compte1 = new Courant("US1234-5678-2345", doeJane);
            compte1.DepotTest(-1000);

            Courant compte2 = new Courant("US1234-5678-3456", doeJane);
            compte2.DepotTest(-99.99);

            banque.Ajouter(compte);
            banque.Ajouter(compte1);
            banque.Ajouter(compte2);
            //Act
            double result = banque.AvoirDesComptes(doeJane);
            //Assert
            Assert.True(result == 0);
        }




        [Fact]
        public void Test_AvoirDesComptes_Zero()
        {
            //ARRANGE
            Banque banque = new Banque("BankTest");
            Personne doeJane = new Personne("Doe", "Jane", new DateTime(1980, 3, 2));

            Courant compte = new Courant("US1234-5678-1234", doeJane);
            Courant compte1 = new Courant("US1234-5678-2345", doeJane);
            Courant compte2 = new Courant("US1234-5678-3456", doeJane);
            Courant compte3 = new Courant("US1234-5678-4567", doeJane);

            banque.Ajouter(compte);
            banque.Ajouter(compte1);
            banque.Ajouter(compte2);
            banque.Ajouter(compte3);
            //Act
            double result = banque.AvoirDesComptes(doeJane);
            //Assert
            Assert.True(result == 0);
        }

        //test personne n'existe pas
        public void Test_AvoirDesComptes_TitulaireNull()
        {
            //ARRANGE
            Banque banque = new Banque("BankTest");
            Personne doeJane = new Personne("Doe", "Jane", new DateTime(1980, 3, 2));
            Personne doeJhon = new Personne("Doe", "Jhon", new DateTime(1988, 4, 3));

            Courant compte = new Courant("US1234-5678-1234", doeJane);
            Courant compte1 = new Courant("US1234-5678-2345", doeJane);
            Courant compte2 = new Courant("US1234-5678-3456", doeJane);
            Courant compte3 = new Courant("US1234-5678-4567", doeJane);

            banque.Ajouter(compte);
            banque.Ajouter(compte1);
            banque.Ajouter(compte2);
            banque.Ajouter(compte3);
            //Act
            double result = banque.AvoirDesComptes(null);
            //Assert
            Assert.True(result == 0);
        }
        // test personne pas de compte
        [Fact]
        public void Test_AvoirDesComptes_TitulaireNoCompte()
        {
            //ARRANGE
            Banque banque = new Banque("BankTest");
            Personne doeJane = new Personne("Doe", "Jane", new DateTime(1980, 3, 2));
            Personne doeJhon = new Personne("Doe", "Jhon", new DateTime(1988, 4, 3));

            Courant compte = new Courant("US1234-5678-1234", doeJane);
            Courant compte1 = new Courant("US1234-5678-2345", doeJane);
            Courant compte2 = new Courant("US1234-5678-3456", doeJane);
            Courant compte3 = new Courant("US1234-5678-4567", doeJane);

            banque.Ajouter(compte);
            banque.Ajouter(compte1);
            banque.Ajouter(compte2);
            banque.Ajouter(compte3);
            //Act
            double result = banque.AvoirDesComptes(doeJhon);
            //Assert
            Assert.True(result == 0);
        }
    }
}