using System;
using vente_embarque.Core.Domain;

namespace vente_embarque.Model
{
    public class Delivery:EntityBase<Guid>
    {
        public DateTime DeliveryDate { get; set; }
        public string DeliveryAdress { get; set; }

        protected override void Validate()
        {
            throw new System.NotImplementedException();
        }

    }
}