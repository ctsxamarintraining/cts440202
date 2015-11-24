using System;

using Xamarin.Forms;
using System.Collections.Generic;

namespace Assignment
{
	public class MyMasterDetailPage : MasterDetailPage
	{
		public MyMasterDetailPage ()
		{

			List<ContentPage> pages = new List<ContentPage> (0);
			Color[] colors = { Color.Red, Color.Green, Color.Blue, Color.Accent, Color.Lime };
			foreach (Color c in colors) {
				pages.Add (new ContentPage { Content = new StackLayout {
						Children = {
							new BoxView {
								Color = c,
								VerticalOptions = LayoutOptions.FillAndExpand
							}
						}
					}
				});
			}

			string[] Category = new string[] {"Content Demo", "Tabbed Demo", "Carousel Demo"};


			ListView menuListView = new ListView {
				ItemsSource = Category,
				BackgroundColor = Color.Yellow
			};



			this.Master = new ContentPage
			{
				Title = "Master",
				Content = new StackLayout
				{
					Children = 
					{
						new Label 
						{
							Text = "Menu",
							HorizontalOptions = LayoutOptions.Center,
							BackgroundColor = Color.Yellow
						},
						menuListView
					}
					}
			};

			menuListView.SelectedItem = Category [0];
//			this.Detail = new LoginPageView ();
//			this.Detail = new NavigationPage(new ContentDemo());
			this.Detail = new NavigationPage(new FootballPlayersListPage());

			menuListView.ItemSelected += (sender, args) =>
			{
				// Set the BindingContext of the detail page.
				this.Detail.BindingContext = args.SelectedItem;
				if (args.SelectedItem .Equals("Content Demo") ) {
//					this.Detail = new NavigationPage(new ContentDemo());
					this.Detail = new NavigationPage(new FootballPlayersListPage());
				}
				else if (args.SelectedItem.Equals("Tabbed Demo") ) {
					this.Detail = new NavigationPage (new MyTabbed ());
				}
				else if (args.SelectedItem.Equals("Carousel Demo")) {
					this.Detail =  new NavigationPage(new CarouselPageDemo {
						Children = { pages [0],
							pages [1],
							pages [2],
							pages [3],
							pages [4] }
					});
				}
				// Show the detail page.
				this.IsPresented = false;

			};

		}
	}
}