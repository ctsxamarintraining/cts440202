using System;

using Xamarin.Forms;

namespace Assignment
{
	public class TabbedPageFour : ContentPage
	{
		public TabbedPageFour ()
		{
			Content = new StackLayout { 
				BackgroundColor = Color.Red,
				Children = {
					new Label { HorizontalOptions = LayoutOptions.Center,
						VerticalOptions = LayoutOptions.Center,
						Text = "Page Four" }
				}
			};
		}
	}
}


