using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vente_embarque.Model;

namespace vente_embarque.presenter.Bdc
{
    public interface IBdcView
    {
        IEnumerable<ModelViewBdc> Orders { get; set; }
        IEnumerable<Stock> Stocks { get; set; } 
    }
}
