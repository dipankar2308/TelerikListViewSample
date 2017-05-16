// App.xaml.cs
//
//  Author:
//       Nisha <NThakur6@slb.com>
//
//  Copyright (c) 2017 Schlumberger Technology Corporation
using Xamarin.Forms;

namespace TelerikListView
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new TelerikListViewPage();
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
