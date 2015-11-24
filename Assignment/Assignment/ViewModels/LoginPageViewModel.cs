using System;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;
namespace Assignment
{
	public class LoginPageViewModel : BaseViewModel
	{
		public LoginPageViewModel ()
		{
			SignInCommand = new Command(OnSignInCommand);
		}
		private string _username;
		public string Username
		{
			get{  return _username;}
			set{   
				_username = value;
				RaisePropertyChanged ("Username");
			}
		}

		private string _password;
		public string Password
		{
			get{ return _password;}
			set
			{ 
				_password = value;
				RaisePropertyChanged ("Password");
			}

		}

		public ICommand SignInCommand{ get; private set;}

		void OnSignInCommand()
		{
			string loginStatus = "";

			if (Username == null && Password ==null) 
			{
				loginStatus = "Please Enter Credentials";
			} 
			else if(Username == null && Password != null)
			{
				loginStatus = "Please Enter Username";
			}
			else if(Username != null && Password == null)
			{
				loginStatus = "Please Enter Password";
			}
			else if (Username.Equals ("cts") && Password.Equals ("123")) 
			{
				loginStatus = "Login Successful";
			}
			else
			{
				loginStatus = "Please Enter Valid Credentials";
			}

			MessagingCenter.Send (this, "MyAlertName",loginStatus);
		}

	}
}

