using System;
using System.IO;

namespace WriteAndReadAFile
{
	class MainClass
	{
		public static void Main (string[] args)
		{
//			CreateWriteAndReadFromAFile.WriteToAFile (@"/Users/abhishek/Desktop/abhi.txt");
//			CreateWriteAndReadFromAFile.ReadFromAFile (@"/Users/abhishek/Desktop/abhi.txt");

			//1* Write a program that reads a file and writes out a new file with the lines in reversed order (i.e. the first line in the old file becomes the last one in the new file.)
			ReverseLineRead.ReadingInReverse(@"/Users/abhishek/GitHub/Xamarin-Training/FIles/WriteAndReadAFile/SimpleText.txt");

			CreateDirectory.CeateADirectoryAndSubDirectories ();
			CopyContentFromOneFileToOther.CopyContentFormAndTo(@"/Users/abhishek/GitHub/Xamarin-Training/FIles/WriteAndReadAFile/SimpleText.txt",@"/Users/abhishek/GitHub/Xamarin-Training/FIles/WriteAndReadAFile/SimpleTextCopy.txt");

//			Company company = Company.GetData ();

			// Pass "company" object for conversion object to JSON string
//			string json = new System.Web.Script.Serialization.JavaScriptSerializer().Serialize(company);
//
//			// Write that JSON to txt file
//			File.WriteAllText(Environment.CurrentDirectory + @"\JSON.txt", json);


			//**** System.Web.Script.Serialization namespace is not found.
			Console.WriteLine("---------------------------------------------------\n\n\n");
			Console.WriteLine ("Enter any Text to Encrypt: ");
			string dataToEncrypt = Console.ReadLine ();
			Console.WriteLine ();

			Console.WriteLine ("Enter a password: ");
			string passwordToEncrypt = Console.ReadLine ();
			Console.WriteLine ();

			Console.WriteLine ("Please wait White the data is Encrypting...");

			string encryptedData = EncryptAndDecrypt.Encrypt (dataToEncrypt, passwordToEncrypt);

			Console.WriteLine ("Time to retrieve your");
			Console.WriteLine ("Please enter password to decrypt the String you have entered");

			string passwordToDecrypt = Console.ReadLine (); 

			string decryptedData = EncryptAndDecrypt.Decrypt(encryptedData,passwordToDecrypt);

			Console.WriteLine("Decrypted Data:   " + decryptedData);
		}

	}
}
