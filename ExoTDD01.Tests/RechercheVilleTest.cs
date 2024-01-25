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
    }
}