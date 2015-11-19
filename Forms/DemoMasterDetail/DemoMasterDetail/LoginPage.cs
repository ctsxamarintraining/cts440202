using System;
using Xamarin.Forms;

namespace DemoMasterDetail
{
	public class LoginPage : ContentPage
	{

		public Label header = new Label {
			Text = "Login Screen",
			HorizontalOptions = LayoutOptions.Center,
			VerticalOptions = LayoutOptions.Center,
			FontSize = 30,
			HeightRequest = 50,
			//				YAlign = TextAlignment.Center
		};

		public Entry userName = new Entry {
			Placeholder = "User Name"
		};

		public Entry password = new Entry {
			Placeholder = "Password",
			IsPassword = true
		};

		public Button loginBTN = new Button {
			Text = "Login"
		};

		public LoginPage ()
		{			
			loginBTN.Clicked += onButtonClicked;
			this.Content = new StackLayout {
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.Center,
				Children = {
					header,
					userName,
					password,
					loginBTN
				}
			};
		}

		void onButtonClicked (object sender, EventArgs ards)
		{
			if (this.userName != null) 
			{
				if (this.userName.Text == "cts" && this.password.Text == "123") {
					Navigation.PushModalAsync(new MasterDetail());
				} 
				else 
				{
					this.DisplayAlert ("Error", "Please enter valid Credentials", "OK");
				}

			}


		}
	}
}


