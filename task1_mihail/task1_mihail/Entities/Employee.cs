using task1.Interfaces;

namespace task1.Entities
{
    public abstract class Employee : IEmployee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public string Department { get; set; }

        public abstract void Print();
    }
}
