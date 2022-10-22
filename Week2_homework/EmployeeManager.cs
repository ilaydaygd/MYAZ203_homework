using Week2_homework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_homework
{
    public class EmployeeManager
    {
        private readonly List<Employee> employees;
        public EmployeeManager()
        {
            employees = new List<Employee>();
        }

        public EmployeeManager(Employee employee)
        {
            employees = new List<Employee>();
            CreateEmployee(employee);
        }
        // Create
        public void CreateEmployee(Employee employee)
        {
            employees.Add(employee);
            Console.WriteLine($"New employee added.");
        }
        // Read
        public Employee ReadEmployee(int id)
        {
            return employees[id];
        }
        
        // Delete
        public void DeleteEmployee(int id)
        {

            var deleteEmp = employees.FirstOrDefault(x => x.Id == id);
            
            if (deleteEmp == null)
            {
                Console.WriteLine("Employee not found.");
                return;
            }
            
            employees.Remove(deleteEmp);
            Console.WriteLine($"Employee {id} deleted.");

            
        }
        public void ReadList()
        {
            foreach (var emp in employees)
                Console.WriteLine(emp.Id);
        }
    }
}

    


   

   





