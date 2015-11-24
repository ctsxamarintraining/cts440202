using System;
using Xamarin.Forms;

namespace Assignment
{
	public class BaseViewPage : ContentPage, IPage
	{
		#region IPage implementation

		public void NavigateTo (Type t)
		{
			var viewType = App.PageForViewModel [t];
			var page = Activator.CreateInstance (viewType);
			Navigation.PushAsync (page as Page);
		}

		#endregion

		public BaseViewPage ()
		{
		}
	}
}

