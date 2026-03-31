class Menu
{
    private double _TotalPoint;

    public double GetTotalPoints()
    {
        return _TotalPoint;
    } 
    public void SetTotalPoints(double totalpoint)
    {
        _TotalPoint = totalpoint;
    }
    List<Goal> goal = new List<Goal>();

    public void Menu1()
    {
        int choice = Choices();
        while (choice != 6)
        {
            if (choice == 1) // Create new goal (When you make a new goal it makes you enter the goal twice, but only records the second one)
            {   
                int choice1 = Menu2();

                if (choice1 == 1) // Simple goal
                    {
                        goal.Add(new SimpleGoal());
                        choice = Choices();
                    }
                else if (choice1 == 2) // Eternal goal
                    {
                        goal.Add(new EternalGoal());
                        choice = Choices();
                    }
                else if (choice1 == 3) // Checklist goal
                    {
                        goal.Add(new ChecklistGoal());
                        choice = Choices();
                    }
                else // error message
                    {
                        Console.WriteLine($"The option {choice1} is invalid");
                        Thread.Sleep(3000);
                        choice1 = Menu2();
                    }

            }
            else if (choice == 2) // List goals
            {
                DisplayGoals();
                choice = Choices();
            }
            else if (choice == 3) // Save goals
            {
            
            }
            else if (choice == 4) // Load goals
            {
                
            }
            else if (choice == 5) // Record Event
            {
                menu3(); //Still need to learn how to itterate between objects in a list. Also add points to total.
                choice = Choices();
            }
            else // Error message
            {
                Console.WriteLine($"The option {choice} is invalid");
                Thread.Sleep(3000);
                choice = Choices();
            }
            DisplayPoints();
        }
    }
    public int Choices()
    {   
        int choice = 0;
        Console.WriteLine("Menu Options: ");
        Console.WriteLine(" 1. Create New Goal");
        Console.WriteLine(" 2. List Goals");
        Console.WriteLine(" 3. Save Goals");
        Console.WriteLine(" 4. Load Goals");
        Console.WriteLine(" 5. Record Event");
        Console.WriteLine(" 6. Quit");
        Console.Write("Select a choice from the menu: ");
        string input = Console.ReadLine();
        choice = int.Parse(input);
        return choice;
    }
    public int Menu2()
    {
        int choice = 0;
        Console.WriteLine("The types of Goals are: ");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string input = Console.ReadLine();
        choice = int.Parse(input);       

        return choice;
    }   
    public int menu3()
    {
        Console.WriteLine("The goals are: ");
        DisplayGoals();
        Console.WriteLine("Which goal did you accomplish? ");
        string input = Console.ReadLine();
        int choice = int.Parse(input);
        Console.WriteLine("Congratulations! You've earned {} Points!"); // needs to call points earned.
        return choice;
    }
        public void DisplayGoals()
    {
        foreach (Goal i in goal)
        {
            i.DisplayGoal();
        }
    }
    public void DisplayPoints()
    {
        Console.WriteLine();
        Console.WriteLine($"You have {_TotalPoint} points");
        Console.WriteLine();
    }

}