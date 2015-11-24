
using System;
using SQLite;

namespace Assignment
{
	public class FootballPlayer
	{
		[PrimaryKey,AutoIncrement]
		public int ID { get; set;}

		public string ImageSourcePath {
				get;
				set;
			}

		public string FullName{ 
			get
			{
				return string.Concat (FirstName, " ", LastName);
			}
		}

		public string FirstName {
				get;
				set;
			}

		public string LastName {
				get;
				set;
			}

		public string Age
		{
			get 
			{
				TimeSpan span = DateOfBirth.Subtract (DateTime.Today);
				int years = span.Days / - 365;
				return years.ToString ();
			}
		}

		public string DateOfBithWithAge { 
			get
			{
				string[] dateFormat = DateOfBirth.GetDateTimeFormats();
				string formattedDateOfBirth = dateFormat [8];
				TimeSpan span = DateOfBirth.Subtract (DateTime.Today);
				int years = span.Days / - 365;

				return string.Concat (formattedDateOfBirth," ","(",years.ToString(),")");
			}
		}

		public DateTime DateOfBirth {
				get;
				set;
			}

			public string Country {
				get;
				set;
			}

		public string CountryImage
		{
			get
			{
				return string.Concat (Country, ".png");
			}
		}

		public string Description {
				get;
				set;
			}

		public bool IsFavourite {
			get;
			set;
		}
	}
}

