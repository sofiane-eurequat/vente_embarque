using System;
using vente_embarque.Core.Domain;

namespace vente_embarque.Model
{
    public class Fournisseur:EntityBase<Guid>, IAggregateRoot
    {
        public string Name { get; set; }
        
        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }

    public static class FactoryFournisseur
    {
        public static Fournisseur CreateFournisseur(string name)
        {
            var fournisseur = new Fournisseur { id = Guid.NewGuid(), Name = name, newObject = true };
            return fournisseur;
        }
    }
}
