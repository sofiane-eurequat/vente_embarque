using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;
using vente_embarque.DataLayer.Entities.Orders;
using vente_embarque.DataLayer.Entities.Stock;
using vente_embarque.Model;

namespace vente_embarque.DataLayer.Map
{
    public static class Map
    {
        public static Stock.XpoStock MapStock( Model.Stock stock,UnitOfWork uow)
        {
            var xpostock = new Stock.XpoStock(uow)
                {
                    Name =stock.Name,
                    Oid = stock.id
                };
            foreach (var pl in stock.ProductLines)
            {
                var xpl = new XpoProductLine(uow)
                    {
                        Oid = pl.id,
                        Quantity = pl.Quantity,
                        Stock = xpostock,
                        Product = MapProduct(pl.Product,uow)
                    };
            }
            return xpostock;
        }

        private static XpoProduct MapProduct(Product product, UnitOfWork uow)
        {
            return new XpoProduct(uow)
                {
                    Oid = product.id,
                    Name = product.Name, 
                    QuantityMin = product.QuantiteMin,
                    DateEntree = product.DateEntree
                };
        }

        public static void MapOrder(Order entity, UnitOfWork uow)
        {
            var xpoOrder= new XpoOrder(uow)
                {
                    Oid = entity.id,
                    Priorite = entity.Priorite
                };

            xpoOrder.Client = MapClient(entity.Client, uow);

        }

        private static XpoClient MapClient(Client client, UnitOfWork uow)
        {
            return new XpoClient(uow)
                {
                    Address = client.Address,
                    Name = client.Name,
                    PreName = client.PreNom,
                    
                };

        }
    }
}
