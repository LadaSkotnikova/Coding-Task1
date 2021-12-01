using System;
using System.Collections.Generic;
using System.Text;

namespace SQLTestApp
{
    class Student
    {
        private int _id;
        private string _name;
        private string _lastName;
        private string _group;
        private double _aygGrade; //Средний балл
        private string _email;

        public int Id { get { return _id; } set { _id = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public string LastName { get { return _lastName; } set { _lastName = value; } }
        public string Group { get { return _group; } set { _group = value; } }
        public double AygGrade { get { return _aygGrade; } set { _aygGrade = value; } }
        public string Email { get { return _email; } set { _email = value; } }

        public Student()
        {

        }
    }
}
