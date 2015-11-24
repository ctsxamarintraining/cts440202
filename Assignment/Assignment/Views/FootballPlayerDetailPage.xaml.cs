using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Assignment
{
	public partial class FootballPlayerDetailPage : BaseViewPage
	{
		public FootballPlayerDetailPage ()
		{
			InitializeComponent ();
		}

		public FootballPlayerDetailPage(Object obj)
		{
			FootballPlayer player = (FootballPlayer)obj;
			InitializeComponent ();

			this.PlayerNamelbl.Text = player.FullName;
			this.Countrylbl.Text = string.Concat("Country: ", player.Country);
			this.Agelbl.Text = string.Concat("Age: ",player.Age);
			string[] dateFormats = player.DateOfBirth.GetDateTimeFormats ();
			this.DOBlbl.Text = string.Concat("DateOfBirth: ",dateFormats [8]);
			this.Descriptionlbl.Text = string.Concat("Description : ",player.Description);

			if (player.IsFavourite) {
				this.IsFavouritelbl.Text = "(Is Favourite)";
			} else {
				this.IsFavouritelbl.Text = "";
			}
		}

	}
}

