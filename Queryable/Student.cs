using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queryable
{
    public class Student
    {
        public Student() { }

        public Student(int id, string name, string description, int age)
        {
            Id = id;
            Name = name;
            Description = description;
            Age = age;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int Age { get; set; }
    }
}
