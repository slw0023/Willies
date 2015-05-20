
using Android.App;
using Android.OS;
using System.Threading;

namespace App.Android
{
	[Activity (Theme = "@style/Theme.Splash", Icon = "@drawable/icon", MainLauncher = true, NoHistory = true)]			
	public class SplashScreen : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			Thread.Sleep (250);
			StartActivity (typeof(SliderPageActivity));
			// Create your application here
		}
	}
}

