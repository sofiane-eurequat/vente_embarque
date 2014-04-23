using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;
using vente_embarque.Core.Domain;
using vente_embarque.Core.Domain.Query;
using vente_embarque.DataLayer.Entities.Orders;
using vente_embarque.Model;

namespace vente_embarque.DataLayer
{
    public class RepositoryClient : IRepository<Client, Guid>
    {
        public Client FindBy(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Client> FindAll()
        {
            var listeClient = new List<Client>();
            var config = new AppSettingsReader();
            using (
                var uow = new UnitOfWork
                    {
                    ConnectionString = ((string)config.GetValue("connect", typeof(string)))
                })
            {
                var Client = new XPCollection<XpoClient>(uow);
                listeClient.AddRange(Client.Select(Map.MapInverse.MapClient));
            }
            return listeClient;
        }

        public IEnumerable<Client> FindBy(Query query)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Client> FindBy(Query query, int index, int count)
        {
            throw new NotImplementedException();
        }

        public void SaveAll(IEnumerable<Client> entities)
        {
            throw new NotImplementedException();
        }

        public List<Client> FindAll(List<Query> entities)
        {
            throw new NotImplementedException();
        }

        public void Save(Client entity)
        {
            var config = new AppSettingsReader();
            using (
                var uow = new UnitOfWork
                {
                    ConnectionString = ((string)config.GetValue("connect", typeof(string)))
                })
            {
                Map.Map.MapClient(entity, uow);
                uow.CommitChanges();
            }
        }

        public void Add(Client entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(Client entity)
        {
            var config = new AppSettingsReader();
            using (
                var uow = new UnitOfWork
                {
                    ConnectionString = ((string)config.GetValue("connect", typeof(string)))
                })
            {
                var repositoryClient = new RepositoryClient();
                var client = repositoryClient.FindBy(entity.id);
                uow.Delete(client);
            }
        }
    }
}
