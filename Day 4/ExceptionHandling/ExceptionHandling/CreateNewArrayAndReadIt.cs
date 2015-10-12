using System;

namespace ExceptionHandling
{
	public class CreateNewArrayAndReadIt
	{
		public int[] NumbersArray;

		public CreateNewArrayAndReadIt ()
		{
			
		}

		public static bool verifyForCorrectInput(string arrayLength)
		{
			try{
				int.Parse(arrayLength);
				return true;
			}
			catch(FormatException formatException)
			{
				Console.WriteLine (formatException.Message);
				return false;
			}
			catch(Exception exception) 
			{
				Console.WriteLine (exception.Message);
				return false;
			}
			finally 
			{
				
			}
		}

		public bool CreateNewArrayWithLength(string arrayLength)
		{

			if (verifyForCorrectInput (arrayLength)) {
				int length = int.Parse (arrayLength);
				NumbersArray = new int[length];
				Console.WriteLine ("Please Enter the elements of the Array");

				for (int i = 0; i < length; i++) {

					Console.WriteLine ("Enter {0} more numbers: ", length - i);
					

					string elementString = Console.ReadLine ();

					if (verifyForCorrectInput (elementString)) {

						try {
							NumbersArray [i] = int.Parse (elementString);
						} catch (IndexOutOfRangeException outOfRangeException) {
							Console.WriteLine (outOfRangeException);
						} catch (Exception exception) {
							Console.WriteLine (exception.Message);
						}
					} else {
						i--;
					}

				}
				return true;
			} else {
				return false;
			}

		}



		public void PrintTheArrayWithSeparator()
		{
			try{
				int length = NumbersArray.Length;

				for(int i = 0 ; i< length; i++)
				{
					if(i != length - 1){
						Console.Write(NumbersArray[i] + ",");
					}
					else{
						Console.Write(NumbersArray[i]);
					}

				}

			}
			catch(IndexOutOfRangeException indexOutOfRangeException) {
				Console.WriteLine (indexOutOfRangeException.Message);
			}
			catch(NullReferenceException nullReferenceException){
				Console.WriteLine (nullReferenceException.Message);
			}
			catch(Exception exception) 
			{
				Console.WriteLine (exception);
			}
			finally
			{
				if (NumbersArray != null) {
					NumbersArray = null;
				}
			}
		}

	}
}

