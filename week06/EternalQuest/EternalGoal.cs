using System;

namespace EternalQuest
{
    public class EternalGoal : Goal, ILevelable
    {
        private int _timesCompleted;
        private int _level; //for additional functionality
        private const int COMPLETIONS_TO_LEVEL = 5; // additional functionality first time 
        //it might be 5, end every next level +5 , to motivate level up

        public EternalGoal(string name, string description, int points) 
            : base(name, description, points)
        {
            //from :base automatically initialized
        }



        //added methods from ILevelable interface
        public int GetLevel()
        {
            return _level;
        }

        public bool CanLevelUp()
        {
            return _timesCompleted >= COMPLETIONS_TO_LEVEL * (_level + 1);
        }

        public int ProcessLevelUp()
        {
            if (CanLevelUp())
            {
                _level++;
                return _points * _level; // bonus points for leveling up
            }
            return 0;
        }

        public override int RecordEvent()
        {
            _timesCompleted++;
            
            // Проверяем возможность повышения уровня
            if (CanLevelUp())
            {
                int bonusPoints = ProcessLevelUp();
                Console.WriteLine($"\n🎉 Level Up! {_shortName} reached level {_level}!");
                Console.WriteLine($" Bonus points earned: {bonusPoints}");
                return _points + bonusPoints;
            }
            
            return _points;
        }

        public override string GetDetailsString()
        {
            // Добавляем информацию об уровне и прогрессе
            return $"[ ] {_shortName} ({_description}) -- Level: {_level}, Progress: {_timesCompleted}/{COMPLETIONS_TO_LEVEL * (_level + 1)}";
        }

        public override string GetStringRepresentation()//toDo can delete
        {
            return $"{GetType().Name}:{_shortName},{_description},{_points}";
        }
    }
}