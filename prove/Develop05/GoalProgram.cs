class Program
{
    static void Main(string[] args)
    {
        GoalManager newGoal = new GoalManager();
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine($"You have {newGoal.CurrentScore} points.");
            Console.WriteLine("Menu options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("What type of goal would you like to make? ");
                    Console.WriteLine("1. Simple Goal");
                    Console.WriteLine("2. Eternal Goal");
                    Console.WriteLine("3. Checklist Goal");
                    int goalChoice = int.Parse(Console.ReadLine());
                    switch (goalChoice)
                        {
                            case 1:
                                CreateSimpleGoal(newGoal);
                                break;
                            case 2:
                                CreateEternalGoal(newGoal);
                                break;
                            case 3:
                                CreateChecklistGoal(newGoal);
                                break;
                        }
                    break;
                case 2:
                    newGoal.DisplayGoals();
                    break;
                case 3:
                    newGoal.SaveGoals();
                    Console.WriteLine("Goals saved successfully.");
                    break;
                case 4:
                    newGoal.LoadGoals();
                    break;
                case 5:
                    RecordEvent(newGoal);
                    break;
                case 6:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Something went wrong. Please try again.");
                    break;
            }
        }
    }
        static void CreateSimpleGoal(GoalManager goalName)
    {
        Console.WriteLine("What is the goal name? ");
        string name = Console.ReadLine();
        Console.WriteLine("Please include a short description of your goal: ");
        string description = Console.ReadLine();
        Console.WriteLine("How many points is this goal worth? ");
        int points = int.Parse(Console.ReadLine());

        var goal = new SimpleGoal(name, description, points);
        goalName.AddGoal(goal);
        Console.WriteLine("Goal added successfully.");
    }

        static void CreateEternalGoal(GoalManager goalName)
    {
        Console.WriteLine("What is the goal name? ");
        string name = Console.ReadLine();
        Console.WriteLine("Please include a short description of your goal: ");
        string description = Console.ReadLine();
        Console.WriteLine("How many points is this goal worth? ");
        int points = int.Parse(Console.ReadLine());

        var goal = new EternalGoal(name, description, points);
        goalName.AddGoal(goal);
        Console.WriteLine("Goal added successfully.");
    }

    static void CreateChecklistGoal(GoalManager goalName)
    {
        Console.WriteLine("What is the goal name? ");
        string name = Console.ReadLine();
        Console.WriteLine("Please include a short description of your goal: ");
        string description = Console.ReadLine();
        Console.WriteLine("How many points will you earn for recording an event in this goal? ");
        int points = int.Parse(Console.ReadLine());
        Console.WriteLine("How many times do you need to record this goal for it to be complete? ");
        int target = int.Parse(Console.ReadLine());
        Console.WriteLine("How many bonus points will you earn when the target number is reached?");
        int bonusPoints = int.Parse(Console.ReadLine());

        var goal = new ChecklistGoal(name, description, points, target, bonusPoints);
        goalName.AddGoal(goal);
        Console.WriteLine("Goal added successfully.");
    }

    static void RecordEvent(GoalManager goalName)
    {
        Console.WriteLine("Enter the goal you would like to record:");
        string name = Console.ReadLine();
        goalName.RecordEvent(name);
        Console.WriteLine("Event recorded. Thank You!");
    }
}
