using System;
using vente_embarque.Core.Domain;

namespace vente_embarque.Model
{
    public class Marque:EntityBase<Guid>, IAggregateRoot
    {
        public string Name { get; set; }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }

    public static class FactoryMarque
    {
        public static Marque CreateMarque(string name)
        {
            var marque = new Marque { id = Guid.NewGuid(), Name = name, newObject = true };
            return marque;
        }
    }
}