using System;

namespace MhmGreeter
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			PrintWelcomeScreen ();
			while (true) {
				var selection = Console.ReadKey ();
				if (selection.KeyChar == 'x' || selection.KeyChar == 'X') { 
					break;
				}

				Console.WriteLine ();
				Console.WriteLine ("You selected: " + selection.KeyChar);

				PrintMenuWithPrompt ();
			}

			Console.WriteLine ("Goodbye!");
		}

		static void PrintWelcomeScreen ()
		{
			Console.WriteLine ("Welcome to MhmGreeter!");
			PrintMenuWithPrompt ();
		}

		static void PrintMenu ()
		{
			Console.WriteLine ("Please select a greeting:");
			Console.WriteLine ("  a) English");
			Console.WriteLine ("  b) Dog");
			Console.WriteLine ("  c) Cat");
			Console.WriteLine ("  d) French");
			Console.WriteLine ("  e) Multilingual");
			Console.WriteLine ("  f) Random");
			Console.WriteLine ("  g) Impatient");
		}

		static void PrintPrompt ()
		{
			Console.Write ("> ");
		}

		static void PrintMenuWithPrompt ()
		{
			PrintMenu ();
			PrintPrompt ();
		}
	}
}
