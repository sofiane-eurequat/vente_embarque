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
            XpoStock xpoStock;
            if (stock.newObject)
            {
                xpoStock = new XpoStock(uow)
                {
                    Oid = stock.id
                };
            }
            else
            {
                xpoStock = uow.GetObjectByKey<XpoStock>(stock.id);
            }

            xpoStock.Name = stock.Name;
            xpoStock.Wilaya = MapWilaya(stock.Wilaya, uow);
            xpoStock.Commune = MapCommune(stock.Commune, uow);
            xpoStock.Adress = stock.Adress;
                
            if (stock.ProductLines == null) return xpoStock;
            foreach (var pl in stock.ProductLines)
            {
                var crierion = new Criterion(propertyName: "Name", value: pl.Product.Name,criteriaOperator:CriteriaOperator.Equal);
                var xpl = new XpoProductLine(uow)
                    {
                        Oid = pl.id,
                        Quantity = pl.Quantity,
                        Stock = xpoStock,
                        Product = uow.GetObjectByKey<XpoProduct>(pl.Product.id)
                    };
            }
            return xpoStock;
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
            productReturned.Fournisseur = product.Fournisseur;
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
            XpoOrder orderReturned;
            //order.newObject = false;
            if (order.newObject)
            {
                orderReturned = new XpoOrder(uow)
                    {
                        Oid = order.id
                    };
            }
            else
            {
                orderReturned = uow.GetObjectByKey<XpoOrder>(order.id);
            }
            orderReturned.NumCommadne = order.NumCommande;
            orderReturned.Client = MapClient(order.Client, uow);
            orderReturned.Priorite = order.Priorite;
            orderReturned.Etat = order.Etat;
            orderReturned.LivraisonSurPlace = order.LivraisonSurPlace;
            orderReturned.DateCommande = order.DateCommande;
            orderReturned.Montant = order.Montant;
            //orderReturned.Delivery=order.Livraison
            //todo : a implementer lors du lancement du module livraison 

            if (order.OrderLines == null) return orderReturned;
            foreach (var ol in order.OrderLines)
            {
                var xpl = new XpoOrderLine(uow)
                {
                    Oid = ol.id,
                    Quantity = ol.Quantity,
                    Product = uow.GetObjectByKey<XpoProduct>(ol.Product.id)
                };
                orderReturned.OrderLines.Add(xpl);
            }
            return orderReturned;
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

        public static void MapAgentTerrain(AgentTerrain agentterrain, UnitOfWork uow)
        {
            new XpoAgentTerrain(uow)
            {
                Name = agentterrain.Name,
                Oid = agentterrain.id,
            };
            return;
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
