using System;
using System.Collections.Generic;

namespace A1
{
	class Program 
	{
		/// <summary>
		///  both the Main method and GetMovementRange can access it
		/// </summary>
		/// <param name="random"></param>
		
		public static Random random; 

		static void Main(string[] args)
		{
			/// <summary>
			/// Picks a random (with replacement) number of cards base on user input.
			/// </summary>
			Console.WriteLine("Enter the number of cards to pick: ");
			string line = Console.ReadLine();
			if (int.TryParse(line, out int numCards))
			{
				foreach (var card in CardPicker.PickSomeCards(numCards))
				{
					Console.WriteLine(card);
					
				}
			}
			else
			{
				Console.WriteLine("Please enter a valid number.");
			}


			/// <summary>
			/// GetMovementRang the result of the movement range
			/// </summary>
			static void GetMovementRange()
            {
				 
				int movementRange = random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
				
			}

			/// <summary>
			/// the ParticleMovement class so that it is well encapsulated.
			/// </summary>


			ParticleMovement particleMover = new ParticleMovement();
			while (true)
			{
				Console.WriteLine("\n");
				Console.Write("0 for base movement only\n1 if a magnetic field is present\n" +
							  "2 if a gravitational field is present\n3 for both fields\n");

				char key = Console.ReadKey().KeyChar;
				if (key != '0' && key != '1' && key != '2' && key != '3') return;

				int movementRange = random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
				GetMovementRange();
				
				
				particleMover.MovementRange = movementRange;
				particleMover.MagneticField = true;
				particleMover.GravitationalField = true;
				Console.WriteLine($"\nParticle with a movement range of {movementRange} units" +
								  $" moved a total distance of {particleMover.DistanceMoved} units.\n");
			}
		

	}
}

	public class ParticleMovement
	{
		public const int BASE_MOVEMENT = 3;
		public const int GRAVITY_MOVEMENT = 2;

		
		
		public int DistanceMoved;
		private bool gravitationalField;
		private bool magneticField;
		private decimal movementRange;


		public double Distance { get; private set; }
		public decimal MovementRange
		{
			get { return movementRange; }
			set 
			{ 
				movementRange = value;
				CalculateDistance();
			}	
		}

		/// <summary>
		/// Calculate the distance moved base on formula
		/// </summary>
		public void CalculateDistance()
		{
			DistanceMoved = (int)(movementRange * Convert.ToInt32(magneticField)) + BASE_MOVEMENT + Convert.ToInt32(gravitationalField);
		}

		public bool GravitationalField
		{
			get { return gravitationalField; }
			set 
			{
				gravitationalField = value;
				CalculateDistance();
			}	
		}
		public bool MagneticField
		{
			get { return magneticField; }
			set
			{
				magneticField = value;
				CalculateDistance();
			}
		}
	}


	class CardPicker
	{
		
		static Random random = new Random(1);
		/// <summary>
		/// Picks a random (with replacement) number of cards.
		/// </summary>
		/// <param name="numCards">The number of cards to choose at random.</param>
		/// <returns>An array of strings where each string represents a card.</returns>
		public static string[] PickSomeCards(int numCards)
		{
			string[] pickedCards = new string[numCards];
			for (int i = 0; i < numCards; ++i)
			{
				pickedCards[i] = RandomValue() + " of " + RandomSuit();
			}
			return pickedCards;
		}
		/// <summary>
		/// Chooses a random value for a card (Ace, 2, 3, ... , Queen, King)
		/// </summary>
		/// <returns>A string that represents the value of a card</returns>
		private static string RandomValue()
		{
			Random rnd = new Random();
			int intValue = rnd.Next(0, 13);
			string Value = ((Value)intValue).ToString();	
			return Value;

		}
		
			
		

		/// <summary>
		/// Chooses a random suit for a card (Clubs, Diamonds, Hearts, Spades)
		/// </summary>
		/// <returns>A string that represents the suit of a card.</returns>
		private static string RandomSuit()
		{
			Random rnd = new Random();
			int intValue = rnd.Next(0, 3);
			string suit = ((Suit)intValue).ToString();
			return suit;

		}
		public enum Value
		{
			Ace, Two, Three, Four, Five, Six,
			Seven, Eight, Nine, Ten, Jack, Queen,
			King

		};
		



		/// <summary>
		/// Chooses a random suit for a card (Clubs, Diamonds, Hearts, Spades)
		/// </summary>
		public enum Suit { Hearts, Diamonds, Spades, Clubs };
	}
}
