namespace ExoTDD01.Bibliotheque
{
    public class RechercheVille
    {
        private List<String> _villes;

        public RechercheVille()
        {
            _villes = new List<string>
            {
                "Paris", "Budapest", "Skopje", "Rotterdam", "Valence", "Vancouver",
                "Amsterdam", "Vienne", "Sydney", "New York", "Londres", "Bangkok",
                "Hong Kong", "Dubaï", "Rome", "Istanbul"
            };
        }

        public List<String> Rechercher(String mot)
        {
            if (mot.Length < 2)
            {
                throw new NotFoundException("Le texte de la recherche doit contenir au moins 2 caractères.");
            }

            List<string> result = new List<string>();

            foreach (var ville in _villes)
            {
                if (ville.StartsWith(mot, StringComparison.OrdinalIgnoreCase))
                {
                    result.Add(ville);
                }
            }

            return result;
        }
    }
}
