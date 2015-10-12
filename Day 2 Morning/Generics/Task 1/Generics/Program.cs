using System;

namespace Generics
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			LinkedList<int> linked = new LinkedList<int>();

			linked.Add (1);
			linked.Add (2);
			linked.Add (3);
			linked.Add (4);
			linked.Add (10);

			var v = linked.Find (2);

			int count = linked.Count;
			Console.WriteLine ("Number of Nodes: {0}",count);

		}
	}
}
