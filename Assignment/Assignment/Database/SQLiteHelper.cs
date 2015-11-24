using System;
using SQLite;
using Xamarin.Forms;
using System.Collections.Generic;
using System.Linq;

namespace Assignment
{
	public class SQLiteHelper
	{
		public static string path = "";

		public SQLiteHelper ()
		{
			using (SQLite.SQLiteConnection database = DependencyService.Get<ISQLite> ().GetConnection ()) 
			{
				database.CreateTable<FootballPlayer>();
				path = database.DatabasePath;
			}
		}


		public void Save(FootballPlayer player)
		{
			using (SQLite.SQLiteConnection database = DependencyService.Get<ISQLite> ().GetConnection ()) 
			{				
				database.Insert (player);
			}
		}

		public void DeletePlayerWithName (FootballPlayer player)
		{
			using (SQLite.SQLiteConnection database = DependencyService.Get<ISQLite> ().GetConnection ()) 
			{
				database.Delete (player);
			}
		}

		public IEnumerable<FootballPlayer> GetItems () {
			SQLite.SQLiteConnection database = DependencyService.Get<ISQLite> ().GetConnection ();	
			var footballPlayerList = from i in database.Table<FootballPlayer> ()
			                                          select i;
			var sortByIsFavourite = from player in footballPlayerList
				orderby player.IsFavourite descending
				select player;			
			var sortedList = sortByIsFavourite.OrderBy( x => x.FirstName).ThenBy( x => x.LastName);
			return sortedList.ToList();
		}

	}
}

