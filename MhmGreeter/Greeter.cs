using System;
using System.Collections.Generic;

namespace MhmGreeter
{

	static public class Greeter
	{
		static int numTimesImpatientGreeterBothered = 0;
		string patientGreeting = "Oh, hello.";
		string impatientGreeting = "Not now! I'm busy.";

		static public void PrintGreeting (Greeting.Type greetingSelection)
		{
			switch (greetingSelection) { 
			case Greeting.Type.RANDOM: 
				printRandomGreeting ();
				break;
			case Greeting.Type.IMPATIENT:
				printImpatientGreeting ();
				break;
			case Greeting.Type.MULTILINGUAL:
				printMultilingualGreeting ();
				break;
			default:
				Console.WriteLine (Greeting.DefaultGreetings [greetingSelection]);
				Console.WriteLine ();
				break;
			}
		}

		static void printRandomGreeting ()
		{
			var AvailableRandomGreetings = new List<Greeting.Type> {
				Greeting.Type.CAT,
				Greeting.Type.DOG,
				Greeting.Type.ENGLISH,
				Greeting.Type.FRENCH,
				Greeting.Type.SPANISH
			};

			var rand = new Random ();
			var greetingKey = AvailableRandomGreetings [rand.Next (AvailableRandomGreetings.Count)];
			PrintGreeting (greetingKey);
		}

		static void printMultilingualGreeting ()
		{			
			var AvailableMultilingualGreetings = new List<Greeting.Type> {
				Greeting.Type.ENGLISH,
				Greeting.Type.FRENCH,
				Greeting.Type.SPANISH
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
	}
}
