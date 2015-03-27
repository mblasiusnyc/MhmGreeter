using System;

namespace MhmGreeter
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Menu menu = new Menu ();
			menu.PrintWelcomeScreen ();

			menu.PrintInitialMenuWithPrompt ();
			while (true) {
				var greetingSelection = menu.ReadGreetingSelection ();

				// quit
				if (greetingSelection.ToLower () == "x") {
					break;
				}

				menu.PrintLoopingMenuWithPrompt ();
			}
		}

		static bool userWantsToExit (string greetingSelection)
		{
			return greetingSelection.ToLower () == "x";
		}
	}
}
