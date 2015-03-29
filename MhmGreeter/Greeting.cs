using System;
using System.Collections.Generic;

namespace MhmGreeter
{
	public class Greeting
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

		public static Dictionary<Greeting.Type, string> MenuDescriptions = new Dictionary<Greeting.Type, string> {
			{ Greeting.Type.CAT, "Cat" },
			{ Greeting.Type.DOG, "Dog" }, 
			{ Greeting.Type.ENGLISH, "English speaking person" }, 
			{ Greeting.Type.FRENCH, "French speaking person" }, 
			{ Greeting.Type.IMPATIENT, "Impatient person" }, 
			{ Greeting.Type.MULTILINGUAL, "Multilingual greeting" }, 
			{ Greeting.Type.RANDOM, "Random greeting" }, 
			{ Greeting.Type.SPANISH, "Spanish person" }, 
			{ Greeting.Type.EXIT, "Exit the application" },
			{ Greeting.Type.INVALID, "Invalid Selection" },
			{ Greeting.Type.EMPTY, "No item selected" }
		};

		public static Dictionary<Greeting.Type, string> Greetings = new Dictionary<Greeting.Type, string> {
			{ Greeting.Type.CAT, "Meow." },
			{ Greeting.Type.DOG, "Bark!" }, 
			{ Greeting.Type.ENGLISH, "Hello" }, 
			{ Greeting.Type.FRENCH, "Bonjour" }, 
			{ Greeting.Type.IMPATIENT, "" }, 
			{ Greeting.Type.MULTILINGUAL, "" }, 
			{ Greeting.Type.RANDOM, "" }, 
			{ Greeting.Type.SPANISH, "Hola" }, 
			{ Greeting.Type.EXIT, "" },
			{ Greeting.Type.INVALID, "I'm sorry - you have made an invalid selection" },
			{ Greeting.Type.EMPTY, ""}
		};
	}
}
