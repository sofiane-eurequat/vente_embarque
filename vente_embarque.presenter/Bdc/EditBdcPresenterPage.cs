using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vente_embarque.Core.Domain;
using vente_embarque.Model;
using vente_embarque.Model.Enum;

namespace vente_embarque.presenter.Bdc
{
    public class EditBdcPresenterPage:IEditBdcPagePresenter
    {
        private readonly IEditBdcView _EditBdcView;
        private IRepository<Client, Guid> _repositoryClient; 
        private IRepository<Stock, Guid> _repositoryStock;
        private IRepository<Order, Guid> _repositoryOrder;
        private List<OrderLine> _orderLines = new List<OrderLine>();
 
        public EditBdcPresenterPage(IEditBdcView editBdcView, IRepository<Client,Guid> repository, IRepository<Stock,Guid> repository1, IRepository<Order, Guid> repositoryOrder, List<OrderLine> orderLines)
        {
            _EditBdcView = editBdcView;
            _repositoryClient = repository;
            _repositoryStock = repository1;
            _repositoryOrder = repositoryOrder;
            _orderLines = orderLines;
        }

        public void Display()
        {
            _EditBdcView.Clients = _repositoryClient.FindAll();
            _EditBdcView.Stocks = _repositoryStock.FindAll();

        }

        public void Write( Client client, IEnumerable<OrderLine> orderLine, Priorite priorite, DateTime dateLivraison, string adresseLivraison)
        {
            var order = FactoryOrder.CreateOrder(client,orderLine,adresseLivraison,priorite,dateLivraison);
            _repositoryOrder.Save(order);
        }
    }

    internal interface IEditBdcPagePresenter
    {
        void Display();
        void Write(Client client, IEnumerable<OrderLine> orderLine,Priorite priorite, DateTime dateLivraison, string adresseLivraison);
    }
}
