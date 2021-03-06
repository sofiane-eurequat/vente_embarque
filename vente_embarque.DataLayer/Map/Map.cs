﻿using System;
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
                XpoProductLine productLineReturned;
                if (pl.newObject)
                {
                    productLineReturned = new XpoProductLine(uow)
                    {
                        Oid = pl.id
                    };
                }
                else
                {
                    productLineReturned = uow.GetObjectByKey<XpoProductLine>(pl.id);
                }

                productLineReturned.Quantity = pl.Quantity;
                productLineReturned.Product = uow.GetObjectByKey<XpoProduct>(pl.Product.id);
                productLineReturned.Stock = xpoStock;
            }
            return xpoStock;
        }

        public static XpoSector MapSector(Sector sector, UnitOfWork uow)
        {
            XpoSector sectorReturned;
            if (sector.newObject)
            {
                sectorReturned = new XpoSector(uow)
                {
                    Oid = sector.id
                };
            }
            else
            {
                sectorReturned = uow.GetObjectByKey<XpoSector>(sector.id);
            }

            sectorReturned.Name = sector.Name;
            sectorReturned.Wilaya = MapWilaya(sector.Wilaya, uow);
            sectorReturned.Commune = MapCommune(sector.Commune, uow);
            return sectorReturned;
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
            productReturned.DateEntree = product.DateEntree;
            productReturned.Fournisseur = MapFournisseur(product.Fournisseur, uow);
            productReturned.TypeGestion = product.TypeGestion;
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

        public static XpoFournisseur MapFournisseur(Fournisseur fournisseur, UnitOfWork uow)
        {
            XpoFournisseur fournisseurReturned;
            if (fournisseur.newObject)
            {
                fournisseurReturned = new XpoFournisseur(uow)
                {
                    Oid = fournisseur.id
                };
            }
            else
            {
                fournisseurReturned = uow.GetObjectByKey<XpoFournisseur>(fournisseur.id);
            }
            fournisseurReturned.Name = fournisseur.Name;
            return fournisseurReturned;
        }

        public static XpoOrder MapOrder(Order order, UnitOfWork uow)
        {
            XpoOrder orderReturned;
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
                XpoOrderLine orderLineReturned;
                if (ol.newObject)
                {
                    orderLineReturned = new XpoOrderLine(uow)
                    {
                        Oid = ol.id
                    };
                }
                else
                {
                    orderLineReturned = uow.GetObjectByKey<XpoOrderLine>(ol.id);
                }

                orderLineReturned.Quantity = ol.Quantity;
                orderLineReturned.Product = uow.GetObjectByKey<XpoProduct>(ol.Product.id);
                
                orderReturned.OrderLines.Add(orderLineReturned);
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

        public static XpoAgentTerrain MapAgentTerrain(AgentTerrain agentterrain, UnitOfWork uow)
        {
            XpoAgentTerrain agentTerrainReturned;
            if(agentterrain.newObject)
            {
                agentTerrainReturned = new XpoAgentTerrain(uow)
                    {
                        Oid = agentterrain.id
                    };
                
            }
            else
            {
                agentTerrainReturned = uow.GetObjectByKey<XpoAgentTerrain>(agentterrain.id);
            }
            agentTerrainReturned.Name = agentterrain.Name;
            //agentTerrainReturned.Secteur = MapSector(agentterrain.Secteur, uow);
            return agentTerrainReturned;
        }

        private static XpoWilaya MapWilaya(Wilaya wilaya, UnitOfWork uow)
        {
            var xpoWilaya = uow.GetObjectByKey<XpoWilaya>(wilaya.id);

            xpoWilaya.Name = wilaya.Name;
            xpoWilaya.Code = wilaya.Code;
  
            foreach (var co in wilaya.Communes)
            {
                var xpoCommune = uow.GetObjectByKey<XpoCommune>(co.id);
                xpoCommune.Name = co.Name;
                xpoCommune.CodeWilaya = co.CodeWilaya;
                xpoCommune.Wilaya = xpoWilaya;
            }
            return xpoWilaya;
        }
        
        private static XpoCommune MapCommune(Commune commune, UnitOfWork uow)
        {
            var xpoCommune = uow.GetObjectByKey<XpoCommune>(commune.id);
            xpoCommune.Name = commune.Name;
            return xpoCommune;
        } 
    }
}
