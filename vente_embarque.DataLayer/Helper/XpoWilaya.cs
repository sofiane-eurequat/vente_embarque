using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;
using vente_embarque.DataLayer.Entities.Orders;

namespace vente_embarque.DataLayer.Helper
{
    public class XpoWilaya: XPBaseObject
    {

          public XpoWilaya()
            : base()
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

          public XpoWilaya(Session session)
            : base(session)
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }


          [Key(AutoGenerate = true)]

          public Guid Oid;


        private String _Name;
        public String Name
        {
            get { return _Name; }
            set { SetPropertyValue("Name", ref _Name, value); }
        }


        private int _Code;
        public int Code
        {
            get { return _Code; }
            set { SetPropertyValue("Code", ref _Code, value); }
        }

        [Aggregated, Association("XpoWilaya-XpoCommunes")]
        public XPCollection<XpoCommune> Communes
        {
            get { return GetCollection<XpoCommune>("Communes"); }
        }
    }
}
