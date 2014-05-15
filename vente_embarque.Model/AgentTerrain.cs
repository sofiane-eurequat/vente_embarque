using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vente_embarque.Core.Domain;

namespace vente_embarque.Model
{
    public class AgentTerrain : EntityBase<Guid>, IAggregateRoot
    {
        public string Name { get; set; }
        public Sector Secteur { get; set; }
        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }

    public static class FactoryAgentTerrain
    {
        public static AgentTerrain CreateAgentTerrain(string name)
        {
            var agentterrain = new AgentTerrain {Name = name, id = Guid.NewGuid(), newObject = true};
            return agentterrain;
        }

        public static AgentTerrain CreateAgentTerrain(string name, Sector secteur)
        {
            var agentTerrainSecteur = new AgentTerrain { Name = name, id = Guid.NewGuid(), Secteur = secteur, newObject = true};
            return agentTerrainSecteur;
        }
    }
}

