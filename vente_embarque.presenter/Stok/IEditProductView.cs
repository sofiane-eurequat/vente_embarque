using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vente_embarque.Model;

namespace vente_embarque.presenter.Stok
{
    public interface IEditProductView
    {
        IEnumerable<Category> Categories { get; set; }
        IEnumerable<Marque> Marques { get; set; }
        IEnumerable<Fournisseur> Fournisseurs { get; set; }
        IEnumerable<Stock> Stocks { get; set; } 
        IEnumerable<Product> Products { get; set; } 
    }
}
