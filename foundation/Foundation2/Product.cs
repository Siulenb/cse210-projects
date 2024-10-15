


public class Product
{
    private string _name;
    private string _productId;
    private decimal _price;
    private int _quantity;

    // Constructor
    public Product(string name, string productId, decimal price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    // Getter methods
    public string GetName() => _name;
    public string GetProductId() => _productId;
    public decimal GetPrice() => _price;
    public int GetQuantity() => _quantity;

    // Calculate the total cost of this product
    public decimal GetTotalCost()
    {
        return _price * _quantity;
    }
}