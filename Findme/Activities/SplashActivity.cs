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

namespace Findme.Activities
{
    [Activity(Label = "FindMe", Theme = "@style/SplashTheme", NoHistory = true, MainLauncher = true)]
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here


            Intent newIntent;
            //if (Settings.Current.IsLoggedIn)
            //{
            //    newIntent = new Intent(this, typeof(MainActivity));

            //}
            //else if (Settings.Current.FirstRun)

            //{
            //   newIntent = new Intent(this, typeof(LoginActivity));
            //   newIntent = new Intent(this, typeof(GettingStartedActivity));

            //   Settings.Current.FirstRun = false;
            //}
            //else
            newIntent = new Intent(this, typeof(LoginActivity));

           // newIntent.AddFlags(ActivityFlags.ClearTop);
           // newIntent.AddFlags(ActivityFlags.SingleTop);
            StartActivity(newIntent);
           // Finish();
        }
    }
}