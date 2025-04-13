using System;
namespace EternalQuest;
class Program
{
    
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}

//as creativity I just have added an interface that implements its methods in several classes -
// namely, in the verified list of goals and in eternal goals. This 
//interface is associated with gamification and increasing the level ...
// for which additional bonuses will be given in all classes. I also 
//highlighted in the comments the functionality associated with this interface.
public interface ILevelable
{
    //get current level
    int GetLevel();
    //check if can level up
    bool CanLevelUp();
    //level up and return bonus points
    int ProcessLevelUp();
}