using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vente_embarque.Core.Domain;
using vente_embarque.Model;
using vente_embarque.Model.Enum;

namespace vente_embarque.presenter.Stok
{
    public class EditProductPresenterPage:IEditProductPagePresenter
    {
        private readonly IEditProductView _editProductView;
        private readonly IRepository<Category, Guid> _repositoryCategory;
        private readonly IRepository<Marque, Guid> _repositoryMarque;
        private readonly IRepository<Product, Guid> _repositoryProduct;

        public EditProductPresenterPage(IEditProductView editProductView,IRepository<Category,Guid> repositoryCategory,IRepository<Marque,Guid> repositoryMarque, IRepository<Product,Guid> repositoryProduct )
        {
            _editProductView = editProductView;
            _repositoryCategory = repositoryCategory;
            _repositoryMarque = repositoryMarque;
            _repositoryProduct = repositoryProduct;
        }

        public void Display()
        {
            _editProductView.Categories = _repositoryCategory.FindAll();
            _editProductView.Marques = _repositoryMarque.FindAll();
        }

        public void Write(string name, Category category, Marque marque, string fournisseur, int quantiteMin, GestionProduit typeGestion)
        {
            var product = FactoryProduct.CreateProduct(name, quantiteMin, category, marque, null, null, fournisseur,
                                                       typeGestion);
            _repositoryProduct.Save(product);
        }
    }

    internal interface IEditProductPagePresenter
    {
        void Display();
        void Write(string name, Category category, Marque marque, string fournisseur, int quantitéMin, GestionProduit typeGestion);
    }
}
