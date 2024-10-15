



public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    // Constructor
    public Address(string streetAddress, string city, string state, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
    }

    // Getter methods
    public string GetCountry() => _country;

    // Check if the address is in the USA
    public bool IsInUSA()
    {
        return _country.ToLower() == "usa";
    }

    // Return the full address as a string
    public string GetFullAddress()
    {
        return $"{_streetAddress}\n{_city}, {_state}\n{_country}";
    }
}