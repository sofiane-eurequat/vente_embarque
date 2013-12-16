using System;
using System.Collections.Generic;
using NUnit.Framework;
using Moq;
using Moq.Contrib.Indy;
using vente_embarque.Core.Domain;
using vente_embarque.Model;

namespace vente_embarque.Test
{
    public class TestContext<T> where T : class
    {
        private IMockContainer _container;
        private MockRepository _repository;
        private T _classUnderTest;
        protected TestContext()
        {
            _repository = new MockRepository(MockBehavior.Default);
            _container = new AutoMockContainer(_repository);
            _classUnderTest = _container.Create<T>();
        }
        protected T ClassUnderTest
        {
            get { return _classUnderTest; }
        }

        protected IMockContainer Container
        {
            get{return _container}
        }
    }


    [TestFixture]
    public class Test : TestContext<Stock>
    {

        [SetUp]
        void SetupStockMock()
        {
           
        }
        [Test]
        void CanCreateSecteur()
        {
            const string nom = "nom secteur1";
            var secteur =SecteurFactory(nom);
            Assert.AreEqual(secteur.nom = "nom secteur1");
        }


        [Test]
        void CanCreateClient()
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
        void CanCreateBonCommande()
        {
            var client = clientRepository.FindBy(Guid.NewGuid());

            var product = StockRepository.findBy("produit1");
            var product1 = StockRepository.findBy("produit1");
            var product2 = StockRepository.findBy("produit1");

            var orders = new List<OrderLine>();
            OrderLine orderLine = OrderFactory.CreateAnOrderLine(product, 5);
            OrderLine orderLine1 = OrderFactory.CreateAnOrderLine(product1, 5);
            OrderLine orderLine2= OrderFactory.CreateAnOrderLine(product2, 5);

            orders.Add(orderLine);
            orders.Add(orderLine1);
            orders.Add(orderLine2);

            var BonDeCommande = OrderFactory.CreateAnOrder(client,orders);
            var BonDeCommande1 = OrderFactory.CreateAnOrder(client, orders,Priorite.Normal);
            //TODO: des que un bon commande est reçue une livraison est automatiquement crée et est ce que la date du bon de commande fait office de date de livraison 
            Assert.AreEqual(BonDeCommande.client.name,"NomClient");
            Assert.AreEqual(BonDeCommande.OrderLine.Count(),3);

            Assert.AreEqual(BonDeCommande1.client.name, "NomClient");
            Assert.AreEqual(BonDeCommande1.OrderLine.Count(), 3);
            Assert.AreEqual(BonDeCommande1.priorite, Priorite.Normal);
        }

        [Test]
        private void CanCreaateStock()
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
        void getProductminimal()
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
        void CanCreateBCWithoutStock()
        {

            StockRepository.GetById(Guid.NewGuid());

            string namepro1 = "produit1";
            string namepro2 = "produit2";
            int quantiteMinimale = 10;
            var stock = FactoryStock.CreateStock();
            var produit1 = FactoryStock.CreateProduct(stock, namepro1, quantiteMinimale);
            var produit2 = FactoryStock.CreateProduct(stock, namepro2, 15);
            var ligne1 = FactoryStock.CreateProductLine(produit1, 5);
            var ligne2 = FactoryStock.CreateProductLine(produit2, 20);

            var client = clientRepository.FindBy(Guid.NewGuid());
            var product = StockRepository.findproductBy("produit");
            var product1 = StockRepository.findproductBy("produit1");
            var product2 = StockRepository.findproductBy("produit3");


            var orders = new List<OrderLine>();
            OrderLine orderLine = OrderFactory.CreateAnOrderLine(product, 20);
            OrderLine orderLine1 = OrderFactory.CreateAnOrderLine(product1, 5);
            OrderLine orderLine2 = OrderFactory.CreateAnOrderLine(product2, 5);

            orders.Add(orderLine);
            orders.Add(orderLine1);
            orders.Add(orderLine2);

            Assert.IsNull(OrderFactory.CreateAnOrder(client, orders));

            var BonDeCommande1 = OrderFactory.CreateAnOrder(client, orders, Priorite.Normal);
        }




    }

    
}
