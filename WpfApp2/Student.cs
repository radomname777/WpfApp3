using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    public class Student
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public Student() { }
        public Student(string name, string surname, DateTime Datetime) { FirstName = name; LastName = surname; BirthDate = Datetime; }
        public override string ToString() => $"Name {FirstName} Surname {LastName} Age {DateTime.Now.Year - BirthDate.Year}";
    }
}
