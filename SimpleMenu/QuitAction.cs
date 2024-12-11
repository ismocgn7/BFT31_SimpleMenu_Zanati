using System;

namespace SimpleMenu
{
    public class QuitAction : Action
    {
        public override void Execute()
        {
            Console.WriteLine("Tschüss!");
            Environment.Exit(0);
        }
    }
}
