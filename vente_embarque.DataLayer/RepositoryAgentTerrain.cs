using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;
using vente_embarque.Core.Domain;
using vente_embarque.Core.Domain.Query;
using vente_embarque.DataLayer.Entities;
using vente_embarque.Model;

namespace vente_embarque.DataLayer
{
    public class RepositoryAgentTerrain: IRepository<AgentTerrain,Guid>
    {
        public AgentTerrain FindBy(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AgentTerrain> FindAll()
        {
            var listeAgentTerrain = new List<AgentTerrain>();
            var config = new AppSettingsReader();
            using (
                var uow = new UnitOfWork()
                {
                    ConnectionString = ((string)config.GetValue("connect", typeof(string)))
                })
            {
                var AgentTerrains = new XPCollection<XpoAgentTerrain>(uow);
                listeAgentTerrain.AddRange(AgentTerrains.Select(Map.MapInverse.MapAgentTerrain));
            }
            return listeAgentTerrain;
        }

        public IEnumerable<AgentTerrain> FindBy(Query query)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AgentTerrain> FindBy(Query query, int index, int count)
        {
            throw new NotImplementedException();
        }

        public void SaveAll(IEnumerable<AgentTerrain> entities)
        {
            throw new NotImplementedException();
        }

        public List<AgentTerrain> FindAll(List<Query> entities)
        {
            throw new NotImplementedException();
        }

        public void Save(AgentTerrain entity)
        {
            var config = new AppSettingsReader();
            using (
                var uow = new UnitOfWork
                    {
                        ConnectionString = ((string)config.GetValue("connect", typeof(string)))
                    })
            {
                Map.Map.MapAgentTerrain(entity, uow);
                uow.CommitChanges();
            }
        }

        public void Add(AgentTerrain entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(AgentTerrain entity)
        {
            throw new NotImplementedException();
        }
    }
}
