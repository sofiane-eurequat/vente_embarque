﻿using System;
using DevExpress.Xpo;

namespace vente_embarque.DataLayer.Entities.Stock
{
    public class XpoCategory: XPBaseObject
    {

        public XpoCategory()
            : base()
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public XpoCategory(Session session)
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

        private String _description;
        public String Description
        {
            get { return _description; }
            set { SetPropertyValue("Description", ref _description, value); }
        }

    }
}