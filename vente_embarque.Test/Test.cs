using System;
using NUnit.Framework;

namespace vente_embarque.Test
{
    [TestFixture]
    public class Test
    {
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
            var secteur = SecteurFactory(nomSect);

            string nom = "NomClient1";
            string prenom = "PrenomClient1";
            var client = ClientFactory(nom, prenom, secteur);
            Assert.AreEqual(client.nom, "NomClient1");
            Assert.AreEqual(client.prenom, "PrenomClient1");
            Assert.AreEqual(client.secteur.nom, "PrenomClient1");


            var client1= ClientFactory(nom, prenom);
            Assert.AreEqual(client1.nom, "NomClient1");
            Assert.AreEqual(client1.prenom, "PrenomClient1");
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
            string namepro1 = "produit1";
            string namepro2 = "produit2";
            int quantiteMinimale = 10;
            var stock = FactoryStock.CreateStock();
            var produit1 = FactoryStock.CreateProduct(stock,namepro1,quantiteMinimale);
            var produit2 = FactoryStock.CreateProduct(stock,namepro2);
            var ligne1 = FactoryStock.CreateProductLine(produit1, 50);
            var ligne2 = FactoryStock.CreateProductLine(produit2, 20);

            //StockRepository.save(stock);
            Assert.AreEqual(StockRepository.GetById(stock.Oid),stock);
            Assert.AreEqual(stock.GetProduct().quantite,50);
        }

        [Test]
        void getProductminimal()
        {
            StockRepository.GetById(Guid.NewGuid());

            string namepro1 = "produit1";
            string namepro2 = "produit2";
            int quantiteMinimale = 10;
            var stock = FactoryStock.CreateStock();
            var produit1 = FactoryStock.CreateProduct(stock, namepro1, quantiteMinimale);
            var produit2 = FactoryStock.CreateProduct(stock, namepro2,15);
            var ligne1 = FactoryStock.CreateProductLine(produit1, 5);
            var ligne2 = FactoryStock.CreateProductLine(produit2, 20);
            List<Product> listProduct = StockRepository.GetProductMinimale();
            Assert.AreEqual(listProduct.Count(),1);

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
