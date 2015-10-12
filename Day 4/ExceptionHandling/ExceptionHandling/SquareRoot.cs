using System;

namespace ExceptionHandling
{
	public class SquareRoot
	{
		public SquareRoot ()
		{
		}

		public static void FindTheSquareOf(double value)
		{
			double squareRootOfValue = 0;

			try
			{
				if (value >= 0) {
				squareRootOfValue = Math.Sqrt(value);
				Console.WriteLine ("√{0} = {1}",value,squareRootOfValue);
				}
				else{
					Console.WriteLine ("Invalid number");
				}
			}
			catch(Exception exception) 
			{
				Console.WriteLine (exception.Message);
			}
			finally
			{
				Console.WriteLine ("Goodbye");
			}
		}

	}
}

