using System.Collections.Generic;
using System.Linq;
using DevExpress.Xpo;
using vente_embarque.DataLayer.Entities;
using vente_embarque.DataLayer.Entities.Orders;
using vente_embarque.DataLayer.Entities.Stock;
using vente_embarque.DataLayer.Helper;
using vente_embarque.Model;

namespace vente_embarque.DataLayer.Map
{
    public static class MapInverse
    {

       public static Stock MapStock(XpoStock xpoStock)
       {
           var stock = new Stock(xpoStock.Name)
               {
                   id = xpoStock.Oid,
                   Wilaya = MapWilaya(xpoStock.Wilaya),
                   Commune = MapCommune(xpoStock.Commune),
                   Adress = xpoStock.Adress,
                   ProductLines = MapProdcutLine(xpoStock.ProductLines),
               };
           return stock;
       }

       public static Sector MapSector(XpoSector xpoSector)
       {
           var sector = new Sector
               {
               id = xpoSector.Oid,
               Name = xpoSector.Name,
               Wilaya = MapWilaya(xpoSector.Wilaya),
               Commune = MapCommune(xpoSector.Commune)
           };
           return sector;
       }

        private static List<ProductLine> MapProdcutLine(IEnumerable<XpoProductLine> productLines)
        {
            return productLines.Select(xpoProductLine => new ProductLine
                {
                    Quantity = xpoProductLine.Quantity, id = xpoProductLine.Oid, Product = MapProduct(xpoProductLine.Product)
                }).ToList();
        }

        public static Order MapOrder(XpoOrder xpoOrder)
        {
            var order = new Order
                {
                id = xpoOrder.Oid,
                OrderLines = MapOrderLine(xpoOrder.OrderLines),
                NumCommande = xpoOrder.NumCommadne,
                Client = MapClient(xpoOrder.Client),
                Priorite = xpoOrder.Priorite,
                Etat = xpoOrder.Etat,
                LivraisonSurPlace = xpoOrder.LivraisonSurPlace,
                DateCommande = xpoOrder.DateCommande,
                Montant = xpoOrder.Montant,
                newObject = false
            };
            return order;
        }

        private static List<OrderLine> MapOrderLine(IEnumerable<XpoOrderLine> orderLines)
        {
            return orderLines.Select(xpoOrderLine => new OrderLine
            {
                id = xpoOrderLine.Oid,
                Quantity = xpoOrderLine.Quantity,
                Product = MapProduct(xpoOrderLine.Product)
            }).ToList();
        }

        public static Product MapProduct(XpoProduct product)
        {
            return new Product
                {
                    id = product.Oid,
                    Name = product.Name,
                    QuantiteMin = product.QuantityMin,
                    Category = MapCategory(product.Category),
                    Marque = MapMarque(product.Marque),
                    Fournisseur = MapFournisseur(product.Fournisseur),
                    DateEntree = product.DateEntree,
                    TypeGestion = product.TypeGestion,
                    newObject = false
                };
        }

        public static Marque MapMarque(XpoMarque marque)
        {
            return new Marque
                {
                    Name = marque.Name,
                    id = marque.Oid,
                    newObject = false
                };
        }

        public static Category MapCategory(XpoCategory category)
        {
            return new Category
                {
                    id = category.Oid,
                    Name = category.Name,
                    Description = category.Description,
                    newObject = false
                };
        }

        public static Fournisseur MapFournisseur(XpoFournisseur fournisseur)
        {
            return new Fournisseur
            {
                Name = fournisseur.Name,
                id = fournisseur.Oid,
                newObject = false
            };
        }

        public static Wilaya MapWilaya(XpoWilaya xpoWilaya)
        {
            return new Wilaya
                {
                    Code = xpoWilaya.Code,
                    Name = xpoWilaya.Name,
                    id = xpoWilaya.Oid,
                    Communes = MapCommunes(xpoWilaya.Communes).ToList()
                };
        }

        private static Commune MapCommune(XpoCommune xpoCommune)
        {
            return new Commune
            {
                Name = xpoCommune.Name,
                id = xpoCommune.Oid,
            };
        }

        private static IEnumerable<Commune> MapCommunes(IEnumerable<XpoCommune> communes)
        {

            var listeCommunes = communes.Select(xpoCommune => new Commune
                {
                    Name = xpoCommune.Name,
                    id = xpoCommune.Oid
                });

            return listeCommunes;
        }

        public static AgentTerrain MapAgentTerrain(XpoAgentTerrain xpoAgentTerrain)
        {
            return new AgentTerrain
                {
                    Name = xpoAgentTerrain.Name,
                    id = xpoAgentTerrain.Oid
                };
        }

        public static Client MapClient(XpoClient xpoClient)
        {
            return new Client
                {
                    id = xpoClient.Oid,
                    Name = xpoClient.Name,
                    PreNom = xpoClient.PreName,
                    Address = xpoClient.Address
                };
        }
    }
}
