using System;

using Xamarin.Forms;

namespace Assignment
{
	public class TabbedPageOne : ContentPage
	{
		public TabbedPageOne ()
		{
			Content = new StackLayout { 
				BackgroundColor = Color.Green,
				Children = {
					new Label { HorizontalOptions = LayoutOptions.Center,
						VerticalOptions = LayoutOptions.Center,
						Text = "Page One" }
				}
			};
		}
	}
}


