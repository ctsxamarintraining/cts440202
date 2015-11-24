using System;
using Foundation;
using Assignment.iOS;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(UploadImage_iOS))]

namespace Assignment.iOS
{	
	public class UploadImage_iOS :IUploadImage
	{
		
		UIImagePickerController imagePicker;

		public bool GetImagePath ()
		{
			string ImageRefURL = null;
			imagePicker = new UIImagePickerController ();
			imagePicker.SourceType = UIImagePickerControllerSourceType.PhotoLibrary;
			imagePicker.MediaTypes = UIImagePickerController.AvailableMediaTypes (UIImagePickerControllerSourceType.PhotoLibrary);

			imagePicker.FinishedPickingMedia += (object sender, UIImagePickerMediaPickedEventArgs e) => {
				// determine what was selected, video or image
				bool isImage = false;
				switch (e.Info [UIImagePickerController.MediaType].ToString ()) {
				case "public.image":
					//				Console.WriteLine("Image selected");
					isImage = true;
					break;
				case "public.video":
					//				Console.WriteLine("Video selected");
					break;
				}

				// get common info (shared between images and video)
				NSUrl referenceURL = e.Info [new NSString ("UIImagePickerControllerReferenceUrl")] as NSUrl;
				if (referenceURL != null && isImage) {
					ImageRefURL =  referenceURL.ToString();
				}

			};

			return true;
		}


		public UploadImage_iOS ()
		{
		}

//		void Handle_FinishedPickingMedia(object sender, UIImagePickerMediaPickedEventArgs e)
//		{
//			
//		}
//		void Handle_Canceled(){
//			imagePicker.DismissModalViewControllerAnimated(true);
//		}
	}
}

