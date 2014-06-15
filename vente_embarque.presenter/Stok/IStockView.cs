using System.Collections.Generic;

namespace vente_embarque.presenter.Stok
{
    public interface IStockView
    {
        IEnumerable<ModelViewStock> Stocks { get; set; } 
    }
}
