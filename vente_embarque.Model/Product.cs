using System;
using vente_embarque.Core.Domain;

namespace vente_embarque.Model
{
    public class Product : EntityBase<Guid>
    {
        public string Name { get; set; }
        public int QuantiteMin { get; set; }
        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}