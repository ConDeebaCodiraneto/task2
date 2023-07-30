using System;
using task1.Entities;

namespace YourNamespace.Entities
{
    public class Principal : Employee
    {
        public string PrincipalSpecificProperty { get; set; }

        public override void Print()
        {
            Console.WriteLine($"Principal: {FirstName} {LastName} ({Age} years old)");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Department: {Department}");
            Console.WriteLine($"Principal Specific Property: {PrincipalSpecificProperty}");
            Console.WriteLine();
        }
    }
}
