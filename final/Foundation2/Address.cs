class Address
{
    private string _StreetAd;
    private string _City;
    private string _State;
    private string _Country;

    public string GetStreetAd()
    {
        return _StreetAd;
    }
    public void SetStreetAd(string StreetAd)
    {
        _StreetAd = StreetAd;
    }
    public string GetCity()
    {
        return _City;
    }
    public void SetCity(string city)
    {
        _City = city;
    }
    public string GetState()
    {
        return _State;
    }
    public void SetState(string state)
    {
        _State = state;
    }
    public string GetCountry()
    {
        return _Country;
    }
    public void SetCountry(string country)
    {
        _Country = country;
    }

    public void DisplayAd()
    {
        Console.WriteLine($"{_StreetAd}");
        Console.WriteLine($"{_City}, {_State}, {_Country}");
    }

    public bool IsUSA(string _Country)
    {
        if (_Country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public Address(string StreetAd, string city, string state, string country)
    {
        _StreetAd = StreetAd;
        _City = city;
        _State = state;
        _Country = country;
    }
    public Address()
    {
        _StreetAd = "123 haha street";
        _City = "snowflake";
        _State = "AZ";
        _Country = "USA";
    }
}