using System;
using System.Collections.Generic;

namespace MhmGreeter
{

	public class Greeter
	{
		int numTimesImpatientGreeterBothered = 0;

		public void PrintGreeting (Greeting.Type greetingSelection)
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
				Console.WriteLine (Greeting.Greetings [greetingSelection]);
				break;
			}

		}

		void printRandomGreeting ()
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

			Console.WriteLine (Greeting.Greetings [greetingKey]);
		}

		void printMultilingualGreeting ()
		{			
			var AvailableMultilingualGreetings = new List<Greeting.Type> {
				Greeting.Type.ENGLISH,
				Greeting.Type.FRENCH,
				Greeting.Type.SPANISH
			};

			var rand = new Random ();
			var greetingKey = AvailableMultilingualGreetings [rand.Next (AvailableMultilingualGreetings.Count)];

			Console.WriteLine (Greeting.Greetings [greetingKey]);
		}

		void printImpatientGreeting ()
		{
			var patientGreeting = "Oh, hello.";
			var impatientGreeting = "Not now! I'm busy.";
			numTimesImpatientGreeterBothered++;
			if ((numTimesImpatientGreeterBothered % 3) != 0) {
				Console.WriteLine (patientGreeting);
			} else {
				Console.WriteLine (impatientGreeting);
			}
		}
	}
}

