using System;

using UIKit;
using CoreGraphics;
using System.Collections.Generic;

namespace BSTOne
{
	public partial class ViewController : UIViewController
	{
		List<int> GeneratedNumbers = new List<int>();
		private bool touchStartedInside;
		private bool DrawBinaryExecuted = false;
		UIView selectedView = new UIView();
		UILabel selectedViewLabel = new UILabel();
		int selectedValue = 0;
		CGRect PreviousSelctedViewPosition = new CGRect();

		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			MakeRoundSelectionViews ();

			GenerateBTN.TouchUpInside += delegate {
				GenerateUniqueRandomNumbers ();
			};
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}

		public void MakeRoundSelectionViews()
		{
			this.FirstValueView.Layer.CornerRadius = this.FirstValueView.Frame.Size.Width/2;
			this.SecondValueView.Layer.CornerRadius = this.SecondValueView.Frame.Size.Width/2;
			this.ThirdValueView.Layer.CornerRadius = this.ThirdValueView.Frame.Size.Width/2;
			this.FourthValueView.Layer.CornerRadius = this.FourthValueView.Frame.Size.Width/2;
			this.FifthValueView.Layer.CornerRadius = this.FifthValueView.Frame.Size.Width/2;
		}

		public void GenerateUniqueRandomNumbers()
		{
			int i = 0;
			while (i < 5) 
			{
				int randomNumber = RandomNumber (1, 99);
				if (GeneratedNumbers.Contains (randomNumber)) {
					
				} else 
				{
					GeneratedNumbers.Add (randomNumber);

					switch (i) 
					{
					case 0:
						{
							FirstValue.Text = randomNumber.ToString();
						}
						break;
					
					case 1:
						{
							SecondValue.Text = randomNumber.ToString();
						}
						break;

					case 2:
						{
							ThirdValue.Text = randomNumber.ToString ();
						}
						break;

					case 3:
						{
							FourthValue.Text = randomNumber.ToString();
						}
						break;

					case 4:
						{
							FifthValue.Text = randomNumber.ToString();
						}
						break;
					} 
					i++;
				}
			}

		}

		public int RandomNumber(int min, int max)
		{
			Random random = new Random();
			return random.Next(min, max);


		}


		public override void TouchesBegan (Foundation.NSSet touches, UIEvent evt)
		{
			base.TouchesBegan (touches, evt);

			// Get the current touch
			UITouch touch = touches.AnyObject as UITouch;
			if (touch != null)
			{
				DrawBinaryExecuted = false;

				if (FirstValueView.Frame.Contains(touch.LocationInView(this.ValueViews))) {
					touchStartedInside = true;
					selectedView = FirstValueView;
					selectedValue = Int32.Parse(FirstValue.Text);
					selectedViewLabel = FirstValue;
					PreviousSelctedViewPosition = selectedView.Frame;
				}

				if (SecondValueView.Frame.Contains(touch.LocationInView(this.ValueViews))) {
					touchStartedInside = true;
					selectedView = SecondValueView;
					selectedValue = Int32.Parse(SecondValue.Text);
					selectedViewLabel = SecondValue;
					PreviousSelctedViewPosition = selectedView.Frame;
				}

				if (ThirdValueView.Frame.Contains(touch.LocationInView(this.ValueViews))) {
					touchStartedInside = true;
					selectedView = ThirdValueView;
					selectedValue = Int32.Parse(ThirdValue.Text);
					selectedViewLabel = ThirdValue;
					PreviousSelctedViewPosition = selectedView.Frame;
				}

				if (FourthValueView.Frame.Contains(touch.LocationInView(this.ValueViews))) {
					touchStartedInside = true;
					selectedView = FourthValueView;
					selectedValue = Int32.Parse(FourthValue.Text);
					selectedViewLabel = FourthValue;
					PreviousSelctedViewPosition = selectedView.Frame;
				}

				if (FifthValueView.Frame.Contains(touch.LocationInView(this.ValueViews))){
					touchStartedInside = true;
					selectedView = FifthValueView;
					selectedValue = Int32.Parse(FifthValue.Text);
					selectedViewLabel = FifthValue;
					PreviousSelctedViewPosition = selectedView.Frame;
				}
			}

		}

		public override void TouchesMoved (Foundation.NSSet touches, UIEvent evt)
		{
			base.TouchesMoved (touches, evt);

			UITouch touch = touches.AnyObject as UITouch;
			if (touch != null) {
				if (touchStartedInside && selectedValue > 0) {
					// move the shape
					nfloat offsetX = touch.PreviousLocationInView(View).X - touch.LocationInView(View).X;
					nfloat offsetY = touch.PreviousLocationInView(View).Y - touch.LocationInView(View).Y;
					selectedView.Frame = new CGRect(new CGPoint(selectedView.Frame.X - offsetX, selectedView.Frame.Y - offsetY), selectedView.Frame.Size);

					if (selectedView.Frame.Y > this.HeaderView.Frame.Size.Height - 30) {
						if (!DrawBinaryExecuted) {
							DrawBinarySearchTreeWithElement (selectedValue);	
						}

//						Console.WriteLine ();
					}

				}
			}
		}

		public override void TouchesEnded (Foundation.NSSet touches, UIEvent evt)
		{
			base.TouchesEnded (touches, evt);

			if (touchStartedInside && DrawBinaryExecuted) {
				selectedViewLabel.Text = "0";
			}

			if (touchStartedInside) {
				touchStartedInside = false;
				selectedView.Frame = PreviousSelctedViewPosition;
			}

		}


		public void DrawBinarySearchTreeWithElement(int data)
		{
			DrawBinaryExecuted = true;

		}



	}
}

