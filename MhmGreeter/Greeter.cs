using System;
using System.Collections.Generic;

namespace MhmGreeter
{
	static class Greeter
	{
		public enum GreetingType
		{
			CAT,
			DOG,
			ENGLISH,
			FRENCH,
			IMPATIENT,
			MULTILINGUAL,
			RANDOM,
			SPANISH,
			EMPTY,
			EXIT,
			INVALID
		}

		public static readonly Dictionary<GreetingType, string> MenuDescriptions = new Dictionary<GreetingType, string> {
			{ GreetingType.CAT, "Cat" },
			{ GreetingType.DOG, "Dog" }, 
			{ GreetingType.ENGLISH, "English speaking person" }, 
			{ GreetingType.FRENCH, "French speaking person" }, 
			{ GreetingType.IMPATIENT, "Impatient person" }, 
			{ GreetingType.MULTILINGUAL, "Multilingual greeting" }, 
			{ GreetingType.RANDOM, "Random greeting" }, 
			{ GreetingType.SPANISH, "Spanish person" }, 
			{ GreetingType.EMPTY, "Empty user input." },
			{ GreetingType.EXIT, "Exit the application" },
			{ GreetingType.INVALID, "Invalid user input." },
		};

		public static readonly Dictionary<GreetingType, string> GreetingStrings = new Dictionary<GreetingType, string> {
			{ GreetingType.CAT, "Meow." },
			{ GreetingType.DOG, "Bark!" }, 
			{ GreetingType.ENGLISH, "Hello" }, 
			{ GreetingType.FRENCH, "Bonjour" }, 
			{ GreetingType.IMPATIENT, "" }, 
			{ GreetingType.MULTILINGUAL, "" }, 
			{ GreetingType.RANDOM, "" }, 
			{ GreetingType.SPANISH, "Hola" }, 
			{ GreetingType.EMPTY, "" },
			{ GreetingType.EXIT, "Goodbye!" },
			{ GreetingType.INVALID, "I'm sorry - you have made an invalid selection" },
		};

		public static void PrintGreeting (GreetingType greetingSelection)
		{
			switch (greetingSelection) { 
			case GreetingType.RANDOM: 
				printRandomGreeting ();
				break;
			case GreetingType.IMPATIENT:
				printImpatientGreeting ();
				break;
			case GreetingType.MULTILINGUAL:
				printMultilingualGreeting ();
				break;
			default:
				Console.WriteLine (GreetingStrings [greetingSelection]);
				Console.WriteLine ();
				break;
			}
		}

		static void printRandomGreeting ()
		{
			var AvailableRandomGreetings = new List<GreetingType> {
				GreetingType.CAT,
				GreetingType.DOG,
				GreetingType.ENGLISH,
				GreetingType.FRENCH,
				GreetingType.SPANISH
			};

			var rand = new Random ();
			var greetingKey = AvailableRandomGreetings [rand.Next (AvailableRandomGreetings.Count)];
			PrintGreeting (greetingKey);
		}

		static void printMultilingualGreeting ()
		{			
			var AvailableMultilingualGreetings = new List<GreetingType> {
				GreetingType.ENGLISH,
				GreetingType.FRENCH,
				GreetingType.SPANISH
			};

			var rand = new Random ();
			var greetingKey = AvailableMultilingualGreetings [rand.Next (AvailableMultilingualGreetings.Count)];

			PrintGreeting (greetingKey);
		}

		static void printImpatientGreeting ()
		{
			_numTimesImpatientGreeterBothered++;
			if ((_numTimesImpatientGreeterBothered % 3) != 0) {
				Console.WriteLine (_patientGreeting);
				Console.WriteLine ();
			} else {
				Console.WriteLine (_impatientGreeting);
				Console.WriteLine ();
			}
		}

		static int _numTimesImpatientGreeterBothered = 0;
		const string _patientGreeting = "Oh, hello.";
		const string _impatientGreeting = "Not now! I'm busy.";
	}
}
