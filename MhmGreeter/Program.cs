using System;

namespace MhmGreeter
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			PrintWelcomeScreen ();

			PrintInitialMenuWithPrompt ();
			while(true) 
			{
				var greetingSelection = ReadGreetingSelection ();

				//   ACT ON INPUT

				// quit
				if (greetingSelection.ToLower () == "x") {
					break;
				}

				PrintLoopingMenuWithPrompt();
			}
		}

		static void PrintWelcomeScreen ()
		{
			Console.WriteLine ("Welcome to MhmGreeter!");
		}

		static void PrintGreetingMenu ()
		{
			// TODO: print all greeting options
		}

		static void PrintExitOption ()
		{
			Console.WriteLine ("x) Exit the application");
		}

		static void PrintPrompt ()
		{
			Console.Write (">> ");
		}

		static void PrintInitialMenuWithPrompt ()
		{
			Console.WriteLine ("Please select one of the following Greetings:");
			PrintGreetingMenu ();
			PrintPrompt ();
		}

		static void PrintLoopingMenuWithPrompt ()
		{
			Console.WriteLine ("Please select one of the following Greetings ('X' to exit):");
			PrintGreetingMenu ();
			PrintExitOption ();
			PrintPrompt ();
		}

		static string ReadGreetingSelection ()
		{
			var input = Console.ReadLine();
			return input;
		}

		static bool userWantsToExit (string greetingSelection)
		{
			return greetingSelection.ToLower () == "x";
		}
	}
}
