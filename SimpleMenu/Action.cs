using System;

namespace SimpleMenu
{
    public abstract class Action : IAction
    {
        public abstract void Execute();

        protected void WaitOnKey()
        {
            Console.WriteLine("\nDrücken Sie eine beliebige Taste, um fortzufahren...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}