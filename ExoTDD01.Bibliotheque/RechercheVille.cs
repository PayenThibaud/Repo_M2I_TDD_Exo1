namespace ExoTDD01.Bibliotheque
{
    public class RechercheVille
    {
        private List<String> _villes;

        public List<String> Rechercher(String mot)
        {
            if (mot.Length < 2)
            {
                throw new NotFoundException("Le texte de la recherche doit contenir au moins 2 caractères.");
            }

            return _villes;
        }
    }
}
