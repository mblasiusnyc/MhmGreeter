using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace MhmGreeter
{
	using MenuConfig = Dictionary<string, GreetingType>;

	[TestFixture ()]
	public class MenuTest
	{
		Menu menu;

		[SetUp ()]
		public void MenuCreation ()
		{
			var menuConfig = new MenuItemsConfiguration () {
				{ "a", GreetingType.ENGLISH },
				{ "b", GreetingType.DOG },
				{ "c", GreetingType.FRENCH },
			};

			menu = new Menu (menuConfig);
		}

		[Test()]
		public void ValidMenuSelectionsShouldReturnCorrectEnumeratedGreetingTypes () {
			Assert.AreEqual (GreetingType.ENGLISH, menu.GetGreetingTypeGivenMenuSelection ("a"));
			Assert.AreEqual (GreetingType.DOG, menu.GetGreetingTypeGivenMenuSelection ("b"));
			Assert.AreEqual (GreetingType.FRENCH, menu.GetGreetingTypeGivenMenuSelection ("c"));
		}

		[Test()]
		public void InvalidMenuSelectionsShouldReturnGreetingTypeInvalid () {
			Assert.AreEqual (GreetingType.INVALID, menu.GetGreetingTypeGivenMenuSelection ("r"));
			Assert.AreEqual (GreetingType.INVALID, menu.GetGreetingTypeGivenMenuSelection ("not a valid key"));
			Assert.AreEqual (GreetingType.INVALID, menu.GetGreetingTypeGivenMenuSelection ("42"));
		}

	}
}

