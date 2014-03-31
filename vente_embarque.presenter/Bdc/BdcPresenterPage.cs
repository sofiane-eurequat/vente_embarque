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
        private readonly IRepository<Client, Guid> _repositoryclient;

        public BdcPresenterPage(IBdcView bdcView,IRepository<Client,Guid> clientkRepository)
        {
            _bdcView = bdcView;
            _repositoryclient = clientkRepository;
        }
        
        public void Diplay()
        {
            _repositoryclient.FindAll();
        }
    }

    public interface IBdcPagePresenter
    {
        void Diplay();
    }

    public class ModelViewBdc
    {
        public Guid Id { get; set; }
        public Client Client { get; set; }
        public List<OrderLine> OrderLines { get; set; }
        public Priorite Priorite { get; set; }
    }

    public class ModelViewOrderLine
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
