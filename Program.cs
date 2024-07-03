
Console.WriteLine("Example using Primary Constructors");

// Constructor with parameters.
var customer = new Customer("C#", "12");

Console.WriteLine($"{customer.GetFullName()}");

// Constructor empty.
var newCustomer = new Customer();
Console.WriteLine($"{newCustomer.GetFullName()}");
