using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Widget;

namespace Findme.Activities
{
    [Activity(Label = "Logar", ScreenOrientation = ScreenOrientation.Portrait)]
    public class LogarActivity : BaseActivity
    {
        EditText txtemail;
        EditText txtsenha;
        // EditText txtconfirmasenha;
        string token;

        Button btnLogin;

        protected override int LayoutResource
        {
            get { return Resource.Layout.logar; }
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            Intent newIntent;

            btnLogin = FindViewById<Button>(Resource.Id.btnLogin);
            txtemail = FindViewById<EditText>(Resource.Id.txtemail);
            txtsenha = FindViewById<EditText>(Resource.Id.txtsenha);
            // txtconfirmasenha = FindViewById<EditText>(Resource.Id.txtconfirmasenha);

            //  btnLogin.Click += btnLogin_Click;


            FindViewById<Button>(Resource.Id.btnLogin).Click += (sender, e) =>
            {
                if (txtemail.Text == "")
                {
                    Toast.MakeText(this, "Campo Email do Usuário obrigatório...", ToastLength.Short).Show();
                }
                else
                {
                    try
                    {
                        Toast.MakeText(this, "Login excutado com sucesso...,", ToastLength.Short).Show();
                    }
                    catch (Exception ex)
                    {
                        Toast.MakeText(this, ex.ToString(), ToastLength.Short).Show();
                    }


                    newIntent = new Intent(this, typeof(MainActivity));
                    newIntent.AddFlags(ActivityFlags.ClearTop);
                    newIntent.AddFlags(ActivityFlags.SingleTop);
                    StartActivity(newIntent);
                    Finish();

                }

            };
        }

        public override void OnBackPressed()
        {
            var newIntent = new Intent(this, typeof(LoginActivity));
            newIntent.AddFlags(ActivityFlags.ClearTop);
            // newIntent.AddFlags(ActivityFlags.SingleTop);
            StartActivity(newIntent);
            Finish();

        }

    }
}