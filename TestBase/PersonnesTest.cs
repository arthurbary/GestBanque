using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBase
{
    public class PersonnesTest
    {
        
        [Theory]
        [InlineData("Doe", "Jane", "03-04-1980 11:20:48")]
        [InlineData("Doe", "Jane", null)]
        [InlineData("Doe", null, "03-04-1980 11:20:48")]
        [InlineData(null, "Jane", "03-04-1980 11:20:48")]
        [InlineData("Doe", "Jane", "03-04-2080 11:20:48")]
        [InlineData("£ù%§^", "Jane", "03-04-1980 11:20:48")]
        [InlineData("Doe", "µl1sse;", "03-04-1980 11:20:48")]

        public void AjouterCompteCourantTest(string nom, string prenom, string naiss)
        {
            Personne personne = new Personne(nom, prenom, DateTime.Parse(naiss));
        }

    }
}
