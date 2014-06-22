using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vente_embarque.Core.Domain;

namespace vente_embarque.Model
{
    public class Stock:EntityBase<Guid>,IAggregateRoot
    {
        public string Name { get; set; }
        public List<ProductLine> ProductLines { get; set; }
        public Wilaya Wilaya { get; set; }
        public Commune Commune { get; set; }
        public string Adress { get; set; }

        public Stock(string name)
        {
            Name = name;
        }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }

        public  List<Product> GetProductMinimale()
        {
            var listProuitMinimale = ProductLines.Where(s => s.Quantity < s.Product.QuantiteMin).Select(s => s.Product).ToList();
            return listProuitMinimale;
        }


        public List<Product> GetProductInvendue(int mois)
        {
            return new List<Product>();
        }

        public Product GetProduct(Guid id)
        {
            var products=ProductLines.Where(e => e.Product.id == id).Select(p=>p.Product);
            return products.Any() ? products.First() : null;
        }

        public Product GetProduct(string name)
        {
            var products = ProductLines.Where(e => e.Product.Name == name).Select(p => p.Product);
            return products.Any() ? products.First() : null;
            //todo: si plusiseur produit retourner une excetion
        }

        public IEnumerable<Product> GetProducts()
        {
            var products = ProductLines.Select(p => p.Product);
            return products;
        }

        public int GetQuantity(string name)
        {
            var quantite = ProductLines.Where(e => e.Product.Name == name).Select(p => p.Quantity);
            return quantite.Any() ? quantite.First() : default(int);
        }

        public Boolean UpdateQuantity(string name, int quantity)
        {
            var productLine = ProductLines.First(pl => pl.Product.Name == name);
            productLine.Quantity = quantity;
            return true;
        }
    }
    public static class FactoryStock
    {
        public static Stock CreateStock(string name, Wilaya wilaya, Commune commune, string adress)
        {
            var stock = new Stock(name) { id = Guid.NewGuid(), newObject = true, Wilaya = wilaya, Commune = commune, Adress = adress };
            return stock;
        }

        
        public static ProductLine CreateProductLine(Stock stock,Product product,int quantity=0)
        {
            var productline = new ProductLine {Product = product, id = Guid.NewGuid(), Quantity = quantity, newObject = true};

            if(stock.ProductLines==null) stock.ProductLines=new List<ProductLine>();
            stock.ProductLines.Add(productline);
            return productline;
        }

    }
}
