public class GoalManager
{
    private readonly List<Goal> _goals = [];
    private int _score;

    public int CurrentScore
    {
        get { return _score; }
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void DisplayGoals()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{goal.Name}: {goal.Description} Completed: {goal.IsCompleted}");
        }
    }


    public void RecordEvent(string goalName)
    {
        bool goalFound = false;
        foreach (Goal goal in _goals)
        {
            if (goal.Name == goalName)
            {
                goal.RecordEvent();
                _score += goal.Points;
                if (goal is ChecklistGoal checklistGoal && checklistGoal.IsCompleted)
                {
                    _score += checklistGoal.BonusPoints;
                }
                Console.WriteLine($"{goalName} event has been recorded. Here is your current score: {_score}");
                goalFound = true;
                break;
            }
        }

        if (goalFound)
        {
            SaveGoals();
            Console.WriteLine("Changes saved");
        }
        else
        {
            Console.WriteLine("We could not find your goal. Please try again.");
        }
    }


    public void SaveGoals()
    {
        string fileName = "goals.txt";
        using (StreamWriter outputFile = new StreamWriter(fileName, true))
        {
        outputFile.WriteLine(_score);
        foreach (Goal goal in _goals)
        {
            outputFile.WriteLine($"{goal.GetType().Name},{goal.Name},{goal.Description},{goal.Points},{goal.IsCompleted}");
        }
        }
        
    }


    public void LoadGoals()
    {
        string fileName = "goals.txt";
        using StreamReader reader = new(fileName);
        {
            _score = int.Parse(reader.ReadLine());
            string[] lines = System.IO.File.ReadAllLines(fileName);
            {
                foreach (Goal goal in _goals)
                {
                    if (goal is ChecklistGoal checklistGoal)
                    {
                        Console.WriteLine($"Name: {checklistGoal.Name}, Description: {checklistGoal.Description}, Points: {checklistGoal.Points}, Amount Recorded: {checklistGoal.CurrentCount}/{checklistGoal.GoalTarget}, Done: {(checklistGoal.IsCompleted ? "Yes" : "No")}");
                    }
                    else
                    {
                        Console.WriteLine($"Name: {goal.Name}, Description: {goal.Description}, Points: {goal.Points}, Done: {(goal.IsCompleted ? "Yes" : "No")}");
                    }
                }
            }
        }
    }
}