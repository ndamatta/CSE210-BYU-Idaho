public class EthernalGoal : Goal
{
    public EthernalGoal(string name, string description, int points, bool isCompleted) : base (name, description, points, false)
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