using System;
using System.Collections.Generic;

namespace MhmGreeter
{
	class Menu
	{
		private MenuItemsConfiguration _menuItems;

		public Menu(MenuItemsConfiguration menuItems)
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
				Console.WriteLine(" " + menuItem.Key + ") " + Greeting.MenuDescriptions[menuItem.Value]);
			}
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
			PrintPrompt ();
		}

		public Greeting.Type GetGreetingTypeGivenMenuSelection (string key)
		{
			if (_menuItems.ContainsKey (key)) {
				return _menuItems [key];
			}
			else {
				return Greeting.Type.INVALID;
			}
		}
	}
}
