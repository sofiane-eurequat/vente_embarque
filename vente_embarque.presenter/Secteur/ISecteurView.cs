using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vente_embarque.presenter.Secteur
{
    public interface ISecteurView
    {
        IEnumerable<ModelViewSecteur> Secteurs { get; set; } 
    }
}
