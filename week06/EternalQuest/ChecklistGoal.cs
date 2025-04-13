using System;

namespace EternalQuest
{
    public class ChecklistGoal : Goal, ILevelable
    {
        // basic vars for checklist
        private int _target;          
        private int _timesCompleted;  
        private int _bonus;           
        private int _level;            //for additional functionality

        // make new goal
        public ChecklistGoal(string name, string description, int points, int target, int bonus) 
            : base(name, description, points)
        {
            _target = target;
            _bonus = bonus;
            _timesCompleted = 0;  
        }

        // count completions
        public override int RecordEvent()
        {
            _timesCompleted++;
            
            // if done enough times
            if (_timesCompleted >= _target)
            {
                _isComplete = true;
                return _points + _bonus;
            }
            return _points;
        }

        // show goal info
        public override string GetDetailsString()
        {
            return $"[{(_isComplete ? "X" : " ")}] {_shortName} ({_description}) -- Done: {_timesCompleted}/{_target}";
        }

        // save goal to file
        public override string GetStringRepresentation()
        {
            return $"{GetType().Name}:{_shortName},{_description},{_points},{_timesCompleted},{_target},{_bonus}";
        }

        // level system stuff
        public int GetLevel()
        {
            return _level;
        }

        public bool CanLevelUp()
        {
            return _timesCompleted >= _target * (_level + 1);
        }

        public int ProcessLevelUp()
        {
            if (CanLevelUp())
            {
                _level++;
                return _bonus * _level;  // more bonus for each level
            }
            return 0;
        }
    }
}