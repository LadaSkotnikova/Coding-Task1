using System;
using System.Collections.Generic;
using System.Text;

namespace cinema_project.Model
{
    class seans
    {
        DateTime _time;
        movie _kino;
        Zal _mesto;
        List<bool> _zanmesta;


        public DateTime time
        {
            get
            {
                return _time;
            }
            set
            {
                _time = value;
            }
        }

        public movie kino
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
        public Zal mesto
        {
            get
            {
                return _mesto;
            }
            set
            {
                _mesto = value;
            }
        }
        public List<bool> zanmesta
        {
            get
            {
                return _zanmesta;
            }
            set
            {
                _zanmesta = value;
            }
        }
        public seans (DateTime time, movie kino, Zal mesto, List<bool> zanmesta)
        {
            _time = time;
            _kino = kino;
            _mesto = mesto;
            _zanmesta = zanmesta;
        }
    }
}
