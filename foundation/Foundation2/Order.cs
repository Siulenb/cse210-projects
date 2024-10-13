
using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> products;
    private Customer customer;

    // Constructor
    public Order(List<Product> products, Customer customer)
    {
        this.products = products;
        this.customer = customer;
    }

    // Calculate the total price of the order (including shipping)
    public decimal GetTotalPrice()
    {
        decimal total = 0;

        // Add the total cost of each product
        foreach (Product product in products)
        {
            total += product.GetTotalCost();
        }

        // Add shipping cost
        if (customer.IsInUSA())
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
        foreach (Product product in products)
        {
            label += $"Product: {product.GetName()} (ID: {product.GetProductId()})\n";
        }
        return label;
    }

    // Get the shipping label: customer name and address
    public string GetShippingLabel()
    {
        return $"Shipping Label:\nCustomer: {customer.GetName()}\nAddress:\n{customer.GetAddress().GetFullAddress()}";
    }
}