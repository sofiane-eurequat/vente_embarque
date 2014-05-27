﻿using System;
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

        public Client Client { get; set; }
        public List<OrderLine> OrderLines { get; set; }
        public Priorite Priorite { get; set; }
        //public Delivery Livraison { get; set; }
        protected override void Validate()
        {
            throw new NotImplementedException();
        }


    }
    public static class FactoryOrder
    {
        public static Order CreateOrder(Stock stock,Client client,IEnumerable<OrderLine> orderLines, String deliveryAdress, Priorite priorite=Priorite.Normal, DateTime deliveryDate=default(DateTime))
        {
            var order = new Order { id = Guid.NewGuid(), Client = client, Priorite = priorite, newObject = true };
            
            if (orderLines != null)
            {
                if(order.OrderLines==null) order.OrderLines=new List<OrderLine>();
                foreach (var orderLine in orderLines)
                {
                    if (!orderLine.VerifyQuatityWithStock(stock)) return null;
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
