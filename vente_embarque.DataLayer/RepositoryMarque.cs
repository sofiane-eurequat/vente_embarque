using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;
using vente_embarque.Core.Domain;
using vente_embarque.Core.Domain.Query;
using vente_embarque.DataLayer.Entities.Stock;
using vente_embarque.Model;

namespace vente_embarque.DataLayer
{
    public class RepositoryMarque: IRepository<Marque,Guid>
    {
        public Marque FindBy(Guid id)
        {
            var config = new AppSettingsReader();
            using (
                var uow = new UnitOfWork
                {
                    ConnectionString = ((string)config.GetValue("connect", typeof(string)))
                })
            {
                var xpomarque = uow.GetObjectByKey<XpoMarque>(id);
                var marque = Map.MapInverse.MapMarque(xpomarque);
                return marque;
            }
        }

        public IEnumerable<Marque> FindAll()
        {
            var listeMarque = new List<Marque>();
            var config = new AppSettingsReader();
            using (
                var uow = new UnitOfWork
                {
                    ConnectionString = ((string)config.GetValue("connect", typeof(string)))
                })
            {
                var Marques = new XPCollection<XpoMarque>(uow);
                listeMarque.AddRange(Marques.Select(Map.MapInverse.MapMarque));
            }
            return listeMarque;
        }

        public IEnumerable<Marque> FindBy(Query query)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Marque> FindBy(Query query, int index, int count)
        {
            throw new NotImplementedException();
        }

        public void SaveAll(IEnumerable<Marque> entities)
        {
            throw new NotImplementedException();
        }

        public List<Marque> FindAll(List<Query> entities)
        {
            throw new NotImplementedException();
        }

        public void Save(Marque entity)
        {
            var config = new AppSettingsReader();
            using (
                var uow = new UnitOfWork
                {
                    ConnectionString = ((string)config.GetValue("connect", typeof(string)))
                })
            {
                Map.Map.MapMarque(entity, uow);
                uow.CommitChanges();
            }
        }

        public void Add(Marque entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(Marque entity)
        {
            var config = new AppSettingsReader();
            using (
                var uow = new UnitOfWork
                {
                    ConnectionString = ((string)config.GetValue("connect", typeof(string)))
                })
            {
                var repositoryMarque = new RepositoryMarque();
                var marque = repositoryMarque.FindBy(entity.id);
                uow.Delete(marque);
            }
        }
    }
}
