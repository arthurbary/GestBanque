using Models;

namespace TestBase
{
    public class BanqueTest
    {
        [Fact]
        public void AjouterCompteCourantTest()
        {
            //Arrange
            Banque banque = new Banque("BankTest");
            Personne personne = new Personne("Doe", "Jane", new DateTime(1980, 3, 2));
            Courant compteCourant = new Courant("123", personne);
            //Act
            banque.Ajouter(compteCourant);
            //Assert
        }
    }
}