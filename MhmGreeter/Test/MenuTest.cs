using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace MhmGreeter.Test
{
	[TestFixture ()]
	public class MenuTest
	{
		Menu menu;

		[SetUp ()]
		public void MenuCreation ()
		{
			var menuConfig = new Dictionary<string, Greeter.Type> () {
				{ "a", Greeter.Type.ENGLISH },
				{ "b", Greeter.Type.DOG },
				{ "c", Greeter.Type.FRENCH },
			};

			menu = new Menu (menuConfig);
		}

		[Test ()]
		public void ValidMenuSelectionsShouldReturnCorrectEnumeratedGreetingTypes ()
		{
			Assert.AreEqual (Greeter.Type.ENGLISH, menu.GetGreetingTypeGivenMenuSelection ("a"));
			Assert.AreEqual (Greeter.Type.DOG, menu.GetGreetingTypeGivenMenuSelection ("b"));
			Assert.AreEqual (Greeter.Type.FRENCH, menu.GetGreetingTypeGivenMenuSelection ("c"));
		}

		[Test ()]
		public void InvalidMenuSelectionsShouldReturnGreetingTypeInvalid ()
		{
			Assert.AreEqual (Greeter.Type.INVALID, menu.GetGreetingTypeGivenMenuSelection ("r"));
			Assert.AreEqual (Greeter.Type.INVALID, menu.GetGreetingTypeGivenMenuSelection ("not a valid key"));
			Assert.AreEqual (Greeter.Type.INVALID, menu.GetGreetingTypeGivenMenuSelection ("42"));
		}

		[Test ()]
		public void EmptyMenuSelectionsShouldReturnGreetingTypeEmpty ()
		{
			Assert.AreEqual (Greeter.Type.EMPTY, menu.GetGreetingTypeGivenMenuSelection (""));
			Assert.AreEqual (Greeter.Type.EMPTY, menu.GetGreetingTypeGivenMenuSelection (null));
		}

	}
}

