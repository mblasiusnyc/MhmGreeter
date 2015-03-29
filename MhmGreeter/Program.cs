using System;
using System.Collections.Generic;


namespace MhmGreeter
{
	using MenuConfig = Dictionary<string, GreetingType>;

	class MainClass
	{
		public static void Main (string[] args)
		{
			var menuConfig = new MenuConfig () {
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

				if (greetingSelection == GreetingType.INVALID) {
					menu.PrintInvalidSelectionWarningWithPrompt ();
				} else {
					Console.WriteLine("You selected: " + greetingSelection);
					menu.PrintLoopingMenuWithPrompt ();
				}
			}

			Console.WriteLine ("Goodbye!");
		}
	}
}
