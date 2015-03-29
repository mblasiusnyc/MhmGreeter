using System;
using System.Collections.Generic;

namespace MhmGreeter
{
	class Menu
	{
		readonly Dictionary<string, Greeter.Type> _menuItems;

		public Menu (Dictionary<string, Greeter.Type> menuItemsConfiguration)
		{
			_menuItems = menuItemsConfiguration;
		}

		public void PrintWelcomeScreen ()
		{
			Console.WriteLine ("Welcome to MhmGreeter!");
		}

		public void PrintMenu ()
		{
			foreach (var menuItem in _menuItems) {
				PrintMenuItem (menuItem);
			}
		}

		void PrintMenuItem (KeyValuePair<string, Greeter.Type> menuItem)
		{
			Console.WriteLine (" " + menuItem.Key + ") " + Greeter.MenuDescriptions [menuItem.Value]);
		}

		void PrintPrompt ()
		{
			Console.Write (">> ");
		}

		public void PromptUser ()
		{
			Console.WriteLine ("Please select one of the following Greetings:");
			PrintMenu ();
			PrintPrompt ();
		}

		public void RepromptUser ()
		{
			Console.WriteLine ("Would you like to select another greeting? ('X' to exit):");
			PrintMenu ();
			PrintPrompt ();
		}

		public Greeter.Type GetGreetingTypeForKey (string key)
		{
			if (string.IsNullOrEmpty (key)) {
				return Greeter.Type.EMPTY;
			}

			key = key.ToLower ();
			if (_menuItems.ContainsKey (key)) {
				return _menuItems [key];
			} else {
				return Greeter.Type.INVALID;
			}
		}
	}
}
