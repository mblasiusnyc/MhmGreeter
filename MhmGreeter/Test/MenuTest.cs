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
			menu = new Menu ( new Dictionary<string, Greeter.GreetingType> () {
				{ "a", Greeter.GreetingType.ENGLISH },
				{ "b", Greeter.GreetingType.DOG },
				{ "c", Greeter.GreetingType.FRENCH },
			});
		}

		[Test ()]
		public void ValidMenuSelectionsShouldReturnCorrectEnumeratedGreetingTypes ()
		{
			Assert.AreEqual (Greeter.GreetingType.ENGLISH, menu.GetGreetingTypeForKey ("a"));
			Assert.AreEqual (Greeter.GreetingType.DOG, menu.GetGreetingTypeForKey ("b"));
			Assert.AreEqual (Greeter.GreetingType.FRENCH, menu.GetGreetingTypeForKey ("c"));
		}

		[Test ()]
		public void ValidUpperCaseMenuSelectionsShouldReturnCorrectEnumeratedGreetingTypes ()
		{
			Assert.AreEqual (Greeter.GreetingType.ENGLISH, menu.GetGreetingTypeForKey ("A"));
			Assert.AreEqual (Greeter.GreetingType.DOG, menu.GetGreetingTypeForKey ("B"));
			Assert.AreEqual (Greeter.GreetingType.FRENCH, menu.GetGreetingTypeForKey ("C"));
		}

		[Test ()]
		public void InvalidMenuSelectionsShouldReturnGreetingTypeInvalid ()
		{
			Assert.AreEqual (Greeter.GreetingType.INVALID, menu.GetGreetingTypeForKey ("r"));
			Assert.AreEqual (Greeter.GreetingType.INVALID, menu.GetGreetingTypeForKey ("not a valid key"));
			Assert.AreEqual (Greeter.GreetingType.INVALID, menu.GetGreetingTypeForKey ("42"));
		}

		[Test ()]
		public void EmptyMenuSelectionsShouldReturnGreetingTypeEmpty ()
		{
			Assert.AreEqual (Greeter.GreetingType.EMPTY, menu.GetGreetingTypeForKey (""));
			Assert.AreEqual (Greeter.GreetingType.EMPTY, menu.GetGreetingTypeForKey (null));
		}
	}
}

