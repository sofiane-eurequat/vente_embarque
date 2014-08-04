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
    public class RepositoryFournisseur:IRepository<Fournisseur,Guid>
    {
        public Fournisseur FindBy(Guid id)
        {
            var config = new AppSettingsReader();
            using (
                var uow = new UnitOfWork
                {
                    ConnectionString = ((string)config.GetValue("connect", typeof(string)))
                })
            {
                var xpoFournisseur = uow.GetObjectByKey<XpoFournisseur>(id);
                var fournisseur = Map.MapInverse.MapFournisseur(xpoFournisseur);
                return fournisseur;
            }
        }

        public IEnumerable<Fournisseur> FindAll()
        {
            var listeFournisseur = new List<Fournisseur>();
            var config = new AppSettingsReader();
            using (
                var uow = new UnitOfWork
                {
                    ConnectionString = ((string)config.GetValue("connect", typeof(string)))
                })
            {
                var fournisseurs = new XPCollection<XpoFournisseur>(uow);
                listeFournisseur.AddRange(fournisseurs.Select(Map.MapInverse.MapFournisseur));
            }
            return listeFournisseur;
        }

        public IEnumerable<Fournisseur> FindBy(Query query)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Fournisseur> FindBy(Query query, int index, int count)
        {
            throw new NotImplementedException();
        }

        public void SaveAll(IEnumerable<Fournisseur> entities)
        {
            throw new NotImplementedException();
        }

        public List<Fournisseur> FindAll(List<Query> entities)
        {
            throw new NotImplementedException();
        }

        public void Save(Fournisseur entity)
        {
            var config = new AppSettingsReader();
            using (
                var uow = new UnitOfWork
                {
                    ConnectionString = ((string)config.GetValue("connect", typeof(string)))
                })
            {
                Map.Map.MapFournisseur(entity, uow);
                uow.CommitChanges();
            }
        }

        public void Add(Fournisseur entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(Fournisseur entity)
        {
            var config = new AppSettingsReader();
            using (
                var uow = new UnitOfWork
                {
                    ConnectionString = ((string)config.GetValue("connect", typeof(string)))
                })
            {
                var fournisseur = uow.GetObjectByKey<XpoFournisseur>(entity.id);
                fournisseur.Delete();
                uow.CommitChanges();
            }
        }
    }
}
