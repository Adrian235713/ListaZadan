using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoLista_1.Klasy
{
    public class UserManager
    {
        private List<User> _users;
        //--------------------------------------------------------
        public UserManager()
        {
            _users = new List<User>();

            _users.Add(new User(Guid.NewGuid(), "xxx", "xxx", "xxx"));

        }
        //--------------------------------------------------------
        public User WyszukajUrzytkownika(string login, string haslo)
        {

            foreach (User user in _users)
            {
                if (user.Login == login && user.Haslo == haslo)
                {
                    return user;
                }
            }

            return null;
        }
        //--------------------------------------------------------
        public bool CzyLoginWolny(string login)
        {
            foreach (User user in _users)
            {
                if (user.Login == login)
                {
                    return false;
                }
            }

            return true;
        }
        //--------------------------------------------------------
        public void AddUser(User user)
        {
            _users.Add(user);
        }


    }
}
