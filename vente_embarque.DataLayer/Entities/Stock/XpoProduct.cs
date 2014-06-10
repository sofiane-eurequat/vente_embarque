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

        private GestionProduit _typeGestion;
        public GestionProduit TypeGestion
        {
            get { return _typeGestion; }
            set { SetPropertyValue("TypeGestion", ref _typeGestion, value); }
        }

        private int _quantityMin;
        public int QuantityMin
        {
            get { return _quantityMin; }
            set { SetPropertyValue("QuantityMin", ref _quantityMin, value); }
        }

        private XpoCategory _category;
        public XpoCategory Category
        {
            get { return _category; }
            set { SetPropertyValue("Category", ref _category, value); }
        }

        private XpoMarque _marque;
        public XpoMarque Marque
        {
            get { return _marque; }
            set { SetPropertyValue("Marque", ref _marque, value); }
        }

        private String _fournisseur;
        public String Fournisseur
        {
            get { return _fournisseur; }
            set { SetPropertyValue("Name", ref _fournisseur, value); }
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