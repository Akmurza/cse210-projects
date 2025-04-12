public class SimpleGoal : Goal{
    private string _name;
    private string _description;
    private int _points;
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
        _isComplete = false;
    }

    public void RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            Console.WriteLine($"Congratulations! You have completed the goal:{_name}");
        }
        else
        {
            Console.WriteLine($"The goal: {_name} is already complete.");
        }
    }

    public void DisplayGoal()
    {
        string status = _isComplete ? "X" : " ";
        Console.WriteLine($"[{status}] {_name} ({_description}) - Points: {_points}");
    }

    public int GetPoints()
    {
        return _isComplete ? _points : 0;
    }
}

