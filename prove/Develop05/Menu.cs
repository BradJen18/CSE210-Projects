class Menu
{
    private double _TotalPoint;

    public double GetTotalPoints()
    {
        return _TotalPoint;
    } 
    public void SetTotalPoints(double totalpoint) // need to fix Load/Save feature, The double write goal create.
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
                        // need to edit the goal.
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
            else if (choice == 3) // Save goals (how do I customize how it saves based on what goal it is?)
            {
                Console.WriteLine("What is the filename?");
                string name = Console.ReadLine();
                using (StreamWriter outputFile = new StreamWriter(name, true))
                {
                    outputFile.WriteLine(_TotalPoint);
                    foreach (Goal g in goal)
                    {   
                        outputFile.WriteLine($"{g.GetGoalName()}~~{g.GetGoalDesc()}~~{g.GetGoalPoint()}~~{g.GetIsComplete()}");        
                    }
                }
                choice = Choices();
            }
            else if (choice == 4) // Load goals (how do I ignore the first line of the text file?)
            {
                Console.WriteLine("What is the filename?");
                string name = Console.ReadLine();
                string [] lines = System.IO.File.ReadAllLines(name);
                foreach (string line in lines)
                {
                    string [] parts = line.Split("~~");
                    Goal newgoal = new Goal();
                    newgoal.SetGoalName(parts[0]);
                    newgoal.SetGoalDesc(parts[1]);
                    double input = double.Parse(parts[2]);
                    newgoal.SetGoalPoint(input);
                    bool isComplete = bool.Parse(parts[3]);
                    newgoal.SetIsComplete(isComplete);
                    goal.Add(newgoal);
                }
                choice = Choices();
            }
            else if (choice == 5) // Record Event
            {
                menu3();
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
        int choice = int.Parse(input) - 1;
        Goal g = goal[choice];
        double points = g.RecordEntry();
        _TotalPoint += points;
        Console.WriteLine($"Congratulations! You've earned {points} Points!");
        return choice;
    }

    public void CreateGoal()
    {

\
        Console.Write("What is a short description of it? ");
        string input2 = Console.ReadLine();
        SetGoalDesc(input2);
        Console.Write("What is the ammount of points associated with this goal? ");
        string i3 = Console.ReadLine();
        double input3 = double.Parse(i3);
        SetGoalPoint(input3);
        SetIsComplete(false);
    }
    public void DisplayGoals()
    {
        int list = 1;
        foreach (Goal i in goal)
        {
            Console.Write($"{list}. ");
            list += 1;
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