using System;

namespace EternalQuest{
    public class SimpleGoal : Goal
    {
        public SimpleGoal(string name, string description, int points) 
            : base(name, description, points)
        {
            // base class initialized the fields
        }

        public override int RecordEvent()
        {
            if (!_isComplete)
            {
                _isComplete = true;
                return _points;
            }
            return 0;
        }

        public override string GetStringRepresentation()//toDo it should be deleted
        {
            return $"{GetType().Name}:{_shortName},{_description},{_points},{_isComplete}";
        }
    }
}