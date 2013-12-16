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
    }
    public static class FactoryStock
    {
        public static Stock CreateStock(string name)
        {
            var stock = new Stock(name);
            stock.id = Guid.NewGuid();
            return stock;
        }

        public static Product CreateProduct(string name, int quantiteMin=0)
        {
            var product = new Product {Name = name, QuantiteMin = quantiteMin};
            return product;
        }

        public static ProductLine CreateProductLine(Stock stock,Product product,int quantity=0)
        {
            var productline = new ProductLine();
            
            productline.Product = product;
            productline.Quantity = quantity;
            if(stock.ProductLines==null) stock.ProductLines=new List<ProductLine>();
            stock.ProductLines.Add(productline);
            return productline;
        }

    }
}
