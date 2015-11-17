using System;

using UIKit;

namespace TripExpenceManager
{
	public partial class ViewController : UIViewController
	{
		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			Trip trip1 = new Trip ();
			trip1.Name = "Himalayas";

			Trip trip2 = new Trip ();
			trip2.Name = "Ooty";

			Trip trip3 = new Trip ();
			trip3.Name = "Mysore";

			Trip trip4 = new Trip ();
			trip4.Name = "WesternHam";

			Trip trip5 = new Trip ();
			trip5.Name = "Australia";

			Trip[] trips = new Trip[]{ trip1, trip2, trip3, trip4, trip5 };

			tripTableView.Source = new TripTableSOurce (trips);
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}



	}
}

