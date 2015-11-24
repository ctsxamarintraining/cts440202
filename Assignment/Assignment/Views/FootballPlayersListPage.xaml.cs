using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Assignment
{
	public partial class FootballPlayersListPage : BaseViewPage
	{
		public FootballPlayersListPage ()
		{
			InitializeComponent ();
			this.Title = "Football Legends";
			this.BindingContext = new FootballPlayerListViewModel ();
			this.AddFootBallPlayerBTN.SetBinding (MenuItem.CommandProperty, "AddPlayerBTNTapped");
			this.FootballPlayersListView.SetBinding (ItemsView<Cell>.ItemsSourceProperty, "FootballPlayerCollection");
			var cell = new DataTemplate (typeof(FootballPlayerListviewCellPage));
			this.FootballPlayersListView.ItemTemplate = cell;
			this.FootballPlayersListView.RowHeight = 75;
			this.FootballPlayersListView.ItemSelected += async (object sender, SelectedItemChangedEventArgs e) => 
			{
				await Navigation.PushAsync(new FootballPlayerDetailPage(e.SelectedItem));
			};

			MessagingCenter.Subscribe<FootballPlayerListviewCellPage> (this, "ItemDeleted", (sender) => {

				var cell1 = new DataTemplate (typeof(FootballPlayerListviewCellPage));
				this.FootballPlayersListView.ItemTemplate = cell1;
		
				this.BindingContext = new FootballPlayerListViewModel ();
				FootballPlayersListView.ItemsSource = null;
				this.FootballPlayersListView.SetBinding (ItemsView<Cell>.ItemsSourceProperty, "FootballPlayerCollection");
			}, null);

			MessagingCenter.Subscribe<FootballPlayerListViewModel>  (this, "AddFootballPlayer", async (sender) => 
				await Navigation.PushAsync (new CreateFootballPlayerPage ()), null);
		}

		protected override void OnAppearing ()
		{
			base.OnAppearing ();
			SQLiteHelper databaseHelper = new SQLiteHelper ();
			this.FootballPlayersListView.ItemsSource = databaseHelper.GetItems ();
		}


	}
}