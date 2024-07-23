public class GameLogic
{
    public string _intro;
    public string _ask;
    
    public string _endSimulationMessage;
    public GameLogic()
    {
        _intro = "";
        _ask = "";
    }

    public void ShowDetails()
    {
        Console.Clear();
        Console.WriteLine(_intro);
        Console.WriteLine(_ask);
    }


}