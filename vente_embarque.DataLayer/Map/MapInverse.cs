using System.Collections.Generic;
using System.Linq;
using vente_embarque.DataLayer.Entities.Stock;
using vente_embarque.DataLayer.Stock;
using vente_embarque.Model;

namespace vente_embarque.DataLayer.Map
{
    public static class MapInverse
    {

       public static Model.Stock MapStock(XpoStock xpoStock)
       {
           var stock = new Model.Stock(xpoStock.Name)
               {
                   id = xpoStock.Oid,
                   ProductLines = MapProdcutLine(xpoStock.ProductLines),
               };
           return stock;
       }

       public static List<ProductLine> MapProdcutLine(IEnumerable<XpoProductLine> productLines)
        {
            return productLines.Select(xpoProductLine => new ProductLine()
                {
                    Quantity = xpoProductLine.Quantity, id = xpoProductLine.Oid, Product = MapProduct(xpoProductLine.Product)
                }).ToList();
        }

       public static Product MapProduct(XpoProduct product)
        {
            return new Product(){id = product.Oid,Name = product.Name,QuantiteMin = product.QuantityMin,DateEntree = product.DateEntree};
        }
    }
}
