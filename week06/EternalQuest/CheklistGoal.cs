using System;

namespace EternalQuest
{
    public class ChecklistGoal : Goal
    {
        private int _target;          // target amount of execution 
        private int _timesCompleted;  // how many times completed already
        private int _bonus;           // bonus score

        // add parametrs to constructor
        public ChecklistGoal(string name, string description, int points, int target, int bonus) 
            : base(name, description, points)
        {
            _target = target;
            _bonus = bonus;
            _timesCompleted = 0;  
        }

        // increment the number of times
        public override int RecordEvent()
        {
            _timesCompleted++;
            
            // check target compleete
            if (_timesCompleted >= _target)
            {
                _isComplete = true;
                return _points + _bonus;  // points and bonus if completed
            }
            
            return _points;  // just points
        }

        // add condition of target- currently completed
        public override string GetDetailsString()
        {
            return $"[{(_isComplete ? "X" : " ")}] {_shortName} ({_description}) -currently completed:{_timesCompleted}/{_target}";
        }

        // add parametrs here also
        public override string GetStringRepresentation()
        {
            return $"{GetType().Name}:{_shortName},{_description},{_points},{_timesCompleted},{_target},{_bonus}";
        }
    }
}