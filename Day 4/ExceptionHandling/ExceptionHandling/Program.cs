using System;

namespace ExceptionHandling
{
	class MainClass
	{
		public static void Main (string[] args)
		{

//			// 1 * Task
//			CreateNewArrayAndReadIt arrayOperations = new CreateNewArrayAndReadIt ();
//			Console.WriteLine ("Please give the length of Array");
//			if (arrayOperations.CreateNewArrayWithLength (Console.ReadLine ())) {
//				arrayOperations.PrintTheArrayWithSeparator ();
//			}
//
//			// 2* Task
//			SquareRoot.FindTheSquareOf (-10);

			//3 * Task
			ReadAFile.ReadAFileWithPath(@"/Users/abhishek/GitHub/cts440202/Day 4/ExceptionHandling/ExceptionHandling/File.txt");

		}
	}
}
