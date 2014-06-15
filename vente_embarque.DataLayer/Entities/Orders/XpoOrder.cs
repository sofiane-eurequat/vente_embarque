using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;
using vente_embarque.DataLayer.Entities.Stock;
using vente_embarque.Model;
using vente_embarque.Model.Enum;

namespace vente_embarque.DataLayer.Entities.Orders
{
    public class XpoOrder: XPBaseObject
    {

          public XpoOrder()
            : base()
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

          public XpoOrder(Session session)
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

        private int _numCommande;
        public int NumCommadne
        {
            get { return _numCommande; }
            set { SetPropertyValue("Name", ref _numCommande, value); }
        }
        
        private XpoClient _client;
        [Association("XpoOrder-XpoClient")]
        public XpoClient Client
        {
            get { return _client; }
            set { SetPropertyValue("Client", ref _client, value); }
        }

        private Priorite _priorite;
        public Priorite Priorite
        {
            get { return _priorite; }
            set { SetPropertyValue("Priorite", ref _priorite, value); }
        }

        private bool _livraisonSurPlace;
        public bool LivraisonSurPlace
        {
            get { return _livraisonSurPlace; }
            set { SetPropertyValue("Priorite", ref _livraisonSurPlace, value); }
        }

        private GestionCommande _etat;
        public GestionCommande Etat
        {
            get { return _etat; }
            set { SetPropertyValue("Priorite", ref _etat, value); }
        }

        [Aggregated, Association("XpoOrder-XpoOrderLine")]
        public XPCollection<XpoOrderLine> OrderLines
        {
            get { return GetCollection<XpoOrderLine>("OrderLines"); }
        }

        private Delivery _delivery;

        public Delivery Delivery
        {
            get { return _delivery; }
            set { SetPropertyValue("Delivery", ref _delivery, value); }
        }

    }
}
