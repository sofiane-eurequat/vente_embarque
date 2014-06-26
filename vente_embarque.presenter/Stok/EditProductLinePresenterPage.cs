using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vente_embarque.Core.Domain;
using vente_embarque.Model;

namespace vente_embarque.presenter.Stok
{
    public class EditProductLinePresenterPage:IEditProductLinePagePresenter
    {
        private readonly IEditProductLineView _editProductLineView;
        private readonly IRepository<Stock, Guid> _repositoryStock;
        private readonly IRepository<Product, Guid> _repositoryProduct; 

        public EditProductLinePresenterPage(IEditProductLineView editProductLineView,IRepository<Stock,Guid> repositoryStock, IRepository<Product,Guid> repositoryProduct)
        {
            _editProductLineView = editProductLineView;
            _repositoryStock = repositoryStock;
            _repositoryProduct = repositoryProduct;
        }
        
        public void Display()
        {
            _editProductLineView.Stocks = _repositoryStock.FindAll();
            _editProductLineView.Products = _repositoryProduct.FindAll();
        }

        public void Write(Stock stock, Product product, int quantite)
        {
            var productLine = FactoryStock.CreateProductLine(stock, product, quantite);
            _repositoryStock.Add(stock);
        }
    }

    internal interface IEditProductLinePagePresenter
    {
        void Display();
        void Write(Stock stock,Product product, int quantite);
    }
}
