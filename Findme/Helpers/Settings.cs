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

namespace Findme.Helpers
{
    public enum LoginAccount
    {   
        Email   = 0,
        Facebook = 1,
        Twitter = 2,
    }


    public class Settings
    {
        const string LoginAccountKey = "login_account";
        bool isConnected;

        static Settings _settings;

       /// static ISettings AppSettings => CrossSettings.Current;


       // public LoginAccount LoginAccount
       // {
          //  get { return (LoginAccount)AppSettings.GetValueOrDefault(LoginAccountKey, (int)LoginAccountDefault); }
          //  set
          //  {
          //      if (AppSettings.AddOrUpdateValue(LoginAccountKey, (int)value))
          //          OnPropertyChanged();
          //  }
        //}

    }

}