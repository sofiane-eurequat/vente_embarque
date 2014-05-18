using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vente_embarque.Core.Domain;
using vente_embarque.Model;

namespace vente_embarque.presenter.Secteur
{
    public class EditSecteurPresenterPage : IEditSecteurPagePresenter
    {
        private readonly IEditSecteurView _EditSecteurView;
        private IRepository<Wilaya, Guid> _repositoryWilaya;
        private IRepository<AgentTerrain, Guid> _repositoryAgentTerrain;
        private IRepository<Sector, Guid> _repositorySecteur;
        private IRepository<Client, Guid> _repositoryClient; 

        public EditSecteurPresenterPage(IEditSecteurView editSecteurView,IRepository<Wilaya,Guid> repository, IRepository<AgentTerrain,Guid> repository1, IRepository<Sector,Guid> repository2, IRepository<Client,Guid> repository3 )
        {
            _EditSecteurView = editSecteurView;
            _repositoryWilaya = repository;
            _repositoryAgentTerrain = repository1;
            _repositorySecteur = repository2;
            _repositoryClient = repository3;
        }

        public void Display()
        {
            _EditSecteurView.Wilayas = _repositoryWilaya.FindAll();
            _EditSecteurView.AgentTerrains = _repositoryAgentTerrain.FindAll();
            _EditSecteurView.Clients = _repositoryClient.FindAll();
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
