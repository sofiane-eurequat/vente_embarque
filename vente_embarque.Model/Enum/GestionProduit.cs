namespace vente_embarque.Model.Enum
{
    public enum GestionProduit
    {
        Aucune,
        ParLot,
        Individuelle
    }
    public static class GestionP
    {
        public static string ToString(this GestionProduit GP)
        {
            switch (GP)
            {
                case GestionProduit.Aucune:
                    return "Aucune";
                case GestionProduit.Individuelle:
                    return "individuelle";
                case GestionProduit.ParLot:
                    return "Par Lot";
                default:
                    return "Aucune";
            }
        }
    }
}