


public class Product
{
    private string name;
    private string productId;
    private decimal price;
    private int quantity;

    // Constructor
    public Product(string name, string productId, decimal price, int quantity)
    {
        this.name = name;
        this.productId = productId;
        this.price = price;
        this.quantity = quantity;
    }

    // Getter methods
    public string GetName() => name;
    public string GetProductId() => productId;
    public decimal GetPrice() => price;
    public int GetQuantity() => quantity;

    // Calculate the total cost of this product
    public decimal GetTotalCost()
    {
        return price * quantity;
    }
}