using System;
using System.Collections.Generic;

namespace Day5_Morning
{
	class MainClass
	{
		public static void Main (string[] args)
		{
//			//1* Write extension Methods for string for getting no of words, No of characters without white spaces.
//			Console.WriteLine ("Enter a sentence");
//			string inputString = Console.ReadLine ();
//			int  numberOfwords = inputString.NumberOfWords ();
//			int  numberOfCharacter = inputString.NumberOfCharacters ();
//			Console.WriteLine ("Number of words in the above Sentence is: "+ numberOfwords);
//			Console.WriteLine ("Number of characters in the abouve sentence excluding spaces are: " + numberOfCharacter);


//			//2* Create Nullable Type. Assign null and to print value in console. Assign a value and print value in console.
//			Nullable.CreateNullableValue (10);


			//3* Create delegate and assign anonymous method to it and execute the method using delegate.
			List<Employee> employeeList = new List<Employee>(){

				new Employee {ID = 101, FirstName = "John"},
				new Employee {ID = 102, FirstName = "Jonathan"},
				new Employee {ID = 103, FirstName = "Manoj"}

							};
			Employee employee = employeeList.Find (delegate(Employee emp) {
				return emp.ID == 102;
			});
			Console.WriteLine ("Employe ID: {0} and Name is: {1}",employee.ID,employee.FirstName);

		}
	}
}
