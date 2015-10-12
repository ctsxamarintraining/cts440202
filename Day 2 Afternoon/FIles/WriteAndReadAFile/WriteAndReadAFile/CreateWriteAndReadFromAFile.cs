using System;
using System.IO;
using System.Text;

namespace WriteAndReadAFile
{
	public class CreateWriteAndReadFromAFile
	{
			public static void WriteToAFile(string fileName)
			{
				Console.WriteLine ("enter data to write to a file and press retun");
				string dataToWriteToFile = Console.ReadLine ();
				FileStream fileStream = new FileStream (fileName, FileMode.Create, FileAccess.Write);
				if(fileStream.CanWrite)
				{
					byte[] buffer = Encoding.ASCII.GetBytes(dataToWriteToFile);
					fileStream.Write (buffer, 0, buffer.Length);

					fileStream.Flush ();
					fileStream.Close ();
				}

			}

			public static void ReadFromAFile(string fileName)
			{

				FileStream fileStream = new FileStream (fileName, FileMode.Open, FileAccess.Read);

				byte[] buffer = new byte[fileStream.Length];

				int bytesRead = fileStream.Read (buffer, 0, buffer.Length);

				string readStringFromFile = Encoding.ASCII.GetString (buffer, 0, bytesRead);

				Console.WriteLine ("Data Read From File \n" + readStringFromFile);
			}
		public CreateWriteAndReadFromAFile ()
		{
		}
	}
}

