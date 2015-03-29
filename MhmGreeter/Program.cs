using System;
using System.Collections.Generic;

namespace MhmGreeter
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var menuConfig = new MenuItemsConfiguration () {
				{ "a", GreetingType.ENGLISH },
				{ "b", GreetingType.FRENCH },
				{ "c", GreetingType.DOG },
				{ "x", GreetingType.EXIT } 
			};
			Menu menu = new Menu (menuConfig);

			menu.PrintWelcomeScreen ();
			menu.PrintInitialMenuWithPrompt ();

			while (true) {
				var userInput = Console.ReadLine ();
				var greetingSelection = menu.GetGreetingTypeGivenMenuSelection (userInput);

				if (greetingSelection == GreetingType.EXIT) {
					break;
				}

				PrintGreeting (greetingSelection);

				menu.PrintLoopingMenuWithPrompt ();
			}

			Console.WriteLine ("Goodbye!");
		}

		static void PrintGreeting (GreetingType greetingSelection)
		{
			Console.WriteLine ("You selected: " + greetingSelection);
		}
	}
}
