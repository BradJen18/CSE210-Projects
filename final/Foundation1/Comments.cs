class Comments
{
    public string _name;
    public string _text;

    public void DisplayComment()
    {
        Console.WriteLine($"{_name}: ");
        Console.WriteLine($"'{_text}'");
        Console.WriteLine();
    }
}