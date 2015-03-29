using System;
using System.Collections.Generic;

namespace MhmGreeter
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var menuConfig = new Dictionary<string, Greeter.Type> () {
				{ "a", Greeter.Type.ENGLISH },
				{ "b", Greeter.Type.DOG },
				{ "c", Greeter.Type.CAT },
				{ "d", Greeter.Type.FRENCH },
				{ "e", Greeter.Type.MULTILINGUAL },
				{ "f", Greeter.Type.RANDOM },
				{ "g", Greeter.Type.IMPATIENT },
				{ "x", Greeter.Type.EXIT }
			};
			Menu menu = new Menu (menuConfig);

			menu.PrintWelcomeScreen ();
			menu.PrintInitialPromptWithMenu ();

			while (true) {
				var userInput = Console.ReadLine ();

				var greetingSelection = menu.GetGreetingTypeGivenMenuSelection (userInput);
				if (greetingSelection == Greeter.Type.EXIT) {
					break;
				}
				Greeter.PrintGreeting (greetingSelection);

				menu.PrintLoopingPromptWithMenu ();
			}
			Console.WriteLine ("Goodbye!");
		}

	}
}
