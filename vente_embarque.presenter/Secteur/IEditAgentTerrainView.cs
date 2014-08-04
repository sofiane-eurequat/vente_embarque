using System.Collections.Generic;
using vente_embarque.Model;

namespace vente_embarque.presenter.Secteur
{
    public interface IEditAgentTerrainView
    {
        IEnumerable<Sector> Secteurs { get; set; }
    }
}
