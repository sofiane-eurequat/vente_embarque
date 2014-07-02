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
        private readonly IEditBdcView _editBdcView;
        private readonly IRepository<Client, Guid> _repositoryClient; 
        private readonly IRepository<Stock, Guid> _repositoryStock;
        private readonly IRepository<Order, Guid> _repositoryOrder;
        private List<OrderLine> _orderLines = new List<OrderLine>();
 
        public EditBdcPresenterPage(IEditBdcView editBdcView, IRepository<Client,Guid> repository, IRepository<Stock,Guid> repository1, IRepository<Order, Guid> repositoryOrder, List<OrderLine> orderLines)
        {
            _editBdcView = editBdcView;
            _repositoryClient = repository;
            _repositoryStock = repository1;
            _repositoryOrder = repositoryOrder;
            _orderLines = orderLines;
        }

        public void Display()
        {
            _editBdcView.Clients = _repositoryClient.FindAll();
            _editBdcView.Stocks = _repositoryStock.FindAll();

        }

        public void Write(int numCommande, Client client, DateTime dateLivraison, string adresseLivraison, Priorite priorite, GestionCommande etat, bool livraisonSurPlace, DateTime dateCommande, IEnumerable<OrderLine> orderLine)
        {
            var order = FactoryOrder.CreateOrder(numCommande,client,orderLine,adresseLivraison,livraisonSurPlace,priorite,etat,dateLivraison,dateCommande);
            _repositoryOrder.Save(order);
        }

        public void Save(Guid idOrder, int numCommande, Client client, DateTime dateLivraison, string adresseLivraison, Priorite priorite, GestionCommande etat, bool livraisonSurPlace, DateTime dateCommande, IEnumerable<OrderLine> orderLine)
        {
            var order = new Order
                {
                    id = idOrder,
                    NumCommande = numCommande,
                    Client = client,
                    Priorite = priorite,
                    Etat = etat,
                    LivraisonSurPlace = livraisonSurPlace,
                    DateCommande = dateCommande
                };
            if (orderLine == null) return;
            if (order.OrderLines == null) order.OrderLines = new List<OrderLine>();
            foreach (var ol in orderLine)
            {
                //if (!orderLine.VerifyQuatityWithStock(stock)) return null;
                order.OrderLines.Add(ol);
            }

            _repositoryOrder.Save(order);
        }
    }

    internal interface IEditBdcPagePresenter
    {
        void Display();

        void Write(int numCommande, Client client, DateTime dateLivraison, string adresseLivraison, Priorite priorite,
                   GestionCommande etat, bool livraisonSurPlace, DateTime dateCommande, IEnumerable<OrderLine> orderLine);

        void Save(Guid idOrder, int numCommande, Client client, DateTime dateLivraison, string adresseLivraison, Priorite priorite, GestionCommande etat, bool livraisonSurPlace, DateTime dateCommande, IEnumerable<OrderLine> orderLine);
    }
}
