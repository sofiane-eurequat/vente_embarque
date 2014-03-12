using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vente_embarque.Model;

namespace vente_embarque.presenter.Secteur
{
    public interface IEditSecteurView
    {
        IEnumerable<Wilaya> Wilayas { get; set; }
        IEnumerable<AgentTerrain> AgentTerrains { get; set; } 
    }
}
