using System;

using Xamarin.Forms;

namespace DemoMasterDetail
{
	public class TabbedPageOne : ContentPage
	{
		public TabbedPageOne ()
		{
			this.BackgroundColor = Color.Aqua;
			Content = new StackLayout { 
				VerticalOptions = LayoutOptions.Center,
				Children = {
					new Label { Text = "Tabbed Page 1",
						XAlign = TextAlignment.Center,
					}
				}
			};
		}
	}
}


