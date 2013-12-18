using System;
using vente_embarque.Core.Domain;

namespace vente_embarque.Model
{
    public class OrderLine:EntityBase<Guid>
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }

        public Boolean VerifyQuatityWithStock(Stock stock)
        {
            var quantiteStock = stock.GetQuantity(Product.Name);
            return quantiteStock >= Quantity;
        }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }

    }
}