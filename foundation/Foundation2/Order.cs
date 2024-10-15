using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> _product; //list all the products
    private Customer _customer; // store the client
    private double _shippingCost; // calculate the total price of the order


//constructor that initializes the order pf the products and the clients
    public Order(Customer customer, List<Product> product)
    {
        _customer = customer;
        _product = product;
        
        if(customer.InUSA())
        {
            _shippingCost = 5;
        }
        else
        {
            _shippingCost = 35;
        }
    }

    public double CalculateTotal() //method to calculate the total
    {
        double total = 0;
        foreach (var product in _product)
        {
            total += product.GetPrice() * product.GetQuantity();
        }
        return total + _shippingCost;
    }

    public string GetPackingLabel() //method that generate the packing label (etiqueta)
    {
        string packingLabel = "Packing Label:\n";
        foreach (var product in _product)
        {
            packingLabel += $"Product: {product.GetName()}, ID: {product.GetProductId()}:\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()//method to generate the shipping label
    {
        string shippingLabel = "Shipping Label:\n";
        shippingLabel += $"Customer: {_customer.GetName()}\n";
        shippingLabel += $"{_customer.GetAddress()}\n";
        return shippingLabel;
    }

    public string GetProductDetails()
    {
        string details = $"Products for {_customer.GetName()}:\n";
        foreach (var product in _product)
        {
            details += $"Name: {product.GetName()}, ID: {product.GetProductId()}, Price: ${product.GetPrice()}, Quantity: {product.GetQuantity()}\n";
        }
        return details;
    }
}