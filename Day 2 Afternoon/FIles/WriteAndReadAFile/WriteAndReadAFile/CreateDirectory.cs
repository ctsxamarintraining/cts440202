﻿using System;
using System.IO;

namespace WriteAndReadAFile
{
	public class CreateDirectory
	{
		static System.Collections.Specialized.StringCollection log = new System.Collections.Specialized.StringCollection();
		public CreateDirectory ()
		{
		}


		public static void CeateADirectoryAndSubDirectories()
		{
			Directory.CreateDirectory(@"/Users/abhishek/GitHub/Xamarin-Training/FIles/NewDirectoryParent/SubFolder1/Subfolder2");
			Console.WriteLine ("New Directories and Sub directories are created");
		}


		public static void WalkDirectoryTree(System.IO.DirectoryInfo root)
		{
			System.IO.FileInfo[] files = null;
			System.IO.DirectoryInfo[] subDirs = null;

			// First, process all the files directly under this folder
			try {
				files = root.GetFiles ("*.*");
			}
			// This is thrown if even one of the files requires permissions greater
			// than the application provides.
			catch (UnauthorizedAccessException e) {
				// This code just writes out the message and continues to recurse.
				// You may decide to do something different here. For example, you
				// can try to elevate your privileges and access the file again.
				log.Add (e.Message);
			} catch (System.IO.DirectoryNotFoundException e) {
				Console.WriteLine (e.Message);
			}

			if (files != null) {
				foreach (System.IO.FileInfo fi in files) {
					// In this example, we only access the existing FileInfo object. If we
					// want to open, delete or modify the file, then
					// a try-catch block is required here to handle the case
					// where the file has been deleted since the call to TraverseTree().
					Console.WriteLine (fi.FullName);
				}

				// Now find all the subdirectories under this directory.
				subDirs = root.GetDirectories ();

				foreach (System.IO.DirectoryInfo dirInfo in subDirs) {
					// Resursive call for each subdirectory.
					WalkDirectoryTree (dirInfo);
				}
			} 
		}
	}
}

