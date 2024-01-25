using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
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
            Assert.Contains("Valence", result);
            Assert.Contains("Vancouver", result);
            Assert.DoesNotContain("Paris", result);
            Assert.DoesNotContain("Budapest", result);
            Assert.DoesNotContain("Skopje", result);
            Assert.DoesNotContain("Rotterdam", result);
            Assert.DoesNotContain("Amsterdam", result);
            Assert.DoesNotContain("Vienne", result);
            Assert.DoesNotContain("Sydney", result);
            Assert.DoesNotContain("New York", result);
            Assert.DoesNotContain("Londres", result);
            Assert.DoesNotContain("Bangkok", result);
            Assert.DoesNotContain("Hong Kong", result);
            Assert.DoesNotContain("Dubaï", result);
            Assert.DoesNotContain("Rome", result);
            Assert.DoesNotContain("Istanbul", result);
        }
    }
}