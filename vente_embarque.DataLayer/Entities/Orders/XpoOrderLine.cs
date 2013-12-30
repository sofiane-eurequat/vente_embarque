using System;
using DevExpress.Xpo;
using vente_embarque.DataLayer.Entities.Stock;

namespace vente_embarque.DataLayer.Entities.Orders
{
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