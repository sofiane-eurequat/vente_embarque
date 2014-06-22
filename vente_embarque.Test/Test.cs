using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Moq;
using Moq.Contrib.Indy;
using vente_embarque.Core.Domain;
using vente_embarque.Core.Domain.Query;
using vente_embarque.DataLayer;
using vente_embarque.DataLayer.Helper;
using vente_embarque.Model;
using vente_embarque.Model.Enum;

namespace vente_embarque.Test
{
    [TestFixture]
    public class Test
    {/*
        private Mock<IRepository<Stock, Guid>> stockMock;
        private Mock<IRepository<Sector, Guid>> sectorMock;
        private Mock<IRepository<Sector, Guid>> sectorMock2;
        private Mock<IRepository<Product, Guid>> productMock;
        [SetUp]
        public void SetupStockMock()
        {

            InitDal.Init();
            var factoryStockCreateStock = FactoryStock.CreateStock("stock1");
            
           // mock du stock
            var marque = FactoryMarque.CreateMarque("Nom marque");
            var category = FactoryCategory.CreateCategory("Nom category","Description");
            FactoryStock.CreateProductLine(factoryStockCreateStock, FactoryProduct.CreateProduct("product1",15,category,marque), 10);
            FactoryStock.CreateProductLine(factoryStockCreateStock, FactoryProduct.CreateProduct("product2",17,category,marque), 10);
            FactoryStock.CreateProductLine(factoryStockCreateStock, FactoryProduct.CreateProduct("product3",20,category,marque), 10);

            stockMock = new Mock<IRepository<Stock, Guid>>();
            stockMock.Setup(e => e.FindBy(It.IsAny<Query>())).Returns(
                new List<Stock>() {factoryStockCreateStock}
                );

            // mock du secteur et client
            const string nomSect = "nom secteur1";
            //const string wilaya = "Tlemcen";
            //const string commune = "Tlemcen";
            var wilaya = new RepositoryWilaya().FindAll().First();
            var commune = new RepositoryWilaya().FindAll().First().Communes.First();
            var sector = FactorySector.CreateSector(nomSect,wilaya,commune);
            const string nom = "NomClient1";
            const string prenom = "PrenomClient1";
            FactorySector.CreateClient(nom, prenom, sector);
            sectorMock=new Mock<IRepository<Sector, Guid>>();
            sectorMock.Setup(e => e.FindBy(It.IsAny<Query>())).Returns(
                new List<Sector> {sector}
                );


            //mock du produit 
            const string nommarque = "Dell";
            var marque2 = FactoryMarque.CreateMarque(nommarque);
            const string nom1 = "Desktop";
            const string description = "Pc bureau";
            var category2 = FactoryCategory.CreateCategory(nom1, description);
            var produit1 = FactoryProduct.CreateProduct("MockedProduct",10,category2,marque2);
            var produit2 = FactoryProduct.CreateProduct("MockedProduct", 15, category2, marque2,"ce produit est explosif",reference: "http://www.google.com");
            productMock=new Mock<IRepository<Product, Guid>>();
            productMock.Setup(e => e.FindBy(It.IsAny<Query>())).Returns(
                new List<Product>()
                    {
                        produit1,
                        produit2
                    }
                );
            const string nomSector = "secteur1";
            //var rw1 = new RepositoryWilaya();
            //string wilaya1 = rw1.FindBy(new Query()).First().ToString();
            //string commune1 = rw1.FindBy(new Query()).First().Communes.First().ToString();
            var wilaya1 = new RepositoryWilaya().FindAll().First();
            var commune1 = new RepositoryWilaya().FindAll().First().Communes.First();
            var secteur=FactorySector.CreateSector(nomSector,wilaya1,commune1);
            sectorMock2=new Mock<IRepository<Sector, Guid>>();
            sectorMock2.Setup(e => e.FindBy(It.IsAny<Query>())).Returns(
                new List<Sector>
                    {
                        secteur
                    }
                );

        }

        [Test]
        public void CanCreateSecteur()
        {
            const string nom = "nom secteur1";
            //const string wilaya = "Tlemcen";
            //const string commune = "Tlemcen";
            var wilaya = new RepositoryWilaya().FindAll().First();
            var commune = new RepositoryWilaya().FindAll().First().Communes.First();
            var sector = FactorySector.CreateSector(nom,wilaya,commune);
            Assert.AreEqual(sector.Name, "nom secteur1");
        }



        [Test]
        public void CanCreateClient()
        {
            const string nomSect = "nom secteur1";
            //const string wilaya = "Tlemcen";
            //const string commune = "Tlemcen";
            var wilaya = new RepositoryWilaya().FindAll().First();
            var commune = new RepositoryWilaya().FindAll().First().Communes.First();
            Sector secteur = FactorySector.CreateSector(nomSect,wilaya,commune);

            const string nom = "NomClient1";
            const string prenom = "PrenomClient1";
            //un secteur doit tjr etre defini mmee si il doit etre nommé indéfini
            var client = FactorySector.CreateClient(nom, prenom, secteur);
            Assert.AreEqual(client.Name, "NomClient1");
            Assert.AreEqual(client.PreNom, "PrenomClient1");
        }
        */
        [Test]
        public void CanCreateClientBd()
        {
         //   const string nomSect = "Kiffane";
            //const string wilaya = "Tlemcen";
            //const string commune = "Tlemcen";
         //   var wilaya = new RepositoryWilaya().FindAll().First(w => w.Name == "Tlemcen");
         //   var commune = new RepositoryWilaya().FindAll().First(w => w.Name == "Tlemcen").Communes.First(com => com.Name == "Tlemcen");
         //   Sector secteur = FactorySector.CreateSector(nomSect, wilaya, commune);
            var secteur = new RepositorySector().FindAll().First(s => s.Name == "Kiffane");
            const string nom = "nomClient3";
            const string prenom = "prenomClient3";
            //un secteur doit tjr etre defini mmee si il doit etre nommé indéfini
            var client = FactorySector.CreateClient(nom, prenom, secteur);
            new RepositoryClient().Save(client);
        }
        /*
        [Test]
        public void CanCreateBonCommande()
        {
            IRepository<Stock, Guid> stockRepository = stockMock.Object;

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
            IEnumerable<Sector> sectorRepositoryFindBy = sectorRepository.FindBy(new Query());
            var sector = sectorRepositoryFindBy.First(s => s.Name == "nom secteur1");
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

            //test de la sauvegarde dans une base de données 
            var repStock = new RepositoryStock();
            repStock.Save(stock);
        }
    
        [Test]
        public void CanCreateProduct()
        {
            const string productname = "produit2";
            const int quantiteMinimale = 5;
            const string nom = "Dell";
            var marque = FactoryMarque.CreateMarque(nom);
            Assert.AreEqual(marque.Name,nom);
            const string nom1 = "Desktop";
            const string description = "Pc bureau";
            var category = FactoryCategory.CreateCategory(nom1, description);
            Assert.AreEqual(category.Name,nom1);
            Assert.AreEqual(category.Description,description);
            var product = FactoryProduct.CreateProduct(productname,quantiteMinimale,category,marque);
            Assert.AreEqual(product.Name, "produit2");
            Assert.AreEqual(product.QuantiteMin, 5);
            Assert.AreEqual(product.Marque,marque);
            Assert.AreEqual(product.Category,category);
            new RepositoryProduct().Save(product);
        }


        [Test]
        public void CanCreateProductWithMarqueAndCategoyFromDB()
        {
            const string productname = "produit1";
            const int quantiteMinimale = 15;
            var marque = new RepositoryMarque().FindAll().First();
            var category = new RepositoryCategory().FindAll().First();
            var product = FactoryProduct.CreateProduct(productname, quantiteMinimale, category, marque);
            Assert.AreEqual(product.Name, "produit1");
            Assert.AreEqual(product.QuantiteMin, 15);
         
            new RepositoryProduct().Save(product);

            var rp = new RepositoryMarque().FindBy(product.Marque.id);
            Assert.AreEqual(product.Marque.id, rp.id);
            Assert.AreEqual(product.Marque.Name, rp.Name);

            var rc = new RepositoryCategory().FindBy(product.Category.id);
            Assert.AreEqual(product.Category.id, rc.id);
            Assert.AreEqual(product.Category.Name,rc.Name);
            Assert.AreEqual(product.Category.Description, rc.Description);
            
            new RepositoryProduct().Remove(product);
        }

        [Test]
        public void CanCreateProductwithStockAndProductLine()
        {
            const string productname = "HP Desktop I3";
            const int quantiteMinimale = 10;
            const string productname1 = "HP Desktop I5";
            const int quantiteMinimale1 = 10;
            const string productname2 = "HP Desktop I7";
            const int quantiteMinimale2 = 10;
            const string productname3 = "Laptop Sony";
            const int quantiteMinimale3 = 10;
            var marque = new RepositoryMarque().FindAll().First();
            var category = new RepositoryCategory().FindAll().First();
            var product = FactoryProduct.CreateProduct(productname, quantiteMinimale, category, marque);
            var product1 = FactoryProduct.CreateProduct(productname1, quantiteMinimale1, category, marque);
            var product2 = FactoryProduct.CreateProduct(productname2, quantiteMinimale2, category, marque);
            var product3 = FactoryProduct.CreateProduct(productname3, quantiteMinimale3, category, marque);
            Assert.AreEqual(product.Name, productname);
            Assert.AreEqual(product.QuantiteMin, quantiteMinimale);
            Assert.AreEqual(product1.Name, productname1);
            Assert.AreEqual(product1.QuantiteMin, quantiteMinimale1);
            Assert.AreEqual(product2.Name, productname2);
            Assert.AreEqual(product2.QuantiteMin, quantiteMinimale2);
            Assert.AreEqual(product3.Name, productname3);
            Assert.AreEqual(product3.QuantiteMin, quantiteMinimale3);

            new RepositoryProduct().Save(product);
            new RepositoryProduct().Save(product1);
            new RepositoryProduct().Save(product2);
            new RepositoryProduct().Save(product3);

            var rp = new RepositoryMarque().FindBy(product.Marque.id);
            Assert.AreEqual(product.Marque.id, rp.id);
            Assert.AreEqual(product.Marque.Name, rp.Name);

            var rc = new RepositoryCategory().FindBy(product.Category.id);
            Assert.AreEqual(product.Category.id, rc.id);
            Assert.AreEqual(product.Category.Name, rc.Name);
            Assert.AreEqual(product.Category.Description, rc.Description);

            const string stockname = "Stock Alger";
            var stock = FactoryStock.CreateStock(stockname);
            Assert.AreEqual(stock.Name, stockname);


            var lineStock = FactoryStock.CreateProductLine(stock, product, 30);
            var lineStock1 = FactoryStock.CreateProductLine(stock, product1, 20);
            var lineStock2 = FactoryStock.CreateProductLine(stock, product2, 40);
            var lineStock3 = FactoryStock.CreateProductLine(stock, product3, 25);
            Assert.AreEqual(lineStock.Product, product);
            Assert.AreEqual(lineStock.Quantity, 30);
            Assert.AreEqual(lineStock1.Product, product1);
            Assert.AreEqual(lineStock1.Quantity, 20);
            Assert.AreEqual(lineStock2.Product, product2);
            Assert.AreEqual(lineStock2.Quantity, 40);
            Assert.AreEqual(lineStock3.Product, product3);
            Assert.AreEqual(lineStock3.Quantity, 25);
            new RepositoryStock().Save(stock);
        }

        [Test]
        public void CanCreateProductwithStockFromDb()
        {
            const string productname = "Tablette Samsung";
            const int quantiteMinimale = 10;
            var marque = new RepositoryMarque().FindAll().First();
            var category = new RepositoryCategory().FindAll().First();
            var product = FactoryProduct.CreateProduct(productname, quantiteMinimale, category, marque);
            Assert.AreEqual(product.Name, productname);
            Assert.AreEqual(product.QuantiteMin, 10);

            new RepositoryProduct().Save(product);

            var rp = new RepositoryMarque().FindBy(product.Marque.id);
            Assert.AreEqual(product.Marque.id, rp.id);
            Assert.AreEqual(product.Marque.Name, rp.Name);

            var rc = new RepositoryCategory().FindBy(product.Category.id);
            Assert.AreEqual(product.Category.id, rc.id);
            Assert.AreEqual(product.Category.Name, rc.Name);
            Assert.AreEqual(product.Category.Description, rc.Description);
            
            const string stockname = "Stock Tlemcen";
            var stock = FactoryStock.CreateStock(stockname);
            Assert.AreEqual(stock.Name, stockname);
            

            var lineStock = FactoryStock.CreateProductLine(stock, product, 5);
            Assert.AreEqual(lineStock.Product, product);
            Assert.AreEqual(lineStock.Quantity, 5);
            new RepositoryStock().Save(stock);
        }

        [Test]
        public void CanCreateProductWithNLot()
        {
            const string productname = "produit4";
            const int quantiteMinimale = 6;
            var marque = new RepositoryMarque().FindAll().First(); var category = new RepositoryCategory().FindAll().First();
            var product = FactoryProduct.CreateProduct(productname, quantiteMinimale, category, marque);
        }

        
        [Test]
        public void CanCreateStock()
        {
            const string stockName = "stock1";
            const string namepro1 = "produit1";
            const string namepro2 = "produit2";
            const int quantiteMinimale = 10;
            var stock = FactoryStock.CreateStock(stockName);
            Assert.AreEqual(stock.Name,"stock1");
            var produit1 = FactoryProduct.CreateProduct(namepro1, quantiteMinimale);
            Assert.AreEqual(produit1.Name,"produit1");
            Assert.AreEqual(produit1.QuantiteMin, 10);
            var produit2 = FactoryProduct.CreateProduct(namepro2);
            Assert.AreEqual(produit2.Name, "produit2");
            var ligne1 = FactoryStock.CreateProductLine(stock,produit1, 50);
            var ligne2 = FactoryStock.CreateProductLine(stock,produit2, 20);
            var listeProduit = productMock.Object.FindBy(new Query()).ToList();
        
            var ligne3 = FactoryStock.CreateProductLine(stock, listeProduit[1], 20);

            Assert.AreEqual(stock.ProductLines.Count,3);
            /*************************************************/
            /****          Test on the data base          ****/
            /*************************************************/

            //new RepositoryStock().Save(stock);
   /*     }
    
        [Test]
        public void GetProductminimal()
        {
            const string nameStock = "stock1";
            const string namepro1 = "produit1";
            const string namepro2 = "produit2";
            const int quantiteMinimale = 10;
            var marque = new RepositoryMarque().FindAll().First();
            var category = new RepositoryCategory().FindAll().First();
            var marque1 = new RepositoryMarque().FindAll().Last();
            var category1 = new RepositoryCategory().FindAll().Last();
            var stock = FactoryStock.CreateStock(nameStock);
            var produit1 = FactoryProduct.CreateProduct(namepro1, quantiteMinimale, category, marque);
            var produit2 = FactoryProduct.CreateProduct(namepro2, 15, category1, marque1);
            var ligne1 = FactoryStock.CreateProductLine(stock,produit1, 5);
            var ligne2 = FactoryStock.CreateProductLine(stock,produit2, 20);
            var listProduct = stock.GetProductMinimale();
            Assert.AreEqual(listProduct.Count,1);
        }
        
        
        [Test]
        public void CanCreateBcWithoutStock()
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
        
        [Test]
        public void CanUpateStock()
        {
            var stockRepository = stockMock.Object;
            var stock = stockRepository.FindBy(new Query()).First();

        }
        
        [Test]
        public void CanCreateAgentTerrain()
        {
            const string nomAgent = "Agent1";
            const string nomAgent2 = "Agent2";
            var agentterrain = FactoryAgentTerrain.CreateAgentTerrain(nomAgent);
            Assert.AreEqual(agentterrain.Name,nomAgent);

            var secteur=sectorMock.Object.FindBy(new Query()).First();
            AgentTerrain agentTerrainSecteur = FactoryAgentTerrain.CreateAgentTerrain(nomAgent2,secteur);
            Assert.AreEqual(agentTerrainSecteur.Name,nomAgent2);
            Assert.AreEqual(agentTerrainSecteur.Secteur,secteur);
        }

        [Test]
        public void CanCreateStockDatabase()
        {
            const string stock2 = "stock2";
            var stock = FactoryStock.CreateStock(stock2);
            var rs = new RepositoryStock();
            rs.Save(stock);
        }
        */
        [Test]
        public void CanCreateAgentTerrainBd()
        {
            const string agentterrain1 = "agentterrain1";
            var agentterrain = FactoryAgentTerrain.CreateAgentTerrain(agentterrain1);
            new RepositoryAgentTerrain().Save(agentterrain);
        }

        [Test]
        public void CanCreateSecteurDb()
        {
            const string nom = "Tlemcen";
            var wilaya = new RepositoryWilaya().FindAll().First(w => w.Name == "Tlemcen");
            var commune = new RepositoryWilaya().FindAll().First(w => w.Name == "Tlemcen").Communes.First(com => com.Name == "Tlemcen");
            var sector = FactorySector.CreateSector(nom, wilaya, commune);
            Assert.AreEqual(sector.Name, nom);
            Assert.AreEqual(sector.Wilaya, wilaya);
            Assert.AreEqual(sector.Commune, commune);
            new RepositorySector().Save(sector);
        }
        
        [Test]
        public void CanCreateMarqueDb()
        {
            const string nom = "Samsung";
            var marque = FactoryMarque.CreateMarque(nom);
            new RepositoryMarque().Save(marque);
        }
    
        [Test]
        public void CanCreateCategoryDb()
        {
            const string nom = "Tablette";
            const string description = "Tablette 7 pouces";
            var categ = FactoryCategory.CreateCategory(nom, description);
            new RepositoryCategory().Save(categ);
        }

        [Test]
        public void CanDeleteCategoryBb()
        {
            var rc = new RepositoryCategory();
            var categ = rc.FindAll().First();
            rc.Remove(categ);
        }

        [Test]
        public void CanDeleteMarqueBb()
        {
            var rc = new RepositoryMarque();
            var marque = rc.FindAll().First();
            rc.Remove(marque);
        }
    }
}
