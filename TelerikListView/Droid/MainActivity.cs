using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Com.Telerik.Widget.List;
using System.Collections.ObjectModel;
using GalaSoft.MvvmLight.Helpers;

namespace TelerikListView.Droid
{
	[Activity(Label = "TelerikListView.Droid", Icon = "@drawable/icon", Theme = "@style/MyTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
	{
		private RadListView mBucketListView;

		private SampleAdapter mSampleAdapter;

		private SampleViewModel mViewModel;

		private Button clickbtn;


		protected override void OnCreate(Bundle bundle)
		{
			TabLayoutResource = Resource.Layout.Tabbar;
			ToolbarResource = Resource.Layout.Toolbar;

			base.OnCreate(bundle);

			global::Xamarin.Forms.Forms.Init(this, bundle);

			LoadApplication(new App());

			SetContentView(Resource.Layout.Main);

			mViewModel = new SampleViewModel();

			mViewModel.Buckets.CollectionChanged += Buckets_CollectionChanged;

			this.mBucketListView = (RadListView)FindViewById(Resource.Id.lv_Dashboard_ListView);

			clickbtn = (Button)FindViewById(Resource.Id.click);

			clickbtn.Click += Clickbtn_Click;

			//clickbtn.SetCommand("Click", mViewModel.GetSampleSelection);

			mSampleAdapter = new SampleAdapter(this, mViewModel);

			mBucketListView.SetAdapter(mSampleAdapter);
		}

		void Buckets_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			//mSampleAdapter.Items = mViewModel.Buckets;
			mSampleAdapter.NotifyDataSetChanged();
		}

		void Clickbtn_Click(object sender, EventArgs e)
		{
			mViewModel.GetSampleSelection.Execute(null);
		}
	}
}
