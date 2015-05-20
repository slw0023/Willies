﻿using System;
using CoreGraphics;
using Foundation;
using UIKit;
using FlyoutNavigation;

namespace App.iOS
{
	public class DisclaimerViewController : UIViewController
	{
		FlyoutNavigationController flyout;
		UIScrollView scrollView;

		UIButton hamburgerMenu;
		DisclaimerView disclaimerView;

		public DisclaimerViewController (FlyoutNavigationController flyoutViewController)
		{
			flyout = flyoutViewController;
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			scrollView = new UIScrollView {
				BackgroundColor = UIColor.Black,
				Frame = new CGRect (0, 0, 320, View.Bounds.Height * 3)
			};

			hamburgerMenu = new UIButton {
				Frame = new CGRect (10, 10, 25, 25)
			};
			hamburgerMenu.SetImage (UIImage.FromFile ("HamburgerMenu.png"), UIControlState.Normal);
			hamburgerMenu.TouchUpInside += (sender, e) => {
				flyout.ToggleMenu ();
			};

			disclaimerView = new DisclaimerView (View.Bounds) {
				Frame = new CGRect (0, 0, View.Bounds.Width, View.Bounds.Height)
			};

			scrollView.Add (disclaimerView);
			scrollView.Add (hamburgerMenu);

			View.Add (scrollView);
		}

		public override bool PrefersStatusBarHidden ()
		{
			return true;
		}
	}
}