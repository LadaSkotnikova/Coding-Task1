using System;
using System.Collections.Generic;
using System.Text;

namespace cinema_project.Model
{
    class Zal
    {
        int _id;
        int _place;

        public int id
        {
            get
            {
                return _id;
            }
            set
            {
                if (value > 3)
                    id = 3;
                else
                    _id = value;
            }
        }
 
        public int place
        {
            get
            {
                return _place;
            }
            set
            {
                if (value < 1)
                    place = 1;
                else
                    _place = value;

            }
        }
        public Zal (int id, int place)
        {
            _id = id;
            _place = place;
        }
    }
}
