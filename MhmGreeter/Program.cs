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
			menu.PromptUser ();

			while (true) {
				var userInput = Console.ReadLine ();

				var greetingSelection = menu.GetGreetingTypeGivenMenuSelection (userInput);
				Greeter.PrintGreeting (greetingSelection);
				if (greetingSelection == Greeter.Type.EXIT) {
					break;
				}

				menu.RepromptUser ();
			}
		}
	}
}
