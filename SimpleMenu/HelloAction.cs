using System;

namespace SimpleMenu
{
    public class HelloAction : Action
    {
        public override void Execute()
        {
            Console.Clear();    
            Console.WriteLine("Hallo, Welt!");
            WaitOnKey();
            Console.Clear();
        }
    }
}