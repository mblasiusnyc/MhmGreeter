﻿using System;

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
