using System;
using System.Collections.Generic;
using vente_embarque.Core.Domain;
using vente_embarque.Model;
using vente_embarque.Model.Enum;
using System.Drawing;
namespace vente_embarque.presenter
{
    public class StockPresenterPage:IStockPagePresenter
    {
        private readonly IStockView _stockView;
        private readonly IRepository<Stock, Guid> _repositorystock; 

        public StockPresenterPage(IStockView stockView,IRepository<Stock,Guid> stockRepository)
        {
            _stockView = stockView;
            _repositorystock = stockRepository;
        }


        public void Display()
        {
            var stock = _repositorystock.FindAll();
            var tempStock = new List<ModelViewStock>();

            foreach (var stoc in stock)
            {
                var mvs=new ModelViewStock()
                    {
                        Name = stoc.Name,
                        wilaya = stoc.Wilaya,
                        commune = stoc.Commune
                        
                    };
                mvs.ProductLine=new List<ModelViewProductLine>();
                mvs.Products=new List<ModelViewProduct>();
                foreach (var ProductLine in stoc.ProductLines)
                {
                    mvs.ProductLine.Add(new ModelViewProductLine() { Id = ProductLine.id,Quantity = ProductLine.Quantity,Name = ProductLine.Product.Name,Product =ProductLine.Product });
                }

                foreach (var product in stoc.GetProducts())
                {
                    mvs.Products.Add(new ModelViewProduct()
                        {
                            Nom = product.Name,
                            Id = product.id,
                            QuantiteMin = product.QuantiteMin,
                            Fournisseur = product.Fournisseur,
                            Reference = product.SiteReference,
                            Categorie = product.Category,
                            Remarque = product.Remarque,
                            Marque = product.Marque
                        });
                }

                var nombreProduit=stoc.GetProductMinimale().Count;
                if (nombreProduit == 0) mvs.Etat = StockBas.rien_a_signaler.ToString();
                if (nombreProduit == 1) mvs.Etat = StockBas.un_produit_stock_bas.ToString();
                if (nombreProduit > 1) mvs.Etat = StockBas.plusier_produit_stock_bas.ToString();
                var produitinvendue = stoc.GetProductInvendue(1).Count;
                if (produitinvendue == 0) mvs.Invendue = ProduitInvendue.ras.Tostring();
                if (produitinvendue == 1) mvs.Invendue = ProduitInvendue.un_produit_invendue.ToString();
                if (produitinvendue > 1) mvs.Invendue = ProduitInvendue.plusieur_invendue.ToString();

                

                tempStock.Add(mvs);


            }

            _stockView.Stocks = tempStock;
        }
    }
    public class ModelViewStock
    {
        public string Name { get; set; }
        public List<ModelViewProductLine> ProductLine { get; set; }
        public string Etat { get; set; }
        public string Invendue { get; set; }
        public string wilaya { get; set; }
        public string commune { get; set; }
        public Guid Id { get; set; }
        public List<ModelViewProduct> Products { get; set; }
 
    }

    public class ModelViewProductLine
    {
        public Product Product { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public Guid Id { get; set; }
    }

    public class ModelViewProduct
    {
        public Guid Id { get; set; }
        public int QuantiteMin { get; set; }
        public Image Photo { get; set; }
        public string Fournisseur { get; set; }
        public Category Categorie { get; set; }
        public Marque Marque { get; set; }
        public string Remarque { get; set; }
        public string Reference { get; set; }
        public string Nom { get; set; }

    }

    public interface IStockPagePresenter
    {
        void Display();
    }
}