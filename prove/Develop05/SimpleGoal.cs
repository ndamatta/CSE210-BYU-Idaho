public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points, bool isCompleted) : base (name, description, points, isCompleted)
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