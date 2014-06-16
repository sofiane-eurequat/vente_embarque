using System;
using DevExpress.Xpo;

namespace vente_embarque.DataLayer.Entities
{
    public class XpoUser : XPBaseObject
    {
        public XpoUser()
        {

        }

        public XpoUser(Session session)
            : base(session)
        {

        }

        private Guid _oid;
        [Key]
        public Guid Oid
        {
            get { return _oid; }
            set { SetPropertyValue("Oid", ref _oid, value); }
        }

        private String _idUser;
        public String IdUser
        {
            get { return _idUser; }
            set { SetPropertyValue("Name", ref _idUser, value); }
        }

        private String _login;
        public String Login
        {
            get { return _login; }
            set { SetPropertyValue("Name", ref _login, value); }
        }

        private String _password;
        public String Password
        {
            get { return _password; }
            set { SetPropertyValue("Name", ref _password, value); }
        }
    }
}
