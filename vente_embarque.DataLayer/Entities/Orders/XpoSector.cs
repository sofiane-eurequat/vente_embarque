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


        private Guid _Oid;

        [Key]
        public Guid Oid
        {
            get { return _Oid; }
            set { SetPropertyValue("Oid", ref _Oid, value); }
        }

        private String _Name;

        public String Name
        {
            get { return _Name; }
            set { SetPropertyValue("Name", ref _Name, value); }
        }

        private XpoWilaya _Wilaya;
        [Aggregated, Association("XpoSector-XpoWilaya")]
        public XpoWilaya Wilaya
        {
            get { return _Wilaya; }
            set { SetPropertyValue("Wilaya", ref _Wilaya, value); }
        }

        private XpoCommune _Commune;
        [Aggregated, Association("XpoSector-XpoCommunes")]
        public XpoCommune Commune
        {
            get { return _Commune; }
            set { SetPropertyValue("Commune", ref _Commune, value); }
        }

        [Aggregated, Association("XpoSector-XpoClient")]
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