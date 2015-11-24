using System;
using System.IO;
using Xamarin.Forms;
using Assignment.Droid;

[assembly: Dependency(typeof(SQLite_Android))]
namespace Assignment.Droid
{
	public class SQLite_Android : ISQLite
	{
		#region ISQLite implementation

		public SQLite.SQLiteConnection GetConnection ()
		{
			var sqliteFilename = "Database.sqlite";
			string documentsPath = System.Environment.GetFolderPath (System.Environment.SpecialFolder.Personal); 
			var path = Path.Combine(documentsPath, sqliteFilename);
			var conn = new SQLite.SQLiteConnection(path);
			return conn;
		}

		#endregion

		public SQLite_Android ()
		{
		}

	}
}

