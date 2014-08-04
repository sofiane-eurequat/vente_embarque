using System;
using DevExpress.Xpo;

namespace vente_embarque.DataLayer.Entities.Stock
{
    public class XpoFournisseur:XPBaseObject
    {
        public XpoFournisseur()
            : base()
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public XpoFournisseur(Session session)
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
    }
}
