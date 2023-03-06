public class ChecklistGoal : Goal
{
    private int _bonusPoints;
    private int _timeForBonus;
    private int _timeDone;
    public ChecklistGoal(string name, string description, int points, int bonusPoints, int timeForBonus, int timeDone, bool isCompleted) : base (name, description, points, isCompleted)
    {

    }
    public override void SetIsCompleted()
    {
    
    }
    public override void DisplayGoal()
    {

    }
    public override string GetStringRep()
    {
        return "pass";
    }
}