using System;
using System.Collections.Generic;
using System.Text;

namespace cinema_project.Model
{
    public class dop
    {
        int _id;
        string _menu;
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
        public string menu
        {
            get
            {
                return _menu;
            }
            set
            {
                _menu = value;
            }
        }
        public double preis
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
 

        public dop (string menu, double preis)
        {
            _menu = menu;
            _preis = preis;
        }
    }
}
