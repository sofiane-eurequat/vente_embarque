using System;
using DevExpress.Xpo;

namespace vente_embarque.DataLayer.Entities.Orders
{
    public  class XpoClient: XPBaseObject
    {

        public XpoClient()
            : base()
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public XpoClient(Session session)
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


        private String _PreName;
        public String PreName
        {
            get { return _PreName; }
            set { SetPropertyValue("PreName", ref _PreName, value); }
        }



        private String _Address;
        public String Address
        {
            get { return _Address; }
            set { SetPropertyValue("Address", ref _Address, value); }
        }


        [Aggregated, Association("XpoOrder-XpoClient")]
        public XPCollection<XpoOrder> Orders
        {
            get { return GetCollection<XpoOrder>("Orders"); }
        }

        private XpoSector _Sector;
        [Aggregated, Association("XpoSector-XpoClient")]
        public XpoSector Sector
        {
            get { return _Sector; }
            set { SetPropertyValue("Sector", ref _Sector, value); }
        }
    }
}