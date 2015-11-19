using System;

using Xamarin.Forms;

namespace DemoMasterDetail
{
	public class App : Application
	{
		public App ()
		{
			MainPage = new LoginPage ();
//			MainPage = new MasterDetail();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

