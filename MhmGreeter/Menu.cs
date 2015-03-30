using System;
using System.Collections.Generic;

namespace MhmGreeter
{
	class Menu
	{
		public Menu (Dictionary<string, Greeter.GreetingType> menuItemsConfiguration)
		{
			_menuItems = menuItemsConfiguration;
		}

		public void PromptUser ()
		{
			Console.WriteLine ("Please select one of the following Greetings:");
			PrintMenuWithPrompt ();
		}

		public void RepromptUser ()
		{
			Console.WriteLine ();
			Console.WriteLine ("Would you like to select another greeting? ('X' to exit):");
			PrintMenuWithPrompt ();
		}

		public Greeter.GreetingType GetGreetingTypeForKey (string key)
		{
			if (string.IsNullOrEmpty (key)) {
				return Greeter.GreetingType.EMPTY;
			}

			key = key.ToLower ();
			if (_menuItems.ContainsKey (key)) {
				return _menuItems [key];
			} else {
				return Greeter.GreetingType.INVALID;
			}
		}

		void PrintMenu ()
		{
			foreach (var menuItem in _menuItems) {
				PrintMenuItem (menuItem);
			}
		}

		void PrintMenuItem (KeyValuePair<string, Greeter.GreetingType> menuItem)
		{
			Console.WriteLine (" " + menuItem.Key + ") " + Greeter.MenuDescriptions [menuItem.Value]);
		}

		void PrintMenuWithPrompt ()
		{
			PrintMenu ();
			PrintPrompt ();
		}

		void PrintPrompt ()
		{
			Console.Write (">> ");
		}

		readonly Dictionary<string, Greeter.GreetingType> _menuItems;
	}
}
