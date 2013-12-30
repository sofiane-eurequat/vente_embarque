using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vente_embarque.Model.Enum
{
    public enum StockBas
    {
        rien_a_signaler,
        un_produit_stock_bas,
        plusier_produit_stock_bas
    }

    public static class StockB
    {
        public static string ToString(this StockBas SB)
        {
            switch (SB)
            {
                    case StockBas.plusier_produit_stock_bas:
                    return "plusieurs produit ont un stocks bas";
                    case StockBas.rien_a_signaler:
                    return "rien a signaler";
                    case StockBas.un_produit_stock_bas:
                    return "un produit a un stock bas";
                    default: return "rien a signaler";
            }
        }
    }
}
