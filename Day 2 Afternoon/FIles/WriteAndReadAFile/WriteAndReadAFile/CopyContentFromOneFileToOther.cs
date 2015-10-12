using System;
using System.Text;

namespace WriteAndReadAFile
{
	public class CopyContentFromOneFileToOther
	{
		public CopyContentFromOneFileToOther ()
		{
		}

		public static void CopyContentFormAndTo(string fromPath, string toPath)
		{
			string line;
			var sb = new StringBuilder();
			System.IO.StreamReader file = new System.IO.StreamReader(fromPath);
			while ((line = file.ReadLine()) != null)
				sb.AppendLine(line.Substring(0, Math.Min(line.Length, line.Length)));

			file.Close();
			using (System.IO.StreamWriter files = new System.IO.StreamWriter(toPath))
			{
				files.WriteLine(sb.ToString());
			}
		}
	}
}

