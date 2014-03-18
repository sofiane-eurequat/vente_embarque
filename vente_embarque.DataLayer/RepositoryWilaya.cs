using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using DevExpress.Xpo;
using vente_embarque.Core.Domain;
using vente_embarque.Core.Domain.Query;
using vente_embarque.DataLayer.Helper;
using vente_embarque.Model;

namespace vente_embarque.DataLayer
{
    public class RepositoryWilaya:IRepository<Wilaya,Guid>
    {
        public Wilaya FindBy(Guid id)
        {
            var config = new AppSettingsReader();
            using (
                var uow = new UnitOfWork
                {
                    ConnectionString = ((string)config.GetValue("connect", typeof(string)))
                })
            {
                var wilaya = new Wilaya();
                var wialaya=uow.GetObjectByKey<XpoWilaya>(id);
                //var wilayas = new XPCollection<XpoWilaya>(uow);
                //return wilaya = wilayas.First(w => w.Oid == id);

            }
            throw new NotImplementedException();
        }

        public IEnumerable<Wilaya> FindAll()
        {
            var listeWilaya = new List<Wilaya>();
            var config = new AppSettingsReader();
            using (
                var uow = new UnitOfWork
                    {
                    ConnectionString = ((string)config.GetValue("connect", typeof(string)))
                })
            {
                var Wilayas = new XPCollection<XpoWilaya>(uow);
                listeWilaya.AddRange(Wilayas.Select(Map.MapInverse.MapWilaya));
            }
            return listeWilaya;
        }

        public IEnumerable<Wilaya> FindBy(Query query)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Wilaya> FindBy(Query query, int index, int count)
        {
            throw new NotImplementedException();
        }

        public void SaveAll(IEnumerable<Wilaya> entities)
        {
            throw new NotImplementedException();
        }

        public List<Wilaya> FindAll(List<Query> entities)
        {
            throw new NotImplementedException();
        }

        public void Save(Wilaya entity)
        {
            throw new NotImplementedException();
        }

        public void Add(Wilaya entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(Wilaya entity)
        {
            throw new NotImplementedException();
        }
    }
}