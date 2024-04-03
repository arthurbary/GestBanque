using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Sdk;

namespace TestBase
{
    public class CourantTest
    {
        [Fact]
        public void Test_LigneCrédit()
        {
            Banque banque = new Banque("BankTest");
            Personne personne = new Personne("Doe", "Jane", new DateTime(1980, 3, 2));
            Courant compteCourant = new Courant("213546dsf", 200, personne);
        }

        [Fact]
        public void Test_LigneCrédit_Negatif_Creation()
        {
            Banque banque = new Banque("BankTest");
            Personne personne = new Personne("Doe", "Jane", new DateTime(1980, 3, 2));
            string errorMessage = "La ligne de credit doit etre un chiffre positif ou zéro";

            InvalidOperationException exception = Assert.Throws<InvalidOperationException>(() => new Courant("213546dsf", -200, personne));

            Assert.Equal(errorMessage, exception.Message);
        }


        [Fact]
        public void Test_LigneCrédit_Negatif()
        {
            Banque banque = new Banque("BankTest");
            Personne personne = new Personne("Doe", "Jane", new DateTime(1980, 3, 2));
            Courant compteCourant = new Courant("213546dsf", -200, personne);
            string errorMessage = "La ligne de credit doit etre un chiffre positif ou zéro";

            InvalidOperationException exception = Assert.Throws<InvalidOperationException>(() => compteCourant.LigneDeCredit = -200);

            Assert.Equal(errorMessage, exception.Message);
        }
    }
}
