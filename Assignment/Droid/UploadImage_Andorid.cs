using System;
using Android.Content;
using Android.Telephony;
using Assignment.Droid;
using System.Linq;
using Xamarin.Forms;

using Uri = Android.Net.Uri;
[assembly: Dependency(typeof(UploadImage_Andorid))]

namespace Assignment.Droid
{
	
	public class UploadImage_Andorid : IUploadImage
	{
		#region IUploadImage implementation

		public string GetImagePath ()
		{
		}

		#endregion

		public UploadImage_Andorid ()
		{
		}
	}
}

