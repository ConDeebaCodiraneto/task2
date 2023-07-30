using System;
using System.Collections.Generic;
using task1.Entities;
using YourNamespace.Entities;

namespace YourNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            Manager manager1 = new Manager
            {
                FirstName = "John",
                LastName = "Doe",
                Email = "john.doe@example.com",
                Age = 35,
                Department = "HR",
                ManagerSpecificProperty = "Property for Manager 1"
            };
            employees.Add(manager1);


            Principal principal1 = new Principal
            {
                FirstName = "Jane",
                LastName = "Smith",
                Email = "jane.smith@example.com",
                Age = 45,
                Department = "School",
                PrincipalSpecificProperty = "Property for Principal 1"
            };
            employees.Add(principal1);


            foreach (var employee in employees)
            {
                employee.Print();
            }
        }
    }
}
