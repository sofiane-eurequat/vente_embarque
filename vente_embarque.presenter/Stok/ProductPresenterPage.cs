using System;
using System.Collections.Generic;
using vente_embarque.Core.Domain;
using vente_embarque.Model;
using vente_embarque.Model.Enum;
using System.Drawing;

namespace vente_embarque.presenter.Stok
{
    public class ProductPresenterPage:IProductPagePresenter
    {
        private readonly IProductView _productView;
        private readonly IRepository<Product, Guid> _repositoryProduct; 

        public ProductPresenterPage(IProductView productView, IRepository<Product,Guid> productRepository)
        {
            _productView = productView;
            _repositoryProduct = productRepository;
        }

        public void Display()
        {
            var product = _repositoryProduct.FindAll();
            if (product == null) return;
        
            var tempProduct = new List<ModelViewProduct>();

            foreach (var p in product)
            {
                var mvp = new ModelViewProduct
                    {
                        Id = p.id,
                        Nom = p.Name,
                        QuantiteMin = p.QuantiteMin,
                        Fournisseur = p.Fournisseur,
                        Categorie = p.Category.Name,
                        Marque = p.Marque.Name,
                        DateEntree = p.DateEntree,
                        TypeGestion = p.TypeGestion,
                        
                    };
            tempProduct.Add(mvp);
            }
            
            _productView.Produits = tempProduct;
    
        }
    }

    public interface IProductPagePresenter
    {
        void Display();
    }
}