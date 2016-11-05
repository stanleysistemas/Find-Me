using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;

namespace Findme.Activities
{
    [Activity(Label = "FindMe", MainLauncher = true)]

public class LoginActivity : BaseActivity

    {
        protected override int LayoutResource
        {
            get
            {
                return Resource.Layout.login;
            }
        }


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            Intent newIntent;

            var twitter = FindViewById<Button>(Resource.Id.button_twitter);
            var microsoft = FindViewById<Button>(Resource.Id.button_microsoft);
            var facebook = FindViewById<Button>(Resource.Id.button_facebook);
            var skip = FindViewById<Button>(Resource.Id.button_skip);
            
            // twitter.Click += (sender, e) => Login(LoginAccount.Twitter);
            // facebook.Click += (sender, e) => Login(LoginAccount.Facebook);
            //  microsoft.Click += (sender, e) => Login(LoginAccount.Windows);


            FindViewById<Button>(Resource.Id.button_microsoft).Click += (sender, e) =>
            {
                newIntent = new Intent(this, typeof(LogarActivity));
               // newIntent.AddFlags(ActivityFlags.ClearTop);
                newIntent.AddFlags(ActivityFlags.SingleTop);
                StartActivity(newIntent);
                Finish();
            };

            FindViewById<Button>(Resource.Id.button_skip).Click += (sender, e) =>
            {
                newIntent = new Intent(this, typeof(RegistroActivity));
               // newIntent.AddFlags(ActivityFlags.ClearTop);
                newIntent.AddFlags(ActivityFlags.SingleTop);
                StartActivity(newIntent);
                Finish();
            };

        }

        
    }
}