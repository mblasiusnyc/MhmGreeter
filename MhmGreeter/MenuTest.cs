using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace MhmGreeter
{
	[TestFixture ()]
	public class MenuTest
	{
		Menu menu;

		[SetUp ()]
		public void MenuCreation ()
		{
			var menuConfig = new MenuItemsConfiguration () {
				{ "a", Greeting.Type.ENGLISH },
				{ "b", Greeting.Type.DOG },
				{ "c", Greeting.Type.FRENCH },
			};

			menu = new Menu (menuConfig);
		}

		[Test ()]
		public void ValidMenuSelectionsShouldReturnCorrectEnumeratedGreetingTypes ()
		{
			Assert.AreEqual (Greeting.Type.ENGLISH, menu.GetGreetingTypeGivenMenuSelection ("a"));
			Assert.AreEqual (Greeting.Type.DOG, menu.GetGreetingTypeGivenMenuSelection ("b"));
			Assert.AreEqual (Greeting.Type.FRENCH, menu.GetGreetingTypeGivenMenuSelection ("c"));
		}

		[Test ()]
		public void InvalidMenuSelectionsShouldReturnGreetingTypeInvalid ()
		{
			Assert.AreEqual (Greeting.Type.INVALID, menu.GetGreetingTypeGivenMenuSelection ("r"));
			Assert.AreEqual (Greeting.Type.INVALID, menu.GetGreetingTypeGivenMenuSelection ("not a valid key"));
			Assert.AreEqual (Greeting.Type.INVALID, menu.GetGreetingTypeGivenMenuSelection ("42"));
		}

	}
}

