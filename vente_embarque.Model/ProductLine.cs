using System;
using vente_embarque.Core.Domain;

namespace vente_embarque.Model
{
    public class ProductLine : EntityBase<Guid>
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}