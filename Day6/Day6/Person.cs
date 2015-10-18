using System;

namespace Day6
{
	public class Person
	{

		public int ID { set; get;}
		public string Name { set; get;}
		public string Location { get; set;}

		public Person(int id, string name, string location)
		{
			this.ID = id;
			this.Name = name;
			this.Location = location;
		}

		public Person ()
		{
		}
	}
}

