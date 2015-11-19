using System;

using Xamarin.Forms;

namespace DemoMasterDetail
{
	public class ContentDemo : ContentPage
	{
		public ContentDemo ()
		{
			Button button = new Button
			{
				Text = "Edit Profile",
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.CenterAndExpand
			};
			button.Clicked += OnButtonClicked;

			Image myImage = new Image
			{
				Aspect = Aspect.Fill,
				Source = ImageSource.FromUri( new Uri(@"https://4e72eb44013d543eb0c67f8fbddf2ed30743ec8d.googledrive.com/host/0B70CO9lnNPfceHNFLXh2Wm8yMHc/List-Most-Expensive-Cars-photo-OdYL.jpg"))
			};
			this.Title = "Content Page";


			RelativeLayout relativeLayout = new RelativeLayout ();

			relativeLayout.Children.Add (myImage, 
				Constraint.Constant (0), 
				Constraint.Constant (0),
				Constraint.RelativeToParent ((parent) => { return parent.Width; }),
				Constraint.RelativeToParent ((parent) => { return parent.Height; }));

			relativeLayout.Children.Add (button, 
				Constraint.RelativeToParent ((parent) => {return parent.Width/2;} ), 
				Constraint.RelativeToParent ((parent) => {return parent.Height/2;} ),
				Constraint.RelativeToParent ((parent) => { return 75.0; }),
				Constraint.RelativeToParent ((parent) => { return 75.0; }));

			Content = relativeLayout;

		}

		void OnButtonClicked(object sender, EventArgs args)
		{
			Navigation.PushAsync (new EditProfilePage ());
		}


	}
}


