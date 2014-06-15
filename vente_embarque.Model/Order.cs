using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vente_embarque.Core.Domain;
using vente_embarque.Model.Enum;

namespace vente_embarque.Model
{
    public class Order : EntityBase<Guid>,IAggregateRoot
    {
        public int NumCommande { get; set; }
        public Client Client { get; set; }
        public List<OrderLine> OrderLines { get; set; }
        public Priorite Priorite { get; set; }
        public GestionCommande Etat { get; set; }
        public bool LivraisonSurPlace { get; set; }
        //public Delivery Livraison { get; set; }
        protected override void Validate()
        {
            throw new NotImplementedException();
        }


    }
    public static class FactoryOrder
    {
        public static Order CreateOrder(int numCommande, Client client, IEnumerable<OrderLine> orderLines, String deliveryAdress, bool livraisonSurPlace, Priorite priorite=Priorite.Normal, GestionCommande etat=GestionCommande.EnCours, DateTime deliveryDate=default(DateTime))
        {
            var order = new Order { id = Guid.NewGuid(), NumCommande = numCommande, Client = client, Priorite = priorite, Etat = etat, LivraisonSurPlace = livraisonSurPlace, newObject = true };
            
            if (orderLines != null)
            {
                if(order.OrderLines==null) order.OrderLines=new List<OrderLine>();
                foreach (var orderLine in orderLines)
                {
                    //if (!orderLine.VerifyQuatityWithStock(stock)) return null;
                    order.OrderLines.Add(orderLine);
                }
            }
            /*
            if (deliveryDate != default(DateTime))
                order.Livraison.DeliveryDate = deliveryDate;
            order.Livraison.DeliveryAdress = deliveryAdress;
            */
            return order;
        }
        public static OrderLine CreateOrderLine(Stock stock,string productName, int quantity)
        {
            var orderline = new OrderLine {id = Guid.NewGuid()};
            var product = stock.GetProduct(productName);
            if(product.Equals(null))  return null; 
            orderline.Product = product;
                        
            orderline.Quantity = quantity;
            return orderline.VerifyQuatityWithStock(stock) ? orderline : null;
        }
    }
}
