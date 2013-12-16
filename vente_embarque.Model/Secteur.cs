using System;
using System.Collections.Generic;
using vente_embarque.Core.Domain;

namespace vente_embarque.Model
{
    public class Sector:EntityBase<Guid>,IAggregateRoot
    {
        public string Name { get; set; }
        public List<Client> Clients { get; set; }
        //TODO: lati et long du perimetre
        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }

    public static class FactorySector
    {
        public static Sector CreateSector(string name)
        {
            var sector = new Sector {Name = name,id = Guid.NewGuid()};
            return sector;
        }
        public static Client CreateClient(string nom, string prenom, Sector sector)
        {
            var client = new Client {id = Guid.NewGuid(), Name = nom, PreNom = prenom};
            sector.Clients.Add(client);
            return client;
        }
    }
}