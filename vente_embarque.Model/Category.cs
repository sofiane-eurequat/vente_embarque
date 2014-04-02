using System;
using vente_embarque.Core.Domain;

namespace vente_embarque.Model
{
    public class Category:EntityBase<Guid>, IAggregateRoot
    {
        public string Name { get; set; }
        public string Description { get; set; }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }

    public static class FactoryCategory
    {
        public static Category CreateCategory(string name, string description)
        {
            var category = new Category { id = Guid.NewGuid(), Name = name, Description = description };
            return category;
        }
    }
}