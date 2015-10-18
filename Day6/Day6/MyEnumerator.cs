using System;
using System.Collections;

namespace Day6
{
	
		public class MyEnumerator: IEnumerator
		{

			Person[] personArray = new Person[]{
				new Person(1, "Jonathan", "new Jersy"),
				new Person(2,"Postiga", "Paris"),
				new Person(3,"Lucio", "Brazil")
			};

			int currentIndex = -1;
			public bool MoveNext ()
			{
				if (personArray.Length - 1 > currentIndex) {
					currentIndex++;
					return true;

				} else {
					return false;
				}
			}
			public void Reset ()
			{
				currentIndex = -1;
			}
			public object Current {
				get {
					return personArray[currentIndex];
				}
			}
		}


		public class Myenumarable :IEnumerable
		{
			public IEnumerator GetEnumerator ()
			{
				return new MyEnumerator();
			}

		}

}

