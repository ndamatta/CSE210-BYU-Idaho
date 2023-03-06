public abstract class Goal
{
    private bool _isCompleted;
    private string _name;
    private string _description;
    private int _points;
    private int _totalPoints;
    private int _type;
    private List<Goal> _goals;

    public Goal (string name, string description, int points, bool isCompleted)
    {
        _name = name;
        _description = description;
        _points = points;
        _isCompleted = isCompleted;
    }

    public void CreateNewGoal()
    {

    }
    public void RefreshPoints(int points)
    {

    }
    public void DisplayGoals()
    {

    }
    public void RecordEvent()
    {

    }
    public abstract void SetIsCompleted();
    public abstract void DisplayGoal();
    public abstract string GetStringRep();

    //GETTERS
    public bool GetIsCompleted()
    {
        return _isCompleted;
    }
    public string GetName()
    {
        return _name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public int GetPoints()
    {
        return _points;
    }
    public int GetTotalPoints()
    {
        return _totalPoints;
    }

}