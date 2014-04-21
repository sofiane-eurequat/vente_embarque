using System;
using System.Collections.Generic;
using System.Linq;
using vente_embarque.Core.Domain;

namespace vente_embarque.Model
{
    public class Sector:EntityBase<Guid>,IAggregateRoot
    {
        public string Name { get; set; }
        public string Wilaya { get; set; }
        public string Commune { get; set; }
        public List<Client> Clients { get; set; }
        //TODO: lati et long du perimetre
        protected override void Validate()
        {
            throw new NotImplementedException();
        }

        public Client GetClient(string nom)
        {
            var clients= Clients.Where(c => c.Name == nom);
            return clients.Any() ? clients.First() : null;
        }
    }

    public static class FactorySector
    {
        public static Sector CreateSector(string name, string wilaya, string commune)
        {
            var sector = new Sector {id = Guid.NewGuid(), Name = name, Wilaya = wilaya, Commune = commune};
            return sector;
        }

    /*    public static Sector CreateSector(string name, Wilaya wilaya, Commune commune)
        {
            var sector = new Sector { Name = name, id = Guid.NewGuid(), Wilaya = wilaya, Commune = commune };
            return sector;
        }
 */
        public static Client CreateClient(string nom, string prenom, Sector sector)
        {
            var client = new Client {id = Guid.NewGuid(), Name = nom, PreNom = prenom};
            if (sector.Clients == null) sector.Clients = new List<Client>();
            sector.Clients.Add(client);
            return client;
        }
    }
}