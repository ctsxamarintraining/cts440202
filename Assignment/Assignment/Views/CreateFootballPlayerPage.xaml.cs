using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Assignment
{
	public partial class CreateFootballPlayerPage : BaseViewPage
	{
		public CreateFootballPlayerPage ()
		{
			InitializeComponent ();

//			this.ImagePickerGesture.

			string[] countries = new string[] {"Argentina","Brazil","Germany","India","Spain"};

			foreach (string country in countries) {
				this.CountryPicker.Items.Add (country);
			}

			this.BindingContext = new CreateFootballPlayerViewModel ();
			this.FirstNamelbl.SetBinding (Entry.TextProperty, "FirstName");
			this.LastNamelbl.SetBinding (Entry.TextProperty, "LastName");
			this.DateOfBirthPicker.SetBinding (DatePicker.DateProperty, "DateOfBirth");
			this.CountryPicker.SetBinding (Picker.SelectedIndexProperty, "Country");
			this.DescriptionEditor.SetBinding (Editor.TextProperty, "Description");
			this.SavePlayerProfileBTN.SetBinding (Button.CommandProperty, "SavePlayerProfileBTNClicked");
			this.ImagePickerTapGesture.SetBinding (TapGestureRecognizer.CommandProperty, "UploadImageFromProfilePictureClicked");
			MessagingCenter.Subscribe<CreateFootballPlayerViewModel, string> (this, "SaveFootballPlayerProfileStatusAlert", async (sender, message) => 
				{
					await DisplayAlert ("", message, "OK");
					if (message.Equals("Player Data Saved Successfully")) {
						await Navigation.PopAsync(true);
					}
				}, null);
		}


	}
}

