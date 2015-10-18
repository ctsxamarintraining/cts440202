using System;
using System.Collections;

namespace Day6
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			//1* Implement double LinkedList for a Person class (which contains Id, Name , Location properties) and use enumerator to 
			// iterate through each item and print the values on console. Note: Dont not use any default classes, only use either IEnumerable/IEnumerator.
			Myenumarable enumarableObj = new Myenumarable ();
			var enumarator =  enumarableObj.GetEnumerator ();
			while (enumarator.MoveNext ()) {
				Person person = (Person)enumarator.Current;
				Console.WriteLine ("Person ID: {0}, Name: {1}, Location: {2}",person.ID, person.Name, person.Location);

			}


			//2. Implement IList<T> interface and perform operations to add, remove, contains, clear all. 
			MyCollection<int> myCollection = new MyCollection<int>();
			myCollection.Add (1);
			myCollection.Add (2);
			myCollection.Add (3);
			var enumarator1 = myCollection.GetEnumerator();
			while (enumarator1.MoveNext ()) {
				Console.WriteLine (enumarator1.Current);
			}


			//4. Using .Net provided List<T> and Dictionary<Tkey,TValue>, perform operations for Add,AddRange, Remove, Contains, InsertAt, Clear.
			MyCollection<string> myCollection4 = new MyCollection<string>();
			myCollection4.Add ("John");
			myCollection4.Add ("Lessy");
			myCollection4.Add ("Clair");
			var enumarator4 = myCollection4.GetEnumerator();
			while (enumarator4.MoveNext ()) {
				Console.WriteLine (enumarator4.Current);
			}
			myCollection4.Remove ("Lessy");
			var enumarator41 = myCollection4.GetEnumerator();
			while (enumarator41.MoveNext ()) {
				Console.WriteLine (enumarator41.Current);
			}



			//3* Implement stack and Queue using array as backing field in the class.
			stack st = new stack();
			while (true)
			{
				Console.Clear();
				Console.WriteLine("\nStack MENU(size -- 10)");
				Console.WriteLine("1. Add an element");
				Console.WriteLine("2. See the Top element.");
				Console.WriteLine("3. Remove top element.");
				Console.WriteLine("4. Display stack elements.");
				Console.WriteLine("5. Exit");
				Console.Write("Select your choice: ");
				int choice = Convert.ToInt32(Console.ReadLine());
				switch (choice)
				{
				case 1:
					Console.WriteLine("Enter an Element : ");
					st.Push(Console.ReadLine());
					break;

				case 2: Console.WriteLine("Top element is: {0}", st.Peek());
					break;

				case 3: Console.WriteLine("Element removed: {0}", st.Pop());
					break;

				case 4: st.Display();
					break;

				case 5: System.Environment.Exit(1);
					break;
				}
				Console.ReadKey();
			}
		}



	}
}
