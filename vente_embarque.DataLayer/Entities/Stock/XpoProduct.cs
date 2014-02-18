using System;
using DevExpress.Xpo;
using vente_embarque.DataLayer.Entities.Orders;
using vente_embarque.Model.Enum;

namespace vente_embarque.DataLayer.Entities.Stock
{
    public class XpoProduct: XPBaseObject
    {

        public XpoProduct()
            : base()
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public XpoProduct(Session session)
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



        private GestionProduit _TypeGestion;
        public GestionProduit TypeGestion
        {
            get { return _TypeGestion; }
            set { SetPropertyValue("TypeGestion", ref _TypeGestion, value); }
        }

        private int _QuantityMin;
        public int QuantityMin
        {
            get { return _QuantityMin; }
            set { SetPropertyValue("QuantityMin", ref _QuantityMin, value); }
        }


        private XpoCategory _Category;

        public XpoCategory Category
        {
            get { return _Category; }
            set { SetPropertyValue("Category", ref _Category, value); }
        }

        private XpoMarque _Marque;

        public XpoMarque Marque
        {
            get { return _Marque; }
            set { SetPropertyValue("Marque", ref _Marque, value); }
        }


        [Aggregated, Association("XpoProduct-XpoproductLine")]
        XPCollection<XpoProductLine> ProductLines
        {
            get { return GetCollection<XpoProductLine>("ProductLines"); }
        }



      
        [Association("XpoProduct-XpoOrderLine")]
        XPCollection<XpoOrderLine> OrderLines
        {
            get { return GetCollection<XpoOrderLine>("OrderLines"); }
        }
    }
}