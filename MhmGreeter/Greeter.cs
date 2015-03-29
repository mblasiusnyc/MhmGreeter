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

		public static Dictionary<Greeter.Type, string> MenuDescriptions = new Dictionary<Greeter.Type, string> {
			{ Greeter.Type.CAT, "Cat" },
			{ Greeter.Type.DOG, "Dog" }, 
			{ Greeter.Type.ENGLISH, "English speaking person" }, 
			{ Greeter.Type.FRENCH, "French speaking person" }, 
			{ Greeter.Type.IMPATIENT, "Impatient person" }, 
			{ Greeter.Type.MULTILINGUAL, "Multilingual greeting" }, 
			{ Greeter.Type.RANDOM, "Random greeting" }, 
			{ Greeter.Type.SPANISH, "Spanish person" }, 
			{ Greeter.Type.EXIT, "Exit the application" },
		};

		public static Dictionary<Greeter.Type, string> GreetingStrings = new Dictionary<Greeter.Type, string> {
			{ Greeter.Type.CAT, "Meow." },
			{ Greeter.Type.DOG, "Bark!" }, 
			{ Greeter.Type.ENGLISH, "Hello" }, 
			{ Greeter.Type.FRENCH, "Bonjour" }, 
			{ Greeter.Type.SPANISH, "Hola" }, 
			{ Greeter.Type.EMPTY, "" },
			{ Greeter.Type.INVALID, "I'm sorry - you have made an invalid selection" },
			{ Greeter.Type.EXIT, "Goodbye!" },
		};

		static public void PrintGreeting (Greeter.Type greetingSelection)
		{
			switch (greetingSelection) { 
			case Greeter.Type.RANDOM: 
				printRandomGreeting ();
				break;
			case Greeter.Type.IMPATIENT:
				printImpatientGreeting ();
				break;
			case Greeter.Type.MULTILINGUAL:
				printMultilingualGreeting ();
				break;
			default:
				Console.WriteLine (Greeter.GreetingStrings [greetingSelection]);
				Console.WriteLine ();
				break;
			}
		}

		static void printRandomGreeting ()
		{
			var AvailableRandomGreetings = new List<Greeter.Type> {
				Greeter.Type.CAT,
				Greeter.Type.DOG,
				Greeter.Type.ENGLISH,
				Greeter.Type.FRENCH,
				Greeter.Type.SPANISH
			};

			var rand = new Random ();
			var greetingKey = AvailableRandomGreetings [rand.Next (AvailableRandomGreetings.Count)];
			PrintGreeting (greetingKey);
		}

		static void printMultilingualGreeting ()
		{			
			var AvailableMultilingualGreetings = new List<Greeter.Type> {
				Greeter.Type.ENGLISH,
				Greeter.Type.FRENCH,
				Greeter.Type.SPANISH
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
