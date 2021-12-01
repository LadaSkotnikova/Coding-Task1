using System;
using System.Collections.Generic;
using System.Text;

namespace cinema_project.Model
{
    public class chekeda
    {
        int _id;
        Dictionary<dop, int> _essen;
        double _itog;
        double _preis;

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

        public Dictionary<dop, int> essen
        {
            get
            {
                return _essen;
            }
            set
            {
                _essen = value;
            }
        }
        public double itog
        {
            get
            {
                return _itog;
            }
            set
            {
                _itog = value;
            }
        }
        public double preise
        {
            get
            {
                return _preis;
            }
            set
            {
                _preis = value;
            }
        }


        public chekeda(int id, Dictionary<dop, int> essen, double itog, double preis)
        {
            _id = id;
            _essen = essen;
            _itog = itog;
            _preis = preis;
        }
        public chekeda ()
        {

        }
    }
}
