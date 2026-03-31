class Order
{
    private Customer customer = new Customer();
    private List<Product> product = new List<Product>();

    public void OverallPrice()
    {
        int TPrice = 0;
        foreach (Product p in product)
        {
            int PPrice = p.TotalPrice();
            TPrice += PPrice;
        }
        bool IsUSA = customer.InUSA();
        if (IsUSA == true)
        {
            TPrice = TPrice + 5;
        }
        else
        {
            TPrice = TPrice + 35;
        }
        Console.WriteLine("Total price:");
        Console.WriteLine($"${TPrice}");

    }
    public void PackingLabel() // Lists name and product ID for each item in order
    {
        Console.WriteLine("Packing Label:");
        foreach (Product p in product)
        {
            string name = p.GetName();
            string productID = p.GetProductID();
            Console.WriteLine($"{name} - {productID}");
            Console.WriteLine();
        }        
    }
    public void ShippingLabel() // name and address of customer
    {
        string name = customer.GetName();
        Console.WriteLine("Shipping label: ");
        customer.Display();
    }
    public void SetCustomer(string name, string ad, string city, string state, string country)
    {
        customer.SetName(name);
        customer.SetAddress(ad, city, state, country);
    }
    public void AddProduct(string name, string productID, int pricePU, int quantity)
    {
        Product pr1 = new Product();
        pr1.SetName(name);
        pr1.SetProductID(productID);
        pr1.SetPricePU(pricePU);
        pr1.SetQuantity(quantity);
        product.Add(pr1);
    }
    public void DisplayAll()
    {
        PackingLabel();
        ShippingLabel();
        OverallPrice();
        Console.WriteLine("------------------------");
    }
}