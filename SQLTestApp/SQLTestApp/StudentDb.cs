using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace SQLTestApp
{
    class StudentDb : DbContext 
    {
        List<Student> _students;
        public List<Student> Students
        {
            get { return _students; }
            set { _students = value; }
        }
    }
}
