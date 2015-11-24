using System;

using Xamarin.Forms;

namespace Assignment
{
	public class TabbedPageTwo : ContentPage
	{
		public TabbedPageTwo ()
		{
			Content = new StackLayout { 
				BackgroundColor = Color.Maroon,
				Children = {
					new Label { 
						HorizontalOptions = LayoutOptions.Center,
						VerticalOptions = LayoutOptions.Center,
						Text = "Page Two" }
				}
			};
		}
	}
}


