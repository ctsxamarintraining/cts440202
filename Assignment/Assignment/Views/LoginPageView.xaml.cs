using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Assignment
{
	public partial class LoginPageView :  BaseViewPage
	{
		public LoginPageView ()
		{
			InitializeComponent ();
			this.BindingContext = new LoginPageViewModel();
			UserName.SetBinding(Entry.TextProperty, "Username");
			Password.SetBinding (Entry.TextProperty, "Password");
			Signin.SetBinding (Button.CommandProperty, "SignInCommand");

			MessagingCenter.Subscribe<LoginPageViewModel, string> (this, "MyAlertName",async (sender,message) => {
				if(message != null && message.Equals("Login Successful"))
				{
					await Navigation.PushModalAsync(new MyMasterDetailPage());
				}
				else
				{
					await DisplayAlert("Error !",message,"OK");	
				}

			});
		}


		public void DisplayAlert()
		{
			
		}
	}
}

