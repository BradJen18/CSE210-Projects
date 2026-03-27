using System.Runtime.InteropServices;
using System.Security.Authentication;

class Customer
{
    private string _name;
    private Address address = new Address();

    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name;
    }
    public void SetAddress(string ad, string city, string state, string country) // do i need this?
    {
        address.SetStreetAd(ad);
        address.SetCity(city);
        address.SetState(state);
        address.SetCountry(country);
    }
    public void Display()
    {
        Console.WriteLine(_name);
        address.DisplayAd();
    }
    public bool InUSA()
    {
        string country = address.GetCountry();
        return address.IsUSA(country);
    }
    
    public Customer(string name)
    {
        _name = name;
    }

        public Customer()
    {
        _name = "joe";
    }

}