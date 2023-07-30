namespace task1.Interfaces
{
    public interface IEmployee
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string Email { get; set; }
        int Age { get; set; }

        void Print();
    }
}
