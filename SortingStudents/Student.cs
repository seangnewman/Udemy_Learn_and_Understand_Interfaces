using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingStudents
{
    class Student : IComparable<Student>
     {
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Student( int studentID, string firstName, string lastName)
        {
            StudentID = studentID;
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString()
        {
            return String.Format("{0} {1} ({2})", FirstName, LastName, StudentID.ToString());
        }

        public int CompareTo(Student other)
        {
            return this.ToString().CompareTo(other.ToString());
        }
    }
}
