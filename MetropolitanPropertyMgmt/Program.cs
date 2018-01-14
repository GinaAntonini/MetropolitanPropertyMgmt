using System;
using System.Collections.Generic;

namespace MetropolitanPropertyMgmt
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Company
    {
        /*
            Some readonly properties
        */
        public string Name { get; }
        public DateTime CreatedOn { get; }

        // Create a property for holding a list of current employees
        public void EmployeeList()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee(){ FirstName = "Gina", LastName = "Antonini", JobTitle = "Director of Operations", StartDate = "11/1/16" },
                new Employee(){ FirstName = "Haley", LastName = "Adamas", JobTitle = "Assistant Director of Operations", StartDate = "1/2/17" },
                new Employee(){ FirstName = "Tyler", LastName = "Hall", JobTitle = "Property Manager", StartDate = "1/5/14" },
            };

            // Create a method that allows external code to add an employee
            employees.Add(new Employee() { FirstName = "Jacie", LastName = "Rush", JobTitle = "Administrative Assistant", StartDate = "2/1/18" });

            // Create a method that allows external code to remove an employee
            employees.Remove(new Employee() { FirstName = "Jacie", LastName = "Rush", JobTitle = "Administrative Assistant", StartDate = "2/1/18" });
        }

    /*
        Create a constructor method that accepts two arguments:
            1. The name of the company
            2. The date it was created

        The constructor will set the value of the public properties
    */
}
    }
