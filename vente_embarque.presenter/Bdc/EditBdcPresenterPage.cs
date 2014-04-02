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
        private IRepository<Stock, Guid> _repositoryStock;
        private IRepository<Order, Guid> _repositoryOrder; 
 
        public EditBdcPresenterPage(IEditBdcView editBdcView, IRepository<Client,Guid> repository, IRepository<Stock,Guid> repository1  )
        {
            _EditBdcView = editBdcView;
            _repositoryClient = repository;
           // _repositoryStock = repository1;
        }
        
        public void Display()
        {
            _EditBdcView.Clients = _repositoryClient.FindAll();
            //_EditBdcView.Stocks = _repositoryStock.FindAll();
        }

        public void Write(Stock stock, string nomProduit, int quantité)
        {
            var orderline = FactoryOrder.CreateOrderLine(stock, nomProduit, quantité);
            //_repositoryOrder.Save(orderline);
        }
    }

    internal interface IEditBdcPagePresenter
    {
        void Display();
        void Write(Stock stock, string nomProduit, int quantité);
    }
}
