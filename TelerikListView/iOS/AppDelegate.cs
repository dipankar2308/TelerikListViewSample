// AppDelegate.cs
//
//  Author:
//       Nisha <NThakur6@slb.com>
//
//  Copyright (c) 2017 Schlumberger Technology Corporation
using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace TelerikListView.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init();

			LoadApplication(new App());

			return base.FinishedLaunching(app, options);
		}
	}
}
