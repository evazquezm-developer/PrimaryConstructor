// Constructor is declared at class level.

public class Customer(string firstName, string lastName)
{
    public string GetFullName() => $"{firstName} - {lastName}";
}