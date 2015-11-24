using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Assignment
{
	public class App : Application
	{
		public static Dictionary<Type,Type> PageForViewModel = new Dictionary<Type,Type>()
		{
			{typeof(FootballPlayerListViewModel),typeof(FootballPlayersListPage)},
			{typeof(CreateFootballPlayerViewModel),typeof(CreateFootballPlayerPage)},
			{typeof(FootballPlayerDetailViewModel), typeof(FootballPlayerDetailPage)},
		};

		public App ()
		{
			MainPage = new LoginPageView ();
//			MainPage = new MyMasterDetailPage();
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

