class Product
{
    private string _name;
    private string _ProductID;
    private int _PricePU;
    private int _Quantity;

    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name;
    }
    public string GetProductID()
    {
        return _ProductID;
    }
    public void SetProductID(string productid)
    {
        _ProductID = productid;
    }
    public int GetPricePU()
    {
        return _PricePU;
    }
    public void SetPricePU(int pricepu)
    {
        _PricePU = pricepu;
    }
    public int GetQuantity()
    {
        return _Quantity;
    }
    public void SetQuantity(int quantity)
    {
        _Quantity = quantity;
    }
    public int TotalPrice()
    {
        int TotalPrice = _PricePU * _Quantity;
        return TotalPrice;
    }

    public Product(string name, string productID, int pricePU, int quantity)
    {
        _name = name;
        _ProductID = productID;
        _PricePU = pricePU;
        _Quantity = quantity;
    }
    public Product()
    {
        _name = "Evaportated Water";
        _ProductID = "10284DA";
        _PricePU = 5;
        _Quantity = 3;
    }
}