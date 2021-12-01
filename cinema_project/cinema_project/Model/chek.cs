using System;
using System.Collections.Generic;
using System.Text;

namespace cinema_project.Model
{
    class chek
    {
        int _id;
        user _person;
        double _summa;
        seans _kino;
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
       
        public user person
        {
            get
            {
                return _person;
            }
            set
            {
                _person = value;
            }
        }
        

        public double summa
        {
            get
            {
                return _summa;
            }
            set
            {
                _summa = value;
            }
        }
        public seans kino
        {
            get
            {
                return _kino;
            }
            set
            {
                _kino = value;
            }
        }


        public chek (int id, user person, double summa, seans kino)
        {
            _id = id;
            _person = person;
            _summa = summa;
            _kino = kino;
        }
    }
}
