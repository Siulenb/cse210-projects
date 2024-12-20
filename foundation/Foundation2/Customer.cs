



public class Customer
{
    private string _name;
    private Address _address;

    // Constructor
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // Getter methods
    // public string GetName() => _name;
    // public Address GetAddress() => _address;

    public string GetCustomerDetail()
    {
        return $"Customer: {_name}\nAddress:\n{_address.GetFullAddress()}";
    }

    // Check if the customer lives in the USA
    public bool IsInUSA()
    {
        return _address.IsInUSA();
    }
}