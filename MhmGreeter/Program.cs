using System;
using System.Collections.Generic;


namespace MhmGreeter
{
	using MenuConfig = Dictionary<string, GreetingType>;

	class MainClass
	{
		 
		public static void Main (string[] args)
		{
			MenuConfig menuConfig = new MenuConfig () {
				{ "a", GreetingType.ENGLISH },
				{ "b", GreetingType.FRENCH },
				{ "c", GreetingType.DOG } 
			};
			Menu menu = new Menu (menuConfig);
			 
			menu.PrintWelcomeScreen ();
			menu.PrintInitialMenuWithPrompt ();
			while (true) {
				var greetingSelection = menu.ReadGreetingSelection ();

				// quit
				if (UserWantsToExit(greetingSelection)) {
					break;
				}

				menu.PrintLoopingMenuWithPrompt ();
			}
		}

		static bool UserWantsToExit (string greetingSelection)
		{
			return greetingSelection.ToLower () == "x";
		}
	}
}
