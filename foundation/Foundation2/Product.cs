using System;

public class Product
{
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;

    public Product(string name, string productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public string GetName() //getter that access the name of the product
    {
        return _name;
    }

    public string GetProductId() //getter that access the Id
    {
        return _productId;
    }

    public double GetPrice() //getter that access the price
    {
        return _price;
    }

    public int GetQuantity() //getter that access the quantity 
    {
        return _quantity;
    }

    public double GetTotal() //getter that multiplies the total
    {
        return _price * _quantity;
    }
}