namespace Domain.Entities;

public sealed class Customer {
    public required string Name { get; init; }

    private Customer()
    { }
    
    public Customer(string name)
    {
        Name = name;
    }
}
