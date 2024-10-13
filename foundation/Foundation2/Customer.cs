



public class Customer
{
    private string name;
    private Address address;

    // Constructor
    public Customer(string name, Address address)
    {
        this.name = name;
        this.address = address;
    }

    // Getter methods
    public string GetName() => name;
    public Address GetAddress() => address;

    // Check if the customer lives in the USA
    public bool IsInUSA()
    {
        return address.IsInUSA();
    }
}