using System;
using System.Collections.Generic;

namespace SimpleMenu
{
    public class Menu
    {
        public string Title { get; }
        private List<MenuEntry> items = new List<MenuEntry>();

        public Menu(string title)
        {
            Title = title;
        }

        public void AddItem(MenuEntry item)
        {
            items.Add(item);
        }

        public void StartMenu()
        {
            while (true)
            {
                PrintTitle();
                PrintItems();

                string selection = GetSelection();
                HandleSelection(selection);
            }
        }

        private void PrintTitle()
        {
            Console.WriteLine($"\n{Title}");
            Console.WriteLine(new string('=', Title.Length));
        }

        private void PrintItems()
        {
            foreach (var item in items)
            {
                item.PrintTitle();
            }
        }

        private string GetSelection()
        {
            Console.Write("\nWählen Sie eine Option: ");
            return Console.ReadLine();
        }

        private void HandleSelection(string selection)
        {
            foreach (var item in items)
            {
                if (item.Command.Equals(selection, StringComparison.OrdinalIgnoreCase))
                {
                    item.Execute();
                    return;
                }
            }

            Console.WriteLine("Ungültige Auswahl. Bitte versuchen Sie es erneut.");
        }
    }
}