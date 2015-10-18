using System;

namespace Day5_Morning
{
	public static class StringExtension
	{
		

		public static int NumberOfWords(this string inputString){
			string[] stringArray = inputString.Split(' ');
			return stringArray.Length;
		}

		public static int NumberOfCharacters(this string inputString){
			inputString =  inputString.Replace(" ","");
			Console.WriteLine (inputString);
			return(inputString.Length);
		}

	}
}

