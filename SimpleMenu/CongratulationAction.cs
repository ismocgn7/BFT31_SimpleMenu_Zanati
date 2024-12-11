using System;

namespace SimpleMenu
{
    public class CongratulationAction : Action
    {
        public override void Execute()
        {
            Console.Clear();
            Console.WriteLine("Herzlichen Glückwunsch! Sie haben die Aktion ausgeführt.");
            WaitOnKey();
        }
    }
}