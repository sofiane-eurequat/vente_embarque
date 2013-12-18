﻿using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Moq;
using Moq.Contrib.Indy;
using vente_embarque.Core.Domain;
using vente_embarque.Core.Domain.Query;
using vente_embarque.Model;
using vente_embarque.Model.Enum;

namespace vente_embarque.Test
{
  


    [TestFixture]
    public class Test
    {
        private Mock<IRepository<Stock, Guid>> stockMock;
        private Mock<IRepository<Sector, Guid>> sectorMock;
        [SetUp]
        public void SetupStockMock()
        {
            var factoryStockCreateStock = FactoryStock.CreateStock("stock1");
            
           // mock du stock
            FactoryStock.CreateProductLine(factoryStockCreateStock, FactoryStock.CreateProduct("product1"), 10);
            FactoryStock.CreateProductLine(factoryStockCreateStock, FactoryStock.CreateProduct("product2"), 10);
            FactoryStock.CreateProductLine(factoryStockCreateStock, FactoryStock.CreateProduct("product3"), 10);

            stockMock = new Mock<IRepository<Stock, Guid>>();
            stockMock.Setup(e => e.FindBy(It.IsAny<Query>())).Returns(
                new List<Stock>() {factoryStockCreateStock}
                );

            // mock du secteur et client
            const string nomSect = "nom secteur1";
            var sector = FactorySector.CreateSector(nomSect);
            var nom = "NomClient1";
            var prenom = "PrenomClient1";
            FactorySector.CreateClient(nom, prenom, sector);
            sectorMock=new Mock<IRepository<Sector, Guid>>();
            sectorMock.Setup(e => e.FindBy(It.IsAny<Query>())).Returns(
                new List<Sector>() {sector}
                );

        }

        [Test]
        public void CanCreateSecteur()
        {
            const string nom = "nom secteur1";
            var sector = FactorySector.CreateSector(nom);
            Assert.AreEqual(sector.Name, "nom secteur1");
        }



        [Test]
        public void CanCreateClient()
        {
            const string nomSect = "nom secteur1";
            Sector secteur = FactorySector.CreateSector(nomSect);

            string nom = "NomClient1";
            string prenom = "PrenomClient1";
            //un secteur doit tjr etre defini mmee si il doit etre nommé indéfini
            var client = FactorySector.CreateClient(nom, prenom, secteur);
            Assert.AreEqual(client.Name, "NomClient1");
            Assert.AreEqual(client.PreNom, "PrenomClient1");
        }


        [Test]
        public void CanCreateBonCommande()
        {
            var stockRepository = stockMock.Object;
            var stock=stockRepository.FindBy(new Query()).First();

            var product1=stock.GetProduct("product1");
            var product2=stock.GetProduct("product2");
            var product3=stock.GetProduct("product3");

            var orders = new List<OrderLine>();

            var orderLine = FactoryOrder.CreateOrderLine(stock,"product1", 5);
            var orderLine1 = FactoryOrder.CreateOrderLine(stock,"product2", 5);
            var orderLine2 = FactoryOrder.CreateOrderLine(stock,"product3", 5);

            orders.Add(orderLine);
            orders.Add(orderLine1);
            orders.Add(orderLine2);


            var sectorRepository = sectorMock.Object;
            var sector = sectorRepository.FindBy(new Query()).First();
            var client=sector.GetClient("NomClient1");

            var BonDeCommande = FactoryOrder.CreateOrder(stock,client, orders);
            var BonDeCommande1 = FactoryOrder.CreateOrder(stock, client, orders, Priorite.Normal);
            var BonDeCommande2 = FactoryOrder.CreateOrder(stock, client);
            //TODO: des que un bon commande est reçue une livraison est automatiquement crée et est ce que la date du bon de commande fait office de date de livraison 
            Assert.AreEqual(BonDeCommande.Client.Name,"NomClient1");
            Assert.AreEqual(BonDeCommande.OrderLines.Count,3);

            Assert.AreEqual(BonDeCommande1.Client.Name, "NomClient1");
            Assert.AreEqual(BonDeCommande1.OrderLines.Count, 3);
            Assert.AreEqual(BonDeCommande1.Priorite, Priorite.Normal);
        }

        [Test]
        public void CanCreaateStock()
        {
            const string stockName = "stock1";
            const string namepro1 = "produit1";
            const string namepro2 = "produit2";
            const int quantiteMinimale = 10;
            var stock = FactoryStock.CreateStock(stockName);
            Assert.AreEqual(stock.Name,"stock1");
            var produit1 = FactoryStock.CreateProduct( namepro1, quantiteMinimale);
            Assert.AreEqual(produit1.Name,"produit1");
            Assert.AreEqual(produit1.QuantiteMin, 10);
            var produit2 = FactoryStock.CreateProduct(namepro2);
            Assert.AreEqual(produit2.Name, "produit2");
            var ligne1 = FactoryStock.CreateProductLine(stock,produit1, 50);
            var ligne2 = FactoryStock.CreateProductLine(stock,produit2, 20);
            


            //StockRepository.save(stock);
            
            Assert.AreEqual(stock.ProductLines.Count,2);
        }

        [Test]
        public void getProductminimal()
        {
            
            string nameStock = "stock1";
            string namepro1 = "produit1";
            string namepro2 = "produit2";
            int quantiteMinimale = 10;
            var stock = FactoryStock.CreateStock(nameStock);
            var produit1 = FactoryStock.CreateProduct( namepro1, quantiteMinimale);
            var produit2 = FactoryStock.CreateProduct( namepro2,15);
            var ligne1 = FactoryStock.CreateProductLine(stock,produit1, 5);
            var ligne2 = FactoryStock.CreateProductLine(stock,produit2, 20);
            var listProduct = stock.GetProductMinimale();
            Assert.AreEqual(listProduct.Count,1);

        }

        [Test]
        public void CanCreateBCWithoutStock()
        {

            var stockRepository = stockMock.Object;
            IEnumerable<Stock> stockRepositoryFindBy = stockRepository.FindBy(new Query());
            var stock = stockRepositoryFindBy.First();
            var product1 = stock.GetProduct("product1");
            var product2 = stock.GetProduct("product2");
            var product3 = stock.GetProduct("product3");
            

            var sectorRepository = sectorMock.Object;
            var sector = sectorRepository.FindBy(new Query()).First();
            var client = sector.GetClient("NomClient1");

            


            var orders = new List<OrderLine>();
            OrderLine orderLine = FactoryOrder.CreateOrderLine(stock,"product1", 20);
            OrderLine orderLine1 = FactoryOrder.CreateOrderLine(stock, "product2", 5);
            OrderLine orderLine2 = FactoryOrder.CreateOrderLine(stock, "product3", 5);
            Assert.IsNull(orderLine);

            stock.UpdateQuantity("product2", 4);

            orders.Add(orderLine1);
            orders.Add(orderLine2);
            Assert.IsNull(FactoryOrder.CreateOrder(stock,client, orders));

        }
        /*
        [Test]
        public void CanUpateStock()
        {
            var stockRepository = stockMock.Object;
            var stock = stockRepository.FindBy(new Query()).First();

            

        }
        */

    }

    
}
