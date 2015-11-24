using System;
using SQLite;
using Xamarin.Forms;
using System.IO;
using Assignment.iOS;

[assembly: Dependency(typeof(SQLite_iOS))]

namespace Assignment.iOS
{
	public class SQLite_iOS : ISQLite
	{
		#region ISQLite implementation

		public SQLiteConnection GetConnection ()
		{
			var SQLiteFileName = @"Database.sqlite";
			string documentPath = Environment.GetFolderPath (Environment.SpecialFolder.Personal);
			string libraryPath = Path.Combine (documentPath, "..", "Library");
			var path = Path.Combine (libraryPath, SQLiteFileName);
			var conn = new SQLite.SQLiteConnection(path);
			return conn;
		}

		#endregion

		public SQLite_iOS ()
		{
		}
	}
}

