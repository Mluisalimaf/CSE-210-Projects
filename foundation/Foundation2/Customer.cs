using System;

public class Customer
{
    private string _name;
    private Address _address; //instance of class address

//contructor
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string GetName() //getter that obtains the clients name
    {
        return _name;
    }

    public string GetAddress()// getter - obtain the address
    {
        return _address.GetFullAddress();
    }

    public bool InUSA() //method that verifies is its in the USA or not (relate to Address class)
    {
        return _address.InUSA();
    }
}