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
    public class BdcPresenterPage:IBdcPagePresenter
    {
        private readonly IBdcView _bdcView;
        //private readonly IRepository<Client, Guid> _repositoryClient;
        private readonly IRepository<Order, Guid> _repositoryOrder; 

        public BdcPresenterPage(IBdcView bdcView, IRepository<Order,Guid> orderRepository )
        {
            _bdcView = bdcView;
            //_repositoryClient = clientkRepository;
            _repositoryOrder = orderRepository;
        }
        
        public void Diplay()
        {
            var order = _repositoryOrder.FindAll();
            var tempOrder = new List<ModelViewBdc>();

            foreach (var bdc in order)
            {
                var mvb = new ModelViewBdc
                    {
                    Client = bdc.Client.Name,
                    Priorite = bdc.Priorite,
                    Id = bdc.id,
                };

                mvb.OrderLines=new List<ModelViewOrderLine>();

                foreach (var orderLine in bdc.OrderLines)
                {
                    mvb.OrderLines.Add(new ModelViewOrderLine { Id = orderLine.id, Product = orderLine.Product.Name, Quantity = orderLine.Quantity });
                }

                tempOrder.Add(mvb);
            }

            _bdcView.Orders = tempOrder;
        }
    }

    public interface IBdcPagePresenter
    {
        void Diplay();
    }

    public class ModelViewBdc
    {
        public Guid Id { get; set; }
        public string Client { get; set; }
        public List<ModelViewOrderLine> OrderLines { get; set; }
        public Priorite Priorite { get; set; }
        public DateTime DateLivraison { get; set; }
        public string AdresseLivraison { get; set; }
    }

    public class ModelViewOrderLine
    {
        public string Product { get; set; }
        public int Quantity { get; set; }
        public Guid Id { get; set; }
    }
}