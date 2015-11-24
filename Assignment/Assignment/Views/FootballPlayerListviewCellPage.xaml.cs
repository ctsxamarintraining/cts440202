using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Assignment
{
	public partial class FootballPlayerListviewCellPage : ViewCell
	{
		public FootballPlayerListviewCellPage ()
		{
			InitializeComponent ();
//			FootballPlayer footballplayercollection = (FootballPlayer)this.BindingContext;
			this.FootBallPlayerName.SetBinding (Label.TextProperty, "FullName");
			this.DateofBirthWithYears.SetBinding (Label.TextProperty, "DateOfBithWithAge");
			this.CountryImage.SetBinding (Image.SourceProperty, "CountryImage");
			this.CellView.BackgroundColor = Color.FromHex ("#eee");
			var deleteAction = new MenuItem {
				Text = "Delete", IsDestructive = true 
			};

			deleteAction.SetBinding (MenuItem.CommandParameterProperty, new Binding ("."));
			deleteAction.Clicked += (sender, e) => {
				FootballPlayer player;
				var mi = ((MenuItem)sender);
				player= (FootballPlayer)mi.CommandParameter;
				SQLiteHelper databaseHelper = new SQLiteHelper();
				databaseHelper.DeletePlayerWithName(player);
				MessagingCenter.Send(this,"ItemDeleted");
			};
			this.ContextActions.Add (deleteAction);

			var favouriteAction = new MenuItem {
				Text = "Favourite", IsDestructive = false 
			};
			favouriteAction.SetBinding (MenuItem.CommandParameterProperty, new Binding ("."));
			favouriteAction.Clicked += (sender, e) => {
				FootballPlayer player;
				var mi = ((MenuItem)sender);
				player = (FootballPlayer)mi.CommandParameter;
				SQLiteHelper databaseHelper = new SQLiteHelper();
				databaseHelper.DeletePlayerWithName(player);
				player.IsFavourite = !player.IsFavourite;
				if (player.IsFavourite) {
					this.CellView.BackgroundColor = Color.Green;
				}
				else
				{
					this.CellView.BackgroundColor = Color.FromHex("#eee");					
				}

				databaseHelper.Save(player);
				MessagingCenter.Send(this,"ItemDeleted");
			};

			this.ContextActions.Add (favouriteAction);
		}
	}
}