using System;
using task1.Entities;

namespace task1.Entities
{
    public class Manager : Employee
    {
        public string ManagerSpecificProperty { get; set; }

        public override void Print()
        {
            Console.WriteLine($"Manager: {FirstName} {LastName} ({Age} years old)");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Department: {Department}");
            Console.WriteLine($"Manager Specific Property: {ManagerSpecificProperty}");
            Console.WriteLine();
        }
    }
}