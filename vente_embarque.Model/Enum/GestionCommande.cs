namespace vente_embarque.Model.Enum
{
    public enum GestionCommande
    {
        EnCours,
        Annulé,
        Livré
    }

    public static class GestionC
    {
        public static string ToString(this GestionCommande gc)
        {
            switch (gc)
            {
                case GestionCommande.EnCours:
                    return "En cours";
                case GestionCommande.Annulé:
                    return "Annulée";
                case GestionCommande.Livré:
                    return "Livrée";
                default:
                    return "En cours";
            }
        }
    }
}
