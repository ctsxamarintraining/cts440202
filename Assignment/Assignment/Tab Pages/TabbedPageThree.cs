using System;

using Xamarin.Forms;

namespace Assignment
{
	public class TabbedPageThree : ContentPage
	{
		public TabbedPageThree ()
		{
			Content = new StackLayout { 
				BackgroundColor = Color.Yellow,
				Children = {
					new Label { HorizontalOptions = LayoutOptions.Center,
						VerticalOptions = LayoutOptions.Center,
						Text = "Page Three" }
				}
			};
		}
	}
}


