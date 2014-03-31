using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vente_embarque.Model;

namespace vente_embarque.presenter.Bdc
{
    public interface IEditBdcView
    {
        IEnumerable<Client> Clients { get; set; } 
    }
}
