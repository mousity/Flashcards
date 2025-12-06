using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spectre.Console;
using static flashcards.Enums;

namespace flashcards
{
    internal class UserInterface
    {
        public static void MainMenu()
        {
            bool runMenu = true;
            while (runMenu)
            {
                AnsiConsole.Markup("[green]Welcome to your Flashcards program![/]");

                var choice = AnsiConsole.Prompt(
                        new SelectionPrompt<MenuOptions>()
                        .Title("\nChoose an option from the menu below to continue.\n")
                        .AddChoices(MenuOptions.ViewAllStacks,
                                    MenuOptions.Quit)
                    );
            }


        }
    }
}
