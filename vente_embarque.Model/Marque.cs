using System;
using vente_embarque.Core.Domain;

namespace vente_embarque.Model
{
    public class Marque:EntityBase<Guid>
    {
        public string Name { get; set; }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}