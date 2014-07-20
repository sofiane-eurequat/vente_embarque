using System.Collections.Generic;

namespace vente_embarque.presenter.Stok
{
    public interface IProductView
    {
        IEnumerable<ModelViewProduct> Produits { get; set; } 
    }
}
