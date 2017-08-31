using Android.App;
using Android.Widget;
using Android.OS;
using Com.Github.Channguyen.Rsv;
using System;

namespace RangeSliderViewQs
{
    [Activity(Label = "RangeSliderViewQs", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity, RangeSliderView.IOnSlideListener
    {
        private RangeSliderView smallSlider;
        private RangeSliderView largeSlider;

        public void OnSlide(int p0)
        {
            Toast.MakeText(this,"More Jump from Naxam",ToastLength.Long).Show();

        }

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.activity_main);
            smallSlider = (RangeSliderView)FindViewById(Resource.Id.rsv_small);
            largeSlider = (RangeSliderView)FindViewById(Resource.Id.rsv_large);
            smallSlider.SetOnSlideListener(this);
            largeSlider.SetOnSlideListener(this);

        }
    }
}

