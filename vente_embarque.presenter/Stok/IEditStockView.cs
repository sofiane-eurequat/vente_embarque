using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vente_embarque.Model;

namespace vente_embarque.presenter.Stok
{
    public interface IEditStockView
    {
        IEnumerable<Wilaya> Wilayas { get; set; } 

    }
}
