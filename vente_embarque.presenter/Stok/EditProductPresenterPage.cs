using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vente_embarque.Core.Domain;
using vente_embarque.Model;

namespace vente_embarque.presenter.Stok
{
    public class EditProductPresenterPage:IEditProductPagePresenter
    {
        private readonly IEditProductView _editProductView;
        private IRepository<Stock, Guid> _repositoryStock;
        private IRepository<Category, Guid> _repositoryCategory;
        private IRepository<Marque, Guid> _repositoryMarque;

        public EditProductPresenterPage(IEditProductView editProductView,IRepository<Stock,Guid> repositoryStock,IRepository<Category,Guid> repositoryCategory,IRepository<Marque,Guid> repositoryMarque)
        {
            _editProductView = editProductView;
            _repositoryStock = repositoryStock;
            _repositoryCategory = repositoryCategory;
            _repositoryMarque = repositoryMarque;
        }

        public void Display()
        {
            _editProductView.Stocks = _repositoryStock.FindAll();
            _editProductView.Categories = _repositoryCategory.FindAll();
            _editProductView.Marques = _repositoryMarque.FindAll();
        }

        public void Write()
        {
            throw new NotImplementedException();
        }
    }

    internal interface IEditProductPagePresenter
    {
        void Display();
        void Write();
    }
}
