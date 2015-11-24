using System;
using SQLite;

namespace Assignment
{
	public interface ISQLite
	{
		SQLiteConnection GetConnection();

	}
}

