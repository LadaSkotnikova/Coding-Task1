using System;
using System.Collections.Generic;
using System.Text;

namespace cinema_project.Model
{
    class Korzina
    {
        Dictionary<dop, int> _essen;
        int _id;
        user _user;

        public Korzina (int id, user user, Dictionary<dop, int> essen)
        {
            _id = id;
            _user = user;
            _essen = essen;
        }

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
        public user user
        {
            get
            {
                return _user;
            }
            set
            {
                _user = value;
            }
        }
        public Dictionary<dop, int> essen
        {
            get
            {
                return _essen
            }
            set
            {
                _essen = value;
            }
        }

    }
}
