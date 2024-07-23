using System;

class Program
{
    private static string keyinspect;
    private static string input;
    private static string input1;
    private static string button;
    private static string snapgiveinput1;


    static void Main(string[] args)
    {

        
            Story intro = new Story();
            intro._intro = "You wake up in an cold, empty cell.";
            intro._ask = "(1) to look around\n(2) to inspect yourself";
            intro.ShowDetails();

            input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    //look around
                    Story case1 = new Story();
                    case1._intro = "Looking around, you spot a key on the floor. You go to pick it up.\n";
                    case1._ask = "(key) to use the key on the door\n(inspect) to inspect yourself.";
                    case1.ShowDetails();
  
                    keyinspect = Console.ReadLine().ToLower();
                        if (keyinspect == "key")
                        {

                            Story keyinspect = new Story();
                            keyinspect._intro = "You head towards the door and slot the key into the lock. Shaking and fidgeting, the lock snaps open and the door swings outwards.\nYou enter an auspicious room. A heads up display reading END SIMULATION is accompanied by a big red button.";
                            keyinspect._ask = "\n(1) to press the button";
                            keyinspect.ShowDetails();
                            button = Console.ReadLine().ToLower();
                            if (button == "1")
                            {
                                Console.WriteLine("You walk up to the console and press the button. You clutch yourself, bracing the reprecussions of what you have done.");
                                keyinspect.ShowEndSimulationMessage();
                                //END
                            }
                            else
                            {
                                Console.WriteLine("You faint. A cloud of white washes your vision.");
                                keyinspect.ShowEndSimulationMessage();
                                //END
                            }
                        }
                        else if (keyinspect == "inspect")
                        {
                            Story keyinspect1 = new Story();
                            keyinspect1._intro = "You put the key in your pocket. Your skin feels like cold porcelain. A shudder trickles down your spine. A wave of emotions shakes you to your core. You try to grasp any dominent emotion. All you can make is ... fear and uncanniness.";
                            keyinspect1._ask = "\n(1) to snap out of it (2) to give in to the emotions";
                            keyinspect1.ShowDetails();

                            string snapgiveinput = Console.ReadLine();
                            if (snapgiveinput == "1")
                            {
                                Story snapgivein = new Story();
                                snapgivein._intro = "You try to fight the wave of emotions as it pulls you deeper into it's grasps. As you push against it, it draws back its power. Like a line, it's influence snaps and now you are back to reality. You take a moment to recollect yourself.\nYou head towards the door and slot the key into the lock. Shaking and fidgeting, the lock snaps open and the door swings outwards.\nYou enter an auspicious room. A heads up display reading END SIMULATION is accompanied by a big red button.";
                                snapgivein._ask = "(1) press button";
                                snapgivein.ShowDetails();
                                button = Console.ReadLine();
                                if (button == "1")
                                {
                                    Console.WriteLine("You walk up to the console and press the button. You clutch yourself, bracing the reprecussions of what you have done.");
                                    snapgivein.ShowEndSimulationMessage();
                                //END
                                }
                                else
                                {
                                    Console.WriteLine("You faint. A cloud of white washes your vision.");
                                    snapgivein.ShowEndSimulationMessage();
                                //END
                                }
                            }
                            else if (snapgiveinput == "2")
                            {
                                Story snapgivein1 = new Story();
                                snapgivein1._intro="You let go of your grasps on the emotions and let the waves drown you, pulling you into it's darkness. Every inch of your body is submerged in emotions.\n\n";
                                snapgivein1.ShowDetails();
                                snapgivein1.ShowEndSimulationMessage();
                                //END
                            }
                        }
                        break;

                case "2":
                    //inspect yourself
                    Story case2 = new Story();
                    case2._intro = "Your skin feels like cold porcelain. A shudder trickles down your spine. A wave of emotions shakes you to your core. You try to grasp any dominent emotion. All you can make is ... fear and uncanniness.";
                    case2._ask = "\n(1) to snap out of it (2) to give in to the emotions";
                    case2.ShowDetails();
                        string snapgiveinput1 = Console.ReadLine();
                        if (snapgiveinput1 == "1")
                        {
                            Story snapgivein = new Story();
                            snapgivein._intro = "You try to fight the wave of emotions as it pulls you deeper into it's grasps. As you push against it, it draws back its power. Like a line, it's influence snaps and now you are back to reality. You take a moment to recollect yourself.\nYou head towards the door and slot the key into the lock. Shaking and fidgeting, the lock snaps open and the door swings outwards.\nYou enter an auspicious room. A heads up display reading END SIMULATION is accompanied by a big red button.";
                            snapgivein._ask = "(1) press button";
                            snapgivein.ShowDetails();
                            button = Console.ReadLine();
                            if (button == "1")
                            {
                                Console.WriteLine("You walk up to the console and press the button. You clutch yourself, bracing the reprecussions of what you have done.");
                                snapgivein.ShowEndSimulationMessage();
                            //END
                            }
                            else
                            {
                                Console.WriteLine("You faint. A cloud of white washes your vision.");
                                snapgivein.ShowEndSimulationMessage();
                            //END
                            }
                        }
                        else if (snapgiveinput1 == "2")
                        {
                            Story snapgivein1 = new Story();
                            snapgivein1._intro="You let go of your grasps on the emotions and let the waves drown you, pulling you into it's darkness. Every inch of your body is submerged in emotions.\n\n";
                            snapgivein1.ShowDetails();
                            snapgivein1.ShowEndSimulationMessage();
                            //END
                        }
                    break;
                default:
                    Console.WriteLine("Please enter a number from the menu option."); 
                    break;
            }
    }
}