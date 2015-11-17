using System;
using UIKit;

namespace TripExpenceManager
{
	public class TripTableSOurce : UITableViewSource
	{

		Trip[] createdTrips;

		public TripTableSOurce(Trip[] trips)
		{
			this.createdTrips = trips;
		}



		public override nint RowsInSection (UITableView tableview, nint section)
		{
			return this.createdTrips.Length;
		}

		public override UITableViewCell GetCell (UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			UITableViewCell createdCell = tableView.DequeueReusableCell ("CreatedCell");

			if (createdCell == null) {
				createdCell = new UITableViewCell (UITableViewCellStyle.Default, "CreatedCell");
			}

			Trip trip = createdTrips [indexPath.Row];
			Console.WriteLine (trip.Name);
			createdCell.TextLabel.Text = trip.Name;
			return createdCell;
		}

		public override void WillDisplay (UITableView tableView, UITableViewCell cell, Foundation.NSIndexPath indexPath)
		{
//			cell.SeparatorInset = UIEdgeInsets.Zero;
//			cell.PreservesSuperviewLayoutMargins = false;
//			cell.LayoutMargins = UIEdgeInsets.Zero; 
//
		}

		public override nfloat GetHeightForRow (UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			return 50;
		}
//		public override UIView GetViewForHeader (UITableView tableView, nint section)
//		{
//			double screenWidth = UIScreen.MainScreen.Bounds.Width;
//			UIView headerView = new UIView {
//				Frame = new CoreGraphics.CGRect (0, 0, screenWidth, 44)
//
//			};
//			UILabel label = new UILabel {
//				
//				Frame = new CoreGraphics.CGRect(0,28,screenWidth,22),
//				TextAlignment = UITextAlignment.Center,
//				Text = "Add New Trip"
//			};
//
//			headerView.AddSubview (label);
//			headerView.BackgroundColor = UIColor.FromRGB (27, 197, 225);
//			return headerView;
//		}
//
//		public override nfloat GetHeightForHeader (UITableView tableView, nint section)
//		{
//			return 60;
//		}
	}
}

