using System;
using vente_embarque.Core.Domain;

namespace vente_embarque.Model
{
    public class User:EntityBase<Guid>
    {
        public int IdUser { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        
        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }

    public static class FactoryUser
    {
        public static User CreateUser(int idUser, string login, string password)
        {
            var user = new User { id = Guid.NewGuid(), IdUser = idUser, Login = login, Password = password, newObject = true };
            return user;
        }
    }
}
