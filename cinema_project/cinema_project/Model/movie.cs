using System;
using System.Collections.Generic;
using System.Text;

namespace cinema_project.Model
{
    class movie
    {
        int _id;
        string _name;
        string _director;
        int _duration; // if <1 => 1
        double _rating; //if <=0 || >10 => 0 || 10
        int _year; //if>2030 => 2030
        string _country;
        string _genre;

        public int id {
            get 
            {
                return _id;
            }
            set
            {
                if (value >= 1)
                    _id = value;
                else
                    _id = value - 2 * value;
            }
        }
        public string name {
            get
            {
                return _name;

            }
            set
            {
                _name = value; 
            }
        }
        public string director
        {
            get
            {
                return _director;
            }
            set
            {
                _director = value;
            }
        }
        public int duration
        {
            get
            {
                return _duration;
            }
            set
            {
                if (value < 1)
                    _duration = 1;
                else
                    _duration = value;
            }
        }
        public double rating
        {
            get
            {
                return _rating;
            }
            set
            {
                if (value < 0)
                    _rating = 0;
                else
                 if (value > 10)
                    _rating = 10;
                else
                    _rating = value;
                
            }
        }
        public int year
        {
            get
            {
                return _year;
            }
            set
            {
                if (value > 2030)
                    _year = 2030;
                else
                    _year = value;
            }
        }
        public string country
        {
            get
            {
                return _country;
            }
            set
            {
                _country = value;
            }
        }
        public string genre
        {
            get
            {
                return _genre;
            }
            set
            {
                _genre = value;
            }
        }
        public movie ()
        {
            _rating = 5;
            Console.WriteLine("we have a new movi");
        }


        public movie(int id, string name, string director, int duration, int year, string genre)
        {
            _id = id;
            _name = name;
            _director = director;
            _duration = duration;
            _year = year;
            _genre = genre;
        }
    }
}
