using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Extensions;
using ExoTDD01.Bibliotheque;

namespace ExoTDD01.Tests.Bibliotheque
{
    public class RechercheVilleTests
    {
        [Fact]
        public void Rechercher_WithLessThan2Characters_ThrowsNotFoundException()
        {
            // Arrange
            RechercheVille rechercheVille = new RechercheVille();
            string searchInput = "a"; // Moins de 2 caractères

            // Act & Assert
            Assert.Throws<NotFoundException>(() => rechercheVille.Rechercher(searchInput));
        }

        [Fact]
        public void Rechercher_WithValidSearchText_ReturnsMatchingCities()
        {
            // Arrange
            RechercheVille rechercheVille = new RechercheVille();
            string searchInput = "Va"; // Recherche

            // Act
            List<string> result = rechercheVille.Rechercher(searchInput);

            // Assert
            List<string> villeCorrecte = new List<string> { "Valence", "Vancouver" };
            List<string> villeIncorrecte = new List<string> { "Paris", "Budapest", "Skopje", "Rotterdam", "Amsterdam", "Vienne",
                "Sydney", "New York", "Londres", "Bangkok", "Hong Kong", "Dubaï", "Rome", "Istanbul" };

            Assert.All(villeCorrecte, ville => Assert.Contains(ville, result));
            Assert.All(villeIncorrecte, ville => Assert.DoesNotContain(ville, result));
        }
    }
}