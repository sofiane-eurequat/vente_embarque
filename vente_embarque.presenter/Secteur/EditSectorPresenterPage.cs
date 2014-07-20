using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vente_embarque.Core.Domain;
using vente_embarque.Model;

namespace vente_embarque.presenter.Secteur
{
    public class EditSectorPresenterPage : IEditSecteurPagePresenter
    {
        private readonly IEditSecteurView _editSecteurView;
        private readonly IRepository<Wilaya, Guid> _repositoryWilaya;
        private readonly IRepository<AgentTerrain, Guid> _repositoryAgentTerrain;
        private readonly IRepository<Sector, Guid> _repositorySecteur;
        private readonly IRepository<Client, Guid> _repositoryClient; 

        public EditSectorPresenterPage(IEditSecteurView editSecteurView,IRepository<Wilaya,Guid> repository, IRepository<AgentTerrain,Guid> repository1, IRepository<Sector,Guid> repository2, IRepository<Client,Guid> repository3 )
        {
            _editSecteurView = editSecteurView;
            _repositoryWilaya = repository;
            _repositoryAgentTerrain = repository1;
            _repositorySecteur = repository2;
            _repositoryClient = repository3;
        }

        public void Display()
        {
            _editSecteurView.Wilayas = _repositoryWilaya.FindAll();
            _editSecteurView.AgentTerrains = _repositoryAgentTerrain.FindAll();
            _editSecteurView.Clients = _repositoryClient.FindAll();
        }

        public void Write(string name, Wilaya wilaya, Commune communes)
        {
            var secteur =FactorySector.CreateSector(name, wilaya, communes);
            _repositorySecteur.Save(secteur);
        }
    }

    internal interface IEditSecteurPagePresenter
    {
        void Display();
        void Write(string name, Wilaya wilaya, Commune communes);
    }
}
