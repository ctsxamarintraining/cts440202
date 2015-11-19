using System;
using System.Collections;
using Xamarin.Forms;
using System.Collections.Generic;


namespace DemoMasterDetail
{

	public class MasterDetail : MasterDetailPage
	{
		public MasterDetail()
		{

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
			this.Detail = new NavigationPage(new ContentDemo());

			menuListView.ItemSelected += (sender, args) =>
			{
				// Set the BindingContext of the detail page.
				this.Detail.BindingContext = args.SelectedItem;
				if (args.SelectedItem == "Content Demo") {
					this.Detail = new NavigationPage(new ContentDemo());
				}
				else if (args.SelectedItem == "Tabbed Demo") {
					this.Detail = new NavigationPage (new MyTabbed ());
				}
				else if (args.SelectedItem == "Carousel Demo") {
					this.Detail = new NavigationPage (new CarouselPage ());
				}

				// Show the detail page.
				this.IsPresented = false;

			};



		}			
	}
}


