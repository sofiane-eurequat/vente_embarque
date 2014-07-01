using System;
using DevExpress.Xpo;
using vente_embarque.DataLayer.Entities.Stock;

namespace vente_embarque.DataLayer.Entities.Orders
{
    public class XpoOrderLine: XPBaseObject
    {

        public XpoOrderLine()
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


        private Guid _oid;
        [Key]
        public Guid Oid
        {
            get { return _oid; }
            set { SetPropertyValue("Oid", ref _oid, value); }
        }

        private int _quantity;
        public int Quantity
        {
            get { return _quantity; }
            set { SetPropertyValue("Quantity", ref _quantity, value); }
        }

        private XpoProduct _product;
        [Association("XpoProduct-XpoOrderLine")]
        public XpoProduct Product
        {
            get { return _product; }
            set { SetPropertyValue("Product", ref _product, value); }
        }


        private XpoOrder _order;
        [Association("XpoOrder-XpoOrderLine")]
        public XpoOrder Order
        {
            get { return _order; }
            set { SetPropertyValue("Order", ref _order, value); }
        }
    }
}