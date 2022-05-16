using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoLista_1.MojeKlasy
{

    public class UserManager
    {
        private List<User> _users;

        public UserManager()
        {
            _users = new List<User>();

            _users.Add(new User(Guid.NewGuid(), "test", "test", "test"));

        }

        public User WyszukajUrzytownika(string login, string haslo)
        {
            foreach (User user in _users)
            {
                if (user.Login == login && user.Hasło == haslo)
                {
                    return user;
                }
            }

            return null;
        }


        public void AddUser(User user)
        {
            _users.Add(user);
        }


    }
}
