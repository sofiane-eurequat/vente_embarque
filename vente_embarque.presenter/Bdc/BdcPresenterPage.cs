using System;
using System.Collections.Generic;
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
        private readonly IRepository<Stock, Guid> _repositoryStock;

        public BdcPresenterPage(IBdcView bdcView, IRepository<Order, Guid> orderRepository, IRepository<Stock, Guid> stockRepository)
        {
            _bdcView = bdcView;
            _repositoryOrder = orderRepository;
            _repositoryStock = stockRepository;
        }
        
        public void Diplay()
        {
            var order = _repositoryOrder.FindAll();
            _bdcView.Stocks = _repositoryStock.FindAll();
            if (order == null) return;

            var tempOrder = new List<ModelViewBdc>();

            foreach (var bdc in order)
            {
                var mvb = new ModelViewBdc
                    {
                        NumCommande = bdc.NumCommande,
                        Client = bdc.Client.Name + " " + bdc.Client.PreNom,
                        NameClient = bdc.Client.Name,
                        Priorite = bdc.Priorite,
                        Etat = bdc.Etat,
                        Datecommande = bdc.DateCommande,
                        LivraisonSurPlace = bdc.LivraisonSurPlace,
                        Montant = bdc.Montant,
                        Id = bdc.id,
                        OrderLines = new List<ModelViewOrderLine>(),
                        Products = new List<ModelViewProduct>(),
                    };

                foreach (var orderLine in bdc.OrderLines)
                {
                    mvb.OrderLines.Add(new ModelViewOrderLine { Id = orderLine.id, ProductName = orderLine.Product.Name, Quantity = orderLine.Quantity, Product = orderLine.Product, IdOrder = bdc.id});
                    
                    foreach (var pr in bdc.OrderLines)
                    {
                        mvb.Products.Add(new ModelViewProduct
                            {
                                Nom = pr.Product.Name,
                                Id = pr.Product.id,
                                QuantiteMin = pr.Product.QuantiteMin,
                                Fournisseur = pr.Product.Fournisseur.Name,
                                Reference = pr.Product.SiteReference,
                                Categorie = pr.Product.Category.Name,
                                Remarque = pr.Product.Remarque,
                                Marque = pr.Product.Marque.Name,
                                DateEntree = pr.Product.DateEntree,
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
        public int NumCommande { get; set; }
        public string Client { get; set; }
        public string NameClient { get; set; }
        public List<ModelViewOrderLine> OrderLines { get; set; }
        public Priorite Priorite { get; set; }
        public GestionCommande Etat { get; set; }
        public DateTime DateLivraison { get; set; }
        public string AdresseLivraison { get; set; }
        public bool LivraisonSurPlace { get; set; }
        public int Montant { get; set; }
        public DateTime Datecommande { get; set; }
        public List<ModelViewProduct> Products { get; set; } 
    }

    public class ModelViewOrderLine
    {
        public Guid Id { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public Product Product { get; set; }
        public Guid IdOrder { get; set; }
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
        public DateTime DateEntree { get; set; }
        public GestionProduit TypeGestion { get; set; }
    }
}