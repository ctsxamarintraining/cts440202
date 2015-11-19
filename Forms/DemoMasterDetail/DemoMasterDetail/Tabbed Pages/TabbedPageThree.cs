using System;

using Xamarin.Forms;

namespace DemoMasterDetail
{
	public class TabbedPageThree : ContentPage
	{
		public TabbedPageThree ()
		{
			this.BackgroundColor = Color.Gray;
			Content = new StackLayout { 
				VerticalOptions = LayoutOptions.Center,
				Children = {
					new Label { Text = "Tabbed Page 3",
						XAlign = TextAlignment.Center,
					}
				}
			};
		}
	}
}


