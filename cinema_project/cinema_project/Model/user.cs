using System;
using System.Collections.Generic;
using System.Text;

namespace cinema_project.Model
{
    class user
    {
        int _id;
        string _name;
        string _female;
        string _email;
        string _login;
        int _password;
        long _nomer;

        public int id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public string female
        {
            get
            {
                return _female;
            }
            set
            {
                _female = value;
            }
        }

        public string email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
            }
        }
        public string login
        {
            get
            {
                return _login;
            }
            set
            {
                _login = value;
            }
        }
        public int password
        {
            get
            {
                return _password;
            }
            set
            {
                if (value < 8)
                    throw new Exception("больше буковок"); //через try catch обработать ошибку
                else
                    _password = value;
            }
        }
        public long nomer
        {
            get
            {
                return _nomer;
            }
            set
            {
                if (value > 11)
                    throw new Exception("");
                else
                    nomer = value;
                if (value < 11)
                    throw new Exception("");
                else
                    _nomer = value;

            }
        }

        public user (int id, string name, string female, string email, string login, int password, long nomer)
        {
            _id = id;
            _name = name;
            _female = female;
            _email = email;
            _login = login;
            _password = password;
            _nomer = nomer;
        }
    }
}
