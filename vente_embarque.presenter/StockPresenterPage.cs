using System;
using System.Collections.Generic;
using vente_embarque.Core.Domain;
using vente_embarque.Model;
using vente_embarque.Model.Enum;

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
                        ProductLine = stoc.ProductLines
                    };
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
        public List<ProductLine> ProductLine { get; set; }
        public string Etat { get; set; }
        public string Invendue { get; set; }
        
    }
    public interface IStockPagePresenter
    {
        void Display();
    }
}