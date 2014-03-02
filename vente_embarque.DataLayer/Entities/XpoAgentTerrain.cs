using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;
using vente_embarque.DataLayer.Entities.Orders;

namespace vente_embarque.DataLayer.Entities
{
    public class XpoAgentTerrain: XPBaseObject
    {
        public XpoAgentTerrain()
            : base()
        {
            
        }

        public XpoAgentTerrain(Session session)
            : base(session)
        {

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


        private XpoSector _Secteur;
        [Association("XpoAgentTerrain-XpoSector")]
        public XpoSector Secteur
        {
            get { return _Secteur; }
            set { SetPropertyValue("Secteur", ref _Secteur, value); }
        }
    }
}
