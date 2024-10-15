
using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    // Constructor
    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    // Calculate the total price of the order (including shipping)
    public decimal GetTotalPrice()
    {
        decimal total = 0;

        // Add the total cost of each product
        foreach (Product product in _products)
        {
            total += product.GetTotalCost();
        }

        // Add shipping cost
        if (_customer.IsInUSA())
        {
            total += 5; // Shipping cost in USA
        }
        else
        {
            total += 35; // Shipping cost outside USA
        }

        return total;
    }

    // Get the packing label: product name and product ID for each product
    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (Product product in _products)
        {
            label += $"{product.GetProductDetail()})\n";
        }
        return label;
    }

    // Get the shipping label: customer name and address
    public string GetShippingLabel()
    {
        return $"Shipping Label:\nCustomer: {_customer.GetCustomerDetail()}";
    }
}