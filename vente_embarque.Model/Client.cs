using System;
using vente_embarque.Core.Domain;

namespace vente_embarque.Model
{
    public class Client:EntityBase<Guid>
    {
        public string Name { get; set; }
        public string PreNom { get; set; }
        public string Address { get; set; }
        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}