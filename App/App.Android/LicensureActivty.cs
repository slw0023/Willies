
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Webkit;

namespace App.Android
{
	[Activity (ScreenOrientation = global::Android.Content.PM.ScreenOrientation.Portrait)]			
	public class LicensureActivty : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			RequestWindowFeature (WindowFeatures.ActionBar);
			ActionBar.Hide ();

			SetContentView (Resource.Layout.webview_Licensure);
			WebView licensure, tos;
			licensure = FindViewById<WebView> (Resource.Id.Licensure);
			licensure.Settings.JavaScriptEnabled = true;
			licensure.LoadUrl ("file:///android_asset/Licensure.html");
			Button backButton = FindViewById<Button> (Resource.Id.back_button);
			backButton.Click += delegate {
				OnBackPressed();
			};
		}
	}
}

