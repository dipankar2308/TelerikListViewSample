
using System;
using System.Collections.ObjectModel;
using Android.App;
using Android.Views;
using Android.Widget;
using Com.Telerik.Widget.List;
using TelerikListView.Droid;

namespace TelerikListView.Droid
{
	public class SampleAdapter : ListViewAdapter
	{
		private Activity mContext;
		public SampleViewModel mViewModel; 

		public SampleAdapter(Activity context, SampleViewModel viewModel ) : base(viewModel.Buckets)
		{
			mViewModel = viewModel;
			mContext = context;
		}

		public override Android.Support.V7.Widget.RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup p0, int p1)
		{
			View itemView = LayoutInflater.From(p0.Context).Inflate(Resource.Layout.list_items, p0, false);
			SwipeToExecuteCustomViewHolder customHolder = new SwipeToExecuteCustomViewHolder(itemView);
			return customHolder;
		}

		public override int ItemCount
		{
			get
			{
				return mViewModel.Buckets.Count;
			}
		}

		public override void OnBindListViewHolder(ListViewHolder p0, int position)
		{
			SwipeToExecuteCustomViewHolder customVH = (SwipeToExecuteCustomViewHolder)p0;
			customVH.tvTitle.Text = mViewModel.Buckets[position] ;
		}
	}

	class SwipeToExecuteCustomViewHolder : ListViewHolder
	{
		public TextView tvTitle;

		public SwipeToExecuteCustomViewHolder(View itemView) : base(itemView)
		{
			this.tvTitle = (TextView)itemView.FindViewById(Resource.Id.tv_Title);

		}
	}


}
