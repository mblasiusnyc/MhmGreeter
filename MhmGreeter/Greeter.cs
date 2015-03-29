using System;
using System.Collections.Generic;

namespace MhmGreeter
{
	static class Greeter
	{
		public enum Type
		{
			CAT,
			DOG,
			ENGLISH,
			FRENCH,
			IMPATIENT,
			MULTILINGUAL,
			RANDOM,
			SPANISH,
			EXIT,
			EMPTY,
			INVALID
		}

		public static readonly Dictionary<Type, string> MenuDescriptions = new Dictionary<Type, string> {
			{ Type.CAT, "Cat" },
			{ Type.DOG, "Dog" }, 
			{ Type.ENGLISH, "English speaking person" }, 
			{ Type.FRENCH, "French speaking person" }, 
			{ Type.IMPATIENT, "Impatient person" }, 
			{ Type.MULTILINGUAL, "Multilingual greeting" }, 
			{ Type.RANDOM, "Random greeting" }, 
			{ Type.SPANISH, "Spanish person" }, 
			{ Type.EXIT, "Exit the application" },
		};

		public static readonly Dictionary<Type, string> GreetingStrings = new Dictionary<Type, string> {
			{ Type.CAT, "Meow." },
			{ Type.DOG, "Bark!" }, 
			{ Type.ENGLISH, "Hello" }, 
			{ Type.FRENCH, "Bonjour" }, 
			{ Type.SPANISH, "Hola" }, 
			{ Type.EMPTY, "" },
			{ Type.INVALID, "I'm sorry - you have made an invalid selection" },
			{ Type.EXIT, "Goodbye!" },
		};

		public static void PrintGreeting (Type greetingSelection)
		{
			switch (greetingSelection) { 
			case Type.RANDOM: 
				printRandomGreeting ();
				break;
			case Type.IMPATIENT:
				printImpatientGreeting ();
				break;
			case Type.MULTILINGUAL:
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
			var AvailableRandomGreetings = new List<Type> {
				Type.CAT,
				Type.DOG,
				Type.ENGLISH,
				Type.FRENCH,
				Type.SPANISH
			};

			var rand = new Random ();
			var greetingKey = AvailableRandomGreetings [rand.Next (AvailableRandomGreetings.Count)];
			PrintGreeting (greetingKey);
		}

		static void printMultilingualGreeting ()
		{			
			var AvailableMultilingualGreetings = new List<Type> {
				Type.ENGLISH,
				Type.FRENCH,
				Type.SPANISH
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
