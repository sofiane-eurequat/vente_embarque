using System;
using DevExpress.Xpo;
using vente_embarque.DataLayer.Helper;
using vente_embarque.Model;

namespace vente_embarque.DataLayer.Entities.Orders
{
    public class XpoSector : XPBaseObject
    {

        public XpoSector()
            : base()
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public XpoSector(Session session)
            : base(session)
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }


        private Guid _oid;
        [Key]
        public Guid Oid
        {
            get { return _oid; }
            set { SetPropertyValue("Oid", ref _oid, value); }
        }

        private String _name;

        public String Name
        {
            get { return _name; }
            set { SetPropertyValue("Name", ref _name, value); }
        }

        private XpoWilaya _wilaya;

        public XpoWilaya Wilaya
        {
            get { return _wilaya; }
            set { SetPropertyValue("Name", ref _wilaya, value); }
        }

        private XpoCommune _commune;

        public XpoCommune Commune
        {
            get { return _commune; }
            set { SetPropertyValue("Name", ref _commune, value); }
        }

        [Association("XpoSector-XpoClient")]
        public XPCollection<XpoClient> Clients
        {
            get { return GetCollection<XpoClient>("Clients"); }
        }

        [Aggregated, Association("XpoAgentTerrain-XpoSector")]
        public XPCollection<XpoAgentTerrain> AgentTerrains
        {
            get { return GetCollection<XpoAgentTerrain>("AgentTerrains"); }
        }
    }
}