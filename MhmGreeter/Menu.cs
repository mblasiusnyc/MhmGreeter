using System;
using System.Collections.Generic;

namespace MhmGreeter
{
	class Menu
	{
		private Dictionary<string, Greeting.Type> _menuItems;

		public Menu (Dictionary<string, Greeting.Type> menuItemsConfiguration)
		{
			_menuItems = menuItemsConfiguration;
		}

		public void PrintWelcomeScreen ()
		{
			Console.WriteLine ("Welcome to MhmGreeter!");
		}

		public void PrintGreetingMenu ()
		{
			foreach (var menuItem in _menuItems) {
				PrintMenuItem (menuItem);
			}
		}

		void PrintMenuItem (KeyValuePair<string, Greeting.Type> menuItem)
		{
			Console.WriteLine (" " + menuItem.Key + ") " + Greeting.MenuDescriptions [menuItem.Value]);
		}

		public void PrintPrompt ()
		{
			Console.Write (">> ");
		}

		public void PrintInitialPromptWithMenu ()
		{
			Console.WriteLine ("Please select one of the following Greetings:");
			PrintGreetingMenu ();
			PrintPrompt ();
		}

		public void PrintLoopingPromptWithMenu ()
		{
			Console.WriteLine ("Would you like to select another greeting? ('X' to exit):");
			PrintGreetingMenu ();
			PrintPrompt ();
		}

		public Greeting.Type GetGreetingTypeGivenMenuSelection (string selection)
		{
			if (selection == "" || selection == null) {
				return Greeting.Type.EMPTY;
			}

			if (_menuItems.ContainsKey (selection)) {
				return _menuItems [selection];
			} else {
				return Greeting.Type.INVALID;
			}
		}
	}
}
