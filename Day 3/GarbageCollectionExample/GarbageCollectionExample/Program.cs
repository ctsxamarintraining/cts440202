using System;

namespace GarbageCollectionExample
{
	class MainClass
	{
		public static void Main (string[] args)
		{
//			SimpleGarbageCollector ();
			DifferenceOfGarbageCollector ();
				
		}

		public static void SimpleGarbageCollector()
		{
			long memoryOne = GC.GetTotalMemory(false);
			{
				// Allocate an array and make it unreachable.
				int[] values = new int[50000];
				values = null;
			}
			long memoryTeo = GC.GetTotalMemory(false);
			{
				// Collect garbage.
				GC.Collect();
			}
			long memoryThree = GC.GetTotalMemory(false);
			{
				Console.WriteLine(memoryOne);
				Console.WriteLine(memoryTeo);
				Console.WriteLine(memoryThree);
			}
		}


		public static void DifferenceOfGarbageCollector()
		{
			long bytes1 = GC.GetTotalMemory(false); // Get memory in bytes

			byte[] memory = new byte[1000 * 1000 * 10]; // Ten million bytes
			memory[0] = 1; // Set memory (prevent allocation from being optimized out)

			long bytes2 = GC.GetTotalMemory(false); // Get memory
			long bytes3 = GC.GetTotalMemory(true); // Get memory

			Console.WriteLine(bytes1 + "   Program started with these bytes.");
			Console.WriteLine(bytes2+ "  After ten million bytes allocated");
			Console.WriteLine(bytes2 - bytes1 + "  Difference"); // Write difference
			Console.WriteLine(bytes3 + "  After garbage collection");
			Console.WriteLine(bytes3 - bytes2 + "  Difference"); // Write difference
			Console.ReadLine();
		}

	}
}
