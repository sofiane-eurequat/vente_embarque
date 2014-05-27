using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;
using vente_embarque.Core.Domain.Query;
using vente_embarque.DataLayer.Entities;
using vente_embarque.DataLayer.Entities.Orders;
using vente_embarque.DataLayer.Entities.Stock;
using vente_embarque.DataLayer.Helper;
using vente_embarque.Model;

namespace vente_embarque.DataLayer.Map
{
    public static class Map
    {
        public static XpoStock MapStock( Stock stock,UnitOfWork uow)
        {
            var xpostock = new XpoStock(uow)
                {
                    Name =stock.Name,
                    Oid = stock.id
                };
            if (stock.ProductLines == null) return xpostock;
            foreach (var pl in stock.ProductLines)
            {
                var crierion = new Criterion(propertyName: "Name", value: pl.Product.Name,criteriaOperator:CriteriaOperator.Equal);
                var xpl = new XpoProductLine(uow)
                    {
                        Oid = pl.id,
                        Quantity = pl.Quantity,
                        Stock = xpostock,
                        Product = uow.GetObjectByKey<XpoProduct>(pl.Product.id)
                    };
            }
            return xpostock;
        }

        public static XpoSector MapSector(Sector sector, UnitOfWork uow)
        {
            return new XpoSector(uow)
            {
                Oid = sector.id,
                Name = sector.Name,
                Wilaya = MapWilaya(sector.Wilaya,uow),
                Commune = MapCommune(sector.Commune,uow)
            };
        }

        public static XpoProduct MapProduct(Product product, UnitOfWork uow)
        {

            XpoProduct productReturned;
            if (product.newObject)
            {
                productReturned= new XpoProduct(uow)
                {
                    Oid = product.id
                };
            }
            else
            {
                productReturned = uow.GetObjectByKey<XpoProduct>(product.id);
            }
            productReturned.Name = product.Name;
            productReturned.QuantityMin = product.QuantiteMin;
            productReturned.Category = MapCategory(product.Category, uow);
            productReturned.Marque = MapMarque(product.Marque, uow);
            return productReturned;
        }

        public static XpoMarque MapMarque(Marque marque, UnitOfWork uow)
        {
            XpoMarque marqueReturned;
            if (marque.newObject)
            {
                marqueReturned= new XpoMarque(uow)
                {
                    Oid = marque.id
                };
            }
            else
            {
                marqueReturned = uow.GetObjectByKey<XpoMarque>(marque.id);
            }
            marqueReturned.Name = marque.Name;
            return marqueReturned;
        }

        public static XpoCategory MapCategory(Category category, UnitOfWork uow)
        {
            XpoCategory categoryReturned;
            if (category.newObject)
            {
                categoryReturned = new XpoCategory(uow)
                {
                    Oid = category.id
                };
            }
            else
            {
                categoryReturned = uow.GetObjectByKey<XpoCategory>(category.id);
            }
            categoryReturned.Name = category.Name;
            categoryReturned.Description = category.Description;
            return categoryReturned;
        }

        public static XpoOrder MapOrder(Order order, UnitOfWork uow)
        {
            var xpoOrder= new XpoOrder(uow)
                {
                    Oid = order.id,
                    Priorite = order.Priorite,
                    //Delivery = order.Livraison
                    //todo : a implementer lors du lancement du module livraison
                };
            xpoOrder.Client = MapClient(order.Client, uow);
            if (order.OrderLines == null) return xpoOrder;
            foreach (var ol in order.OrderLines)
            {
                var xpl = new XpoOrderLine(uow)
                    {
                        Oid = ol.id,
                        Quantity = ol.Quantity,
                        Product = uow.GetObjectByKey<XpoProduct>(ol.Product.id)
                    };
                xpoOrder.OrderLines.Add(xpl); 
            }
            return xpoOrder;
        }
       
        public static XpoClient MapClient(Client client, UnitOfWork uow)
        {
            XpoClient clientReturned;
            if (client.newObject)
            {
                clientReturned = new XpoClient(uow)
                {
                    Oid = client.id
                };
            }
            else
            {
                clientReturned = uow.GetObjectByKey<XpoClient>(client.id);
            }
            clientReturned.Name = client.Name;
            clientReturned.PreName = client.PreNom;
            return clientReturned;
        }

        public static XpoAgentTerrain MapAgentTerrain(AgentTerrain agentterrain, UnitOfWork uow)
        {
            return new XpoAgentTerrain(uow)
            {
                Name = agentterrain.Name,
                Oid = agentterrain.id,
            };
        }
        
        private static XpoWilaya MapWilaya(Wilaya wilaya, UnitOfWork uow)
        {
            var xpoWilaya = new XpoWilaya(uow)
            {
                Name = wilaya.Name,
                Code = wilaya.Code,
                //Communes = MapCommune(wilaya.Communes,uow)
            };

            foreach (var co in wilaya.Communes)
            {
                var xco = new XpoCommune(uow)
                {
                    Name = co.Name,
                    CodeWilaya = co.CodeWilaya,
                    Wilaya = xpoWilaya
                };
            }
            return xpoWilaya;
        }
        
        private static XpoCommune MapCommune(Commune commune, UnitOfWork uow)
        {
            return new XpoCommune(uow)
            {
                Name = commune.Name
            };
        } 
    }
}
