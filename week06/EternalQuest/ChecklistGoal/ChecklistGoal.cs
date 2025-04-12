public class ChecklistGoal : Goal{
    private string _name;
    private string _description;
    private int _points;
    private int _bonusPoints;
    private int _goalCount;
    private int _completedCount;
    private bool _isComplete;

    public ChecklistGoal(string name, string description, int points, int bonusPoints, int goalCount)
    {
        _name = name;
        _description = description;
        _points = points;
        _bonusPoints = bonusPoints;
        _goalCount = goalCount;
        _completedCount = 0;
        _isComplete = false;
    }

    public void RecordEvent()
    {
        if (!_isComplete)
        {
            _completedCount++;
            if (_completedCount >= _goalCount)
            {
                _isComplete = true;
                Console.WriteLine($"Congratulations! You have completed the goal: {_name}");
            }
            else
            {
                Console.WriteLine($"You have completed {_completedCount} out of {_goalCount} for the goal: {_name}");
            }
        }
        else
        {
            Console.WriteLine($"The goal: {_name} is already complete.");
        }
    }

    public void DisplayGoal()
    {
        string status = _isComplete ? "X" : " ";
        Console.WriteLine($"[{status}] {_name} ({_description}) - Completed: {_completedCount}/{_goalCount}, Points: {_points}");
    }

    public int GetPoints()
    {
        return _isComplete ? _points + _bonusPoints : 0;
    }
}