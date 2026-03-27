using System.Transactions;

class Video
{
public string _title;
public string _author;
public double _length;
public List<Comments> comment = new List<Comments>();

public void DisplayComments()
    {
        foreach (Comments i in comment)
        {
            i.DisplayComment();   
        }
    }

    public void DisplayVideo()
    {
        Console.WriteLine($"'{_title}'");
        Console.WriteLine($"{_author} - {_length}");
        Console.WriteLine();

        DisplayComments();
    }

}

