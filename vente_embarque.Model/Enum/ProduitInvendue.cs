using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vente_embarque.Model.Enum
{
    public enum ProduitInvendue
    {
        ras,
        un_produit_invendue,
        plusieur_invendue
    }

    public static class EnumPi
    {
        public static string Tostring(this ProduitInvendue pi)
        {
            switch (pi)
            {
                case ProduitInvendue.ras:
                    return "rien a signaler";
                case ProduitInvendue.plusieur_invendue:
                    return "plusieurs produit sont invendues";
                case ProduitInvendue.un_produit_invendue:
                    return "un produit est resté invendue";
                    
                default:  return "rien a signaler";
            }
        }
    }
}
