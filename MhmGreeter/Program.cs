using System;
using System.Collections.Generic;


namespace MhmGreeter
{
	using MenuItem = KeyValuePair<string, GreetingType>;
	using MenuConfig = List<KeyValuePair<string, GreetingType>>;

	class MainClass
	{
		 
		public static void Main (string[] args)
		{
			MenuConfig menuConfig = new MenuConfig () {
				new MenuItem ( "a", GreetingType.ENGLISH ),
				new MenuItem ( "b", GreetingType.FRENCH ), 
				new MenuItem ( "c", GreetingType.DOG ) 
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
