using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vente_embarque.Core.Domain;
using vente_embarque.Model;
using vente_embarque.Model.Enum;
using System.Drawing;

namespace vente_embarque.presenter.Bdc
{
    public class BdcPresenterPage:IBdcPagePresenter
    {
        private readonly IBdcView _bdcView;
        private readonly IRepository<Order, Guid> _repositoryOrder;
        private readonly IRepository<Product, Guid> _repositoryProduct;

        public BdcPresenterPage(IBdcView bdcView, IRepository<Order, Guid> orderRepository, IRepository<Product, Guid> productRepository)
        {
            _bdcView = bdcView;
            _repositoryOrder = orderRepository;
            _repositoryProduct = productRepository;
        }
        
        public void Diplay()
        {
            var order = _repositoryOrder.FindAll();
            //var product = _repositoryProduct.FindAll();
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
                mvb.Products=new List<ModelViewProduct>();
                foreach (var orderLine in bdc.OrderLines)
                {
                    mvb.OrderLines.Add(new ModelViewOrderLine { Id = orderLine.id, ProductName = orderLine.Product.Name, Quantity = orderLine.Quantity, Product = orderLine.Product});
                    
                    foreach (var pr in bdc.OrderLines)
                    {
                        mvb.Products.Add(new ModelViewProduct
                            {
                                Nom = pr.Product.Name,
                                Id = pr.Product.id,
                                QuantiteMin = pr.Product.QuantiteMin,
                                Fournisseur = pr.Product.Fournisseur,
                                Reference = pr.Product.SiteReference,
                                Categorie = pr.Product.Category.Name,
                                Remarque = pr.Product.Remarque,
                                Marque = pr.Product.Marque.Name,
                            });
                    }
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
        public List<ModelViewProduct> Products { get; set; } 
    }

    public class ModelViewOrderLine
    {
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public Guid Id { get; set; }
        public Product Product { get; set; }
    }

    public class ModelViewProduct
    {
        public Guid Id { get; set; }
        public int QuantiteMin { get; set; }
        public Image Photo { get; set; }
        public string Fournisseur { get; set; }
        public string Categorie { get; set; }
        public string Marque { get; set; }
        public string Remarque { get; set; }
        public string Reference { get; set; }
        public string Nom { get; set; }

    }
}