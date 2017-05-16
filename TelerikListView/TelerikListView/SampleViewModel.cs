
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace TelerikListView
{
	public class SampleViewModel: ViewModelBase
	{
		
		public ObservableCollection<string> Buckets { get; set; }



		public SampleViewModel()
		{
			Buckets = new ObservableCollection<string> ();
			Buckets.Add("Pune");
			Buckets.Add("Mumbai");
		}


		private RelayCommand _getSampleSelection = null;

		public RelayCommand GetSampleSelection
		{
			get
			{
				return _getSampleSelection ?? (_getSampleSelection = new RelayCommand(() =>
				{
					Buckets.Clear();
					Buckets.Add("London");
					Buckets.Add("Houston");
					Buckets.Add("Sweden");
					Buckets.Add("America");
				}));
			}
		}
	}
}

