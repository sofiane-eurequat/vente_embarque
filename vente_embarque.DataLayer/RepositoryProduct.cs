using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using DevExpress.Xpo;
using vente_embarque.Core.Domain;
using vente_embarque.Core.Domain.Query;
using vente_embarque.DataLayer.Entities.Stock;
using vente_embarque.Model;

namespace vente_embarque.DataLayer
{
    public class RepositoryProduct:IRepository<Product,Guid>
    {
        public Product FindBy(Guid id)
        {
            var config = new AppSettingsReader();
            using (
                var uow = new UnitOfWork
                {
                    ConnectionString = ((string)config.GetValue("connect", typeof(string)))
                })
            {
                var xpoproduct = uow.GetObjectByKey<XpoProduct>(id);
                var product = Map.MapInverse.MapProduct(xpoproduct);
                return product;
            }
        }

        public IEnumerable<Product> FindAll()
        {
            var listeProduct = new List<Product>();
            AppSettingsReader config = new AppSettingsReader();
            using (
                var uow = new UnitOfWork
                    {
                        ConnectionString = ((string)config.GetValue("connect", typeof(string)))
                    })
            {
                var Products = new XPCollection<XpoProduct>(uow);
                listeProduct.AddRange(Products.Select(Map.MapInverse.MapProduct));
            }
            return listeProduct;
        }

        public IEnumerable<Product> FindBy(Query query)
        {
            var listeProduct = new List<Product>();
            var config = new AppSettingsReader();
            using (
                var uow = new UnitOfWork
                    {
                    ConnectionString = ((string)config.GetValue("connect", typeof(string)))
                })
            {

                var Products = new XPCollection<XpoProduct>(uow);
                IEnumerable<XpoProduct> produitFiltre=null;
                var requete = query.Criteria.First(e => e.PropertyName == "Name");
                if (requete != null)
                    produitFiltre = Products.Where(e => e.Name == (string) requete.Value);

                if (produitFiltre != null) 
                    listeProduct.AddRange(produitFiltre.Select(Map.MapInverse.MapProduct));
            }
            return listeProduct;
        }

        public IEnumerable<Product> FindBy(Query query, int index, int count)
        {
            throw new NotImplementedException();
        }

        public void SaveAll(IEnumerable<Product> entities)
        {
            throw new NotImplementedException();
        }

        public List<Product> FindAll(List<Query> entities)
        {
            throw new NotImplementedException();
        }

        public void Save(Product entity)
        {
            var config = new AppSettingsReader();

            using (
                var uow = new UnitOfWork
                {
                    ConnectionString = ((string)config.GetValue("connect", typeof(string)))
                })
            {
                
                Map.Map.MapProduct(entity, uow);
                uow.CommitChanges();
            }
        }

        public void Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(Product entity)
        {
            var config = new AppSettingsReader();
            using (
                var uow = new UnitOfWork
                {
                    ConnectionString = ((string)config.GetValue("connect", typeof(string)))
                })
            {
                var product = uow.GetObjectByKey<XpoProduct>(entity.id);
                uow.Delete(product); 
                uow.CommitChanges();
            }
        }

        public void Remove(Guid id)
        {
            var config = new AppSettingsReader();
            using (
                var uow = new UnitOfWork
                {
                    ConnectionString = ((string)config.GetValue("connect", typeof(string)))
                })
            {
                var product = uow.GetObjectByKey<XpoProduct>(id);
                product.Delete();
                uow.CommitChanges();
            }
        }
    }
}