using System;
using System.Collections.Generic;

namespace MhmGreeter
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Menu menu = new Menu ( new Dictionary<string, Greeter.GreetingType> () {
				{ "a", Greeter.GreetingType.ENGLISH },
				{ "b", Greeter.GreetingType.DOG },
				{ "c", Greeter.GreetingType.CAT },
				{ "d", Greeter.GreetingType.FRENCH },
				{ "e", Greeter.GreetingType.MULTILINGUAL },
				{ "f", Greeter.GreetingType.RANDOM },
				{ "g", Greeter.GreetingType.IMPATIENT },
				{ "x", Greeter.GreetingType.EXIT }
			});

			Console.WriteLine ("Welcome to MhmGreeter!");
			menu.PromptUser ();

			while (true) {
				var userInput = Console.ReadLine ();

				var greetingSelection = menu.GetGreetingTypeForKey (userInput);
				Greeter.PrintGreeting (greetingSelection);
				if (greetingSelection == Greeter.GreetingType.EXIT) {
					break;
				}

				menu.RepromptUser ();
			}
		}
	}
}
