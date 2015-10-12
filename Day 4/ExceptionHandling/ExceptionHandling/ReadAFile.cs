using System;
using System.IO;

namespace ExceptionHandling
{
	public class ReadAFile
	{
		public ReadAFile ()
		{
		}

		public static void ReadAFileWithPath(string path)
		{
			StreamReader streamReader = null;
			try
			{
				streamReader = new StreamReader (path);
				Console.WriteLine (streamReader.ReadToEnd ());	
			}
			catch(FileNotFoundException fileNotFoundException)
			{
				Console.WriteLine (fileNotFoundException.Message);				
			}
			catch(DirectoryNotFoundException directoryNotFoundException) 
			{
				Console.WriteLine (directoryNotFoundException.Message);
			}
			catch(Exception exception) 
			{
				Console.WriteLine (exception.Message);
			}
			finally 
			{
				if (streamReader != null) 
				{
					streamReader.Close ();
				}
			}



		}


	}
}

