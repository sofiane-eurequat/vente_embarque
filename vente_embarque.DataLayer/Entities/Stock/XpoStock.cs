using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;
using vente_embarque.DataLayer.Entities.Stock;

namespace vente_embarque.DataLayer.Stock
{
    public class XpoStock : XPBaseObject
    {

          public XpoStock()
            : base()
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


        private Guid _Oid;
        [Key]
         public Guid Oid
        {
            get { return _Oid; }
            set { SetPropertyValue("Oid", ref _Oid, value); }
        }

        private string _Name;
        public string Name
        {
            get { return _Name; }
            set { SetPropertyValue("Name", ref _Name, value); }
        }
        [Aggregated, Association("XpoStock-XpoproductLine")]
        public XPCollection<XpoProductLine> ProductLines
        {
            get { return GetCollection<XpoProductLine>("ProductLines"); }
        }

    }
}