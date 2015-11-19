using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

using Xamarin.Forms;

namespace DemoMasterDetail
{
	public class EditProfilePage : ContentPage
	{
		Label emptyLbl = new Label {
			VerticalOptions = LayoutOptions.Center,
			Text = "not Visible",
			Opacity = 0,
			HeightRequest = 50,
			XAlign = TextAlignment.Start
		};
		Label lblCustomer = new Label
		{
//			HorizontalOptions = LayoutOptions.Center,
			VerticalOptions = LayoutOptions.Center,
			Text = "Customer Name",
			XAlign = TextAlignment.Start
		};
		Entry entryName = new Entry
		{
		};

		Label lblDOB = new Label
		{
			Text = "Date of Birth",
			XAlign = TextAlignment.Start
		};
		DatePicker datePicker = new DatePicker
		{
		};

		Switch genderSwitch = new Switch
		{

		};
		Label lblGenderSelected = new Label
		{
			Text = "Male"
		};
		Editor descriptionEditor = new Editor
		{
			HeightRequest = 50,
			Text = "Description about yourself",
			BackgroundColor = Color.FromRgb(215,215,215)
		};

		string[] countries = new string[] {"Africa","India","USA","Zimbawe"};

		Picker countryPicker = new Picker
		{

		};

		Label lblCountry = new Label
		{
			Text = "Select a Country"
		};

		Button saveBTN = new Button
		{
			Text = "Save",
			VerticalOptions = LayoutOptions.Center,
			HorizontalOptions = LayoutOptions.Center
		};

		public EditProfilePage ()
		{
			this.Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);

			genderSwitch.Toggled += GenderSelectionSwitchToggeled;

			StackLayout horizontalStacklayout = new StackLayout
			{
				Orientation = StackOrientation.Horizontal,
				Children =
				{
					new Label
					{
						Text = "Gender"
					},
					genderSwitch,
					lblGenderSelected
				}
				};

			foreach(string str in countries)
			{
				countryPicker.Items.Add(str);
			}



			StackLayout scrollViewContentViewStackLayout = new StackLayout { 
				Children = {
					emptyLbl,
					lblCustomer,
					entryName,
					lblDOB,
					datePicker,
					new Label {
						VerticalOptions = LayoutOptions.Center,
						Text = "not Visible",
						Opacity = 0,
						HeightRequest = 20,
						XAlign = TextAlignment.Start
					},
					horizontalStacklayout,
					descriptionEditor,
					new Label {
						VerticalOptions = LayoutOptions.Center,
						Text = "not Visible",
						Opacity = 0,
						HeightRequest = 50,
						XAlign = TextAlignment.Start
					},
					lblCountry,
					countryPicker,
					new BoxView
					{
						BackgroundColor = Color.Aqua,
						HeightRequest = 20
					},
					saveBTN
				}
			};
			saveBTN.Clicked += saveBTNClicked;
			ScrollView scrollView = new ScrollView ();
			scrollView.Content = scrollViewContentViewStackLayout;
			this.Content = scrollView;

		}

		void GenderSelectionSwitchToggeled(object sender, ToggledEventArgs e)
		{
			if (e.Value) {
				lblGenderSelected.Text = "Female";
			}
			else{
				lblGenderSelected.Text = "Male";
			}
		}

		void saveBTNClicked(object sender, EventArgs args)
		{	

			if (entryName.Text != null && descriptionEditor.Text != null && countryPicker.SelectedIndex > -1) {
				Person person = new Person()
				{
					Name = entryName.Text, 
					DOB = datePicker.Date.ToString(), 
					Gender = lblGenderSelected.Text, 
					Description = descriptionEditor.Text,
					Country = countries[countryPicker.SelectedIndex]
				};

			PersonDetails personDetails = new PersonDetails ();
				personDetails.Save (person);
				this.DisplayAlert ("", "Your Profile Saved", "OK");
			}
			else
			{
				this.DisplayAlert("Error !", "Please enter all details", "OK");
			}

		}

	}
}


