public abstract class Goal{
    public string _shortName;
    public string _description;
    public string _points;

    public Goal(string shortName, string description, string points) {
        _shortName = shortName;
        _description = description;
        _points = points;
    }

    public abstract int RecordEvent()
    {
        IsComplete = true;
        return Points;
    }

    public abstract bool IsComplete() {
        return false;
    }
    public abstract string GetDetailsString(){
        return $"{_shortName} ({_description}) - Points: {_points}";
    };
    public virtual string GetStringRepresentation()
    {
        return $"{GetType().Name}:{_shortName},{_description},{_points},{IsComplete}";
    }
}