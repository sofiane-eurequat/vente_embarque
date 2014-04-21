using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vente_embarque.Core.Domain;
using vente_embarque.Model;

namespace vente_embarque.presenter.Bdc
{
    public class EditOrderLinePresenterPage:IEditOrderLinePagePresenter
    {
        private readonly IEditBdcView _EditBdcView; 
        private IRepository<Product, Guid> _repositoryProduit;
        private IRepository<Stock, Guid> _repositoryStock;
        private IRepository<Order, Guid> _repositoryOrder; 
 
        public EditOrderLinePresenterPage(IEditBdcView editBdcView, IRepository<Product,Guid> repository, IRepository<Stock,Guid> repository1  )
        {
            _EditBdcView = editBdcView;
            //_repositoryProduit = repository;
            _repositoryStock = repository1;
        }

        public void Display()
        {
            _EditBdcView.Stocks = _repositoryStock.FindAll();
            //_EditBdcView.Produits = _repositoryProduit.FindAll();
        }

        public void Write(Stock stock, Product product, int quantiteMin)
        {
            throw new NotImplementedException();
        }
    }

    internal interface IEditOrderLinePagePresenter
    {
        void Display();
        void Write(Stock stock, Product product, int quantiteMin);
    }
}
