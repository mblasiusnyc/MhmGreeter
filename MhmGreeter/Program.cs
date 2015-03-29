using System;
using System.Collections.Generic;

namespace MhmGreeter
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var menuConfig = new MenuItemsConfiguration () {
				{ "a", Greeting.Type.ENGLISH },
				{ "b", Greeting.Type.DOG },
				{ "c", Greeting.Type.CAT },
				{ "d", Greeting.Type.FRENCH },
				{ "e", Greeting.Type.MULTILINGUAL },
				{ "f", Greeting.Type.RANDOM },
				{ "g", Greeting.Type.IMPATIENT },
				{ "x", Greeting.Type.EXIT }
			};
			Menu menu = new Menu (menuConfig);

			menu.PrintWelcomeScreen ();
			menu.PrintInitialMenuWithPrompt ();

			while (true) {
				var userInput = Console.ReadLine ();
				var greetingSelection = menu.GetGreetingTypeGivenMenuSelection (userInput);

				if (greetingSelection == Greeting.Type.EXIT) {
					break;
				}

				PrintGreeting (greetingSelection);

				menu.PrintLoopingMenuWithPrompt ();
			}

			Console.WriteLine ("Goodbye!");
		}

		static void PrintGreeting (Greeting.Type greetingSelection)
		{
			Console.WriteLine (Greeting.Greetings[greetingSelection]);
		}
	}
}
