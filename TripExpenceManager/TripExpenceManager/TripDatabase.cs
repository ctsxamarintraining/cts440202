using System;
using System.Linq;
using System.Collections.Generic;

using Mono.Data.Sqlite;
using System.IO;
using System.Data;

namespace TripExpenceManager
{
	public class TripDatabase
	{
		public TripDatabase ()
		{
		}


		static object locker = new object ();

		public SqliteConnection connection;

		public string path;



	}
}

