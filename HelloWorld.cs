using Android.App;
using Android.Content;
using Android.OS;

using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Microsoft.AppCenter.Push;

namespace Mono.Samples.HelloWorld
{
	// This is a second test comment
	[Activity(Label = "Hello Android World", MainLauncher = true)]
	[IntentFilter(new[] { Intent.ActionView },
		Categories = new[] {
			Intent.CategoryDefault,
			Intent.CategoryBrowsable
		},
		DataScheme = "http",
		DataHost = "example.com"
	)]
	public class HelloAndroid: Activity
	{
		protected override void OnCreate (Bundle savedInstanceState)
		{
            Analytics.TrackEvent("Test event");
            Push.SetSenderId("802849790066");
            AppCenter.Start("921e668d-d00c-4953-a8ab-a88fa5bae01f", typeof(Analytics), typeof(Crashes), typeof(Push));

			base.OnCreate(savedInstanceState);

			SetContentView(Resource.Layout.main);
		}
	}
}
