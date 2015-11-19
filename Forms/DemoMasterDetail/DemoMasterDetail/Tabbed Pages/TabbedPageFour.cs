using System;

using Xamarin.Forms;

namespace DemoMasterDetail
{
	public class TabbedPageFour : ContentPage
	{
		public TabbedPageFour ()
		{
			this.BackgroundColor = Color.Maroon;
			Content = new StackLayout { 
				VerticalOptions = LayoutOptions.Center,
				Children = {
					new Label { Text = "Tabbed Page 4",
						XAlign = TextAlignment.Center,
					}
				}
			};
		}
	}
}


