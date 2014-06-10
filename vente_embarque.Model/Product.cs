using System;
using vente_embarque.Core.Domain;
using vente_embarque.Model.Enum;

namespace vente_embarque.Model
{
    public class Product : EntityBase<Guid>,IAggregateRoot
    {
        public Marque Marque { get; set; }
        public string Name { get; set; }
        public int QuantiteMin { get; set; }
        public Category Category { get; set; }
        public string Fournisseur { get; set; }
        public string Remarque { get; set; }
        public string SiteReference { get; set; }
        public GestionProduit TypeGestion { get; set; }
        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
    public class FactoryProduct
    {
        public static Product CreateProduct(string name, int quantiteMin,Category category, Marque marque, string remarque = "", string reference = "", string fournisseur = "", GestionProduit typeGestion = GestionProduit.Aucune)
        {
            var product = new Product
                {
                    Name = name, 
                    QuantiteMin = quantiteMin, 
                    id = Guid.NewGuid(),
                    Remarque = remarque,
                    SiteReference = reference,
                    Fournisseur = fournisseur,
                    Marque = marque,
                    Category = category,
                    TypeGestion = typeGestion,
                    newObject = true
                };
            return product;
        }
    }
}