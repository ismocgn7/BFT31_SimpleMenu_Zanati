using System;

namespace SimpleMenu
{
    class Program
    {
        static void Main()
        {
            Menu menu = new Menu("Main Menu");

            menu.AddItem(new MenuEntry("1", "Say Hello", new HelloAction()));
            menu.AddItem(new MenuEntry("2", "Send Congratulations", new CongratulationAction()));
            menu.AddItem(new MenuEntry("Q", "Quit", new QuitAction()));

            menu.StartMenu();
        }
    }
}