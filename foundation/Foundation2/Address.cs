using System;

public class Address
{
   private string _street;
   private string _city;
   private string _state;
   private string _country;

    //constructor
   public Address(string street, string city, string state, string country)
   {
    _street = street;
    _city = city;
    _state = state;
    _country = country;
   } 

    public bool InUSA() //method that verifies if its in USA or not
    {
        return _country.ToLower() == "usa";
    }

    public string FullAddress() //return the address in a string
    {
        return $"{_street}, {_city}, {_state}-{_country}";
    }

}