using System;

using Xamarin.Forms;

namespace DemoMasterDetail
{
	public class MyTabbed : TabbedPage
	{
		public MyTabbed ()
		{
			this.Title = "Tabbed Page";
			this.Children.Add (new TabbedPageOne () { Title = "First Tab" });
			this.Children.Add (new TabbedPageTwo () { Title = "Second Tab" });
			this.Children.Add (new TabbedPageThree () { Title = "Third Tab" });
			this.Children.Add (new TabbedPageFour () { Title = "Fourth Tab" });
		}
	}
}


