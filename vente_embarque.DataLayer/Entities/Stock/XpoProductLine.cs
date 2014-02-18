using System;
using DevExpress.Xpo;

namespace vente_embarque.DataLayer.Entities.Stock
{
    public  class XpoProductLine: XPBaseObject
    {

        public XpoProductLine()
            : base()
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


        private Guid _Oid;
        [Key]
        public Guid Oid
        {
            get { return _Oid; }
            set { SetPropertyValue("Oid", ref _Oid, value); }
        }

        private XpoProduct _Product;
        [ Association("XpoProduct-XpoproductLine")]
        public XpoProduct Product
        {
            get { return _Product; }
            set { SetPropertyValue("Product", ref _Product, value); }
        }


        private int _Quantity;
        public int Quantity
        {
            get { return _Quantity; }
            set { SetPropertyValue("Quantity", ref _Quantity, value); }
        }

        private XpoStock _Stock;
        [Aggregated, Association("XpoStock-XpoproductLine")]
        public XpoStock Stock
        {
            get { return _Stock; }
            set { SetPropertyValue("Stock", ref _Stock, value); }
        }

    }
}