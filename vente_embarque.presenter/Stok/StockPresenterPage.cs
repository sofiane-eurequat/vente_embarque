﻿using System;
using System.Collections.Generic;
using vente_embarque.Core.Domain;
using vente_embarque.Model;
using vente_embarque.Model.Enum;
using System.Drawing;

namespace vente_embarque.presenter.Stok
{
    public class StockPresenterPage:IStockPagePresenter
    {
        private readonly IStockView _stockView;
        private readonly IRepository<Stock, Guid> _repositoryStock;
        private readonly IRepository<Product, Guid> _repositoryProduct;

        public StockPresenterPage(IStockView stockView, IRepository<Stock, Guid> stockRepository, IRepository<Product, Guid> productRepository)
        {
            _stockView = stockView;
            _repositoryStock = stockRepository;
            _repositoryProduct = productRepository;
        }

        public void Display()
        {
            var stock = _repositoryStock.FindAll();
            var produit = _repositoryProduct.FindAll();

            if (stock == null) return;
        
            var tempStock = new List<ModelViewStock>();

            foreach (var stoc in stock)
            {
                var mvs=new ModelViewStock
                    {
                        Nom = stoc.Name,
                        Wilaya = stoc.Wilaya.Name,
                        Commune = stoc.Commune.Name,
                        Id = stoc.id,
                        Adresse = stoc.Adress,
                        CodeWilaya = stoc.Wilaya.Code,
                        ProductLine = new List<ModelViewProductLine>(),
                        Products = new List<ModelViewProduct>()
                    };
                foreach (var productLine in stoc.ProductLines)
                {
                    mvs.ProductLine.Add(new ModelViewProductLine { Id = productLine.id,Quantity = productLine.Quantity,Name = productLine.Product.Name,Product =productLine.Product, Stock = stoc, IdProduct = productLine.Product.id});
                }

                foreach (var product in stoc.GetProducts())
                {
                    mvs.Products.Add(new ModelViewProduct
                        {
                            Nom = product.Name,
                            Id = product.id,
                            QuantiteMin = product.QuantiteMin,
                            Fournisseur = product.Fournisseur.Name,
                            Reference = product.SiteReference,
                            Categorie = product.Category.Name,
                            Remarque = product.Remarque,
                            Marque = product.Marque.Name,
                            DateEntree = product.DateEntree,
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

            if (produit == null) return;

            var tempProduct = new List<ModelViewProduct>();

            foreach (var p in produit)
            {
                var mvp = new ModelViewProduct
                {
                    Id = p.id,
                    Nom = p.Name,
                    QuantiteMin = p.QuantiteMin,
                    Fournisseur = p.Fournisseur.Name,
                    Categorie = p.Category.Name,
                    Marque = p.Marque.Name,
                    DateEntree = p.DateEntree,
                    TypeGestion = p.TypeGestion,

                };
                tempProduct.Add(mvp);
            }

            _stockView.Products = tempProduct;
        }
    }
    public class ModelViewStock
    {
        public string Nom { get; set; }
        public List<ModelViewProductLine> ProductLine { get; set; }
        public string Etat { get; set; }
        public string Invendue { get; set; }
        public string Wilaya { get; set; }
        public string Commune { get; set; }
        public Guid Id { get; set; }
        public List<ModelViewProduct> Products { get; set; }
        public string Adresse { get; set; }
        public int CodeWilaya { get; set; }
    }

    public class ModelViewProductLine
    {
        public Product Product { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public Guid Id { get; set; }
        public Stock Stock { get; set; }
        public Guid IdProduct { get; set; }
    }

    public class ModelViewProduct
    {
        public Guid Id { get; set; }
        public string Nom { get; set; }
        public int QuantiteMin { get; set; }
        public Image Photo { get; set; }
        public string Fournisseur { get; set; }
        public string Categorie { get; set; }
        public string Marque { get; set; }
        public string Remarque { get; set; }
        public string Reference { get; set; }
        public DateTime DateEntree { get; set; }
        public GestionProduit TypeGestion { get; set; }
    }

    public interface IStockPagePresenter
    {
        void Display();
    }
}