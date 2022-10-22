using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_homework
{
    public class Employee
    {
        public Employee(int ıd, string firstName, string lastName)
        {
            Id = ıd;
            FirstName = firstName;
            LastName = lastName;
        }


        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

    }

       
    
}