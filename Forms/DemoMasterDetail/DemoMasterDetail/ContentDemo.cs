using System;

using Xamarin.Forms;

namespace DemoMasterDetail
{
	public class ContentDemo : ContentPage
	{
		public ContentDemo ()
		{
			this.Title = "Content Page";

			Content = new StackLayout { 

				VerticalOptions = LayoutOptions.Center,				
				Children = {
					new Label 
					{ 
						Text = "Welcome to Master Detail",
						XAlign = TextAlignment.Center
					}
				}
			};
		}
	}
}


