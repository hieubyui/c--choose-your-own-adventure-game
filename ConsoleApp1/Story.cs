public class Story : GameLogic
{
    public Story()
    {
        _intro = "";
        _ask = "";
        _endSimulationMessage = "A voice calls out from within.\n     \"An interesting choice. You choose to end the simulation. You are free now.\"";
    }
        public void ShowEndSimulationMessage()
    {
        Console.WriteLine(_endSimulationMessage);
        Environment.Exit(0);
    }

}