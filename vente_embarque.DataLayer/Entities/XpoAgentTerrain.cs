using System;
using DevExpress.Xpo;
using vente_embarque.DataLayer.Entities.Orders;

namespace vente_embarque.DataLayer.Entities
{
    public class XpoAgentTerrain: XPBaseObject
    {
        public XpoAgentTerrain()
        {
            
        }

        public XpoAgentTerrain(Session session)
            : base(session)
        {

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


        private XpoSector _secteur;
        [Association("XpoAgentTerrain-XpoSector")]
        public XpoSector Secteur
        {
            get { return _secteur; }
            set { SetPropertyValue("Secteur", ref _secteur, value); }
        }
    }
}
