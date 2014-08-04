using System.Collections.Generic;
using vente_embarque.Model;

namespace vente_embarque.presenter.Secteur
{
    public interface IEditSecteurView
    {
        IEnumerable<Wilaya> Wilayas { get; set; }
        IEnumerable<AgentTerrain> AgentTerrains { get; set; }
        IEnumerable<Client> Clients { get; set; } 
        IEnumerable<Sector> Secteurs { get; set; }
    }
}
