using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;
using vente_embarque.DataLayer.Entities.Orders;

namespace vente_embarque.DataLayer.Helper
{
    public class XpoCommune: XPBaseObject
    {

          public XpoCommune()
            : base()
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

          public XpoCommune(Session session)
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


          private int _CodeWilaya;
          public int CodeWilaya
          {
              get { return _CodeWilaya; }
              set { SetPropertyValue("CodeWilaya", ref _CodeWilaya, value); }
          }


          private XpoWilaya _Wilaya;
          [Aggregated, Association("XpoWilaya-XpoCommunes")]
          public XpoWilaya Wilaya
          {
              get { return _Wilaya; }
              set { SetPropertyValue("Wilaya", ref _Wilaya, value); }
          }
        /*
          [Association("XpoCommune-XpoSectors")]
          public XPCollection<XpoSector> Secteurs
          {
              get { return GetCollection<XpoSector>("Secteurs"); }
          }*/
    }
}
