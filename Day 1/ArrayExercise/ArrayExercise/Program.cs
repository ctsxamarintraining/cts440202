using System;
using System.Collections;


namespace ArrayExercise
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			// 1 * Design a 4D Array
			ArrayFourD fourD = new ArrayFourD ();
			Array fourDimentionalArray = fourD.Create4DStringArray ();

			Console.WriteLine ("-----------------------------------------");
			//2*  Reusable Code to iterate through any dimentional array.
			//Creating a new array
			int[,] twoDimentionalArray = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
			//Print Any Array with any dimention
			MainClass mainClass = new MainClass ();
			mainClass.printAnyArray (fourDimentionalArray);
			Console.WriteLine ("-----------------------------------------");
			mainClass.printAnyArray (twoDimentionalArray);
			Console.WriteLine ("-----------------------------------------");
			//3*  Create a custom type Person with FirstName, LastName and Age properties.Write a re-usable function that can Sort this Person[] Array by age.
			Person person1 = new Person ("Akil", "K", 27);
			Person person2 = new Person ("Madhu", "C", 25);
			Person person3 = new Person ("Bhanu", "K", 29);

			ArrayList personArray = new ArrayList ();
			personArray.Add (person1);
			personArray.Add (person2);
			personArray.Add (person3);


			personArray.Sort ();
			Console.WriteLine ("Sorted By Age ");
			foreach (Person person in personArray) {			
				Console.WriteLine ("Name: " + person.FirstName + "\tAge: " + person.Age);
			}
			Console.WriteLine ("-----------------------------------------");
		}

		public void printAnyArray (Array array){

			foreach (var element in array) {
				Console.Write (element + "\t");
			}
			Console.WriteLine ();
		}

	}
}