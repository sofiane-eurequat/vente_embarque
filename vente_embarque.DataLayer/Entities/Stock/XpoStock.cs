using System;
using DevExpress.Xpo;
using vente_embarque.DataLayer.Helper;

namespace vente_embarque.DataLayer.Entities.Stock
{
    public class XpoStock : XPBaseObject
    {

          public XpoStock()
          {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

          public XpoStock(Session session)
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

        private string _name;
        public string Name
        {
            get { return _name; }
            set { SetPropertyValue("Name", ref _name, value); }
        }

        private XpoWilaya _wilaya;
        public XpoWilaya Wilaya
        {
            get { return _wilaya; }
            set { SetPropertyValue("Category", ref _wilaya, value); }
        }

        private XpoCommune _commune;
        public XpoCommune Commune
        {
            get { return _commune; }
            set { SetPropertyValue("Category", ref _commune, value); }
        }

        private string _adress;
        public string Adress
        {
            get { return _adress; }
            set { SetPropertyValue("Name", ref _adress, value); }
        }

        [Aggregated, Association("XpoStock-XpoproductLine")]
        public XPCollection<XpoProductLine> ProductLines
        {
            get { return GetCollection<XpoProductLine>("ProductLines"); }
        }

    }
}