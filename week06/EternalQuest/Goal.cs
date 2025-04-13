using System;

namespace EternalQuest
{
    public abstract class Goal
    {
        protected string _shortName;
        protected string _description;
        protected int _points;
        protected bool _isComplete;

        public Goal(string shortName, string description, int points)
        {
            _shortName = shortName;
            _description = description;
            _points = points;
            _isComplete = false;
        }

        // get methods
        public string Name 
        { 
            get { return _shortName; }
        }
        public int Points 
        { 
            get { return _points; }
        }
        public bool IsComplete 
        { 
            get { return _isComplete; }
        }

        // that is abstract method that must be implemented by all derived classes
        public abstract int RecordEvent();
        
        public virtual string GetDetailsString()
        {
            return $"[{(_isComplete ? "X" : " ")}] {_shortName} ({_description})";
        }

        //virtual method that can be overridden
        public virtual string GetStringRepresentation()
        {
            return $"{GetType().Name}:{_shortName},{_description},{_points},{_isComplete}";//return current class name and info in string
        }
    }
}