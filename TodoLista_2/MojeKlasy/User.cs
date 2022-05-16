using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoLista_1.MojeKlasy
{
    public class User
    {
        public Guid Id;

        public string Imie;

        public string Login;

        public string Hasło;

        public User(Guid id, string imie, string login, string haslo)
        {
            Id = id;
            Imie = imie;
            Login = login;
            Hasło = haslo;

        }


    }
}
