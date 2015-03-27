using System;

namespace MhmGreeter
{
	class Menu
	{
		public Menu()
		{
			
		}

		public void PrintWelcomeScreen ()
		{
			Console.WriteLine ("Welcome to MhmGreeter!");
		}

		public void PrintGreetingMenu ()
		{
			// TODO: print all greeting options
		}

		public void PrintExitOption ()
		{
			Console.WriteLine ("x) Exit the application");
		}

		public void PrintPrompt ()
		{
			Console.Write (">> ");
		}

		public void PrintInitialMenuWithPrompt ()
		{
			Console.WriteLine ("Please select one of the following Greetings:");
			PrintGreetingMenu ();
			PrintPrompt ();
		}

		public void PrintLoopingMenuWithPrompt ()
		{
			Console.WriteLine ("Would you like to select another greeting? ('X' to exit):");
			PrintGreetingMenu ();
			PrintExitOption ();
			PrintPrompt ();
		}

		public string ReadGreetingSelection ()
		{
			var input = Console.ReadLine ();
			return input;
		}
	}
}
