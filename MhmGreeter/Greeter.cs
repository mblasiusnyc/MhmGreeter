using System;
using System.Collections.Generic;

namespace MhmGreeter
{
	static public class Greeter
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

		public static Dictionary<Type, string> MenuDescriptions = new Dictionary<Type, string> {
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

		public static Dictionary<Type, string> GreetingStrings = new Dictionary<Type, string> {
			{ Type.CAT, "Meow." },
			{ Type.DOG, "Bark!" }, 
			{ Type.ENGLISH, "Hello" }, 
			{ Type.FRENCH, "Bonjour" }, 
			{ Type.SPANISH, "Hola" }, 
			{ Type.EMPTY, "" },
			{ Type.INVALID, "I'm sorry - you have made an invalid selection" },
			{ Type.EXIT, "Goodbye!" },
		};

		static public void PrintGreeting (Type greetingSelection)
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
			numTimesImpatientGreeterBothered++;
			if ((numTimesImpatientGreeterBothered % 3) != 0) {
				Console.WriteLine (patientGreeting);
				Console.WriteLine ();
			} else {
				Console.WriteLine (impatientGreeting);
				Console.WriteLine ();
			}
		}

		static int numTimesImpatientGreeterBothered = 0;
		static string patientGreeting = "Oh, hello.";
		static string impatientGreeting = "Not now! I'm busy.";
	}
}
