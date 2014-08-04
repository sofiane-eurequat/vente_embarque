using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vente_embarque.Core.Domain;
using vente_embarque.Model;

namespace vente_embarque.presenter.Secteur
{
    public class EditAgentTerrainPresenterPage 
    {
        private readonly IEditAgentTerrainView _editAgentTerrainView;
        private readonly IRepository<AgentTerrain, Guid> _repositoryAgentTerrain;
        private readonly IRepository<Sector, Guid> _repositorySecteur;

        public EditAgentTerrainPresenterPage(IEditAgentTerrainView editAgentTerrainView, IRepository<AgentTerrain,Guid> repository1, IRepository<Sector,Guid> repository2 )
        {
            _editAgentTerrainView = editAgentTerrainView;
            _repositoryAgentTerrain = repository1;
            _repositorySecteur = repository2;
        }

        public void Display()
        {
            _editAgentTerrainView.Secteurs = _repositorySecteur.FindAll();
        }

        public void Write(string name, Sector sector)
        {
            var agentTerrain =FactoryAgentTerrain.CreateAgentTerrain(name, sector);
            _repositoryAgentTerrain.Save(agentTerrain);
        }
    }

    internal interface IEditAgentTerrainPagePresenter
    {
        void Display();
        void Write(string name, Wilaya wilaya, Commune communes);
    }
}
