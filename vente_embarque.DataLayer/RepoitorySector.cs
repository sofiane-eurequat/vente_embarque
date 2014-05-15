using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using vente_embarque.Core.Domain;
using vente_embarque.Core.Domain.Query;
using vente_embarque.DataLayer.Entities.Orders;
using vente_embarque.DataLayer.Helper;
using vente_embarque.Model;
using vente_embarque.DataLayer;

namespace vente_embarque.DataLayer
{
    public class RepositorySector : IRepository<Sector, Guid>
    {
        public Sector FindBy(Guid id)
        {
            var config = new AppSettingsReader();
            using (
                var uow = new UnitOfWork
                {
                    ConnectionString = ((string)config.GetValue("connect", typeof(string)))
                })
            {
                var sector = uow.GetObjectByKey<Sector>(id);
                return sector;
            }
        }

        public IEnumerable<Sector> FindAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Sector> FindBy(Query query)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Sector> FindBy(Query query, int index, int count)
        {
            throw new NotImplementedException();
        }

        public void SaveAll(IEnumerable<Sector> entities)
        {
            throw new NotImplementedException();
        }

        public List<Sector> FindAll(List<Query> entities)
        {
            throw new NotImplementedException();
        }

        public void Save(Sector entity)
        {
            var config = new AppSettingsReader();
            using (
                var uow = new UnitOfWork
                {
                    ConnectionString = ((string)config.GetValue("connect", typeof(string)))
                })
            {
                //var repositoryWilaya = new RepositoryWilaya();
                //var wilaya = repositoryWilaya.FindBy(entity.id);
                //var wilaya = uow.FindObject<XpoWilaya>(new BinaryOperator("Name",entity.Wilaya));
                //var communes = uow.FindObject<XpoCommune>(new BinaryOperator("Name", entity.Commune));
                Map.Map.MapSector(entity,uow );
                uow.CommitChanges();
            }
        }

        public void Add(Sector entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(Sector entity)
        {
            var config = new AppSettingsReader();
            using (
                var uow = new UnitOfWork
                    {
                        ConnectionString = ((string) config.GetValue("connect", typeof (string)))
                    })
            {
                var secteur = uow.GetObjectByKey<XpoSector>(entity.id);
                uow.Delete(secteur);
                uow.CommitChanges();
            }
        }
    }
}
