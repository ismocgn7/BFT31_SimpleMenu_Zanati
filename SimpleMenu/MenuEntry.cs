using System;

namespace SimpleMenu
{
    public class MenuEntry
    {
        private string command;
        public string Command => command;
        public string Title { get; }
        private IAction action;

        public MenuEntry(string command, string title, IAction action)
        {
            this.command = command;
            Title = title;
            this.action = action;
        }

        public void PrintTitle()
        {
            Console.WriteLine($"{command}: {Title}");
        }

        public void Execute()
        {
            action.Execute();
        }
    }
}
