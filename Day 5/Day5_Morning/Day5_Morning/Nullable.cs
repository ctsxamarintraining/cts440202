using System;

namespace Day5_Morning
{
	public class Nullable
	{
		public static void CreateNullableValue(int? nullableValue)
		{
			if(nullableValue != null)
				Console.WriteLine ("Value of the Nullable Value: " + nullableValue.Value);
			else
				Console.WriteLine ("Value is the Null");			
		}
	}



}

