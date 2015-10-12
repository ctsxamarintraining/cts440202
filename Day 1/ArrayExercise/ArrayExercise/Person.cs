using System;
using System.Collections;
namespace ArrayExercise
{	
	public class Person : IComparable
	{

		public string FirstName;
		public string LastName;
		public int Age;

		public Person(string firstName, string lastName, int age){		
			FirstName = firstName;
			LastName = lastName;
			Age = age;
		}		

		public Person ()
		{
		}


		public int CompareTo(object obj)
		{
			if (obj is Person)
			{
				Person person = (Person)obj;
				return Age.CompareTo(person.Age);
			}
			else
				throw new ArgumentException("Object is not of type Car.");
		}




//		public int CompareTo(Person person, PersonComparer.ComparisonType comparisonType)
//		{
//			switch (comparisonType)
//			{
//			case PersonComparer.ComparisonType.Age:
//				return Age.CompareTo(person.Age);
//			case PersonComparer.ComparisonType.FirstName:
//				return FirstName.CompareTo(person.FirstName);
//			case PersonComparer.ComparisonType.LastName:
//				return LastName.CompareTo(person.LastName);
//			default:
//				return Age.CompareTo(person.Age);
//			}
//		}
//
//	}
//
//
//	class PersonComparer:  IComparer
//	{
//		public enum ComparisonType
//		{
//			Age = 1, 
//			FirstName = 2, 
//			LastName = 3
//		}
//
//		public ComparisonType ComparisonMethod
//		{
//			set;
//			get;
//		}
//
//		public int Compare(object x, object y)
//		{
//			Person person1;
//			Person person2;
//
//			if (x is Person)
//				person1 = x as Person;
//			else
//				throw new ArgumentException("Object is not of type Car.");
//
//			if (y is Person)
//				person2 = y as Person;
//			else
//				throw new ArgumentException("Object is not of type Car.");
//
//			return person1.CompareTo(person2, ComparisonMethod);
//		}
	}

}


