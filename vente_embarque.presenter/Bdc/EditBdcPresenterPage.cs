using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vente_embarque.Core.Domain;
using vente_embarque.Model;

namespace vente_embarque.presenter.Bdc
{
    public class EditBdcPresenterPage:IEditBdcPagePresenter
    {
        private readonly IEditBdcView _EditBdcView;
        private IRepository<Client, Guid> _repositoryClient;
 
        public EditBdcPresenterPage(IEditBdcView editBdcView, IRepository<Client,Guid> repository )
        {
            _EditBdcView = editBdcView;
            _repositoryClient = repository;
        }
        
        public void Display()
        {
            _EditBdcView.Clients = _repositoryClient.FindAll();
        }

        public void Write()
        {
            throw new NotImplementedException();
        }
    }

    internal interface IEditBdcPagePresenter
    {
        void Display();
        void Write();
    }
}
