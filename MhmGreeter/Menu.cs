using System;
using System.Collections.Generic;

namespace MhmGreeter
{
	class Menu
	{
		private Dictionary<string,GreetingType> _menuItems;

		public Menu(Dictionary<string, GreetingType> menuItems)
		{
			_menuItems = menuItems;
		}

		public void PrintWelcomeScreen ()
		{
			Console.WriteLine ("Welcome to MhmGreeter!");
		}

		public void PrintGreetingMenu ()
		{
			foreach(var menuItem in _menuItems) 
			{
				Console.WriteLine(menuItem.Key);
			}
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
