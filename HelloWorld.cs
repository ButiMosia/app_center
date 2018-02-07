using System;

using Android.App;
using Android.Content;
using Android.OS;

using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace Mono.Samples.HelloWorld
{
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
            AppCenter.Start("921e668d-d00c-4953-a8ab-a88fa5bae01f", typeof(Analytics), typeof(Crashes));

			base.OnCreate(savedInstanceState);

			SetContentView(Resource.Layout.main);
		}
	}
}
