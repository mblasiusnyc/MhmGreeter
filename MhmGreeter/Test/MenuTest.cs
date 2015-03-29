using System.Collections.Generic;
using NUnit.Framework;

namespace MhmGreeter.Test
{
	[TestFixture ()]
	public class MenuTest
	{
		Menu menu;

		[SetUp ()]
		public void CreateTestMenu ()
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
			Assert.AreEqual (Greeter.Type.ENGLISH, menu.GetGreetingTypeForKey ("a"));
			Assert.AreEqual (Greeter.Type.DOG, menu.GetGreetingTypeForKey ("b"));
			Assert.AreEqual (Greeter.Type.FRENCH, menu.GetGreetingTypeForKey ("c"));
		}

		[Test ()]
		public void ValidUpperCaseMenuSelectionsShouldReturnCorrectEnumeratedGreetingTypes ()
		{
			Assert.AreEqual (Greeter.Type.ENGLISH, menu.GetGreetingTypeForKey ("A"));
			Assert.AreEqual (Greeter.Type.DOG, menu.GetGreetingTypeForKey ("B"));
			Assert.AreEqual (Greeter.Type.FRENCH, menu.GetGreetingTypeForKey ("C"));
		}

		[Test ()]
		public void InvalidMenuSelectionsShouldReturnGreetingTypeInvalid ()
		{
			Assert.AreEqual (Greeter.Type.INVALID, menu.GetGreetingTypeForKey ("r"));
			Assert.AreEqual (Greeter.Type.INVALID, menu.GetGreetingTypeForKey ("not a valid key"));
			Assert.AreEqual (Greeter.Type.INVALID, menu.GetGreetingTypeForKey ("42"));
		}

		[Test ()]
		public void EmptyMenuSelectionsShouldReturnGreetingTypeEmpty ()
		{
			Assert.AreEqual (Greeter.Type.EMPTY, menu.GetGreetingTypeForKey (""));
			Assert.AreEqual (Greeter.Type.EMPTY, menu.GetGreetingTypeForKey (null));
		}
	}
}

