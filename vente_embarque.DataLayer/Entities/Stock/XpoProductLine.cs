using System;
using DevExpress.Xpo;

namespace vente_embarque.DataLayer.Entities.Stock
{
    public  class XpoProductLine: XPBaseObject
    {

        public XpoProductLine()
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public XpoProductLine(Session session)
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

        private XpoProduct _product;
        [Association("XpoProduct-XpoproductLine")]
        public XpoProduct Product
        {
            get { return _product; }
            set { SetPropertyValue("Product", ref _product, value); }
        }


        private int _quantity;
        public int Quantity
        {
            get { return _quantity; }
            set { SetPropertyValue("Quantity", ref _quantity, value); }
        }

        private XpoStock _stock;
        [Association("XpoStock-XpoproductLine")]
        public XpoStock Stock
        {
            get { return _stock; }
            set { SetPropertyValue("Stock", ref _stock, value); }
        }

    }
}