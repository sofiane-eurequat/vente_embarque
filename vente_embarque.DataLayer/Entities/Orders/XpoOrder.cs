using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;
using vente_embarque.DataLayer.Entities.Stock;
using vente_embarque.Model.Enum;

namespace vente_embarque.DataLayer.Entities.Orders
{
    public class XpoOrder: XPBaseObject
    {

          public XpoOrder()
            : base()
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

          public XpoOrder(Session session)
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

        private XpoClient _Client;
        [Aggregated, Association("XpoOrder-XpoClient")]
        public XpoClient Client
        {
            get { return _Client; }
            set { SetPropertyValue("Client", ref _Client, value); }
        }


        private Priorite _Priorite;
        public Priorite Priorite
        {
            get { return _Priorite; }
            set { SetPropertyValue("Priorite", ref _Priorite, value); }
        }



        [Aggregated, Association("XpoOrder-XpoOrderLine")]
        public XPCollection<XpoOrderLine> OrderLines
        {
            get { return GetCollection<XpoOrderLine>("OrderLines"); }
        }


    }

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

    public class XpoSector: XPBaseObject
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


        [Aggregated, Association("XpoSector-XpoClient")]
        public XPCollection<XpoClient> Clients
        {
            get { return GetCollection<XpoClient>("Clients"); }
        }




    }


    public class XpoOrderLine: XPBaseObject
    {

          public XpoOrderLine()
            : base()
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

          public XpoOrderLine(Session session)
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

        private int _Quantity;
        public int Quantity
        {
            get { return _Quantity; }
            set { SetPropertyValue("Quantity", ref _Quantity, value); }
        }

        private XpoProduct _Product;
        [Aggregated, Association("XpoProduct-XpoOrderLine")]
        public XpoProduct Product
        {
            get { return _Product; }
            set { SetPropertyValue("Product", ref _Product, value); }
        }


        private XpoOrder _Order;
        [Aggregated, Association("XpoOrder-XpoOrderLine")]
        public XpoOrder Order
        {
            get { return _Order; }
            set { SetPropertyValue("Order", ref _Order, value); }
        }
    }
}
