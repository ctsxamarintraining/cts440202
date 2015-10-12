using System;
using System.Collections.Generic;
using System.IO;

namespace WriteAndReadAFile
{
	public class ReverseLineRead
	{
		public static void ReadingInReverse(string fileName)
		{
			List<string> lines = new List<string>();
			using (var sr = File.OpenText(fileName))
			{
				string line;
				while ((line = sr.ReadLine()) != null)
				{
					lines.Add(line); 
				}
			}

			lines.Reverse();

			foreach (string line in lines) 
			{
				Console.WriteLine (line);
			}
		}


		public ReverseLineRead ()
		{
		}
	}
}

