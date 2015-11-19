using System;
using SQLite;

namespace DemoMasterDetail
{


	[Table ("Person")]
	public class Person
	{
		[PrimaryKey, AutoIncrement]
		public int ID {
			get;
			set;
		}
		public string Name {
			get;
			set;
		}
		public string DOB {
			get;
			set;
		}
		public string Gender {
			get;
			set;
		}
		public string Description{
			get;
			set;
		}
		public string Country {
			get;
			set;
		}

	}

	public class PersonDetails
	{
		const string path = @"/Users/abhishek/Desktop/path.sqlite";

		public PersonDetails ()
		{
			getConnection ();
		}

		public static SQLite.SQLiteConnection getConnection ()
		{
			using (var conn = new SQLite.SQLiteConnection(path))
			{
				conn.CreateTable<Person> ();
				return conn;
			}
		}

		public void Save(Person person)
		{
			using (var conn = new SQLite.SQLiteConnection (path)) 
			{
				conn.Insert (person);
			}
		}

	}
}

