using System;

using Xamarin.Forms;

namespace DemoMasterDetail
{
	public class TabbedPage3 : ContentPage
	{
		public TabbedPage3 ()
		{
			Content = new StackLayout { 
				Children = {
					new Label { Text = "Hello ContentPage" }
				}
			};
		}
	}
}


