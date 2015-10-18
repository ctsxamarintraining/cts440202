using System;

namespace Day5_Evening
{
	class MainClass : Attribute
	{
		[Obsolete("Don't use Old method, use New method", true)]
		static void Old( ) { }

		static void New( ) { }


		public static void Main (string[] args)
		{
//			Old ();
			Console.WriteLine ("Hello World!");



		}
	}
}
