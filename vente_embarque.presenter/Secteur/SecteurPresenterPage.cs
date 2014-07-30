using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vente_embarque.Core.Domain;
using vente_embarque.Model;

namespace vente_embarque.presenter.Secteur
{
    public class SecteurPresenterPage : ISecteurPagePresenter
    {
        private readonly ISecteurView _secteurView;
        private readonly IRepository<Sector, Guid> _repositorysecteur; 

        public SecteurPresenterPage(ISecteurView secteurView,IRepository<Sector,Guid> secteurkRepository)
        {
            _secteurView = secteurView;
            _repositorysecteur = secteurkRepository;
        }

        public void Diplay()
        {
            var secteur = _repositorysecteur.FindAll();
            if (secteur == null) return;

            var tempSecteur = secteur.Select(sector => new ModelViewSecteur
                {
                    Name = sector.Name, Wilaya = sector.Wilaya.Name, Commune = sector.Commune.Name, Id = sector.id, CodeWilaya = sector.Wilaya.Code,
                }).ToList();

            _secteurView.Secteurs = tempSecteur;
        }
    }

    public class ModelViewSecteur
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Client Client { get; set; }
        public AgentTerrain AgentTerrain { get; set; }
        public string Wilaya { get; set; }
        public string Commune { get; set; }
        public int CodeWilaya { get; set; }
    }

    public class ModelViewAgentTerrain
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }

    public interface ISecteurPagePresenter
    {
        void Diplay();
    }
}
