// Constructor with two parameters is declared at class level.

public class Customer(string firstName, string lastName)
{
    // Constructor empty
    public Customer() : this("", "")
    {
    }

    public string GetFullName() => $"{firstName} - {lastName}";
}