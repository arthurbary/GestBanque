using Models;

namespace TestBase
{
    public class BanqueTest
    {
        [Theory]
        [InlineData("Nom")]
        [InlineData("^§!$1234")]
        [InlineData("BBL Inc.")]
        [InlineData(null)]
        public void Test_CreeBanque(string name) 
        {
            Banque banque = new Banque(name);
        }

        [Theory]
        [InlineData("1234")]
        [InlineData("anbdjjjoo")]
        [InlineData("^§!$")]
        public void Test_AjouterCompteCourant_Numero(string Numero)
        {
            //Arrange
            Banque banque = new Banque("BankTest");
            Personne personne = new Personne("Doe", "Jane", new DateTime(1980, 3, 2));
            Courant compteCourant = new Courant(Numero, personne);
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
    }
}