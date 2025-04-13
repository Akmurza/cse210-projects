using System;

namespace EternalQuest
{
    public class EternalGoal : Goal
    {
        public EternalGoal(string name, string description, int points) 
            : base(name, description, points)
        {
            //from :base automatically initialized
        }

        public override int RecordEvent()
        {
            //always return points,eternal
            return _points;
        }

        public override string GetDetailsString()
        {
            return $"[ ] {_shortName} ({_description})";
        }

        public override string GetStringRepresentation()//toDo can delete
        {
            return $"{GetType().Name}:{_shortName},{_description},{_points}";
        }
    }
}