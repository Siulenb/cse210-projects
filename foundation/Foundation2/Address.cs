



public class Address
{
    private string streetAddress;
    private string city;
    private string state;
    private string country;

    // Constructor
    public Address(string streetAddress, string city, string state, string country)
    {
        this.streetAddress = streetAddress;
        this.city = city;
        this.state = state;
        this.country = country;
    }

    // Getter methods
    public string GetCountry() => country;

    // Check if the address is in the USA
    public bool IsInUSA()
    {
        return country.ToLower() == "usa";
    }

    // Return the full address as a string
    public string GetFullAddress()
    {
        return $"{streetAddress}\n{city}, {state}\n{country}";
    }
}