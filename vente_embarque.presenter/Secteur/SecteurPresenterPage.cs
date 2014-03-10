using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vente_embarque.Core.Domain;
using vente_embarque.Model;

namespace vente_embarque.presenter.Secteur
{
    public class SecteurPresenterPage : IStecteurPagePresenter
    {
        private readonly ISecteurView _secteurView;
        private readonly IRepository<Stock, Guid> _repositorysecteur; 

        public SecteurPresenterPage(ISecteurView secteurView,IRepository<Stock,Guid> secteurkRepository)
        {
            _secteurView = secteurView;
            _repositorysecteur = secteurkRepository;
        }

        public void Diplay()
        {
            var secteur = _repositorysecteur.FindAll();

        }
    }

    public class ModelViewSecteur
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Client Client { get; set; }
        public AgentTerrain AgentTerrain { get; set; }
    }

    public interface IStecteurPagePresenter
    {
        void Diplay();
    }
}
