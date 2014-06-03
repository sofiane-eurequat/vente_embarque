using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;
using vente_embarque.DataLayer.Entities.Stock;
using vente_embarque.Model;
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
        [Association("XpoOrder-XpoClient")]
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

        private Delivery _Delivery;

        public Delivery Delivery
        {
            get { return _Delivery; }
            set { SetPropertyValue("Delivery", ref _Delivery, value); }
        }

    }
}
