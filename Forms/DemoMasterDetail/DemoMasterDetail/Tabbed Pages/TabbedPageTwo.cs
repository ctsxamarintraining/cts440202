using System;

using Xamarin.Forms;

namespace DemoMasterDetail
{
	public class TabbedPageTwo : ContentPage
	{
		public TabbedPageTwo ()
		{
			this.BackgroundColor = Color.Fuchsia;
			Content = new StackLayout { 
				VerticalOptions = LayoutOptions.Center,
				Children = {
					new Label { Text = "Tabbed Page 2",
						XAlign = TextAlignment.Center,
					}
				}
			};
		}
	}
}


