using System;
using System.Collections.Generic;

namespace MhmGreeter
{
	class Menu
	{
		private Dictionary<string, Greeter.Type> _menuItems;

		public Menu (Dictionary<string, Greeter.Type> menuItemsConfiguration)
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

		void PrintMenuItem (KeyValuePair<string, Greeter.Type> menuItem)
		{
			Console.WriteLine (" " + menuItem.Key + ") " + Greeter.MenuDescriptions [menuItem.Value]);
		}

		public void PrintPrompt ()
		{
			Console.Write (">> ");
		}

		public void PromptUser ()
		{
			Console.WriteLine ("Please select one of the following Greetings:");
			PrintGreetingMenu ();
			PrintPrompt ();
		}

		public void RepromptUser ()
		{
			Console.WriteLine ("Would you like to select another greeting? ('X' to exit):");
			PrintGreetingMenu ();
			PrintPrompt ();
		}

		public Greeter.Type GetGreetingTypeGivenMenuSelection (string selection)
		{
			if (string.IsNullOrEmpty (selection)) {
				return Greeter.Type.EMPTY;
			}

			selection = selection.ToLower ();
			if (_menuItems.ContainsKey (selection)) {
				return _menuItems [selection];
			} else {
				return Greeter.Type.INVALID;
			}
		}
	}
}
